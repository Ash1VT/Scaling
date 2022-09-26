using System.Drawing;

namespace Scaling.Algorithms
{
    public class NearestNeighbourAlgorithm : Algorithm
    {
        public override string ToString()
        {
            return "Nearest neighbour";
        }


        public override void Fill(Bitmap oldBitmap, Bitmap newBitmap, Color emptyColor, int pixelX, int pixelY, double xCoefficient, double yCoefficient)
        {
            int oldBitmapPixelX = (int)(pixelX / xCoefficient);
            int oldBitmapPixelY = (int)(pixelY / yCoefficient);
            
            newBitmap.SetPixel(pixelX, pixelY, oldBitmap.GetPixel(oldBitmapPixelX, oldBitmapPixelY));
        }
        //
        // public override void FillY(Bitmap bitmap, Color emptyColor, int pixelX, int pixelY)
        // {
        //     int currentY = pixelY;
        //     while (true)
        //     {
        //         if (!Utility.Compare(bitmap.GetPixel(pixelX, currentY), emptyColor))
        //         {
        //             bitmap.SetPixel(pixelX, pixelY, bitmap.GetPixel(pixelX, currentY));
        //             break;
        //         }
        //         currentY--;
        //     }
        // }
    }
}