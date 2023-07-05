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
using System.Threading.Tasks;

namespace LetterReader3
{
    public partial class MainWindow : Window
    {
        NewImageOpener newImageOpener;
        NewSpeecher newSpeecher;
        NewLanguage newLanguage;
        public MainWindow()
        {
            InitializeComponent();
            newLanguage = new NewLanguage();
            newLanguage.SetLanguages(ComboBoxLang);
        }

        private void ButtonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            newImageOpener = new NewImageOpener();
            image.Source = newImageOpener.OpenImage();
        }

        async private void ButtonConvert_Click(object sender, RoutedEventArgs e)
        {
            newSpeecher = new NewSpeecher();
            await Task.Run(() => newSpeecher.ConvertToSpeech(newImageOpener.FilePath, newLanguage.speecher));
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

        private void ComboBoxLang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            newLanguage.GetLanguage(ComboBoxLang, NewTextConverter.IronOcr);
        }
    }
}
