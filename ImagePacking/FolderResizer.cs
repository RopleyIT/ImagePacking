using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace ImagePacking
{
    public class FolderResizer
    {
        private string sourceFolder;
        private Size maxSize;
        private long maxFileSize;

        public FolderResizer(string srcFolder, long maxFileSz,
            int maxWidth, int maxHeight, int quality = 100)
        {
            srcFolder = Path.GetFullPath(srcFolder);
            if (!Directory.Exists(srcFolder))
                throw new ArgumentException
                    ("Folder to be resized does not exist");
            sourceFolder = srcFolder;
            outputFileType = "JPG";
            maxSize = new Size(maxWidth, maxHeight);
            maxFileSize = maxFileSz;
            JpgCompressionLevel = quality;
        }

        private string outputFileType;

        /// <summary>
        /// The image output type. Can be one of:
        /// "BMP", "JPG", "PNG", "GIF"
        /// </summary>

        public string OutputFileType
        {
            get
            {
                return outputFileType;
            }
            set
            {
                if (ImageCompressor.IsImage("X." + value))
                    outputFileType = value;
                else
                    throw new ArgumentException
                        ("Not a valid output image format: " + value);
            }
        }

        public int JpgCompressionLevel
        {
            get;
            set;
        }

        private int CountFiles(string inputFolder, string outputFolder)
        {
            int files = 0;
            foreach (string subDir in Directory.EnumerateDirectories(inputFolder)
                .Where(f => string.Compare(f, outputFolder, true) != 0))
                files += CountFiles(subDir, outputFolder);
            files += Directory.EnumerateFiles(inputFolder).Where(p => ImageCompressor.IsImage(p)).Count();
            return files;
        }

        /// <summary>
        /// Get verbose report of file compression information. Only
        /// valid after call to 'ResizeTo'
        /// </summary>

        public string CompressionInfo
        {
            get;
            private set;
        }

        private void Resize(string inputFolder, string outputFolder, int fileCount)
        {
            if (!Directory.Exists(outputFolder))
                Directory.CreateDirectory(outputFolder);
            foreach(string subDir in Directory.EnumerateDirectories(inputFolder)
                .Where(f => string.Compare(f, outputFolder, true) != 0))
                Resize(subDir, Path.Combine(outputFolder, Path.GetFileName(subDir)), fileCount);
            CompressionInfo += string.Format("Folder {0}\r\n", outputFolder);
            foreach(string imgFile in Directory.EnumerateFiles(inputFolder).Where(p => ImageCompressor.IsImage(p)))
            {
                if (Notifier != null)
                    Notifier((int)(100.0*fileIndex++/fileCount), Path.GetFileName(imgFile));
                ImageCompressor ic = new ImageCompressor(imgFile);
                string error = ic.SaveAs(Path.Combine(outputFolder, 
                    Path.GetFileNameWithoutExtension(imgFile) + "." + OutputFileType),
                    OutputFileType, maxFileSize, maxSize, JpgCompressionLevel);
                CompressionInfo += ic.CompressionInfo + "\r\n";
                if (!string.IsNullOrEmpty(error))
                {
                    CompressionInfo += "*** " + error + "\r\n";
                    throw new ArgumentException("Error resizing " + imgFile + ", " + error);
                }
            }
        }

        /// <summary>
        /// Notification mechanism for progress through files
        /// </summary>

        public Action<int, string> Notifier
        {
            get;
            set;
        }

        private int fileIndex;

        /// <summary>
        /// Resize the files under the source folder into the specified output folder
        /// </summary>
        /// <param name="outputPath">The target folder into which resized images
        ///  will be placed</param>

        public void ResizeTo(string outputPath, bool clearOutputFolder)
        {
            CompressionInfo = string.Empty;
            string outputFolder = Path.GetFullPath(outputPath);
            if (clearOutputFolder && Directory.Exists(outputFolder))
                Directory.Delete(outputFolder, true);

            int fileCount = CountFiles(sourceFolder, outputFolder);
            fileIndex = 0;
            Resize(sourceFolder, outputFolder, fileCount);
            if (Notifier != null)
                Notifier(0, fileCount + " files shrunk.");
        }
    }
}
