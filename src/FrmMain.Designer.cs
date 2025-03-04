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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLameExeStub = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLameBool = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.panelDropToConvert = new System.Windows.Forms.Panel();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox.SuspendLayout();
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
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLameExeStub,
            this.toolStripStatusLabelLameBool});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
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
            this.groupBox.Controls.Add(this.textBoxLog);
            this.groupBox.Controls.Add(this.panelDropToConvert);
            this.groupBox.Enabled = false;
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(776, 376);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Drop WAVe to convert or click:";
            // 
            // panelDropToConvert
            // 
            this.panelDropToConvert.AllowDrop = true;
            this.panelDropToConvert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDropToConvert.BackgroundImage")));
            this.panelDropToConvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDropToConvert.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDropToConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelDropToConvert.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDropToConvert.Location = new System.Drawing.Point(3, 16);
            this.panelDropToConvert.Name = "panelDropToConvert";
            this.panelDropToConvert.Size = new System.Drawing.Size(770, 266);
            this.panelDropToConvert.TabIndex = 0;
            this.panelDropToConvert.Click += new System.EventHandler(this.panelDropToConvert_Click);
            this.panelDropToConvert.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDropToConvert_DragDrop);
            this.panelDropToConvert.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDropToConvert_DragEnter);
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
            // textBoxLog
            // 
            this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxLog.Location = new System.Drawing.Point(3, 288);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(770, 85);
            this.textBoxLog.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.textBoxLamePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyLame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLamePath;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLameExeStub;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLameBool;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Panel panelDropToConvert;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxLog;
    }
}

