using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;


namespace ImagePacking
{
    /// <summary>
    /// Manage the image resizing of a single image file
    /// </summary>

    public class ImageCompressor
    {
        private Image uncompressedImage;

        /// <summary>
        /// Constructor from an already loaded image
        /// </summary>
        /// <param name="uncompressed">The input (unresized) image</param>

        public ImageCompressor(Image uncompressed)
        {
            if (uncompressed == null)
                throw new ArgumentException("Can only create an ImageCompressor by passing a valid image");
            uncompressedImage = uncompressed;
        }

        /// <summary>
        /// Constructor from image file name
        /// </summary>
        /// <param name="inputPath">Path to image file</param>

        public ImageCompressor(string inputPath)
        {
            if (File.Exists(inputPath) && IsImage(inputPath))
                uncompressedImage = Image.FromFile(inputPath);
            else
                throw new ArgumentException
                    ($"File {inputPath} non-existent or not an image");
        }

        /// <summary>
        /// Validate a filee to see if it is an image file. Only
        /// verifies the filename extension at present
        /// </summary>
        /// <param name="path">Path to image file</param>
        /// <returns>True if a valid image file</returns>

        public static bool IsImage(string path)
        {
            string ext = Path.GetExtension(path).Substring(1).ToUpper();
            return ext == "BMP" || ext == "JPG" || ext == "GIF" || ext == "PNG";
        }

        /// <summary>
        /// The dimensions of the input image file
        /// </summary>

        public Size UncompressedSize
        {
            get
            {
                return uncompressedImage.Size;
            }
        }

        private static ImageFormat ImageFormatFromString(string imageType)
        {
            switch(imageType.ToUpper())
            {
                case "JPG":
                case "JPEG":
                    return ImageFormat.Jpeg;

                case "GIF":
                    return ImageFormat.Gif;

                case "PNG":
                    return ImageFormat.Png;

                default:
                case "BMP":
                    return ImageFormat.Bmp;
            }
        }

        /// <summary>
        /// Given an image and the type of output file,
        /// calculate how big the saved file would be
        /// </summary>
        /// <param name="image">The image to be saved</param>
        /// <param name="compressionType">The output image file type</param>
        /// <returns>The size of the output file</returns>

        public static long FileSize(Image imageToSave, string format, int quality)
        {
            using (MemoryStream ms = new MemoryStream())
                return SaveToStream(ms, imageToSave, format, quality);
        }

        /// <summary>
        /// Write an image out to a target stream
        /// </summary>
        /// <param name="stream">The stream to save to</param>
        /// <param name="imageToSave">The image to be saved</param>
        /// <param name="format">The encoding format, JPG, BMP, GIF or PNG</param>
        /// <param name="quality">The encoding quality 0 .. 100 for JPG</param>
        /// <returns>The size of the output file in bytes</returns>

        public static long SaveToStream(Stream stream, Image imageToSave, string format, int quality)
        {
            if (string.Compare("JPG", format, true) == 0 && quality != 0)
            {
                ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);
                Encoder qualityEncoder = Encoder.Quality;
                EncoderParameters encParams = new EncoderParameters(1);
                EncoderParameter qualParam = new EncoderParameter(qualityEncoder, (long)quality);
                encParams.Param[0] = qualParam;
                imageToSave.Save(stream, jpgEncoder, encParams);
            }
            else
                imageToSave.Save(stream, ImageFormatFromString(format));
            return stream.Length;
        }

        private Size GetMinDimensions(Size minRequested)
        {
            if (UncompressedSize.Width * minRequested.Height > UncompressedSize.Height * minRequested.Width)
                return new Size
                    (minRequested.Width, minRequested.Width * UncompressedSize.Height / UncompressedSize.Width);
            else
                return new Size
                    (minRequested.Height * UncompressedSize.Width / UncompressedSize.Height, minRequested.Height);
        }

        private const int maxImageDimension = 32767;

        private Size GetMaxDimensions(Size maxRequested)
        {
            if (maxRequested.Width == 0)
                maxRequested.Width = maxImageDimension;
            if (maxRequested.Height == 0)
                maxRequested.Height = maxImageDimension;

            if (UncompressedSize.Width * maxRequested.Height < UncompressedSize.Height * maxRequested.Width)
                return new Size
                    (maxRequested.Height * UncompressedSize.Width / UncompressedSize.Height, maxRequested.Height);
            else
                return new Size
                    (maxRequested.Width, maxRequested.Width * UncompressedSize.Height / UncompressedSize.Width);
        }

        private static void SetHighQualityRendering(Graphics g)
        {
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
        }

        private Image ResizedTo(Size newSize)
        {
            // Never grow an image, only allow them to be reduced in size
            //
            // if (newSize.Width > uncompressedImage.Width || newSize.Height > uncompressedImage.Height)
            //    return uncompressedImage;

            Bitmap bmp = new Bitmap(newSize.Width, newSize.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                SetHighQualityRendering(g);
                g.DrawImage(uncompressedImage, 0, 0, newSize.Width, newSize.Height);
            }
            return bmp;
        }

