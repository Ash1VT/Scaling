using System;
using System.Drawing;

namespace Scaling
{
    public class SizeCalculator
    {
        public static Size Calculate(Size oldSize, double xCoefficient, double yCoefficient)
        {
            int newWidth = (int) (oldSize.Width * xCoefficient);
            int newHeight = (int) (oldSize.Height * yCoefficient);
            return new Size(newWidth, newHeight);

        }
    }
}