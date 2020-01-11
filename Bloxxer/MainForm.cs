using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bloxxer.Utils;
using CefSharp;
using CefSharp.WinForms;
using Newtonsoft.Json.Linq;
using WeAreDevs_API;

namespace Bloxxer
{
	public partial class MainForm : Form
    {
        private ChromiumWebBrowser Monaco;
        private readonly ExploitAPI Api = new ExploitAPI();

        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public MainForm()
        {
            InitializeComponent();
        }

        #region Initialization
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitPreferences();
            InitMonaco();
            LoadRecentList();
        }

        private void InitPreferences()
        {
            JsonManager.GetPreferences();

            if (!TopMost)
                TopMost = GlobalVars.BloxxerOnTop;

            Process[] roblox = Process.GetProcessesByName("RobloxPlayerBeta");
            if (roblox.Length == 1)
            {
                SetWindowPos(roblox[0].MainWindowHandle, (GlobalVars.RobloxOnTop ? HWND_TOPMOST : HWND_NOTOPMOST), 0, 0, 0, 0, TOPMOST_FLAGS);
            }
        }

        #endregion
        #region Monaco

        public void ChangeMonacoTheme(string theme)
        {
            Monaco.ExecuteScriptAsyncWhenPageLoaded(String.Format("SetTheme(\"{0}\");", theme));
        }

        public void SetMonacoText(string text)
        {
            Monaco.ExecuteScriptAsyncWhenPageLoaded(String.Format("SetText(String.raw`{0}`);", text));
        }

        private void Learn(string label, string kind, string detail, string text)
        {
            Monaco.ExecuteScriptAsyncWhenPageLoaded(String.Format("AddIntellisense({0}, {1}, {2}, {3});", label, kind, detail, text));
        }

        private void InitMonaco()
        {
            // Init CEF for Monaco
            Monaco = new ChromiumWebBrowser(string.Format("file:///{0}/monaco/monaco.html", Directory.GetCurrentDirectory()));
            Panel.Controls.Add(Monaco);
            Monaco.Dock = DockStyle.Fill;

            Monaco.ExecuteScriptAsyncWhenPageLoaded(String.Format("SetTheme(\"{0}\");", (GlobalVars.DarkMode ? "Dark" : "Light")));

            // Syntax highlighting for Monaco
            JObject definitions = JObject.Parse(File.ReadAllText(Directory.GetCurrentDirectory() + @"\monaco\definitions.json"));
            JArray keywords = definitions["keywords"] as JArray;
            JArray luaFunctions = definitions["functions"]["lua"] as JArray;
            JArray robloxFunctions = definitions["functions"]["roblox"] as JArray;
            JArray namespaces = definitions["namespaces"] as JArray;
            JArray globals = definitions["globals"] as JArray;

            foreach (string text in keywords)
            {
                Learn(text, "Keyword", text, text);
            }

            foreach (string text in luaFunctions)
            {
                Learn(text, "Method", text, text);
            }

            foreach (string text in robloxFunctions)
            {
                Learn(text, "Function", ":" + text, text);
            }

            foreach (string text in namespaces)
            {
                Learn(text, "Class", text, text);
            }

            foreach (string text in globals)
            {
                Learn(text, "Variable", text, text);
            }
        }
        #endregion
        #region Utility
        
        private void LoadDataFromFile(string path)
        {
            if (File.Exists(path))
            {
                Monaco.ExecuteScriptAsyncWhenPageLoaded(String.Format("SetText(String.raw`{0}`);", File.ReadAllText(path)));
            }
        }

        #endregion
        #region Recently Used

        private void SaveRecentFile(string path)
        {
            JObject json = JsonManager.GetJson();
            JArray recentlyUsed = json["recentlyUsed"] as JArray;

            if (recentlyUsed.Contains(path))
            {
                return;
            }
            recentlyUsed.Insert(recentlyUsed.Count >= 1 ? recentlyUsed.Count - 1 : 0, path);

            json["recentlyUsed"].Parent.Remove();
            json.Add(new JProperty("recentlyUsed", recentlyUsed));

            JsonManager.SaveJson(json.ToString());
            LoadRecentList();
        }

