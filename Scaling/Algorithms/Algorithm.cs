using System.Drawing;

namespace Scaling.Algorithms
{
    public abstract class Algorithm
    {
        public abstract void Fill(Bitmap oldBitmap, Bitmap newBitmap, Color emptyColor, int pixelX, int pixelY, double xCoefficient, double yCoefficient);

        // public abstract void FillY(Bitmap bitmap, Color emptyColor, int pixelX, int pixelY);

    }
}