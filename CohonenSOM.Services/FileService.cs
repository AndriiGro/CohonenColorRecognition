using System.Drawing;
using System.Windows.Forms;

namespace CohonenSOM.Services
{
    public class FileService
    {
        public string GetImageFilePath()
        {
            string filePath = null;
            var openFileDialog = new OpenFileDialog
            {
                CheckFileExists = true,
                AddExtension = true,
                Multiselect = false,
                Filter = "Bitmap image file (*.bmp)|*.bmp"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }

            return filePath;
        }

        public Bitmap GetBitmapFromPath(string imagePath)
        {
            Bitmap imageToReturn = new Bitmap(0, 0);

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
    }
}
