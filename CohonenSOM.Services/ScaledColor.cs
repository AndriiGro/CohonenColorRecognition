using System.Drawing;

namespace CohonenSOM.Services
{
    public class ScaledColor
    {
        public double Red;
        public double Green;
        public double Blue;

        public ScaledColor(int r, int g, int b)
        {
            Red = r / 255.0;
            Green = g / 255.0;
            Blue = b / 255.0;
        }

        public Color ConvertScaledColorToColor(ScaledColor scaledColor)
        {
            int r = (int)scaledColor.Red * 255;
            int g = (int)scaledColor.Green * 255;
            int b = (int)scaledColor.Blue * 255;

            return Color.FromArgb(r, g, b);
        }
    }
}
