using System.Drawing;
using System.IO;
using Scaling.Algorithms;

namespace Scaling
{
    public static class Data
    {
        public static Bitmap CurrentBitmap { get; set; }
        public static FileInfo FileInfo { get; set; }
        
        public static Algorithm CurrentAlgorithm { get; set; }
        
        
        public static double XCoefficient { get; set; }
        
        public static double YCoefficient { get; set; }
        
        
    }
}