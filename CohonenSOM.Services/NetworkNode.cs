using System;
using System.Drawing;
using System.Linq;

namespace CohonenSOM.Services
{
    public class NetworkNode
    {
        private readonly Point _nodePosition;
        private double[] _nodeWeights = new double[3];

        public NetworkNode(int xPosition, int yPosition)
        {
            _nodePosition.X = xPosition;
            _nodePosition.Y = yPosition;
            InitializeNodeWeightWithRandom();
        }

        public void SetNodeWeights(double[] weights)
        {
            if (_nodeWeights.Length != weights.Length)
            {
                return;
            }
            _nodeWeights = weights;
        }

        public double[] GetNodeWeights()
        {
            return _nodeWeights;
        }

        public double GetEuclideanDistance(double[] inputVector)
        {
            double distance = _nodeWeights.Select((t, index) =>
                (inputVector[index] - t) * (inputVector[index] - t)).Sum();

            return Math.Sqrt(distance);
        }

        public void AdjustWeights(double[] targetColorsArray, double learningRate, double influence)
        {
            for (int i = 0; i < targetColorsArray.Length; i++)
            {
                _nodeWeights[i] += 
                    learningRate * influence * (targetColorsArray[i] - _nodeWeights[i]);
            }
        }

        private void InitializeNodeWeightWithRandom()
        {
            for (int index = 0; index < _nodeWeights.Length; index++)
            {
                _nodeWeights[index] = new CryptoRandom().NextDouble();
            }
        }
    }
}
