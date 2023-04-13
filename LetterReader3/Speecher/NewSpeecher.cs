using System;
using System.Speech.Synthesis;
using LetterReader3.TextConverter;
using System.Windows.Controls;
using System.Windows;

namespace LetterReader3.Speecher
{
    internal class NewSpeecher
    {
        public SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        private NewTextConverter newTextConverter = new NewTextConverter();

        public void ConvertToSpeech(string filePath, ComboBox comboBoxSpeecher)
        {
            string text = newTextConverter.ConvertToText(filePath);

            try
            {
                synthesizer.SelectVoice(comboBoxSpeecher.Text);
                synthesizer.SpeakAsync(text);
            }
            catch
            {
                if (comboBoxSpeecher.Text == "")
                    MessageBox.Show("Язык не выбран");
                else if (text == "")
                    MessageBox.Show("Тект не выбран");
            }
        }
        public void PauseSpeech()
        {
            if (synthesizer.State == SynthesizerState.Speaking)
            {
                synthesizer.Pause();
            }
        }
        public void ResumeSpeech()
        {
            if (synthesizer.State == SynthesizerState.Paused)
            {
                synthesizer.Resume();
            }
        }
    }
}
