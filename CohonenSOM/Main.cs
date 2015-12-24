using System;
using System.Threading.Tasks;
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

        private async void teachNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _cohonenNetwork.ResetCohonenNetwork();
            _cohonenNetwork.SetupNetworkWithRandoms();
            pictureBox_NetworkGridView.Image = _cohonenNetwork.GetCohonenNetworkImage();
            MessageBox.Show(@"Network initialization finished", @"Notification");
            
            Task startTrainingTask = new Task(
                () =>
                {
                    while (!_cohonenNetwork.RunNetworkTrainingEpoch())
                    {
                        pictureBox_NetworkGridView.Image = _cohonenNetwork.GetCohonenNetworkImage();
                        metroLabel_IterationsDone.Text =
                            NetworkParameters.IterationsDone
                            + @"/"
                            + NetworkParameters.IterationsQuantity;
                        pictureBox_NetworkGridView.Refresh();
                        metroLabel_IterationsDone.Refresh();
                    }
                }
                );

            menuStrip_Main.Enabled = false;
            startTrainingTask.Start();

            await startTrainingTask;

            menuStrip_Main.Enabled = true;
        }
    }
}
