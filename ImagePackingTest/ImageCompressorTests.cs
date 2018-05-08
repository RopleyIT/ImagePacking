using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImagePacking;
using System.Drawing;
using System.IO;

namespace ImagePackingTest
{
    [TestClass]
    public class ImageCompressorTests
    {
        [TestMethod]
        public void CanCreate()
        {
            var ic = new ImageCompressor("PapaWestray.jpg");
            Assert.IsInstanceOfType(ic, typeof(ImageCompressor));
        }

        [TestMethod]
        public void CannotCreateIfInvalidFilename()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var ic = new ImageCompressor("DoesNotExist.jpg");
                Assert.IsInstanceOfType(ic, typeof(ImageCompressor));
            });
        }

        [TestMethod]
        public void IsImageDetectsAValidImage()
        {
            Assert.IsTrue(ImageCompressor.IsImage("PapaWestray.jpg"));
        }

        [TestMethod]
        public void IsImageRejectsAnInvalidImage()
        {
            Assert.IsFalse(ImageCompressor.IsImage("PapaWestray.txt"));
        }

        [TestMethod]
        public void UncompressedSizeReturnsCorrectImageSize()
        {
            var ic = new ImageCompressor("PapaWestray.jpg");
            Assert.AreEqual(3264, ic.UncompressedSize.Width);
            Assert.AreEqual(2448, ic.UncompressedSize.Height);
        }

        [TestMethod]
        public void SavesAsSmallerJpgCorrectly()
        {
            string tmpFolder = Path.GetTempPath();
            string tmpOutputPath = Path.Combine(tmpFolder, "PapaWestray.jpg");
            try
            {
                var ic = new ImageCompressor("PapaWestray.jpg");
                string result = ic.SaveAs(tmpOutputPath, "JPG", 100000L, new Size(1024, 768), 66);
                Assert.IsTrue(File.Exists(tmpOutputPath));
                Assert.AreEqual(String.Empty, result);
            }
            finally
            {
                if (File.Exists(tmpOutputPath))
                    File.Delete(tmpOutputPath);
            }
        }
    }
}
