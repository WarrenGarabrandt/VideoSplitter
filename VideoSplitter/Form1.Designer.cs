namespace VideoSplitter
{
    partial class Form1
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
            this.videoView1 = new LibVLCSharp.WinForms.VideoView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lstChapters = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdPlayPause = new System.Windows.Forms.Button();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSegmentNames = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExportDirectory = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runSimultaneouslyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preserveAllStreamsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // videoView1
            // 
            this.videoView1.BackColor = System.Drawing.Color.Black;
            this.videoView1.Location = new System.Drawing.Point(494, 56);
            this.videoView1.Margin = new System.Windows.Forms.Padding(2);
            this.videoView1.MediaPlayer = null;
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(640, 480);
            this.videoView1.TabIndex = 0;
            this.videoView1.Text = "videoView1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1145, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exportToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "&Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // lstChapters
            // 
            this.lstChapters.FormattingEnabled = true;
            this.lstChapters.IntegralHeight = false;
            this.lstChapters.Location = new System.Drawing.Point(12, 57);
            this.lstChapters.Name = "lstChapters";
            this.lstChapters.Size = new System.Drawing.Size(219, 478);
            this.lstChapters.TabIndex = 2;
            this.lstChapters.SelectedIndexChanged += new System.EventHandler(this.LstChapters_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chapters";
            // 
            // cmdPlayPause
            // 
            this.cmdPlayPause.Location = new System.Drawing.Point(494, 30);
            this.cmdPlayPause.Name = "cmdPlayPause";
            this.cmdPlayPause.Size = new System.Drawing.Size(75, 23);
            this.cmdPlayPause.TabIndex = 4;
            this.cmdPlayPause.Text = "Play/Pause";
            this.cmdPlayPause.UseVisualStyleBackColor = true;
            this.cmdPlayPause.Click += new System.EventHandler(this.cmdPlayPause_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instructionsToolStripMenuItem.Text = "&Instructions";
            this.instructionsToolStripMenuItem.Click += new System.EventHandler(this.instructionsToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Segment Names";
            // 
            // txtSegmentNames
            // 
            this.txtSegmentNames.Location = new System.Drawing.Point(237, 96);
            this.txtSegmentNames.Multiline = true;
            this.txtSegmentNames.Name = "txtSegmentNames";
            this.txtSegmentNames.Size = new System.Drawing.Size(252, 440);
            this.txtSegmentNames.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Export Directory";
            // 
            // txtExportDirectory
            // 
            this.txtExportDirectory.Location = new System.Drawing.Point(237, 57);
            this.txtExportDirectory.Name = "txtExportDirectory";
            this.txtExportDirectory.Size = new System.Drawing.Size(219, 20);
            this.txtExportDirectory.TabIndex = 8;
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(462, 55);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.Size = new System.Drawing.Size(27, 23);
            this.cmdBrowse.TabIndex = 9;
            this.cmdBrowse.Text = "...";
            this.cmdBrowse.UseVisualStyleBackColor = true;
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runSimultaneouslyToolStripMenuItem,
            this.preserveAllStreamsToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 22);
            this.optionToolStripMenuItem.Text = "&Option";
            // 
            // runSimultaneouslyToolStripMenuItem
            // 
            this.runSimultaneouslyToolStripMenuItem.Checked = true;
            this.runSimultaneouslyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.runSimultaneouslyToolStripMenuItem.Name = "runSimultaneouslyToolStripMenuItem";
            this.runSimultaneouslyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.runSimultaneouslyToolStripMenuItem.Text = "Run &Simultaneously";
            this.runSimultaneouslyToolStripMenuItem.Click += new System.EventHandler(this.runSimultaneouslyToolStripMenuItem_Click);
            // 
            // preserveAllStreamsToolStripMenuItem
            // 
            this.preserveAllStreamsToolStripMenuItem.Checked = true;
            this.preserveAllStreamsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.preserveAllStreamsToolStripMenuItem.Name = "preserveAllStreamsToolStripMenuItem";
            this.preserveAllStreamsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.preserveAllStreamsToolStripMenuItem.Text = "&Preserve All Streams";
            this.preserveAllStreamsToolStripMenuItem.Click += new System.EventHandler(this.preserveAllStreamsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 547);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.txtExportDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSegmentNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdPlayPause);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstChapters);
            this.Controls.Add(this.videoView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Video Split Batcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.videoView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox lstChapters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdPlayPause;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSegmentNames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExportDirectory;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runSimultaneouslyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preserveAllStreamsToolStripMenuItem;
    }
}

