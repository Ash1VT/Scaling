using System;
using System.Drawing;

namespace Scaling
{
    public class SizeCalculator
    {
        public static Size Calculate(int oldWidth, int oldHeight, double xCoefficient, double yCoefficient)
        {
            double valueX = (double)(xCoefficient % (int)xCoefficient);
            double valueY = (double)(yCoefficient % (int)yCoefficient);
            
            if (valueX != 0 || valueY != 0)
            {
                int newWidth = (int)Math.Ceiling(oldWidth * xCoefficient);
                int newHeight = (int)Math.Ceiling(oldHeight * yCoefficient);
                return new Size(newWidth, newHeight);
            }
            else
            {
                int newWidth = (int)(oldWidth * xCoefficient);
                int newHeight = (int)(oldHeight * yCoefficient);
                return new Size(newWidth, newHeight);

            }

        }
    }
}