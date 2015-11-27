using System.Drawing;

namespace CohonenSOM.Services
{
    public static class ExtensionMethods
    {
        public static Color ConvertScaledColorToColor(this ScaledColor scaledColor)
        {
            int r = (int)(scaledColor.Red * 255);
            int g = (int)(scaledColor.Green * 255);
            int b = (int)(scaledColor.Blue * 255);

            return Color.FromArgb(r, g, b);
        }
    }
}
