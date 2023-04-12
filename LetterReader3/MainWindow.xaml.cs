using Microsoft.Win32;
using System;
using System.Windows;
using LetterReader3.OpenFile;
using LetterReader3.Speecher;
using LetterReader3.TextConverter;
using LetterReader3.TextConverter.Languages;
using IronOcr;
using System.Speech.Synthesis;
using System.Windows.Controls;

namespace LetterReader3
{
    public partial class MainWindow : Window
    {
        NewImageOpener newImageOpener = new NewImageOpener();
        NewSpeecher newSpeecher = new NewSpeecher();
        NewLanguage newLanguage = new NewLanguage();
        public MainWindow()
        {
            InitializeComponent();
            newLanguage.SetLanguages(comboBoxLang);
            newLanguage.SetSpeechLanguage(newSpeecher.synthesizer);
        }

        private void ButtonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            image.Source = newImageOpener.OpenImage();
        }

        private void ButtonConvert_Click(object sender, RoutedEventArgs e)
        {
            newSpeecher.ConvertToSpeech(newImageOpener.FilePath, comboBoxLang);
        }

        private void ButtonPause_Click(object sender, RoutedEventArgs e)
        {
            newSpeecher.PauseSpeech();
        }

        private void ButtonResume_Click(object sender, RoutedEventArgs e)
        {
            newSpeecher.ResumeSpeech();
        }

        private void CloseApp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MinimizeApp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void comboBoxLang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            newLanguage.GetLanguage(comboBoxLang, NewTextConverter.IronOcr, newSpeecher.synthesizer);
            
        }
    }
}
