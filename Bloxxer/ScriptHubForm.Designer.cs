namespace Bloxxer
{
    partial class ScriptHubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptHubForm));
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.executeBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.authorLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.scriptList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.descriptionTextBox.Location = new System.Drawing.Point(143, 233);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(337, 74);
            this.descriptionTextBox.TabIndex = 1;
            this.descriptionTextBox.Text = "";
            this.descriptionTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.DescriptionTextBox_LinkClicked);
            // 
            // executeBtn
            // 
            this.executeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.executeBtn.FlatAppearance.BorderSize = 0;
            this.executeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeBtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.executeBtn.Location = new System.Drawing.Point(315, 313);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(165, 40);
            this.executeBtn.TabIndex = 2;
            this.executeBtn.Text = "Execute";
            this.executeBtn.UseVisualStyleBackColor = false;
            this.executeBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.loadBtn.FlatAppearance.BorderSize = 0;
            this.loadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadBtn.Font = new System.Drawing.Font("Calibri", 12F);
            this.loadBtn.Location = new System.Drawing.Point(143, 313);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(165, 40);
            this.loadBtn.TabIndex = 3;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = false;
            this.loadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // imagePanel
            // 
            this.imagePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imagePanel.BackgroundImage")));
            this.imagePanel.Location = new System.Drawing.Point(143, 13);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(338, 192);
            this.imagePanel.TabIndex = 4;
            // 
            // authorLabel
            // 
            this.authorLabel.AutoSize = true;
            this.authorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.authorLabel.Location = new System.Drawing.Point(141, 211);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(0, 13);
            this.authorLabel.TabIndex = 6;
            // 
            // versionLabel
            // 
            this.versionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.versionLabel.Location = new System.Drawing.Point(400, 211);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(80, 13);
            this.versionLabel.TabIndex = 7;
            // 
            // scriptList
            // 
            this.scriptList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.scriptList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.scriptList.Font = new System.Drawing.Font("Calibri", 9F);
            this.scriptList.ForeColor = System.Drawing.SystemColors.Window;
            this.scriptList.HideSelection = false;
            this.scriptList.Location = new System.Drawing.Point(13, 13);
            this.scriptList.Name = "scriptList";
            this.scriptList.ShowItemToolTips = true;
            this.scriptList.Size = new System.Drawing.Size(124, 340);
            this.scriptList.TabIndex = 14;
            this.scriptList.UseCompatibleStateImageBehavior = false;
            this.scriptList.View = System.Windows.Forms.View.List;
            this.scriptList.SelectedIndexChanged += new System.EventHandler(this.ScriptList_SelectedIndexChanged);
            this.scriptList.DoubleClick += new System.EventHandler(this.ScriptList_DoubleClick);
            // 
            // ScriptHubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(493, 365);
            this.Controls.Add(this.scriptList);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.authorLabel);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.descriptionTextBox);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ScriptHubForm";
            this.Text = "Script Hub";
            this.Load += new System.EventHandler(this.ScriptHubForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Label authorLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.ListView scriptList;
    }
}