using ImageMagick;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ImageMagic.Utils
{
    public class ImageTools
    {
        public static void ImageMagic(string inputPath, string outputPath, int width, int height, string fileType)
        {
            DirectoryInfo directory = new DirectoryInfo(inputPath);
            FileInfo[] files = directory.GetFiles();

            List<Task> tasks = new List<Task>();
            foreach (var file in files)
            {
                tasks.Add(Task.Run(() => ConvertImage(file, directory, outputPath, width, height, fileType)));
            }
            Task t = Task.WhenAll(tasks);
            try
            {
                t.Wait();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        private static void ConvertImage(FileInfo file, DirectoryInfo directory, string outputPath, int width, int height, string fileType)
        {
            var imageType = Path.GetExtension(file.FullName);
            var fileName = file.Name.Replace(imageType, "");
            //file.MoveTo($"{directory}\\{file.Name.Replace(".png", "")}-old.png");
            //打开文件
            FileStream fileStream = new FileStream(file.FullName, FileMode.Open, FileAccess.Read);
            //读取文件的byte
            byte[] bytes = new byte[fileStream.Length];
            fileStream.Read(bytes, 0, bytes.Length);
            fileStream.Close();
            //把byte[]转换成Stream
            Stream stream = new MemoryStream(bytes);

            MagickImage image = new MagickImage(stream);
            width = width == 0 ? image.Width : width;
            height = height == 0 ? image.Height : height;
            image.Resize(new MagickGeometry(width, height));
            switch (fileType)
            {
                case "jpg":
                    image.Format = MagickFormat.Jpg;
                    break;
                case "png":
                    image.Format = MagickFormat.Png;
                    break;
                case "svg":
                    image.Format = MagickFormat.Svg;
                    break;
                case "gif":
                    image.Format = MagickFormat.Gif;
                    break;
                case "ico":
                    image.Format = MagickFormat.Ico;
                    break;
                default:
                    break;
            }
            var filePath = $"{outputPath}\\{fileName}.{fileType}";
            CheckFileExsit(filePath);
            image.Write(filePath);
        }
        private static void CheckFileExsit(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
