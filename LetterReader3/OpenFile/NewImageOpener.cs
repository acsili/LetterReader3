using Microsoft.Win32;
using System;
using System.Windows.Media.Imaging;

namespace LetterReader3.OpenFile
{
    internal class NewImageOpener
    {
        public string FilePath { get; private set; }

        public BitmapImage OpenImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "Image files (*.png;*.jpg)|*.png;*.jpg",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (openFileDialog.ShowDialog() == true)
            {
                FilePath = openFileDialog.FileName;
                return new BitmapImage(new Uri(openFileDialog.FileName));
            }
            return null;
        }

    }
}
