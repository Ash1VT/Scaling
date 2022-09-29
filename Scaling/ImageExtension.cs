using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Scaling
{
    public class ImageExtension
    {
        
        private Color _emptyColor;
        
        
        public ImageExtension(Color emptyColor)
        {
            _emptyColor = emptyColor;
        }

        public PixelMatrix Extend(PixelMatrix oldPixelMatrix, double xCoefficient, double yCoefficient)
        {
            // size: 3 x 2
            // xcoef = 3
            // ycoef = 2
            // newSize: 10 x 4
            // 
            // 1 2 6
            // 3 4 7
            //
            //
            // 1 0 0 2 0 0 0 0 6
            // 0 0 0 0 0 0 0 0 0
            // 3 0 0 4 0 0 0 0 7
            // 0 0 0 0 0 0 0 0 0
            //
            
            Size newSize = SizeCalculator.Calculate(oldPixelMatrix.Width, oldPixelMatrix.Height, xCoefficient, yCoefficient);
            PixelMatrix pixelMatrix = new PixelMatrix(newSize.Width, newSize.Height);
            
            FillWithEmptyColor(pixelMatrix);

            for (int y = 0; y < oldPixelMatrix.Height; y++)
            {
                for (int x = 0; x < oldPixelMatrix.Width; x++)
                {
                    Pixel pixel = oldPixelMatrix.GetPixel(x, y);
                    pixel.Interpolated = true;
                    pixelMatrix.SetPixel((int)(x * xCoefficient), (int)(y * yCoefficient), pixel);
                    
                }
            }

            int x_max = pixelMatrix.Width - 1;
            for (int y = 0; y < pixelMatrix.Height; y++)
            {
                
                int currentX = x_max;
                
                Pixel interpolatedPixel = null;
                
                while (currentX > 0)
                {
                    Pixel pixel = pixelMatrix.GetPixel(currentX, y);
                    if (pixel.Interpolated)
                    {
                        interpolatedPixel = pixel;
                        Pixel currentPixel = pixelMatrix.GetPixel(x_max, y);
                        pixelMatrix.SetPixel(x_max, y, interpolatedPixel);
                        pixelMatrix.SetPixel(currentX, y, currentPixel);
                        break;
                    }
                    currentX--;
                } 

            }
            int y_max = pixelMatrix.Height - 1;

            for (int x = 0; x < pixelMatrix.Width; x++)
            {
                int currentY = y_max;
                
                Pixel interpolatedPixel = null;
                
                while (currentY > 0)
                {
                    Pixel pixel = pixelMatrix.GetPixel(x, currentY);
                    if (pixel.Interpolated)
                    {
                        interpolatedPixel = pixel;
                        Pixel currentPixel = pixelMatrix.GetPixel(x, y_max);
                        pixelMatrix.SetPixel(x, y_max, interpolatedPixel);
                        pixelMatrix.SetPixel(x, currentY, currentPixel);
                        break;
                    }
                    currentY--;
                } 

            }
        

            return pixelMatrix;
        }

        private void FillWithEmptyColor(PixelMatrix pixelMatrix)
        {
            for (int y = 0; y < pixelMatrix.Height; y++)
            {
                for (int x = 0; x < pixelMatrix.Width; x++)
                {
                    pixelMatrix.SetPixel(x,y, new Pixel(_emptyColor));
                }
            }
        }
    }
}