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

        public ScaledColor(double r, double g, double b)
        {
            Red = r;
            Green = g;
            Blue = b;
        }
    }
}
