using System.Drawing;

namespace Scaling
{
    public class PixelMatrix
    {
        private Pixel[,] _pixels;


        public int Height
        {
            get
            {
                return _pixels.GetLength(1); //?????????????
            }
        }

        public int Width
        {
            get
            {
                return _pixels.GetLength(0);//???????
            }
        }
        public PixelMatrix(int width, int height)
        {
            _pixels = new Pixel[width, height];
        }

        public void SetPixel(int x, int y, Pixel pixel)
        {
            _pixels[x, y] = pixel;
        }

        public Pixel GetPixel(int x, int y)
        {
            return _pixels[x, y];
        }

        public Bitmap GetBitmap()
        {
            Bitmap bitmap = new Bitmap(this.Width, this.Height);
            for (int x = 0; x < this.Width; x++)
            {
                for (int y = 0; y < this.Height; y++)
                {
                    bitmap.SetPixel(x,y,this.GetPixel(x,y).Color);
                }
            }

            return bitmap;
        }

        public static PixelMatrix FromBitmap(Bitmap bitmap)
        {
            PixelMatrix pixelMatrix = new PixelMatrix(bitmap.Width, bitmap.Height);
            for (int y = 0; y < pixelMatrix.Height; y++)
            {
                for (int x = 0; x < pixelMatrix.Width; x++)
                {
                    pixelMatrix._pixels[x, y] = new Pixel(bitmap.GetPixel(x, y));
                }
            }

            return pixelMatrix;
        }
        
    }
}