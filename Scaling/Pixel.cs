using System.Drawing;

namespace Scaling
{
    public class Pixel
    {
        public Color Color { get; set; }
        public bool Interpolated { get; set; }

        public Pixel(Color color)
        {
            Color = color;
            Interpolated = false;
        }
        
    }
}