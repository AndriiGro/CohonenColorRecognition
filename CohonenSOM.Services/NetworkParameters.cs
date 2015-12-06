using System.Drawing;

namespace CohonenSOM.Services
{
    public static class NetworkParameters
    {
        public static int IterationsQuantity { get; } = 100;

        public static int IterationsDone { get; set; } = 0;

        public static string PathToLearningData { get; set; } = string.Empty;

        public static Bitmap LearningBitmapFromDisk { get; set; } = new Bitmap(1, 1);

        public static NetworkNode[,] CohonenNetworkNodes { get; set; } = new NetworkNode[
            NetworkConsts.NetworkWidth, 
            NetworkConsts.NetworkHeight];
    }
}
