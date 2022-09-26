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

        public static List<double> SumColorValues(List<double> color1_values, List<double> color2_values)
        {

            List<double> new_color_values = new List<double>();
            for (int i = 0; i < color1_values.Count; i++)
            {
                new_color_values.Add(color1_values[i] + color2_values[i]);
                
            }

            return new_color_values;
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