using System;
using System.Windows.Forms;
using CohonenSOM.Services;
using MetroFramework.Forms;

namespace CohonenSOM
{
    public partial class Main : MetroForm
    {
        private readonly FileService _fileService = new FileService();
        private readonly CohonenNetwork _cohonenNetwork = new CohonenNetwork();
        public Main()
        {
            InitializeComponent();
        }

        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _fileService.SaveBitmapFileToNetworkParameters();
        }

        // TODO: Check if image to teach was loaded so far
        private void teachNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _cohonenNetwork.SetupNetworkWithRandoms();
            pictureBox_NetworkGridView.Image = _cohonenNetwork.GetCohonenNetworkImage();
            MessageBox.Show(@"Network initialization finished");

            while (!_cohonenNetwork.RunNetworkTrainingEpoch())
            {
                pictureBox_NetworkGridView.Image = _cohonenNetwork.GetCohonenNetworkImage();
                metroLabel_IterationsDone.Text = NetworkParameters.IterationsDone.ToString();
            }
        }
    }
}