        private void LoadRecentList()
        {
            recentlyUsedList.Clear();

            foreach (string file in JsonManager.GetRecentlyUsed())
            {
                if (file == String.Empty || file == null)
                {
                    return;
                }

                ListViewItem item = new ListViewItem
                {
                    Text = file.Substring(file.LastIndexOf(@"\") + 1),
                    ToolTipText = file
                };

                recentlyUsedList.Items.Add(item);
            }
        }

        private void RecentlyUsedList_DoubleClick(object sender, EventArgs e)
        {
            LoadDataFromFile(recentlyUsedList.SelectedItems[0].ToolTipText);
        }

        #endregion
        #region Roblox Exploit

        public void ExecuteScript(string script, bool external = false)
        {
            if (!CheckRobloxRunning())
            {
                MessageBox.Show("Roblox is not running!", "Bloxxer", MessageBoxButtons.OK);
                return;
            }

            if (GlobalVars.InjectOnExecution && !Api.isAPIAttached())
            {
                Api.LaunchExploit();
            }

            if (!Api.isAPIAttached())
            {
                MessageBox.Show("Exploit is not injected!", "Bloxxer", MessageBoxButtons.OK);
                return;
            }

            if (GlobalVars.ExecutionMessage && !execAsLuaC.Checked)
            {
                if (GlobalVars.ExecutionMessageMethod == 0)
                {
                    script += "\n\ngame:GetService('StarterGui'):SetCore('SendNotification',{Title='Bloxxer',Text='Script executed',Duration=5,Button1='Ok'})";
                }
                else if (GlobalVars.ExecutionMessageMethod == 1)
                {
                    script += "\n\nprint('Bloxxer - Executed script')";
                }
                else if (GlobalVars.ExecutionMessageMethod == 2)
                {
                    script += "\n\ngame:GetService('StarterGui'):SetCore('SendNotification',{Title='Bloxxer',Text='Script executed',Duration=5,Button1='Ok'})";
                    script += "\n\nprint('Bloxxer - Executed script')";
                }
            }

            if (execAsLuaC.Checked && !external)
            {
                Api.SendLuaCScript(script);
                return;
            }

            Api.SendLuaScript(script);
        }
        private bool CheckRobloxRunning()
        {
            Process[] roblox = Process.GetProcessesByName("RobloxPlayerBeta");
            if (roblox.Length >= 0)
            {
                return true;
            }
            return false;
        }

        #endregion
        #region Button Click Events

        private void InjectBtn_Click(object sender, EventArgs e)
        {
            if (!CheckRobloxRunning())
            {
                MessageBox.Show("Roblox is not running!", "Bloxxer", MessageBoxButtons.OK);
                return;
            }

            if (Api.isAPIAttached())
            {
                MessageBox.Show("Exploit is already injected!", "Bloxxer", MessageBoxButtons.OK);
                return;
            }

            Api.LaunchExploit();
        }

        private async void ExecuteBtn_Click(object sender, EventArgs e)
        {
            if (Monaco.CanExecuteJavascriptInMainFrame)
            {
                JavascriptResponse response = await Monaco.EvaluateScriptAsync("GetText();");
                ExecuteScript(response.Result.ToString());
            }

        }

        private void ScriptHubBtn_Click(object sender, EventArgs e)
        {
            Form ScriptHub = new ScriptHubForm(this);
            ScriptHub.Show();
        }

        private void OptionsBtn_Click(object sender, EventArgs e)
        {
            Form Options = new OptionsForm(this);
            Options.ShowDialog();
        }

        #endregion
        #region Menu Strip

        private void FileToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = SystemColors.WindowText;
        }

        private void FileToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = SystemColors.Window;
        }

        private void EditToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            editToolStripMenuItem.ForeColor = SystemColors.WindowText;
        }

        private void EditToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            editToolStripMenuItem.ForeColor = SystemColors.Window;
        }

        private void SearchToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            searchToolStripMenuItem.ForeColor = SystemColors.WindowText;
        }

        private void SearchToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            searchToolStripMenuItem.ForeColor = SystemColors.Window;    
        }

        private void ViewToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            viewToolStripMenuItem.ForeColor = SystemColors.WindowText;
        }

        private void ViewToolStripMenuItem_DropDownClosed(object sender, EventArgs e)
        {
            viewToolStripMenuItem.ForeColor = SystemColors.Window;
        }

        private void OpenFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadDataFromFile(openFileDialog.FileName);
                SaveRecentFile(openFileDialog.FileName);
            }
        }

        private void ExecuteScriptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExecuteScript(File.ReadAllText(openFileDialog.FileName));
                SaveRecentFile(openFileDialog.FileName);
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monaco.Cut();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monaco.Copy();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monaco.Paste();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monaco.SelectAll();
        }

        private void FindDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monaco.ExecuteScriptAsyncWhenPageLoaded("editor.getAction('actions.find').run();");
        }

        private async void ZoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double current = await Monaco.GetZoomLevelAsync();
            Monaco.SetZoomLevel(current + 1);
        }

        private async void ZoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double current = await Monaco.GetZoomLevelAsync();
            Monaco.SetZoomLevel(current - 1);
        }

        private void Zoom100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monaco.SetZoomLevel(0);
        }

        private void FindAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monaco.ExecuteScriptAsyncWhenPageLoaded("editor.getAction('actions.find').run();");
        }

        #endregion
    }
}
