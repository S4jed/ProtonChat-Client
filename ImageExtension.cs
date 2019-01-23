using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ProtonChat
{
    public static class ImageExtension
    {
        public static byte[] ToByteArray(this Bitmap image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                return ms.ToArray();
            }
        }
    }
}
