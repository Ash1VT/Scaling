using System;
using System.Collections.Generic;
using System.Drawing;

namespace Scaling.Algorithms
{
    public class KTimeAlgorithm : Algorithm
    {
        private Tuple<int, int> firstPixelCoords = new Tuple<int, int>(0, 0);

        private List<double> Op = new List<double>();

        private Pixel PrevPixel;
        
        // private int interval_pixels = 0;
        public override string ToString()
        {
            return "K-time";
        }

        private void CalculateOp(Pixel pixel1, Pixel pixel2, double coefficient)
        {
            Color color1 = pixel1.Color;
            Color color2 = pixel2.Color;
            
            List<double> color1_values = Utility.ConvertFromColor(color1);
            List<double> color2_values = Utility.ConvertFromColor(color2);
            
            List<double> difference_values = Utility.DifferenceColorValues(color1_values, color2_values);
            
            Op = Utility.DivideColorValues(difference_values, coefficient);
        }
       
        
        
        public override void Fill(PixelMatrix oldPixelMatrix, PixelMatrix newPixelMatrix, double xCoefficient,
            double yCoefficient)
        {
            // 1 0 2 0 4 0
            Stopwatch.Start();
            for (int y = 0; y < newPixelMatrix.Height; y++)
            {

                if(!newPixelMatrix.GetPixel(0,y).Interpolated)
                    continue;
                
                for (int x = 0; x < newPixelMatrix.Width; x++)
                {
                    if (newPixelMatrix.GetPixel(x, y).Interpolated)
                    {
                        if (x != newPixelMatrix.Width - 1)
                        {
                            Pixel left_pixel = newPixelMatrix.GetPixel(x, y);
                            Pixel right_pixel;

                            int current_x = x + 1;

                            while (true)
                            {
                                Pixel cur_pixel = newPixelMatrix.GetPixel(current_x, y);
                                if (cur_pixel.Interpolated)
                                {
                                    right_pixel = cur_pixel;
                                    break;
                                }

                                current_x++;
                            }

                            PrevPixel = Utility.GetMinimum(left_pixel, right_pixel);
                            CalculateOp(left_pixel, right_pixel, xCoefficient);
                        }

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
                    
                        
                        firstPixelCoords = new Tuple<int, int>(x, y); 
                        continue;
                    }

                    List<double> prevPixelColorValues = Utility.ConvertFromColor(PrevPixel.Color);

                    List<double> pixelValue = Utility.SumColorValues(prevPixelColorValues, Op);
                    Pixel pixel = new Pixel(Utility.ConvertFromValues(pixelValue)) { Interpolated = true };
                    newPixelMatrix.SetPixel(x,y, pixel);
                    PrevPixel = pixel;

                    // List<double> pixelValue = Utility.SumColorValues(minimum, );
                    // 1 2 
                    // 3 4
                    //
                    // 1 0 0 2
                    // 0 0 0 0
                    // 3 0 0 4





                }
            }

            for (int x = 0; x < newPixelMatrix.Width; x++)
            {
                
                for (int y = 0; y < newPixelMatrix.Height; y++)
                {
                    if (newPixelMatrix.GetPixel(x, y).Interpolated)
                    {
                        if (y != newPixelMatrix.Height - 1)
                        {
                            Pixel top_pixel = newPixelMatrix.GetPixel(x, y);
                            Pixel bottom_pixel;

                            int current_y = y + 1;

                            while (true)
                            {
                                Pixel cur_pixel = newPixelMatrix.GetPixel(x, current_y);
                                if (cur_pixel.Interpolated)
                                {
                                    bottom_pixel = cur_pixel;
                                    break;
                                }

                                current_y++;
                            }

                            PrevPixel = Utility.GetMinimum(top_pixel, bottom_pixel);
                            CalculateOp(top_pixel, bottom_pixel, yCoefficient);
                        }

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
                    
                        
                        firstPixelCoords = new Tuple<int, int>(x, y); 
                        continue;
                    }
                    
                    List<double> prevPixelColorValues = Utility.ConvertFromColor(PrevPixel.Color);

                    List<double> pixelValue = Utility.SumColorValues(prevPixelColorValues, Op);
                    Pixel pixel = new Pixel(Utility.ConvertFromValues(pixelValue)) { Interpolated = true };
                    newPixelMatrix.SetPixel(x,y, pixel);
                    PrevPixel = pixel;
                    
                  
                    // че за хуйня
                    
                }
            }
            Stopwatch.Stop();

           

        }
    }
}