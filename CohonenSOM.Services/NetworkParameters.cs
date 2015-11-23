using System.Drawing;

namespace CohonenSOM.Services
{
    public static class NetworkParameters
    {
        public static int IterationsLeft = 0;
        public static string PathToLearningData = "";
        public static Bitmap LearningBitmapFromDisk = new Bitmap(1, 1);
    }
}
