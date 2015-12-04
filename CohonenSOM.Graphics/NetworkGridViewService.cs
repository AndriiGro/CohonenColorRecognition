using System.Drawing;
using GridParams = CohonenSOM.Graphics.NetworkViewParameters;

namespace CohonenSOM.Graphics
{
    public class NetworkGridViewService
    {
        public void SetCellColor(int xPostion, int yPosition, Color color)
        {
            GridParams
                .NetworkGridView[xPostion, yPosition].CellColor = color;
        }

        public Bitmap GetNetworkGridAsBitmap()
        {
            var networkImage = new Bitmap(
                GridParams.NetworkGridView.GetLength(0) * GridParams.WideOfCellOnGridInPixels, 
                GridParams.NetworkGridView.GetLength(1) * GridParams.WideOfCellOnGridInPixels);

            for (int i = 0; i < GridParams.NetworkGridView.GetLength(0); i++)
            {
                for (int j = 0; j < GridParams.NetworkGridView.GetLength(1); j++)
                {
                    using (var g = System.Drawing.Graphics.FromImage(networkImage))
                    {
                        using (var brush = new SolidBrush(
                            GridParams.NetworkGridView[i, j].CellColor))
                        {
                            g.FillRectangle(
                                brush,
                                i * GridParams.WideOfCellOnGridInPixels,
                                j * GridParams.WideOfCellOnGridInPixels,
                                GridParams.WideOfCellOnGridInPixels,
                                GridParams.WideOfCellOnGridInPixels);
                        }
                    }
                }
            }

            return networkImage;
        }
    }
}
