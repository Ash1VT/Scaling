using System.Drawing;
using System.Drawing.Imaging;

namespace Scaling
{
    public class ImageExtension
    {
        
        private Color _emptyColor;
        
        
        public ImageExtension(Color emptyColor)
        {
            // _oldBitmap = oldBitmap;
            // _xCoefficient = xCoefficient;
            // _yCoefficient = yCoefficient;
            _emptyColor = emptyColor;
            // InitNewBitmap();
        }

        public Bitmap Extend(Bitmap bitmap, double xCoefficient, double yCoefficient)
        {
            // size: 10 x 1 
            // xcoef = 3.5
            // ycoef = 2
            // newSize: 20 x 1
            // 1 2 1 1 1 1 1 1 1 1    1 0 2 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0 1 0
            // 
            // 1 2 6
            // 3 4 7
            //
            //
            // 1 0 0 2 0 0 0 6 0 0
            // 0 0 0 0 0 0 0 0 0 0
            // 3 0 0 4 0 0 0 7 0 0
            // 0 0 0 0 0 0 0 0 0 0
            //
            // x = 1 / 3 = 0,33 , y = 0
            // x' = 0, y' = 0
            // b = 0
            // a = 0,33
            // I(x,y) = 1 * 1 * I1(1,0)
            
            Size newSize = SizeCalculator.Calculate(bitmap.Size, xCoefficient, yCoefficient);
            Bitmap newBitmap = new Bitmap(newSize.Width, newSize.Height);
            
            FillWithEmptyColor(newBitmap);

            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    newBitmap.SetPixel((int)(x * xCoefficient), (int)(y * yCoefficient), bitmap.GetPixel(x, y));
                }
            }

            return newBitmap;
        }

        private void FillWithEmptyColor(Bitmap bitmap)
        {
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    bitmap.SetPixel(x,y, _emptyColor);
                }
            }
        }
    }
}