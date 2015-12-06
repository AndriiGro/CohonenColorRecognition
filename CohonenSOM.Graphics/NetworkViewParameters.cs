namespace CohonenSOM.Graphics
{
    public static class NetworkViewParameters
    {
        public const int WideOfCellOnGridInPixels = 10;

        public static GridCell[,] NetworkGridView { get; } = new GridCell[40, 40];
    }
}
