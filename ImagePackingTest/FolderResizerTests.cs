using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImagePacking;
using System.IO;
namespace ImagePackingTest
{
    [TestClass]
    public class FolderResizerTests
    {
        [TestMethod]
        public void CanCreate()
        {
            string currPath = Path.GetFullPath(".");
            var fr = new FolderResizer(currPath, 100000, 1024, 768, 66);
            Assert.IsInstanceOfType(fr, typeof(FolderResizer));
        }

        [TestMethod]
        public void CannotCreateWhenSourceFolderNonExistent()
        {
            string currPath = "C:\\__XX__";
            Assert.ThrowsException<ArgumentException>(() =>
            {
                var fr = new FolderResizer(currPath, 100000, 1024, 768, 66);
            });
        }

        [TestMethod]
        public void CanResizeFilesFromAFolder()
        {
            string tmpFolder = Path.GetTempPath();
            tmpFolder = Path.Combine(tmpFolder, "ImgResizeOutput");
            try
            {
                if (Directory.Exists(tmpFolder))
                    Directory.Delete(tmpFolder, true);
                string currPath = Path.GetFullPath(".");
                var fr = new FolderResizer(currPath, 100000, 1024, 768, 66);
                fr.OutputFileType = "JPG";
                fr.ResizeTo(tmpFolder, true);
                Assert.AreEqual(3, Directory.GetFiles(tmpFolder).Length);
            }
            finally
            {
                if (Directory.Exists(tmpFolder))
                    Directory.Delete(tmpFolder, true);
            }
        }
    }
}
