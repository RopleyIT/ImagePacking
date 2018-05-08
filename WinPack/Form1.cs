using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using ImagePacking;

namespace WinPack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            context = SynchronizationContext.Current;
        }

        private void btnSourceDir_Click(object sender, EventArgs e)
        {
            fbdSourceDir.Description = "Please select the folder whose images you wish to compress";
            fbdSourceDir.ShowNewFolderButton = false;
            fbdSourceDir.SelectedPath = lblSourceDir.Text;
            if(fbdSourceDir.ShowDialog(this) == DialogResult.OK)
                lblSourceDir.Text = fbdSourceDir.SelectedPath;
        }

        private void btnDestDir_Click(object sender, EventArgs e)
        {
            fbdSourceDir.Description = "Please select the folder into which compressed images will be placed";
            fbdSourceDir.ShowNewFolderButton = true;
            fbdSourceDir.SelectedPath = lblDestDir.Text;
            if (fbdSourceDir.ShowDialog(this) == DialogResult.OK)
                lblDestDir.Text = fbdSourceDir.SelectedPath;
        }

        int minWidth = 0;

        private void txtMinWidth_Validated(object sender, EventArgs e)
        {
            string error = string.Empty;
            if (!int.TryParse(txtMaxHeight.Text, out minWidth) || minWidth < 0 || minWidth > 32767)
                error = "Must be an integer between 0 and 32767";
            epMaxHeight.SetError(txtMaxHeight, error);
        }

        int maxWidth = 0;

        private void txtMaxWidth_Validated(object sender, EventArgs e)
        {
            string error = string.Empty;
            if (!int.TryParse(txtMaxWidth.Text, out maxWidth) || maxWidth < 0 || maxWidth > 32767)
                error = "Must be an integer between 0 and 32767";
            epMaxWidth.SetError(txtMaxWidth, error);
        }

        int maxHeight = 0;

        private void txtMaxHeight_Validated(object sender, EventArgs e)
        {
            string error = string.Empty;
            if (!int.TryParse(txtMaxHeight.Text, out maxHeight) || maxHeight < 0 || maxHeight > 32767)
                error = "Must be an integer between 0 and 32767";
            epMaxHeight.SetError(txtMaxHeight, error);
        }

        int maxSize = 0;

        private void txtMaxSize_Validated(object sender, EventArgs e)
        {
            string error = string.Empty;
            if (!int.TryParse(txtMaxSize.Text, out maxSize) || maxSize < 0 || maxSize > 32767)
                error = "Must be an integer between 0 and 32767";
            epMaxSize.SetError(txtMaxSize, error);
        }

        SynchronizationContext context;

        private void Form1_Load(object sender, EventArgs e)
        {
            ddlFormat.SelectedIndex = Properties.Settings.Default.Format;
            txtMaxHeight.Text = Properties.Settings.Default.MinWidth.ToString();
            txtMaxWidth.Text = Properties.Settings.Default.MaxWidth.ToString();
            txtMaxHeight.Text = Properties.Settings.Default.MaxHeight.ToString();
            txtMaxSize.Text = Properties.Settings.Default.MaxSize.ToString();
            nudJpegQuality.Value = Properties.Settings.Default.Quality;
            lblSourceDir.Text = Properties.Settings.Default.SrcFolder;
            lblDestDir.Text = Properties.Settings.Default.DstFolder;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnShrink_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(lblDestDir.Text))
                try
                {
                    Directory.CreateDirectory(lblDestDir.Text);
                    Directory.Delete(lblDestDir.Text);
                }
                catch (Exception x)
                {
                    MessageBox.Show(this, "Cannot create destination folder "
                        + lblDestDir.Text + ", (" + x.Message + ")", 
                        "Incorrect destination folder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            Cursor oldCursor = Cursor;
            Cursor = Cursors.WaitCursor;
            SaveSettings();
            string format = ddlFormat.SelectedItem.ToString();
            await Task.Run(() =>
            {
                frs = new FolderResizer
                (Properties.Settings.Default.SrcFolder, 
                Properties.Settings.Default.MaxSize * 1024,
                Properties.Settings.Default.MaxWidth, 
                Properties.Settings.Default.MaxHeight, 
                Properties.Settings.Default.Quality);
                frs.OutputFileType = format;
                frs.Notifier = UpdateProgress;
                frs.ResizeTo(Properties.Settings.Default.DstFolder, chkClearOutputFolder.Checked);
            });
            tsProgress.Value = 0;
            tsProgressLabel.Text = string.Empty;
            Cursor = oldCursor;
        }

        private FolderResizer frs;

        private void UpdateProgress(int percent, string message)
        {
            context.Post(d =>
            {
                tsProgress.Value = percent;
                tsLabel.Text = message;
            }, null);
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        { 
            Properties.Settings.Default.Format = ddlFormat.SelectedIndex;
            if(IsDigits(txtMaxHeight.Text))
                Properties.Settings.Default.MinWidth = int.Parse(txtMaxHeight.Text);
            if(IsDigits(txtMaxWidth.Text))
                 Properties.Settings.Default.MaxWidth = int.Parse(txtMaxWidth.Text);
            if (IsDigits(txtMaxSize.Text))
                Properties.Settings.Default.MaxSize = int.Parse(txtMaxSize.Text);
            Properties.Settings.Default.Quality = (int)(nudJpegQuality.Value);
            Properties.Settings.Default.SrcFolder = lblSourceDir.Text;
            Properties.Settings.Default.DstFolder = lblDestDir.Text;
            Properties.Settings.Default.Save();
        }

        bool IsDigits(string s)
        {
            return s.All(c => char.IsDigit(c));
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
                "Shrinks folders of images so that the images fit\r\n" +
                "within a maximum width, height, and file size\r\n" +
                "© Copyright Ropley Information Technology Ltd.\r\n" +
                "Version 16.1.15", "About PackImages",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void viewDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewDetails vd = new ViewDetails();
            if(frs != null)
                vd.CompressionInfo = frs.CompressionInfo;
            vd.ShowDialog(this);
        }
    }
}
