using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using Bloxxer.Utils;
using Newtonsoft.Json.Linq;

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

        #region Initialization

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            JsonManager.GetPreferences();
            TopMost = true;

            robloxOnTopCheckBox.Checked  = GlobalVars.RobloxOnTop;
            bloxxerOnTopCheckBox.Checked = GlobalVars.BloxxerOnTop;
            injectExecCheckBox.Checked   = GlobalVars.InjectOnExecution;
            scriptExecCheckBox.Checked   = GlobalVars.ExecutionMessage;
            notifyOption.SelectedIndex   = GlobalVars.ExecutionMessageMethod;
            themeOption.SelectedIndex    = GlobalVars.Theme;
            notifyOption.Enabled         = GlobalVars.ExecutionMessage;
            notifyLabel.ForeColor        = GlobalVars.ExecutionMessage ? SystemColors.Window : SystemColors.ScrollBar;
        }

        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                       .Concat(controls)
                                       .Where(c => c.GetType() == type);
        }

        private void UpdateTheme()
        {
            bool light = Convert.ToBoolean(GlobalVars.Theme);

            Color background = light ? Color.FromArgb(255, 255, 255) : Color.FromArgb(25, 25, 25);
            Color text       = light ? Color.FromArgb(0, 0, 0)       : Color.FromArgb(255, 255, 255);
            Color link       = light ? Color.FromArgb(0, 38, 38)     : Color.FromArgb(255, 255, 255);
            Color activeLink = light ? Color.FromArgb(75, 0, 130)    : Color.FromArgb(10, 10, 10);

            BackColor = background;

            foreach (Control control in GetAll(this, typeof(Label)))
            {
                control.ForeColor = text;
            }

            foreach (Control control in GetAll(this, typeof(LinkLabel)))
            {
                LinkLabel linkControl = control as LinkLabel;

                linkControl.ForeColor = link;
                linkControl.LinkColor = link;
                linkControl.ActiveLinkColor = activeLink;
            }

            foreach (Control control in GetAll(this, typeof(CheckBox)))
            {
                control.ForeColor = text;
            }

            // for enabled label text
            ScriptExecCheckBox_CheckedChanged(null, null);
        }

        #endregion
        #region JSON

        private void SaveJson(object value, string jsonLocation)
        {
            string[] location = jsonLocation.Split('.');
            JObject json = JsonManager.GetJson();

            (location[0] == "execution" ? json["preferences"]["execution"] : json["preferences"])[location[location.Length - 1]] = JToken.FromObject(value);
            JsonManager.SaveJson(json.ToString());
            GlobalVars.SetProperty(GlobalVars.GlobalValues[location[location.Length - 1].ToString()], value);
        }

        #endregion
        #region Form Events

        private void ScriptExecCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SaveJson(scriptExecCheckBox.Checked, "execution.show");
            notifyOption.Enabled = scriptExecCheckBox.Checked;

            Color inactiveColor   = Convert.ToBoolean(GlobalVars.Theme) ? SystemColors.WindowFrame : SystemColors.ScrollBar;
            Color activeColor     = Convert.ToBoolean(GlobalVars.Theme) ? SystemColors.WindowText : SystemColors.Window;
            notifyLabel.ForeColor = scriptExecCheckBox.Checked ? activeColor : inactiveColor;
        }

        private void NotifyOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveJson(notifyOption.SelectedIndex, "execution.method");
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

        private void ThemeOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            SaveJson(themeOption.SelectedIndex, "theme");
            GlobalVars.Theme = themeOption.SelectedIndex; // dunno why savejson doesn't handle this on it's own??

            MainForm.UpdateTheme();
            this.UpdateTheme();
        }

        private void GithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(githubLink.Text);
        }

        #endregion
    }
}
