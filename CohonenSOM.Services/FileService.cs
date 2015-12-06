using System.Drawing;
using System.Windows.Forms;

namespace CohonenSOM.Services
{
    public class FileService
    {
        public string GetImageFilePath()
        {
            var openFileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                AddExtension = true,
                Multiselect = false,
                Filter = "Bitmap image file (*.bmp)|*.bmp"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK) { return null;}

            string filePath = openFileDialog.FileName;
            NetworkParameters.PathToLearningData = filePath;

            return filePath;
        }

        public Bitmap GetBitmapFromPath(string imagePath)
        {
            var imageToReturn = new Bitmap(1, 1);

            try
            {
                imageToReturn = (Bitmap)Image.FromFile(imagePath, true);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("There was an error opening the bitmap." +
                                "Please check the path.");
            }

            return imageToReturn;
        }

        public Bitmap GetBitmapFileFromDisk()
        {
            return GetBitmapFromPath(GetImageFilePath());
        }

        public void SaveBitmapFileToNetworkParameters()
        {
            NetworkParameters.LearningBitmapFromDisk = GetBitmapFileFromDisk();
        }
    }
}
