using System;
using System.Collections.Generic;
using System.Drawing;

namespace Scaling
{
    public class Utility
    {
        // public static bool Compare(Color color1, Color color2)
        // {
        //     return color1.R == color2.R && color1.B == color2.B && color1.G == color2.G;
        // }
        public static List<double> MultiplyColorValues(List<double> color_values, double value)
        {
            List<double> new_color_values = new List<double>();
            foreach (var colorValue in color_values)
            {
                new_color_values.Add(colorValue * value);
            }

            return new_color_values;
        }

        public static List<double> DivideColorValues(List<double> color_values, double value)
        {
            List<double> new_color_values = new List<double>();
            foreach (var colorValue in color_values)
            {
                new_color_values.Add(colorValue / value);
            }

            return new_color_values;
        }

        
        public static List<double> SumColorValues(List<double> color1_values, List<double> color2_values)
        {

            List<double> new_color_values = new List<double>();
            for (int i = 0; i < color1_values.Count; i++)
            {
                new_color_values.Add(color1_values[i] + color2_values[i]);
                
            }

            return new_color_values;
        }
        
        
        public static List<double> DifferenceColorValues(List<double> color1_values, List<double> color2_values)
        {

            List<double> new_color_values = new List<double>();
            
            
            for (int i = 0; i < color1_values.Count; i++)
            {
                if (color1_values[i] > color2_values[i])
                    new_color_values.Add(color1_values[i] - color2_values[i]);
                else
                {
                    new_color_values.Add(color2_values[i] - color1_values[i]);
                }
                
            }

            return new_color_values;
        }

        public static Pixel GetMinimum(Pixel pixel1, Pixel pixel2)
        {
            List<double> minimum = new List<double>();
            List<double> color1_values = Utility.ConvertFromColor(pixel1.Color);
            List<double> color2_values = Utility.ConvertFromColor(pixel2.Color);
            
            for (int i = 0; i < color1_values.Count; i++)
            {
                if (color1_values[i] < color2_values[i])
                    minimum.Add(color1_values[i]);
                else
                {
                    minimum.Add(color2_values[i]);
                }
            }

            return new Pixel(Utility.ConvertFromValues(minimum)){Interpolated = true};
        }

        public static Color ConvertFromValues(List<double> color_values)
        {
            return Color.FromArgb((int)color_values[0], (int)color_values[1], (int)color_values[2]);
        }
        
        public static List<double> ConvertFromColor(Color color)
        {
            List<double> color_values = new List<double>()
            {
                color.R,
                color.G,
                color.B
            };
            return color_values;
        }

        
        // 1 - 1 is more than 2
        // -1 - 2 is more than 1
        // 0 - 1 and 2 are equal
        public static int CompareColorValues(List<double> color1_values, List<double> color2_values)
        {
            int count_first = 0, count_second = 0;
            for (int i = 0; i < color1_values.Count; i++)
            {
                if (color1_values[i] < color2_values[i])
                    count_first++;
                else if (color1_values[i] > color2_values[i])
                    count_second++;
                else
                {
                    count_first++;
                    count_second++;
                }
            }

            if (count_first < count_second)
                return 1;
            if (count_first > count_second)
                return -1;
            return 0;

        }

        public static void SortColorValues(List<List<double>> color_values)
        {
            if (color_values.Count != 0)
            {

                int result = Utility.CompareColorValues(color_values[0], color_values[color_values.Count - 1]);

                if (result == -1 || result == 0)
                {

                    color_values.Sort((x, y) =>
                    {
                        if (x[0] > y[0] && x[1] > y[1] && x[2] > y[2])
                        {
                            return 1;
                        }
                        else if (x[0] < y[0] && x[1] < y[1] && x[2] < y[2])
                        {
                            return -1;
                        }

                        return 0;
                    });
                }
                else
                {
                    color_values.Sort((x, y) =>
                    {
                        if (x[0] < y[0] && x[1] < y[1] && x[2] < y[2])
                        {
                            return 1;
                        }
                        else if (x[0] > y[0] && x[1] > y[1] && x[2] > y[2])
                        {
                            return -1;
                        }

                        return 0;
                    });
                }
            }
        }
        public static String BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }
    }
}