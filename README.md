# ImagePacking - a suite of image file compression utilities

### Overview
Application to resize image files or folders containing image files based on maximum file size, image width or height.

Originally this application arose because of the irritation
of web sites that have huge photos uploaded and added to web pages,
thereby taking an age to download and display in a rectangle
the size of a postage stamp.

It takes images or folders full of images and allows you to create
shrunken versions of those images with maximum preservation
of image quality (subject of course to the fact that the image
has fewer pixels).

The application has both a Windows client application 
and a command line version. In each case, you can 
resize the images found in a folder or a single 
image file by selecting a combination of:
- Image width
- Image height
- Image file size
- Image compression percentage (JPG only)

The application will resize your image, but will preserve
the aspect ratio so that images are not distorted.

Example: Assume we have an image with 8000x6000 pixels, in
a file that is 96Mb in size. If we were to set a maximum
width of 1024, a maximum height of 1024, and a maximum
file size of 2Mb, the resulting image would have 1024x768
pixels, thus preserving the aspect ratio, or perhaps fewer
pixels on each axis if the resulting file size would
exceed 2Mb.

Note that the application also supports several image 
formats, including JPG, PNG, GIF and BMP files.

### PackImages - the command line tool
For scripting or command line purposes, the `PackImages.exe`
application can be used in a command window. The syntax for
its use is as follows:
``` javascript
packimages -i sourceFolder [-o|-c] destFolder [-s maxFileSize]
                           [-q quality] [-f fileFormat] [-w maxWidth] [-h maxHeight]
```    
|ARGUMENT|PURPOSE|
|---|---|
|`-v `|Verbose reporting of file compression information|
|`-i sourceFolder`|Folder whose images are to be compressed (mandatory)|
|`-o destFolder`|Destination folder, images added to existing folder|
|`-c destFolder`|Destination folder, deleted then recreated|
|`-s maxFileSize`|Maximum size for output files in kb, default is 16,384kb|
|`-q quality`|Quality of output image (JPG only), 0 to 100, default 100|
|`-f fileFormat`|Image format (one of JPG, BMP, PNG or GIF), default JPG|
|`-w maxWidth`|Maximum output image width in pixels, default 32,767|
|`-h maxHeight`|Maximum output image height in pixels, default 32,767|

Note that any files that are not valid image files are ignored, and
are not transferred to the output folder.

### WinPack - the Windows version of the application
This application provides exactly the same functionality as the
command line tool, but allows you to select the options
from the user interface. Given the options listed above for
the command line tool, if you run the windows version, the
settings should be completely obvious!

### Technical implementation
As with all these kinds of tool, there are the user interfaces, and
then there is the actual class library that does the donkey work.

In this case, the `ImagePacking` project and its output DLL
do all the work, and could be used as a library within some
other image-aware application.

There are two classes in the `ImagePacking` library, `FolderResizer` 
and `ImageCompressor`. `FolderResizer` is responsible for managing
the compression of a set of files within a folder, and
manages the common set of maximum file sizes, widths and heights.
It makes calls on the `ImageCompressor` class for each file
to be compressed, since the `ImageCompressor` is instantiated
for each separate file that requires compression.

#### Methods and properties of the `ImageCompressor` class
|Method/Property|Description|
|---|---|
|`ImageCompressor(Image)`|Constructor. Given an already loaded `Image` object, wrap it in an `ImageCompressor`|
|`ImageCompressor(string)`|Constructor. The string argument is the path to an image file to be loaded.|
|`bool IsImage(string)`|Static method. Validates the path argument is a valid image. Valid images are BMP, PNG, JPG or GIF files.|
|`Size UncompressedSize`|Property giving the dimensions of the image prior to compression|
|`long FileSize(Image, string, int)`|Static method. Given the `Image object` calculate how big its output file would be if it were saved to a particular file format (e.g. "BMP") with a specified image quality. Note that the image quality is an integer from 0 to 100, and is only used for "JPG" file output.|
|`long SaveToStream(Stream, Image, string, int)`|Static method. Given an image object and an output stream, write the image to the stream with the  specified file format and quality. Returns the size of the saved stream.|
|`string SaveAs(string path, string format, long maxFileSize, Size max, int quality = 0)`|The method where most of the work is done. Save the image held by the `ImageCompressor` object applying the maximum size, output format and quality constraints passed as arguments. The return string is empty if successful, or contains an error message if not.|
|`string CompressionInfo`|After `SaveAs` has been invoked, this property contains a message describing the details of the compressed file.|

#### Methods and properties of the `FolderResizer` class
|Method/Property|Description|
|---|---|
|`public FolderResizer(string srcFolder, long maxFileSz, int maxWidth, int maxHeight, int quality = 100)`|Constructor. Identify the folder containing files to be compressed, and set the compression constraints|
|`string OutputFileType`|Property setting the type of image file for output. can be one of "BMP", "PNG", "GIF" or "JPG"|
|`int JpgCompressionLevel`|The percentage compression level for JPG images
|`string CompressionInfo`|Information about completed compression after calling `ResizeTo`|
|`ResizeTo(string outputPath, bool clearOutputFolder)`|Resizes all image files in the folder, placing the shrunk files in the output folder. The second parameter is used to clear the output folder first.|
|`Action<int, string> Notifier`|An optional notification delegate invoked to report progress. The integer parameter gives a percentage complete value for driving progress bars.|

### Licensing
This product is published under the [standard MIT License](https://opensource.org/licenses/MIT). The specific wording for this license is as follows:

Copyright 2018 
[Ropley Information Technology Ltd.](http://www.ropley.com)
Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY 
KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO 
THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A 
PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO 
EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE 
LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
ARISING FROM, OUT OF OR IN CONNECTION WITH THE 
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.


