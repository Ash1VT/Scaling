using System;
using System.Drawing;

namespace Scaling
{
    public class SizeCalculator
    {
        public static Size Calculate(int oldWidth, int oldHeight, double xCoefficient, double yCoefficient)
        {
            int extraWidth = 0, extraHeight = 0;

            if (oldWidth % 2 == 0)
            {
                extraWidth = (int)Math.Ceiling(xCoefficient);
            }
            else
            {
                extraWidth = (int)Math.Floor(xCoefficient);
            }

            if (oldHeight % 2 == 0)
            {
                extraHeight = (int)Math.Ceiling(yCoefficient);
            }
            else
            {
                extraHeight = (int)Math.Ceiling(yCoefficient);
            } 
            
            int newWidth = (int) (oldWidth * xCoefficient) ;
            int newHeight = (int) (oldHeight * yCoefficient) ;
            return new Size(newWidth, newHeight);

        }
    }
}