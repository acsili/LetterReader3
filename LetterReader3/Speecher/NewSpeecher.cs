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

        public void ConvertToSpeech(string filePath, string speecher)
        {
            
            
            string text = newTextConverter.ConvertToText(filePath);

            try
            {
                synthesizer.SelectVoice(speecher);
                synthesizer.SpeakAsync(text);
            }
            catch
            {
                if (speecher == "")
                    MessageBox.Show("Language not selected");
                else if (text == "")
                    MessageBox.Show("Text not selected");
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
