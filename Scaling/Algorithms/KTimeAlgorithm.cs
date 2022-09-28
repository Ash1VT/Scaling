using System;
using System.Collections.Generic;
using System.Drawing;

namespace Scaling.Algorithms
{
    public class KTimeAlgorithm : Algorithm
    {
        private Tuple<int, int> firstPixelCoords = new Tuple<int, int>(0, 0);

        private List<double> Op = new List<double>();

        private int interval_pixels = 0;
        public override string ToString()
        {
            return "K-time";
        }

       
        public override void Fill(PixelMatrix oldPixelMatrix, PixelMatrix newPixelMatrix, Color emptyColor, double xCoefficient,
            double yCoefficient)
        {
            // 1 0 2 0 4 0
            
            for (int y = 0; y < newPixelMatrix.Height; y++)
            {

                if(!newPixelMatrix.GetPixel(0,y).Interpolated)
                    continue;
                for (int x = 0; x < newPixelMatrix.Width; x++)
                {
                    
                    if (newPixelMatrix.GetPixel(x, y).Interpolated)
                    {
                        List<List<double>> colorValues = new List<List<double>>();
                        for (int i = firstPixelCoords.Item1; i <= x; i++)
                        {
                            colorValues.Add(Utility.ConvertFromColor(newPixelMatrix.GetPixel(i, y).Color));
                        }
                        
                        Utility.SortColorValues(colorValues);
                        
                        int index = 0;
                        for (int i = firstPixelCoords.Item1; i <= x; i++)
                        {
                            newPixelMatrix.SetPixel(i, y, new Pixel(Utility.ConvertFromValues(colorValues[index])){Interpolated = true});
                            index++;
                        }

                        
                        interval_pixels = 0;
                        firstPixelCoords = new Tuple<int, int>(x, y); 
                        continue;
                    }
                    
                    double pixelX = x / xCoefficient; 
                    double pixelY = y / yCoefficient; 
                    interval_pixels++;
                        
            
                    int x_left = (int)Math.Floor(pixelX); // 0
                    int x_right = (int)Math.Min(oldPixelMatrix.Width - 1, Math.Ceiling(pixelX)); // 1
                    int y_coord = (int)Math.Floor(pixelY); // 0
                    
                    
                    
                    
                    Color v_left = oldPixelMatrix.GetPixel(x_left, y_coord).Color;
                    Color v_right = oldPixelMatrix.GetPixel(x_right, y_coord).Color;

                    List<double> v_left_values = Utility.ConvertFromColor(v_left);
                    List<double> v_right_values = Utility.ConvertFromColor(v_right);

                    List<double> difference_values = Utility.DifferenceColorValues(v_left_values, v_right_values);

                    Op = Utility.DivideColorValues(difference_values, xCoefficient);



                    List<double> minimum = Utility.GetMinimum(v_left_values, v_right_values);

                    List<double> pixelValue = Utility.SumColorValues(minimum, Utility.MultiplyColorValues(Op,interval_pixels));
                    newPixelMatrix.SetPixel(x,y,new Pixel(Utility.ConvertFromValues(pixelValue)){Interpolated = true});
                    // 1 2 
                    // 3 4
                    //
                    // 1 1,5 2
                    // 0 0 0
                    // 3 3,5 4
                    
                  
                    

                    
                }
            }

            for (int x = 0; x < newPixelMatrix.Width; x++)
            {
                for (int y = 0; y < newPixelMatrix.Height; y++)
                {
                    if (newPixelMatrix.GetPixel(x, y).Interpolated)
                    {
                        List<List<double>> colorValues = new List<List<double>>();
                        for (int i = firstPixelCoords.Item2; i <= y; i++)
                        {
                            colorValues.Add(Utility.ConvertFromColor(newPixelMatrix.GetPixel(x, i).Color));
                        }
                        
                        Utility.SortColorValues(colorValues);
                        
                        int index = 0;
                        for (int i = firstPixelCoords.Item2; i <= y; i++)
                        {
                            newPixelMatrix.SetPixel(x, i, new Pixel(Utility.ConvertFromValues(colorValues[index])){Interpolated = true});
                            index++;
                        }

                        
                        interval_pixels = 0;
                        firstPixelCoords = new Tuple<int, int>(x, y); 
                        continue;

                    }

                    double pixelX = x / xCoefficient; 
                    double pixelY = y / yCoefficient; 
                    interval_pixels++;
                        
            
                    int y_up = (int)Math.Floor(pixelY); // 0
                    int y_down = (int)Math.Min(oldPixelMatrix.Height - 1, Math.Ceiling(pixelY)); // 1
                    int x_coord = (int)Math.Floor(pixelX); // 0
                    
                    
                    
                    
                    Color v_up = oldPixelMatrix.GetPixel(x_coord, y_up).Color;
                    Color v_down = oldPixelMatrix.GetPixel(x_coord, y_down).Color;

                    List<double> v_up_values = Utility.ConvertFromColor(v_up);
                    List<double> v_down_values = Utility.ConvertFromColor(v_down);

                    List<double> difference_values = Utility.DifferenceColorValues(v_up_values, v_down_values);

                    Op = Utility.DivideColorValues(difference_values, yCoefficient);



                    List<double> minimum = Utility.GetMinimum(v_up_values, v_down_values);

                    List<double> pixelValue = Utility.SumColorValues(minimum, Utility.MultiplyColorValues(Op,interval_pixels));
                    newPixelMatrix.SetPixel(x,y,new Pixel(Utility.ConvertFromValues(pixelValue)){Interpolated = true});

                    
                }
            }

           

        }
    }
}