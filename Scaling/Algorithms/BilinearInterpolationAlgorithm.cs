using System;
using System.Collections.Generic;
using System.Drawing;

namespace Scaling.Algorithms
{
    public class BilinearInterpolationAlgorithm : Algorithm
    {
        public override string ToString()
        {
            return "Bilinear interpolation";
        }

        public override void Fill(Bitmap oldBitmap, Bitmap newBitmap, Color emptyColor, int pixelX, int pixelY, double xCoefficient,
            double yCoefficient)
        {
            
            double x = pixelX / xCoefficient;
            double y = pixelY / yCoefficient;

            int x_floor = (int)Math.Floor(x);
            int x_ceil = (int)Math.Min(oldBitmap.Width - 1, Math.Ceiling(x));
            int y_floor = (int)Math.Floor(y);
            int y_ceil = (int)Math.Min(oldBitmap.Height - 1, Math.Ceiling(y));




            List<double> q;
            List<double> q1;
            List<double> q2;

            if (x_ceil == x_floor && y_ceil == y_floor)
            {
                q = Utility.ConvertFromColor(oldBitmap.GetPixel((int)x, (int)y));
            }
            else if (x_ceil == x_floor)
            {
                q1 = Utility.ConvertFromColor(oldBitmap.GetPixel((int)x, (int)y_floor));
                q2 = Utility.ConvertFromColor(oldBitmap.GetPixel((int)x, (int)y_ceil));
                q = Utility.SumColorValues(Utility.MultiplyColorValues(q1, y_ceil - y),
                    Utility.MultiplyColorValues(q2, y - y_floor));
            }
            else if (y_ceil == y_floor)
            {
                q1 = Utility.ConvertFromColor(oldBitmap.GetPixel((int)x_floor, (int)y));
                q2 = Utility.ConvertFromColor(oldBitmap.GetPixel((int)x_ceil, (int)y));
                q = Utility.SumColorValues(Utility.MultiplyColorValues(q1, x_ceil - x),
                    Utility.MultiplyColorValues(q2, x - x_floor));
            }
            else
            {
                Color v1 = oldBitmap.GetPixel(x_floor, y_floor);
                Color v2 = oldBitmap.GetPixel(x_ceil, y_floor);
                Color v3 = oldBitmap.GetPixel(x_floor, y_ceil);
                Color v4 = oldBitmap.GetPixel(x_ceil, y_ceil);

                List<double> v1_values = Utility.ConvertFromColor(v1);
                List<double> v2_values = Utility.ConvertFromColor(v2);
                List<double> v3_values = Utility.ConvertFromColor(v3);
                List<double> v4_values = Utility.ConvertFromColor(v4);
                q1 = Utility.SumColorValues(
                    Utility.MultiplyColorValues(v1_values, x_ceil - x),
                    Utility.MultiplyColorValues(v2_values, x - x_floor));
                q2 = Utility.SumColorValues(
                    Utility.MultiplyColorValues(v3_values, x_ceil - x),
                    Utility.MultiplyColorValues(v4_values, x - x_floor)
                );
                q = Utility.SumColorValues(
                    Utility.MultiplyColorValues(q1, y_ceil - y),
                    Utility.MultiplyColorValues(q2, y - y_floor)
                );
            }

            newBitmap.SetPixel(pixelX, pixelY, Utility.ConvertFromValues(q));
        }


   
    }
}