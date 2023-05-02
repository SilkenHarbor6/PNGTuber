using Aspose.Imaging.FileFormats.Apng;
using Aspose.Imaging.FileFormats.Webp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGTuber
{
    public class ApngController
    {
        public static Bitmap[] getFrames(string path)
        {
            using (ApngImage image = (ApngImage)Aspose.Imaging.Image.Load(path))
            {
                return (from item in image.Pages select (item as ApngFrame).ToBitmap()).ToArray();
            }
        }
    }
}
