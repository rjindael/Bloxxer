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
            this.isDarkModeCheckBox = new System.Windows.Forms.CheckBox();
            this.bloxxerOnTopChkBox = new System.Windows.Forms.CheckBox();
            this.robloxOnTopChkBox = new System.Windows.Forms.CheckBox();
            this.injectExecChkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scriptExecCheckBox
            // 
            this.scriptExecCheckBox.AutoSize = true;
            this.scriptExecCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptExecCheckBox.ForeColor = System.Drawing.SystemColors.Window;
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
            this.notifyLabel.ForeColor = System.Drawing.SystemColors.Window;
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
            // isDarkModeCheckBox
            // 
            this.isDarkModeCheckBox.AutoSize = true;
            this.isDarkModeCheckBox.Checked = true;
            this.isDarkModeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isDarkModeCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.isDarkModeCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.isDarkModeCheckBox.Location = new System.Drawing.Point(13, 64);
            this.isDarkModeCheckBox.Name = "isDarkModeCheckBox";
            this.isDarkModeCheckBox.Size = new System.Drawing.Size(82, 17);
            this.isDarkModeCheckBox.TabIndex = 3;
            this.isDarkModeCheckBox.Text = "Dark mode";
            this.isDarkModeCheckBox.UseVisualStyleBackColor = true;
            this.isDarkModeCheckBox.CheckedChanged += new System.EventHandler(this.IsDarkModeCheckBox_CheckedChanged);
            // 
            // bloxxerOnTopChkBox
            // 
            this.bloxxerOnTopChkBox.AutoSize = true;
            this.bloxxerOnTopChkBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.bloxxerOnTopChkBox.ForeColor = System.Drawing.SystemColors.Window;
            this.bloxxerOnTopChkBox.Location = new System.Drawing.Point(12, 107);
            this.bloxxerOnTopChkBox.Name = "bloxxerOnTopChkBox";
            this.bloxxerOnTopChkBox.Size = new System.Drawing.Size(138, 17);
            this.bloxxerOnTopChkBox.TabIndex = 4;
            this.bloxxerOnTopChkBox.Text = "Bloxxer always on top";
            this.bloxxerOnTopChkBox.UseVisualStyleBackColor = true;
            this.bloxxerOnTopChkBox.CheckedChanged += new System.EventHandler(this.BloxxerOnTopChkBox_CheckedChanged);
            // 
            // robloxOnTopChkBox
            // 
            this.robloxOnTopChkBox.AutoSize = true;
            this.robloxOnTopChkBox.Checked = true;
            this.robloxOnTopChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.robloxOnTopChkBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.robloxOnTopChkBox.ForeColor = System.Drawing.SystemColors.Window;
            this.robloxOnTopChkBox.Location = new System.Drawing.Point(12, 85);
            this.robloxOnTopChkBox.Name = "robloxOnTopChkBox";
            this.robloxOnTopChkBox.Size = new System.Drawing.Size(137, 17);
            this.robloxOnTopChkBox.TabIndex = 5;
            this.robloxOnTopChkBox.Text = "Roblox always on top";
            this.robloxOnTopChkBox.UseVisualStyleBackColor = true;
            this.robloxOnTopChkBox.CheckedChanged += new System.EventHandler(this.RobloxOnTopChkBox_CheckedChanged);
            // 
            // injectExecChkBox
            // 
            this.injectExecChkBox.AutoSize = true;
            this.injectExecChkBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.injectExecChkBox.ForeColor = System.Drawing.SystemColors.Window;
            this.injectExecChkBox.Location = new System.Drawing.Point(12, 130);
            this.injectExecChkBox.Name = "injectExecChkBox";
            this.injectExecChkBox.Size = new System.Drawing.Size(284, 17);
            this.injectExecChkBox.TabIndex = 6;
            this.injectExecChkBox.Text = "Inject upon script execution if not injected already";
            this.injectExecChkBox.UseVisualStyleBackColor = true;
            this.injectExecChkBox.CheckedChanged += new System.EventHandler(this.InjectExecChkBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(276, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "By Zi#8552";
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(334, 167);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.injectExecChkBox);
            this.Controls.Add(this.robloxOnTopChkBox);
            this.Controls.Add(this.bloxxerOnTopChkBox);
            this.Controls.Add(this.isDarkModeCheckBox);
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
        private System.Windows.Forms.CheckBox isDarkModeCheckBox;
        private System.Windows.Forms.CheckBox bloxxerOnTopChkBox;
        private System.Windows.Forms.CheckBox robloxOnTopChkBox;
        private System.Windows.Forms.CheckBox injectExecChkBox;
        private System.Windows.Forms.Label label1;
    }
}