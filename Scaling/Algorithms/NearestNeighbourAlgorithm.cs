using System.Drawing;

namespace Scaling.Algorithms
{
    public class NearestNeighbourAlgorithm : Algorithm
    {
        public override string ToString()
        {
            return "Nearest neighbour";
        }


        public override void Fill(PixelMatrix oldPixelMatrix, PixelMatrix newPixelMatrix, Color emptyColor, double xCoefficient, double yCoefficient)
        {
            for (int y = 0; y < newPixelMatrix.Height; y++)
            {
                for (int x = 0; x < newPixelMatrix.Width; x++)
                {
                    
                    if (newPixelMatrix.GetPixel(x,y).Interpolated)
                        continue;
                    
                    int oldBitmapPixelX = (int)(x / xCoefficient);
                    int oldBitmapPixelY = (int)(y / yCoefficient);

                    Pixel pixel = oldPixelMatrix.GetPixel(oldBitmapPixelX, oldBitmapPixelY);
                    pixel.Interpolated = true;
                    newPixelMatrix.SetPixel(x, y, pixel);
                }
            }
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