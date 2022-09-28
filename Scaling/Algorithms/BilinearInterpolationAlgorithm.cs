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

        public override void Fill(PixelMatrix oldPixelMatrix, PixelMatrix newPixelMatrix, Color emptyColor, double xCoefficient,
            double yCoefficient)
        {
            for (int y = 0; y < newPixelMatrix.Height; y++)
            {
                for (int x = 0; x < newPixelMatrix.Width; x++)
                {
                    if (newPixelMatrix.GetPixel(x,y).Interpolated)
                        continue;
                    
                    double pixelX = x / xCoefficient;
                    double pixelY = y / yCoefficient;

                    int x_floor = (int)Math.Floor(pixelX);
                    int x_ceil = (int)Math.Min(oldPixelMatrix.Width - 1, Math.Ceiling(pixelX));
                    int y_floor = (int)Math.Floor(pixelY);
                    int y_ceil = (int)Math.Min(oldPixelMatrix.Height - 1, Math.Ceiling(pixelY));




                    List<double> q;
                    List<double> q1;
                    List<double> q2;

                    if (x_ceil == x_floor && y_ceil == y_floor)
                    {
                        q = Utility.ConvertFromColor(oldPixelMatrix.GetPixel((int)pixelX, (int)pixelY).Color);
                    }
                    else if (x_ceil == x_floor)
                    {
                        q1 = Utility.ConvertFromColor(oldPixelMatrix.GetPixel((int)pixelX, (int)y_floor).Color);
                        q2 = Utility.ConvertFromColor(oldPixelMatrix.GetPixel((int)pixelX, (int)y_ceil).Color);
                        q = Utility.SumColorValues(Utility.MultiplyColorValues(q1, y_ceil - pixelY),
                            Utility.MultiplyColorValues(q2, pixelY - y_floor));
                    }
                    else if (y_ceil == y_floor)
                    {
                        q1 = Utility.ConvertFromColor(oldPixelMatrix.GetPixel((int)x_floor, (int)pixelY).Color);
                        q2 = Utility.ConvertFromColor(oldPixelMatrix.GetPixel((int)x_ceil, (int)pixelY).Color);
                        q = Utility.SumColorValues(Utility.MultiplyColorValues(q1, x_ceil - pixelX),
                            Utility.MultiplyColorValues(q2, pixelX - x_floor));
                    }
                    else
                    {
                        Color v1 = oldPixelMatrix.GetPixel(x_floor, y_floor).Color;

                        Color v2 = oldPixelMatrix.GetPixel(x_ceil, y_floor).Color;
                        Color v3 = oldPixelMatrix.GetPixel(x_floor, y_ceil).Color;
                        Color v4 = oldPixelMatrix.GetPixel(x_ceil, y_ceil).Color;

                        List<double> v1_values = Utility.ConvertFromColor(v1);
                        List<double> v2_values = Utility.ConvertFromColor(v2);
                        List<double> v3_values = Utility.ConvertFromColor(v3);
                        List<double> v4_values = Utility.ConvertFromColor(v4);
                        q1 = Utility.SumColorValues(
                            Utility.MultiplyColorValues(v1_values, x_ceil - pixelX),
                            Utility.MultiplyColorValues(v2_values, pixelX - x_floor));
                        q2 = Utility.SumColorValues(
                            Utility.MultiplyColorValues(v3_values, x_ceil - pixelX),
                            Utility.MultiplyColorValues(v4_values, pixelX - x_floor)
                        );
                        q = Utility.SumColorValues(
                            Utility.MultiplyColorValues(q1, y_ceil - pixelY),
                            Utility.MultiplyColorValues(q2, pixelY - y_floor)
                        );
                    }
                    
                    newPixelMatrix.SetPixel(x, y, new Pixel(Utility.ConvertFromValues(q)){Interpolated = true});
                }
            }
        }


   
    }
}