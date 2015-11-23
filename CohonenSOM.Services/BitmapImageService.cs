using System.Drawing;

namespace CohonenSOM.Services
{
    public class BitmapImageService
    {
        public Color[,] GetBitmapImageColourMap(Bitmap image)
        {
            var colourMap = new Color[image.Width, image.Height];

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    colourMap[x, y] = image.GetPixel(x, y);
                }
            }
            return colourMap;
        }
    }
}
