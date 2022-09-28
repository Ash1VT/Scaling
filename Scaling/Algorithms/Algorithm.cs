using System.Drawing;

namespace Scaling.Algorithms
{
    public abstract class Algorithm
    {
        public abstract void Fill(PixelMatrix oldPixelMatrix, PixelMatrix newPixelMatrix, Color emptyColor, double xCoefficient, double yCoefficient);

        // public abstract void FillY(Bitmap bitmap, Color emptyColor, int pixelX, int pixelY);

    }
}