namespace EasyLame
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.textBoxLamePath = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLameExeStub = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLameBool = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.panel3D = new System.Windows.Forms.Panel();
            this.panelDropToConvert = new System.Windows.Forms.Panel();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.panel3D.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLamePath
            // 
            this.textBoxLamePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLamePath.Location = new System.Drawing.Point(12, 396);
            this.textBoxLamePath.Name = "textBoxLamePath";
            this.textBoxLamePath.ReadOnly = true;
            this.textBoxLamePath.Size = new System.Drawing.Size(695, 20);
            this.textBoxLamePath.TabIndex = 3;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLameExeStub,
            this.toolStripStatusLabelLameBool});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelLameExeStub
            // 
            this.toolStripStatusLabelLameExeStub.Name = "toolStripStatusLabelLameExeStub";
            this.toolStripStatusLabelLameExeStub.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabelLameExeStub.Text = "lame.exe";
            // 
            // toolStripStatusLabelLameBool
            // 
            this.toolStripStatusLabelLameBool.Name = "toolStripStatusLabelLameBool";
            this.toolStripStatusLabelLameBool.Size = new System.Drawing.Size(90, 17);
            this.toolStripStatusLabelLameBool.Text = "<found or not>";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.panel3D);
            this.groupBox.Enabled = false;
            this.groupBox.Location = new System.Drawing.Point(12, 27);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(776, 361);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Drop WAVe to convert or click:";
            // 
            // panel3D
            // 
            this.panel3D.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3D.Controls.Add(this.panelDropToConvert);
            this.panel3D.Controls.Add(this.textBoxLog);
            this.panel3D.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3D.Location = new System.Drawing.Point(3, 16);
            this.panel3D.Name = "panel3D";
            this.panel3D.Size = new System.Drawing.Size(770, 342);
            this.panel3D.TabIndex = 2;
            // 
            // panelDropToConvert
            // 
            this.panelDropToConvert.AllowDrop = true;
            this.panelDropToConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDropToConvert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDropToConvert.BackgroundImage")));
            this.panelDropToConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDropToConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelDropToConvert.Location = new System.Drawing.Point(3, 3);
            this.panelDropToConvert.Name = "panelDropToConvert";
            this.panelDropToConvert.Size = new System.Drawing.Size(762, 218);
            this.panelDropToConvert.TabIndex = 0;
            this.panelDropToConvert.Click += new System.EventHandler(this.panelDropToConvert_Click);
            this.panelDropToConvert.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDropToConvert_DragDrop);
            this.panelDropToConvert.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDropToConvert_DragEnter);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLog.Location = new System.Drawing.Point(3, 227);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(760, 108);
            this.textBoxLog.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.Enabled = false;
            this.buttonBrowse.Location = new System.Drawing.Point(713, 394);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donateToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // donateToolStripMenuItem
            // 
            this.donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            this.donateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.donateToolStripMenuItem.Text = "Donate";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.textBoxLamePath);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyLame - Easy Convert any WAV  to MP3 320kbs | ww.epicm.org";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.panel3D.ResumeLayout(false);
            this.panel3D.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLamePath;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLameExeStub;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLameBool;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Panel panelDropToConvert;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Panel panel3D;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

