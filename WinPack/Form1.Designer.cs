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
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkClearOutputFolder = new System.Windows.Forms.CheckBox();
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
            this.label1.Location = new System.Drawing.Point(27, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder with images to be shrunk";
            // 
            // lblSourceDir
            // 
            this.lblSourceDir.BackColor = System.Drawing.Color.White;
            this.lblSourceDir.Location = new System.Drawing.Point(32, 98);
            this.lblSourceDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSourceDir.Name = "lblSourceDir";
            this.lblSourceDir.Size = new System.Drawing.Size(687, 28);
            this.lblSourceDir.TabIndex = 1;
            this.lblSourceDir.Text = "C:\\";
            this.lblSourceDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSourceDir
            // 
            this.btnSourceDir.Location = new System.Drawing.Point(728, 95);
            this.btnSourceDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSourceDir.Name = "btnSourceDir";
            this.btnSourceDir.Size = new System.Drawing.Size(112, 35);
            this.btnSourceDir.TabIndex = 2;
            this.btnSourceDir.Text = "Change...";
            this.btnSourceDir.UseVisualStyleBackColor = true;
            this.btnSourceDir.Click += new System.EventHandler(this.btnSourceDir_Click);
            // 
            // btnDestDir
            // 
            this.btnDestDir.Location = new System.Drawing.Point(728, 165);
            this.btnDestDir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDestDir.Name = "btnDestDir";
            this.btnDestDir.Size = new System.Drawing.Size(112, 35);
            this.btnDestDir.TabIndex = 5;
            this.btnDestDir.Text = "Change...";
            this.btnDestDir.UseVisualStyleBackColor = true;
            this.btnDestDir.Click += new System.EventHandler(this.btnDestDir_Click);
            // 
            // lblDestDir
            // 
            this.lblDestDir.BackColor = System.Drawing.Color.White;
            this.lblDestDir.Location = new System.Drawing.Point(32, 168);
            this.lblDestDir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestDir.Name = "lblDestDir";
            this.lblDestDir.Size = new System.Drawing.Size(687, 28);
            this.lblDestDir.TabIndex = 4;
            this.lblDestDir.Text = "C:\\";
            this.lblDestDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
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
            this.label2.Location = new System.Drawing.Point(314, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Maximum height";
            // 
            // txtMaxWidth
            // 
            this.txtMaxWidth.Location = new System.Drawing.Point(180, 218);
            this.txtMaxWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxWidth.Name = "txtMaxWidth";
            this.txtMaxWidth.Size = new System.Drawing.Size(56, 26);
            this.txtMaxWidth.TabIndex = 9;
            this.txtMaxWidth.Text = "2048";
            this.txtMaxWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxWidth.Validated += new System.EventHandler(this.txtMaxWidth_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maximum width";
            // 
            // txtMaxSize
            // 
            this.txtMaxSize.Location = new System.Drawing.Point(180, 272);
            this.txtMaxSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxSize.Name = "txtMaxSize";
            this.txtMaxSize.Size = new System.Drawing.Size(56, 26);
            this.txtMaxSize.TabIndex = 15;
            this.txtMaxSize.Text = "1024";
            this.txtMaxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxSize.Validated += new System.EventHandler(this.txtMaxSize_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 20);
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
            this.ddlFormat.Location = new System.Drawing.Point(729, 218);
            this.ddlFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlFormat.Name = "ddlFormat";
            this.ddlFormat.Size = new System.Drawing.Size(108, 28);
            this.ddlFormat.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(566, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Output image format";
            // 
            // nudJpegQuality
            // 
            this.nudJpegQuality.Location = new System.Drawing.Point(462, 271);
            this.nudJpegQuality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudJpegQuality.Name = "nudJpegQuality";
            this.nudJpegQuality.Size = new System.Drawing.Size(58, 26);
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
            this.label9.Location = new System.Drawing.Point(314, 274);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 20);
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
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgress,
            this.tsProgressLabel,
            this.tsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 335);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(860, 31);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsProgress
            // 
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(450, 25);
            // 
            // tsProgressLabel
            // 
            this.tsProgressLabel.Name = "tsProgressLabel";
            this.tsProgressLabel.Size = new System.Drawing.Size(0, 26);
            // 
            // tsLabel
            // 
            this.tsLabel.Name = "tsLabel";
            this.tsLabel.Size = new System.Drawing.Size(60, 26);
            this.tsLabel.Text = "Ready";
            // 
            // txtMaxHeight
            // 
            this.txtMaxHeight.Location = new System.Drawing.Point(462, 218);
            this.txtMaxHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaxHeight.Name = "txtMaxHeight";
            this.txtMaxHeight.Size = new System.Drawing.Size(56, 26);
            this.txtMaxHeight.TabIndex = 23;
            this.txtMaxHeight.Text = "2048";
            this.txtMaxHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxHeight.Validated += new System.EventHandler(this.txtMaxHeight_Validated);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(860, 35);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // inputFolderToolStripMenuItem
            // 
            this.inputFolderToolStripMenuItem.Name = "inputFolderToolStripMenuItem";
            this.inputFolderToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.inputFolderToolStripMenuItem.Text = "&Input folder ...";
            this.inputFolderToolStripMenuItem.Click += new System.EventHandler(this.btnSourceDir_Click);
            // 
            // outputFolderToolStripMenuItem
            // 
            this.outputFolderToolStripMenuItem.Name = "outputFolderToolStripMenuItem";
            this.outputFolderToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.outputFolderToolStripMenuItem.Text = "&Output folder ...";
            this.outputFolderToolStripMenuItem.Click += new System.EventHandler(this.btnDestDir_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shrinkToolStripMenuItem,
            this.viewDetailsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // shrinkToolStripMenuItem
            // 
            this.shrinkToolStripMenuItem.Name = "shrinkToolStripMenuItem";
            this.shrinkToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.shrinkToolStripMenuItem.Text = "&Shrink";
            this.shrinkToolStripMenuItem.Click += new System.EventHandler(this.btnShrink_Click);
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(206, 30);
            this.viewDetailsToolStripMenuItem.Text = "&View details ...";
            this.viewDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewDetailsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 30);
            this.aboutToolStripMenuItem.Text = "A&bout ...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // chkClearOutputFolder
            // 
            this.chkClearOutputFolder.AutoSize = true;
            this.chkClearOutputFolder.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkClearOutputFolder.Location = new System.Drawing.Point(552, 275);
            this.chkClearOutputFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkClearOutputFolder.Name = "chkClearOutputFolder";
            this.chkClearOutputFolder.Size = new System.Drawing.Size(283, 24);
            this.chkClearOutputFolder.TabIndex = 25;
            this.chkClearOutputFolder.Text = "Empty output folder before packing";
            this.chkClearOutputFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkClearOutputFolder.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 366);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(872, 339);
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

