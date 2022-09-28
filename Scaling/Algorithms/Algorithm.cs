using System.Diagnostics;
using System.Drawing;
using System.Threading;
using Timer = System.Timers.Timer;

namespace Scaling.Algorithms
{
    public abstract class Algorithm
    {
        protected Stopwatch Stopwatch = new Stopwatch();

        public double Milliseconds
        {
            get
            {
                return Stopwatch.ElapsedMilliseconds;
            }
        }
        public abstract void Fill(PixelMatrix oldPixelMatrix, PixelMatrix newPixelMatrix, double xCoefficient, double yCoefficient);

        // public abstract void FillY(Bitmap bitmap, Color emptyColor, int pixelX, int pixelY);

    }
}