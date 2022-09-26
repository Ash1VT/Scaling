using System.Drawing;

namespace Scaling.Algorithms
{
    public class KTimeAlgorithm : Algorithm
    {
        public override string ToString()
        {
            return "K-time";
        }

        public override void Fill(Bitmap oldBitmap, Bitmap newBitmap, Color emptyColor, int pixelX, int pixelY, double xCoefficient,
            double yCoefficient)
        {
            throw new System.NotImplementedException();
        }
    }
}