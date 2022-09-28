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




        // 15 30 15 
        // 30 15 30
        // y = 0
        // x = 0 => 15;
        // x + 1 => 30; min = 15; max = 30; (max - min) / k = 5 - op;
        // (k - 1 time) i = 1 i < k -1; 
        // min(15) + op(5) = 20
        // prev(20) + op(5) = 25

        // new List() - значения k - 1 раз
        // list<list>.add(list)
        // if x + 1 > x
        // then 
        // list<list>.sort(dec) else acs
    }
}