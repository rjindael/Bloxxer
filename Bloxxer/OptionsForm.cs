using System;
using System.Drawing;
using System.Windows.Forms;
using Bloxxer.Utils;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Bloxxer
{
    public partial class OptionsForm : Form
    {
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        private readonly MainForm MainForm;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

        public OptionsForm(MainForm MainForm)
        {
            InitializeComponent();
            this.MainForm = MainForm;
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            JsonManager.GetPreferences();
            TopMost = true;

            robloxOnTopCheckBox.Checked  = GlobalVars.RobloxOnTop;
            bloxxerOnTopCheckBox.Checked = GlobalVars.BloxxerOnTop;
            injectExecCheckBox.Checked   = GlobalVars.InjectOnExecution;
            scriptExecCheckBox.Checked   = GlobalVars.ExecutionMessage;
            notifyOption.SelectedIndex   = GlobalVars.ExecutionMessageMethod;

            notifyOption.Enabled         = GlobalVars.ExecutionMessage;
            notifyLabel.ForeColor        = GlobalVars.ExecutionMessage ? SystemColors.Window : SystemColors.ScrollBar;
        }

        private void SaveJson(object value, string jsonLocation)
        {
            string[] location = jsonLocation.Split('.');
            JObject json = JsonManager.GetJson();

            (location[0] == "execution" ? json["preferences"]["execution"] : json["preferences"])[location[location.Length - 1]] = JToken.FromObject(value);
            JsonManager.SaveJson(json.ToString());
            GlobalVars.SetProperty(GlobalVars.GlobalValues[location[location.Length - 1].ToString()], value);
        }

        private void ScriptExecCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SaveJson(scriptExecCheckBox.Checked, "execution.show");
            notifyOption.Enabled = scriptExecCheckBox.Checked;
            notifyLabel.ForeColor = (scriptExecCheckBox.Checked ? SystemColors.Window : SystemColors.ScrollBar);
        }

        private void NotifyOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveJson(notifyOption.SelectedIndex, "execution.method");
        }

        private void IsDarkModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SaveJson(isDarkModeCheckBox.Checked, "darkMode");
            MainForm.ChangeMonacoTheme(GlobalVars.DarkMode ? "Dark" : "Light");
        }

        private void BloxxerOnTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SaveJson(bloxxerOnTopCheckBox.Checked, "bloxxerOnTop");
            MainForm.TopMost = bloxxerOnTopCheckBox.Checked;
        }

        private void InjectExecCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SaveJson(injectExecCheckBox.Checked, "execution.injectOnExecution");
        }

        private void RobloxOnTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SaveJson(robloxOnTopCheckBox.Checked, "robloxOnTop");

            Process[] roblox = Process.GetProcessesByName("RobloxPlayerBeta");
            if (roblox.Length == 1)
            {
                SetWindowPos(roblox[0].MainWindowHandle, (GlobalVars.RobloxOnTop ? HWND_TOPMOST : HWND_NOTOPMOST), 0, 0, 0, 0, TOPMOST_FLAGS);
            }
        }
    }
}
