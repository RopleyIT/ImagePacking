using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImagePacking;
using System.IO;

namespace PackImages
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string errors = parseArgs(args);
                if (!string.IsNullOrEmpty(errors))
                {
                    Usage(errors);
                    return;
                }

                FolderResizer frs = new FolderResizer
                    (srcFolder, maxSize, maxWidth, maxHeight, quality);
                frs.OutputFileType = fileFormat;
                frs.ResizeTo(dstFolder, clearOutputFolder);
                if (verbose)
                    Console.WriteLine(frs.CompressionInfo);
            }
            catch(Exception x)
            {
                Usage(x.Message);
            }
        }

        static void Usage(string message)
        {
            Console.WriteLine("Error: {0}", message);
            Console.WriteLine(
                "Usage: packimages -i sourceFolder [-o|-c] destFolder [-s maxFileSize]\r\n" +
                "            [-q quality] [-f fileFormat] [-w maxWidth] [-h maxHeight]\r\n" +
                "ARGUMENT    PURPOSE\r\n" +
                "-v          Verbose reporting of file compression information\r\n" +
                "-i <string> Folder whose images are to be compressed (mandatory)\r\n" +
                "-o <string> Destination folder, images added if existing\r\n" +
                "-c <string> Destination folder, deleted then recreated\r\n" +
                "-s <digits> Maximum size for output files in kb, default 16,384\r\n" +
                "-q <digits> Quality of output image (JPG only), 0 to 100, default 100\r\n" +
                "-f <string> Image format (JPG, BMP, PNG or GIF), default JPG\r\n" +
                "-w <digits> Maximum output image width in pixels, default 32,767\r\n" +
                "-h <digits> Maximum output image height in pixels, default 32,767\r\n");
        }

        static int maxWidth = 32767;
        static int maxHeight = 32767;
        static int quality = 75;
        static long maxSize = 16384L * 1024;
        static string srcFolder = string.Empty;
        static string dstFolder = string.Empty;
        static string fileFormat = "JPG";
        static bool clearOutputFolder = false;
        static bool verbose = false;

        static string parseArgs(string[] arguments)
        {
            for (int i = 0; i < arguments.Length - 1; i += 2)
            {
                if(arguments[i] == "-v")
                {
                    verbose = true;
                    --i;
                }
                else if (arguments[i] == "-i" && arguments.Length > i + 1)
                {
                    srcFolder = arguments[i + 1];
                    if (!Directory.Exists(srcFolder))
                        return "Source folder " + srcFolder + " does not exist";
                }
                else if (arguments[i] == "-o" || arguments[i] == "-c" && arguments.Length > i + 1)
                {
                    dstFolder = arguments[i + 1];
                    clearOutputFolder = arguments[i] == "-c";
                    if (!Directory.Exists(dstFolder))
                        try
                        {
                            Directory.CreateDirectory(dstFolder);
                            Directory.Delete(dstFolder);
                        }
                        catch (Exception x)
                        {
                            return "Cannot create destination folder "
                                + dstFolder + ", (" + x.Message + ")";
                        }
                }
                else if (arguments[i] == "-q" && arguments.Length > i + 1)
                {
                    if (!int.TryParse(arguments[i + 1], out quality) || quality < 0 || quality > 100)
                        return "Quality argument (-q) must be decimal digits between 0 and 100";
                }
                else if (arguments[i] == "-f" && arguments.Length > i + 1)
                {
                    if (!In(arguments[i + 1], new string[] { "jpg", "png", "gif", "bmp" }))
                        return "Not a valid image file format (-f): " + arguments[i + 1];
                    fileFormat = arguments[i + 1];
                }
                else if (arguments[i] == "-s" && arguments.Length > i + 1)
                {
                    if (!long.TryParse(arguments[i + 1], out maxSize) || maxSize < 0)
                        return "Maximum file size argument (-s) must be decimal digits";
                    else
                        maxSize *= 1024;
                }
                else if (arguments[i] == "-w" && arguments.Length > i + 1)
                {
                    if (!int.TryParse(arguments[i + 1], out maxWidth) || maxWidth < 0)
                        return "Maximum width argument (-h) must be decimal digits";
                }
                else if (arguments[i] == "-h" && arguments.Length > i + 1)
                {
                    if (!int.TryParse(arguments[i + 1], out maxHeight) || maxHeight < 0)
                        return "Maximum height argument (-w) must be decimal digits";
                }
            }

            // Validate mandatory arguments

            if (string.IsNullOrEmpty(srcFolder))
                return "Missing source folder argument (-i sourceFolder)";
            if (string.IsNullOrEmpty(dstFolder))
                return "Missing destination folder argument (-o|c destinationFolder)";
            if (string.Compare(Path.GetFullPath(srcFolder), Path.GetFullPath(dstFolder), true) == 0)
                return "Cannot compress a folder onto itself";
            return string.Empty;
        }

        private static bool In(string str, IEnumerable<string> sList)
        {
            return sList.Any(s => string.Compare(s, str, true) == 0);
        }
    }
}
