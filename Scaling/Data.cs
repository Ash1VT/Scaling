using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Scaling.Algorithms;

namespace Scaling
{
    public static class Data
    {
        public static PixelMatrix InitialPixelMatrix { get; set; }
                
        public static PixelMatrix CurrentPixelMatrix { get; set; }
        
        public static Bitmap CurrentBitmap { get; set; }

        public static FileInfo FileInfo { get; set; }
        
        public static ImageFormat ImageFormat { get; set; }
        public static Algorithm CurrentAlgorithm { get; set; }

        public static Color EmptyColor { get; set; } = Color.White;


        public static double XCoefficient { get; set; } = 1;

        public static double YCoefficient { get; set; } = 1;


    }
}