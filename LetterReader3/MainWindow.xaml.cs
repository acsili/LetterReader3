using Microsoft.Win32;
using System;
using System.Windows;
using System.Windows.Media.Imaging;
using IronOcr;
using System.Windows.Controls;
using LetterReader3.OpenFile;
using LetterReader3.Speecher;

namespace LetterReader3
{
    public partial class MainWindow : Window
    {
        NewImageOpener newImageOpener = new NewImageOpener();
        NewSpeecher newSpeecher = new NewSpeecher();
        public MainWindow()
        {
            InitializeComponent();
            newSpeecher.SetSpeechLanguage(comboBoxSpeecher);
        }

        private void ButtonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            image.Source = newImageOpener.OpenImage();
        }

        private void ButtonConvert_Click(object sender, RoutedEventArgs e)
        {
            newSpeecher.ConvertToSpeech(newImageOpener.filePath, comboBoxSpeecher);
        }

        private void ButtonPause_Click(object sender, RoutedEventArgs e)
        {
            newSpeecher.PauseSpeech();
        }

        private void ButtonResume_Click(object sender, RoutedEventArgs e)
        {
            newSpeecher.ResumeSpeech();
        }
    }
}
