namespace Bloxxer
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
            this.scriptExecCheckBox = new System.Windows.Forms.CheckBox();
            this.notifyLabel = new System.Windows.Forms.Label();
            this.notifyOption = new System.Windows.Forms.ComboBox();
            this.bloxxerOnTopCheckBox = new System.Windows.Forms.CheckBox();
            this.robloxOnTopCheckBox = new System.Windows.Forms.CheckBox();
            this.injectExecCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.themeOption = new System.Windows.Forms.ComboBox();
            this.githubLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // scriptExecCheckBox
            // 
            this.scriptExecCheckBox.AutoSize = true;
            this.scriptExecCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptExecCheckBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.scriptExecCheckBox.Location = new System.Drawing.Point(13, 13);
            this.scriptExecCheckBox.Name = "scriptExecCheckBox";
            this.scriptExecCheckBox.Size = new System.Drawing.Size(186, 17);
            this.scriptExecCheckBox.TabIndex = 0;
            this.scriptExecCheckBox.Text = "Show script execution message";
            this.scriptExecCheckBox.UseVisualStyleBackColor = true;
            this.scriptExecCheckBox.CheckedChanged += new System.EventHandler(this.ScriptExecCheckBox_CheckedChanged);
            // 
            // notifyLabel
            // 
            this.notifyLabel.AutoSize = true;
            this.notifyLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.notifyLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.notifyLabel.Location = new System.Drawing.Point(30, 37);
            this.notifyLabel.Name = "notifyLabel";
            this.notifyLabel.Size = new System.Drawing.Size(84, 13);
            this.notifyLabel.TabIndex = 1;
            this.notifyLabel.Text = "Notify through";
            // 
            // notifyOption
            // 
            this.notifyOption.BackColor = System.Drawing.SystemColors.Window;
            this.notifyOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.notifyOption.FormattingEnabled = true;
            this.notifyOption.Items.AddRange(new object[] {
            "in-game notification",
            "debug print message (F9)",
            "notification & debug message"});
            this.notifyOption.Location = new System.Drawing.Point(120, 34);
            this.notifyOption.Name = "notifyOption";
            this.notifyOption.Size = new System.Drawing.Size(203, 21);
            this.notifyOption.TabIndex = 2;
            this.notifyOption.SelectedIndexChanged += new System.EventHandler(this.NotifyOption_SelectedIndexChanged);
            // 
            // bloxxerOnTopCheckBox
            // 
            this.bloxxerOnTopCheckBox.AutoSize = true;
            this.bloxxerOnTopCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.bloxxerOnTopCheckBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.bloxxerOnTopCheckBox.Location = new System.Drawing.Point(12, 112);
            this.bloxxerOnTopCheckBox.Name = "bloxxerOnTopCheckBox";
            this.bloxxerOnTopCheckBox.Size = new System.Drawing.Size(138, 17);
            this.bloxxerOnTopCheckBox.TabIndex = 4;
            this.bloxxerOnTopCheckBox.Text = "Bloxxer always on top";
            this.bloxxerOnTopCheckBox.UseVisualStyleBackColor = true;
            this.bloxxerOnTopCheckBox.CheckedChanged += new System.EventHandler(this.BloxxerOnTopCheckBox_CheckedChanged);
            // 
            // robloxOnTopCheckBox
            // 
            this.robloxOnTopCheckBox.AutoSize = true;
            this.robloxOnTopCheckBox.Checked = true;
            this.robloxOnTopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.robloxOnTopCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.robloxOnTopCheckBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.robloxOnTopCheckBox.Location = new System.Drawing.Point(12, 90);
            this.robloxOnTopCheckBox.Name = "robloxOnTopCheckBox";
            this.robloxOnTopCheckBox.Size = new System.Drawing.Size(137, 17);
            this.robloxOnTopCheckBox.TabIndex = 5;
            this.robloxOnTopCheckBox.Text = "Roblox always on top";
            this.robloxOnTopCheckBox.UseVisualStyleBackColor = true;
            this.robloxOnTopCheckBox.CheckedChanged += new System.EventHandler(this.RobloxOnTopCheckBox_CheckedChanged);
            // 
            // injectExecCheckBox
            // 
            this.injectExecCheckBox.AutoSize = true;
            this.injectExecCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.injectExecCheckBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.injectExecCheckBox.Location = new System.Drawing.Point(12, 135);
            this.injectExecCheckBox.Name = "injectExecCheckBox";
            this.injectExecCheckBox.Size = new System.Drawing.Size(284, 17);
            this.injectExecCheckBox.TabIndex = 6;
            this.injectExecCheckBox.Text = "Inject upon script execution if not injected already";
            this.injectExecCheckBox.UseVisualStyleBackColor = true;
            this.injectExecCheckBox.CheckedChanged += new System.EventHandler(this.InjectExecCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(269, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "By Zi#8552";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Theme:";
            // 
            // themeOption
            // 
            this.themeOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeOption.FormattingEnabled = true;
            this.themeOption.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.themeOption.Location = new System.Drawing.Point(58, 61);
            this.themeOption.Name = "themeOption";
            this.themeOption.Size = new System.Drawing.Size(264, 21);
            this.themeOption.TabIndex = 9;
            this.themeOption.SelectedIndexChanged += new System.EventHandler(this.ThemeOption_SelectedIndexChanged);
            // 
            // githubLink
            // 
            this.githubLink.ActiveLinkColor = System.Drawing.Color.Indigo;
            this.githubLink.AutoSize = true;
            this.githubLink.BackColor = System.Drawing.Color.Transparent;
            this.githubLink.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.githubLink.LinkColor = System.Drawing.Color.DarkCyan;
            this.githubLink.Location = new System.Drawing.Point(9, 157);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(170, 13);
            this.githubLink.TabIndex = 10;
            this.githubLink.TabStop = true;
            this.githubLink.Text = "https://github.com/zi-blip/Bloxxer/";
            this.githubLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GithubLink_LinkClicked);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 179);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.themeOption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.injectExecCheckBox);
            this.Controls.Add(this.robloxOnTopCheckBox);
            this.Controls.Add(this.bloxxerOnTopCheckBox);
            this.Controls.Add(this.notifyOption);
            this.Controls.Add(this.notifyLabel);
            this.Controls.Add(this.scriptExecCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.OptionsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox scriptExecCheckBox;
        private System.Windows.Forms.Label notifyLabel;
        private System.Windows.Forms.ComboBox notifyOption;
        private System.Windows.Forms.CheckBox bloxxerOnTopCheckBox;
        private System.Windows.Forms.CheckBox robloxOnTopCheckBox;
        private System.Windows.Forms.CheckBox injectExecCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox themeOption;
        private System.Windows.Forms.LinkLabel githubLink;
    }
}