        /// <summary>
        /// After SaveAs has been called, obtain a verbose message describing the compression
        /// </summary>

        public string CompressionInfo
        {
            get;
            private set;
        }

        /// <summary>
        /// Save the image file by applying the constraints specified
        /// </summary>
        /// <param name="path">The output location to save the file</param>
        /// <param name="format">The output image file format. Can be one of:
        /// "BMP", "JPG", "PNG", "GIF"</param>
        /// <param name="maxFileSize">The maximum size the output file is allowed to be</param>
        /// <param name="min">The minimum values for the width or height of the image</param>
        /// <param name="max">The maximum values for the width or height of the image</param>
        /// <param name="quality">For JPG files, the compression level. 0 uses default of 75</param>
        /// <returns>Error message, or string.Empty if successful</returns>

        public string SaveAs(string path, string format, long maxFileSize, Size max, int quality = 0)
        {
            try
            {
                CompressionInfo = string.Format("{1}{2,4} ", 
                    Path.GetFileName(path), format,
                    string.Compare(format, "JPG", true) == 0 ? quality.ToString() : "   ");

                // Find the two rectangles with the correct aspect ratios that 
                // fit within the maximum and minimum size rectangles specified

                Size maxDimension = GetMaxDimensions(max);
                long uncompressedFileSize = FileSize(uncompressedImage, format, quality);

                // Deal with the easy case when file is already less than max width and height

                Image imageToSave = uncompressedImage;
                if (uncompressedImage.Width <= maxDimension.Width
                    && uncompressedImage.Height <= maxDimension.Height)
                {
                    // If the width and height are fine but the file is too 
                    // big, shrink by just using the maximum size ratio

                    if (uncompressedFileSize > maxFileSize)
                        imageToSave = BinaryShrinkTo(maxFileSize, format, quality);
                }
                else
                {
                    // Width or height is too big. Need to scale the image based on the maximum
                    // dimension criteria. First, find our how big the file size would be for
                    // the image if scaled to fit within these maximum dimensions

                    imageToSave = ResizedTo(maxDimension);
                    long shrunkenSize = FileSize(imageToSave, format, quality);

                    // The difficult case. The file had dimensions that were too large, and even when
                    // reduced to fit the maximum dimensions, the resulting file size was still too large.

                    if (shrunkenSize > maxFileSize)
                        imageToSave = BinaryShrinkTo(maxFileSize, format, quality);
                }

                using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    long savedSize = SaveToStream(fs, imageToSave, format, quality);
                    CompressionInfo += string.Format("{0,12} {1,10:N2}kb {2}",
                        imageToSave.Width + " x " + imageToSave.Height, savedSize / 1024.0,
                        Path.GetFileName(path));
                }
                return string.Empty;
            }
            catch (Exception x)
            {
                return "Failed to save resized image to " 
                    + path + ", " + x.Message;
            }
        }

        /// <summary>
        /// Newton Raphson iterative shrinkage algorithm
        /// </summary>
        /// <param name="requestedFileSize">Maximum size requested for the file</param>
        /// <param name="format">JPG, BMP, PNG or GIF</param>
        /// <param name="quality">Compression factor for JPG</param>
        /// <returns>The compressed image that meets the file size criterion</returns>

        //private Image NewtonianShrinkTo(long requestedFileSize, string format, int quality)
        //{
        //    double scale = 0.5;
        //    long currFileSize = FileSize(uncompressedImage, format, quality);
        //    long newFileSize = 0;
        //    int maxIterations = 10;
        //    while (maxIterations-- > 0 
        //        && Math.Abs((requestedFileSize - newFileSize)/(double)requestedFileSize) > 0.005)
        //    {
        //        using (Image resizedImage = ResizeBy(scale))
        //        {
        //            newFileSize = FileSize(resizedImage, format, quality);
        //            scale += (requestedFileSize - newFileSize) * (1.0 - scale) / (currFileSize - newFileSize);
        //        }
        //    }
        //    return ResizeBy(scale);
        //}

        private Image BinaryShrinkTo(long requestedFileSize, string format, int quality)
        {
            double scale = 0.5;
            for(double dScale = 0.25; dScale >= 1/512.0; dScale *= 0.5)
            {
                using (Image resizedImage = ResizeBy(scale))
                {
                    long newSize = FileSize(resizedImage, format, quality);
                    if (requestedFileSize > newSize)
                        scale += dScale;
                    else if (requestedFileSize < newSize)
                        scale -= dScale;
                    else
                        break;
                }
            }
            return ResizeBy(scale);
        }

        private Image ResizeBy(double ratio)
        {
            Size newSize = new Size
            (
                (int)(uncompressedImage.Width * ratio), 
                (int)(uncompressedImage.Height * ratio)
            );
            return ResizedTo(newSize);
        }

        private static ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach(ImageCodecInfo codec in codecs)
                if (codec.FormatID == format.Guid)
                    return codec;
            return null;
        }
    }
}
