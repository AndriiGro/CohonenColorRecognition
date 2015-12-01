using System.Drawing;

namespace CohonenSOM.Services
{
    public class ScaledColor
    {
        public double Red;
        public double Green;
        public double Blue;

        public ScaledColor(Color color)
        {
            Red = color.R / 255.0;
            Green = color.G / 255.0;
            Blue = color.B / 255.0;
        }

        public ScaledColor(double r, double g, double b)
        {
            Red = r;
            Green = g;
            Blue = b;
        }
    }
}
