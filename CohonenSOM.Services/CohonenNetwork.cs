using System;
using System.Drawing;
using CohonenSOM.Graphics;

namespace CohonenSOM.Services
{
    public class CohonenNetwork
    {
        private readonly NetworkGridViewService _gridViewService = new NetworkGridViewService();
        private readonly double _networkRadius;

        public CohonenNetwork()
        {
            _networkRadius = Math.Max(
                NetworkConsts.NetworkHeight,
                NetworkConsts.NetworkWidth) / 2.0;
        }

        public void SetupNetworkWithRandoms()
        {
            InitNetworkGrid();
            InitNetworkGridView();
            SetNetworkGridColors();
        }

        public Bitmap GetCohonenNetworkImage()
        {
            return _gridViewService.GetNetworkGridAsBitmap();
        }

        // TODO: implement training epoch
        public bool RunNetworkTrainingEpoch(ScaledColor dataScaledColor)
        {
            if (NetworkParameters.IterationsDone == NetworkParameters.IterationsQuantity)
            {
                return NetworkConsts.TeachingFinished;
            }

            for (int x = 0; x < NetworkParameters.LearningBitmapFromDisk.Width; x++)
            {
                for (int y = 0; y < NetworkParameters.LearningBitmapFromDisk.Height; y++)
                {
                    Color currentPixelColor =
                        NetworkParameters.LearningBitmapFromDisk.GetPixel(x, y);

                    var bestMatchingUnitPositionAndColors =
                        CulculateBestMatchingUnit(currentPixelColor);

                    double influenceRadius = CulculateNodeInfluenceRadius(
                        _networkRadius,
                        NetworkParameters.IterationsDone,
                        NetworkParameters.IterationsQuantity);

                    AdjustNetworkWeights(
                        bestMatchingUnitPositionAndColors.Item1, 
                        bestMatchingUnitPositionAndColors.Item2, 
                        influenceRadius);
                }
            }

            return true;
        }

        private void SetNetworkGridColors()
        {
            for (int i = 0; i < NetworkParameters.CohonenNetworkNodes.GetLength(0); i++)
            {
                for (int j = 0; j < NetworkParameters.CohonenNetworkNodes.GetLength(1); j++)
                {
                    double[] nodeWeidghts = NetworkParameters.CohonenNetworkNodes[i, j].GetNodeWeights();
                    var scaledColor = new ScaledColor(nodeWeidghts[0], nodeWeidghts[1], nodeWeidghts[2]);
                    Color color = scaledColor.ConvertScaledColorToColor();
                    _gridViewService.SetCellColor(i, j, color);
                }
            }
        }

        private void InitNetworkGrid()
        {
            for (int i = 0; i < NetworkParameters.CohonenNetworkNodes.GetLength(0); i++)
            {
                for (int j = 0; j < NetworkParameters.CohonenNetworkNodes.GetLength(1); j++)
                {
                    NetworkParameters.CohonenNetworkNodes[i, j] = new NetworkNode(i, j);
                }
            }
        }

        private void InitNetworkGridView()
        {
            for (int i = 0; i < NetworkParameters.CohonenNetworkNodes.GetLength(0); i++)
            {
                for (int j = 0; j < NetworkParameters.CohonenNetworkNodes.GetLength(1); j++)
                {
                    NetworkViewParameters.NetworkGridView[i, j] = new GridCell();
                }
            }
        }

        private double CulculateNodeInfluenceRadius(
            double initialRadius,
            int iterationsDone,
            int iterationsQuantity)
        {
            double radius = initialRadius * (iterationsDone / (double)iterationsQuantity);

            return radius;
        }

        private Tuple<Point, double[]> CulculateBestMatchingUnit(Color color)
        {
            var bestMatchingUnitCoordinates = new Point();
            var scaledColor = new ScaledColor(color);
            double[] colorsArray = scaledColor.ConvertColorsToArray();

            double lowestDistance = double.MaxValue;

            for (int i = 0; i < NetworkParameters.CohonenNetworkNodes.GetLength(0); i++)
            {
                for (int j = 0; j < NetworkParameters.CohonenNetworkNodes.GetLength(1); j++)
                {
                    double distance = NetworkParameters.CohonenNetworkNodes[i, j]
                        .GetEuclideanDistance(colorsArray);

                    if (!(distance < lowestDistance))
                    {
                        continue;
                    }

                    lowestDistance = distance;
                    bestMatchingUnitCoordinates = new Point(i, j);
                }
            }

            return new Tuple<Point, double[]>(bestMatchingUnitCoordinates, colorsArray);
        }

        private void AdjustNetworkWeights(
            Point bestMatchingUnit, 
            double[] colorsArray, 
            double influenceRadius)
        {
            for (int x = 0; x < NetworkParameters.CohonenNetworkNodes.GetLength(0); x++)
            {
                for (int y = 0; y < NetworkParameters.CohonenNetworkNodes.GetLength(1); y++)
                {
                    double distanceToBestMatchingUnit =
                        Math.Sqrt((bestMatchingUnit.X - x) * (bestMatchingUnit.X - x) 
                        + (bestMatchingUnit.Y - y) * (bestMatchingUnit.Y - y));

                    if (distanceToBestMatchingUnit > influenceRadius)
                    {
                        continue;
                    }

                    double learningRate = NetworkConsts.InitialLearningRate * 
                        (NetworkParameters.IterationsDone / 
                        (double)NetworkParameters.IterationsQuantity);

                    double influence = distanceToBestMatchingUnit / influenceRadius;

                    NetworkParameters.CohonenNetworkNodes[x, y]
                        .AdjustWeights(colorsArray, learningRate, influence);
                }
            }
        }
    }
}
