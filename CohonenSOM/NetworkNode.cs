using System;
using System.Drawing;
using System.Linq;

namespace CohonenSOM
{
    public class NetworkNode
    {
        private double[] _nodeWeights = new double[3];

        private readonly Point _nodePosition;

        public NetworkNode(int xPosition, int yPosition)
        {
            _nodePosition.X = xPosition;
            _nodePosition.Y = yPosition;
            InitializeNodeWeightWithRandom();
        }

        public void InitializeNodeWeightWithRandom()
        {
            for (int index = 0; index < _nodeWeights.Length; index++)
            {
                _nodeWeights[index] = new Random().NextDouble();
            }
        }

        public void SetNodeWeights(double[] weights)
        {
            if (_nodeWeights.Length != weights.Length)
            {
                return;
            }
            _nodeWeights = weights;
        }

        public double GetEuclideanDistance(double[] inputVector)
        {
            double distance = _nodeWeights.Select((t, index) => 
                (inputVector[index] - t)*(inputVector[index] - t)).Sum();

            return Math.Sqrt(distance);
        }
    }
}
