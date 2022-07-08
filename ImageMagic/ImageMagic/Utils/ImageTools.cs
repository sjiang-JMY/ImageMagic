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
        private static int ImageCount { get; set; }

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
            var fileSize = file.Length / 1024;
            if (fileSize > 500)
            {
                var fileName = file.Name.Replace(".png", "");
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
                    case "JPG":
                        image.Format = MagickFormat.Jpg;
                        image.Write($"{outputPath}\\{fileName}.jpg");
                        break;
                    case "PNG":
                        image.Format = MagickFormat.Png;
                        image.Write($"{outputPath}\\{fileName}.png");
                        break;
                    case "SVG":
                        image.Format = MagickFormat.Svg;
                        image.Write($"{outputPath}\\{fileName}.svg");
                        break;
                    case "GIF":
                        image.Format = MagickFormat.Gif;
                        image.Write($"{outputPath}\\{fileName}.gif");
                        break;
                    default:
                        break;
                }
                ImageCount++;
            }
        }
    }
}
