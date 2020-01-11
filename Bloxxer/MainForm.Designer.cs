namespace Bloxxer {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.injectBtn = new System.Windows.Forms.Button();
            this.executeBtn = new System.Windows.Forms.Button();
            this.recentlyUsedList = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.optionsBtn = new System.Windows.Forms.Button();
            this.scriptHubBtn = new System.Windows.Forms.Button();
            this.execAsLuaC = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.executeScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            this.openFileDialog.FileName = "New File";
            this.openFileDialog.Filter = "All files|*.*|Text documents (*.txt)|*.txt*|Lua scripts (*.lua)|*.lua";
            // 
            // injectBtn
            // 
            this.injectBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.injectBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.injectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.injectBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.injectBtn.FlatAppearance.BorderSize = 0;
            this.injectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.injectBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.injectBtn.ForeColor = System.Drawing.SystemColors.WindowText;
            this.injectBtn.Location = new System.Drawing.Point(17, 328);
            this.injectBtn.Name = "injectBtn";
            this.injectBtn.Size = new System.Drawing.Size(150, 35);
            this.injectBtn.TabIndex = 11;
            this.injectBtn.Text = "Inject";
            this.injectBtn.UseVisualStyleBackColor = false;
            this.injectBtn.Click += new System.EventHandler(this.InjectBtn_Click);
            // 
            // executeBtn
            // 
            this.executeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.executeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.executeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.executeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.executeBtn.FlatAppearance.BorderSize = 0;
            this.executeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeBtn.ForeColor = System.Drawing.Color.Black;
            this.executeBtn.Location = new System.Drawing.Point(175, 328);
            this.executeBtn.Name = "executeBtn";
            this.executeBtn.Size = new System.Drawing.Size(150, 35);
            this.executeBtn.TabIndex = 12;
            this.executeBtn.Text = "Execute";
            this.executeBtn.UseVisualStyleBackColor = false;
            this.executeBtn.Click += new System.EventHandler(this.ExecuteBtn_Click);
            // 
            // recentlyUsedList
            // 
            this.recentlyUsedList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.recentlyUsedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.recentlyUsedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recentlyUsedList.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentlyUsedList.ForeColor = System.Drawing.SystemColors.Window;
            this.recentlyUsedList.HideSelection = false;
            this.recentlyUsedList.Location = new System.Drawing.Point(658, 68);
            this.recentlyUsedList.Name = "recentlyUsedList";
            this.recentlyUsedList.ShowItemToolTips = true;
            this.recentlyUsedList.Size = new System.Drawing.Size(131, 220);
            this.recentlyUsedList.TabIndex = 13;
            this.recentlyUsedList.UseCompatibleStateImageBehavior = false;
            this.recentlyUsedList.View = System.Windows.Forms.View.List;
            this.recentlyUsedList.DoubleClick += new System.EventHandler(this.RecentlyUsedList_DoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(658, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Recently Used";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionsBtn
            // 
            this.optionsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.optionsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.optionsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.optionsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.optionsBtn.FlatAppearance.BorderSize = 0;
            this.optionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionsBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsBtn.ForeColor = System.Drawing.Color.Black;
            this.optionsBtn.Location = new System.Drawing.Point(491, 328);
            this.optionsBtn.Name = "optionsBtn";
            this.optionsBtn.Size = new System.Drawing.Size(150, 35);
            this.optionsBtn.TabIndex = 19;
            this.optionsBtn.Text = "Options";
            this.optionsBtn.UseVisualStyleBackColor = false;
            this.optionsBtn.Click += new System.EventHandler(this.OptionsBtn_Click);
            // 
            // scriptHubBtn
            // 
            this.scriptHubBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.scriptHubBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.scriptHubBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.scriptHubBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scriptHubBtn.FlatAppearance.BorderSize = 0;
            this.scriptHubBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scriptHubBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scriptHubBtn.ForeColor = System.Drawing.Color.Black;
            this.scriptHubBtn.Location = new System.Drawing.Point(333, 328);
            this.scriptHubBtn.Name = "scriptHubBtn";
            this.scriptHubBtn.Size = new System.Drawing.Size(150, 35);
            this.scriptHubBtn.TabIndex = 20;
            this.scriptHubBtn.Text = "Script Hub";
            this.scriptHubBtn.UseVisualStyleBackColor = false;
            this.scriptHubBtn.Click += new System.EventHandler(this.ScriptHubBtn_Click);
            // 
            // execAsLuaC
            // 
            this.execAsLuaC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.execAsLuaC.AutoSize = true;
            this.execAsLuaC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.execAsLuaC.Location = new System.Drawing.Point(17, 297);
            this.execAsLuaC.Name = "execAsLuaC";
            this.execAsLuaC.Size = new System.Drawing.Size(145, 19);
            this.execAsLuaC.TabIndex = 21;
            this.execAsLuaC.Text = "Execute as Lua C script";
            this.execAsLuaC.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(805, 25);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.executeScriptToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F);
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.DropDownClosed += new System.EventHandler(this.FileToolStripMenuItem_DropDownClosed);
            this.fileToolStripMenuItem.DropDownOpened += new System.EventHandler(this.FileToolStripMenuItem_DropDownOpened);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFileToolStripMenuItem.Text = "Open...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // executeScriptToolStripMenuItem
            // 
            this.executeScriptToolStripMenuItem.Name = "executeScriptToolStripMenuItem";
            this.executeScriptToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.executeScriptToolStripMenuItem.Text = "Execute File...";
            this.executeScriptToolStripMenuItem.Click += new System.EventHandler(this.ExecuteScriptToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator1,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F);
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.DropDownClosed += new System.EventHandler(this.EditToolStripMenuItem_DropDownClosed);
            this.editToolStripMenuItem.DropDownOpened += new System.EventHandler(this.EditToolStripMenuItem_DropDownOpened);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findDialogToolStripMenuItem,
            this.findAndReplaceToolStripMenuItem});
            this.searchToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F);
            this.searchToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.DropDownClosed += new System.EventHandler(this.SearchToolStripMenuItem_DropDownClosed);
            this.searchToolStripMenuItem.DropDownOpened += new System.EventHandler(this.SearchToolStripMenuItem_DropDownOpened);
            // 
            // findDialogToolStripMenuItem
            // 
            this.findDialogToolStripMenuItem.Name = "findDialogToolStripMenuItem";
            this.findDialogToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.findDialogToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.findDialogToolStripMenuItem.Text = "Find...";
            this.findDialogToolStripMenuItem.Click += new System.EventHandler(this.FindDialogToolStripMenuItem_Click);
            // 
            // findAndReplaceToolStripMenuItem
            // 
            this.findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
            this.findAndReplaceToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+H";
            this.findAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.findAndReplaceToolStripMenuItem.Text = "Find and Replace...";
            this.findAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.FindAndReplaceToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.zoom100ToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10F);
            this.viewToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(48, 21);
            this.viewToolStripMenuItem.Text = "View";
            this.viewToolStripMenuItem.DropDownClosed += new System.EventHandler(this.ViewToolStripMenuItem_DropDownClosed);
            this.viewToolStripMenuItem.DropDownOpened += new System.EventHandler(this.ViewToolStripMenuItem_DropDownOpened);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.ZoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.ZoomOutToolStripMenuItem_Click);
            // 
            // zoom100ToolStripMenuItem
            // 
            this.zoom100ToolStripMenuItem.Name = "zoom100ToolStripMenuItem";
            this.zoom100ToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.zoom100ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoom100ToolStripMenuItem.Text = "Zoom 100%";
            this.zoom100ToolStripMenuItem.Click += new System.EventHandler(this.Zoom100ToolStripMenuItem_Click);
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.Location = new System.Drawing.Point(17, 38);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(635, 250);
            this.Panel.TabIndex = 25;
            this.Panel.TabStop = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(805, 374);
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.execAsLuaC);
            this.Controls.Add(this.scriptHubBtn);
            this.Controls.Add(this.optionsBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recentlyUsedList);
            this.Controls.Add(this.executeBtn);
            this.Controls.Add(this.injectBtn);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Bloxxer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button injectBtn;
        private System.Windows.Forms.Button executeBtn;
        private System.Windows.Forms.ListView recentlyUsedList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button optionsBtn;
        private System.Windows.Forms.Button scriptHubBtn;
        private System.Windows.Forms.CheckBox execAsLuaC;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem executeScriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAndReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoom100ToolStripMenuItem;
        private System.Windows.Forms.Panel Panel;
    }
}

