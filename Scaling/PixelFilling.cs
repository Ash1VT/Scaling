using System;
using System.Drawing;
using Scaling.Algorithms;

namespace Scaling
{
    public class PixelFilling
    {
        private Color _emptyColor;
        private Algorithm _algorithm;
        
        public Algorithm Algorithm
        {
            set { _algorithm = value; }
        }
        
        public PixelFilling(Color emptyColor, Algorithm algorithm)
        {
            _emptyColor = emptyColor;
            Algorithm = algorithm;
        }

        public void Fill(Bitmap oldBitmap, Bitmap newBitmap, double yCoefficient, double xCoefficient)
        {
            
            for (int y = 0; y < newBitmap.Height; y++)
            {
                for (int x = 0; x < newBitmap.Width; x++)
                {
                    _algorithm.Fill(oldBitmap, newBitmap, _emptyColor, x, y, xCoefficient, yCoefficient);
                }
            }
        }

        // for (int x = 0; x < bitmap.Width; x++)
        //     {
        //         for (int y = 0; y < bitmap.Height; y++)
        //         {
        //             Color color = bitmap.GetPixel(x, y);
        //             if(Utility.Compare(color, _emptyColor))
        //             {
        //                 _algorithm.FillY(bitmap, _emptyColor, x, y);
        //             }
        //         }
        //     }
            
        }
    }
