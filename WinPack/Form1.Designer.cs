namespace WinPack
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblSourceDir = new System.Windows.Forms.Label();
            this.btnSourceDir = new System.Windows.Forms.Button();
            this.btnDestDir = new System.Windows.Forms.Button();
            this.lblDestDir = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fbdSourceDir = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaxWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaxSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlFormat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nudJpegQuality = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.epMaxWidth = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMaxHeight = new System.Windows.Forms.ErrorProvider(this.components);
            this.epMaxSize = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tsProgressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtMaxHeight = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shrinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkClearOutputFolder = new System.Windows.Forms.CheckBox();
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudJpegQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaxWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaxHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaxSize)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder with images to be shrunk";
            // 
            // lblSourceDir
            // 
            this.lblSourceDir.BackColor = System.Drawing.Color.White;
            this.lblSourceDir.Location = new System.Drawing.Point(21, 64);
            this.lblSourceDir.Name = "lblSourceDir";
            this.lblSourceDir.Size = new System.Drawing.Size(458, 18);
            this.lblSourceDir.TabIndex = 1;
            this.lblSourceDir.Text = "C:\\";
            this.lblSourceDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSourceDir
            // 
            this.btnSourceDir.Location = new System.Drawing.Point(485, 62);
            this.btnSourceDir.Name = "btnSourceDir";
            this.btnSourceDir.Size = new System.Drawing.Size(75, 23);
            this.btnSourceDir.TabIndex = 2;
            this.btnSourceDir.Text = "Change...";
            this.btnSourceDir.UseVisualStyleBackColor = true;
            this.btnSourceDir.Click += new System.EventHandler(this.btnSourceDir_Click);
            // 
            // btnDestDir
            // 
            this.btnDestDir.Location = new System.Drawing.Point(485, 107);
            this.btnDestDir.Name = "btnDestDir";
            this.btnDestDir.Size = new System.Drawing.Size(75, 23);
            this.btnDestDir.TabIndex = 5;
            this.btnDestDir.Text = "Change...";
            this.btnDestDir.UseVisualStyleBackColor = true;
            this.btnDestDir.Click += new System.EventHandler(this.btnDestDir_Click);
            // 
            // lblDestDir
            // 
            this.lblDestDir.BackColor = System.Drawing.Color.White;
            this.lblDestDir.Location = new System.Drawing.Point(21, 109);
            this.lblDestDir.Name = "lblDestDir";
            this.lblDestDir.Size = new System.Drawing.Size(458, 18);
            this.lblDestDir.TabIndex = 4;
            this.lblDestDir.Text = "C:\\";
            this.lblDestDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Output (shrunk) folder";
            // 
            // fbdSourceDir
            // 
            this.fbdSourceDir.Description = "Select folder whose image files you wish to compress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Maximum height";
            // 
            // txtMaxWidth
            // 
            this.txtMaxWidth.Location = new System.Drawing.Point(120, 142);
            this.txtMaxWidth.Name = "txtMaxWidth";
            this.txtMaxWidth.Size = new System.Drawing.Size(39, 20);
            this.txtMaxWidth.TabIndex = 9;
            this.txtMaxWidth.Text = "32767";
            this.txtMaxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxWidth.Validated += new System.EventHandler(this.txtMaxWidth_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maximum width";
            // 
            // txtMaxSize
            // 
            this.txtMaxSize.Location = new System.Drawing.Point(120, 177);
            this.txtMaxSize.Name = "txtMaxSize";
            this.txtMaxSize.Size = new System.Drawing.Size(39, 20);
            this.txtMaxSize.TabIndex = 15;
            this.txtMaxSize.Text = "16384";
            this.txtMaxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxSize.Validated += new System.EventHandler(this.txtMaxSize_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Maximum size (kb)";
            // 
            // ddlFormat
            // 
            this.ddlFormat.AllowDrop = true;
            this.ddlFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlFormat.FormattingEnabled = true;
            this.ddlFormat.Items.AddRange(new object[] {
            "JPG",
            "PNG",
            "GIF",
            "BMP"});
            this.ddlFormat.Location = new System.Drawing.Point(486, 142);
            this.ddlFormat.Name = "ddlFormat";
            this.ddlFormat.Size = new System.Drawing.Size(73, 21);
            this.ddlFormat.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(377, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Output image format";
            // 
            // nudJpegQuality
            // 
            this.nudJpegQuality.Location = new System.Drawing.Point(308, 176);
            this.nudJpegQuality.Name = "nudJpegQuality";
            this.nudJpegQuality.Size = new System.Drawing.Size(39, 20);
            this.nudJpegQuality.TabIndex = 18;
            this.nudJpegQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudJpegQuality.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "JPG image quality";
            // 
            // epMaxWidth
            // 
            this.epMaxWidth.ContainerControl = this;
            // 
            // epMaxHeight
            // 
            this.epMaxHeight.ContainerControl = this;
            // 
            // epMaxSize
            // 
            this.epMaxSize.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgress,
            this.tsProgressLabel,
            this.tsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 216);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(573, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProgress
            // 
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(300, 16);
            // 
            // tsProgressLabel
            // 
            this.tsProgressLabel.Name = "tsProgressLabel";
            this.tsProgressLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // tsLabel
            // 
            this.tsLabel.Name = "tsLabel";
            this.tsLabel.Size = new System.Drawing.Size(39, 17);
            this.tsLabel.Text = "Ready";
            // 
            // txtMaxHeight
            // 
            this.txtMaxHeight.Location = new System.Drawing.Point(308, 142);
            this.txtMaxHeight.Name = "txtMaxHeight";
            this.txtMaxHeight.Size = new System.Drawing.Size(39, 20);
            this.txtMaxHeight.TabIndex = 23;
            this.txtMaxHeight.Text = "32767";
            this.txtMaxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxHeight.Validated += new System.EventHandler(this.txtMaxHeight_Validated);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(573, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputFolderToolStripMenuItem,
            this.outputFolderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // inputFolderToolStripMenuItem
            // 
            this.inputFolderToolStripMenuItem.Name = "inputFolderToolStripMenuItem";
            this.inputFolderToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.inputFolderToolStripMenuItem.Text = "&Input folder ...";
            this.inputFolderToolStripMenuItem.Click += new System.EventHandler(this.btnSourceDir_Click);
            // 
            // outputFolderToolStripMenuItem
            // 
            this.outputFolderToolStripMenuItem.Name = "outputFolderToolStripMenuItem";
            this.outputFolderToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.outputFolderToolStripMenuItem.Text = "&Output folder ...";
            this.outputFolderToolStripMenuItem.Click += new System.EventHandler(this.btnDestDir_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shrinkToolStripMenuItem,
            this.viewDetailsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // shrinkToolStripMenuItem
            // 
            this.shrinkToolStripMenuItem.Name = "shrinkToolStripMenuItem";
            this.shrinkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shrinkToolStripMenuItem.Text = "&Shrink";
            this.shrinkToolStripMenuItem.Click += new System.EventHandler(this.btnShrink_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.aboutToolStripMenuItem.Text = "A&bout ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // chkClearOutputFolder
            // 
            this.chkClearOutputFolder.AutoSize = true;
            this.chkClearOutputFolder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkClearOutputFolder.Location = new System.Drawing.Point(368, 179);
            this.chkClearOutputFolder.Name = "chkClearOutputFolder";
            this.chkClearOutputFolder.Size = new System.Drawing.Size(191, 17);
            this.chkClearOutputFolder.TabIndex = 25;
            this.chkClearOutputFolder.Text = "Empty output folder before packing";
            this.chkClearOutputFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkClearOutputFolder.UseVisualStyleBackColor = true;
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewDetailsToolStripMenuItem.Text = "&View details ...";
            this.viewDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewDetailsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 238);
            this.Controls.Add(this.chkClearOutputFolder);
            this.Controls.Add(this.txtMaxHeight);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nudJpegQuality);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ddlFormat);
            this.Controls.Add(this.txtMaxSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaxWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDestDir);
            this.Controls.Add(this.lblDestDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSourceDir);
            this.Controls.Add(this.lblSourceDir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(589, 240);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Pack Images Into Smaller Files";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudJpegQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaxWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaxHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMaxSize)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSourceDir;
        private System.Windows.Forms.Button btnSourceDir;
        private System.Windows.Forms.Button btnDestDir;
        private System.Windows.Forms.Label lblDestDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FolderBrowserDialog fbdSourceDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaxWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaxSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddlFormat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudJpegQuality;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider epMaxWidth;
        private System.Windows.Forms.ErrorProvider epMaxHeight;
        private System.Windows.Forms.ErrorProvider epMaxSize;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.ToolStripStatusLabel tsProgressLabel;
        private System.Windows.Forms.TextBox txtMaxHeight;
        private System.Windows.Forms.ToolStripStatusLabel tsLabel;
        private System.Windows.Forms.CheckBox chkClearOutputFolder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outputFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shrinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem;
    }
}

