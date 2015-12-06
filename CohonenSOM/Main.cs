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
            teachNetworkToolStripMenuItem.Enabled = true;
        }

        private void teachNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _cohonenNetwork.SetupNetworkWithRandoms();
            pictureBox_NetworkGridView.Image = _cohonenNetwork.GetCohonenNetworkImage();
            MessageBox.Show(@"Network initialization finished", @"Notification");

            while (!_cohonenNetwork.RunNetworkTrainingEpoch())
            {
                pictureBox_NetworkGridView.Image = _cohonenNetwork.GetCohonenNetworkImage();
                metroLabel_IterationsDone.Text = NetworkParameters.IterationsDone.ToString();
                pictureBox_NetworkGridView.Refresh();
                metroLabel_IterationsDone.Refresh();
            }
        }
    }
}
