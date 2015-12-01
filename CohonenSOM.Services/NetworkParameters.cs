using System.Drawing;

namespace CohonenSOM.Services
{
    public static class NetworkParameters
    {
        public static int IterationsQuantity = 1;
        public static int IterationsDone = 0;
        public static string PathToLearningData = string.Empty;
        public static Bitmap LearningBitmapFromDisk = new Bitmap(1, 1);
        public static NetworkNode[,] CohonenNetworkNodes = new NetworkNode[
            NetworkConsts.NetworkWidth, 
            NetworkConsts.NetworkHeight];
        public static Point CurrentPosition = new Point(0, 0);
    }
}
