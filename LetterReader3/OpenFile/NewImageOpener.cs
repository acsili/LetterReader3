using IronOcr;
using Microsoft.Win32;
using SixLabors.ImageSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace LetterReader3.OpenFile
{
    internal class NewImageOpener
    {
        public string filePath { get; private set; }

        public BitmapImage OpenImage()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Multiselect = true,
                Filter = "Image files (*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            };

            if (openFileDialog.ShowDialog() == true)
            {
                filePath = openFileDialog.FileName;
                return new BitmapImage(new Uri(openFileDialog.FileName));
            }
            return null;
        }

    }
}
