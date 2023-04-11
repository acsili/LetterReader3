using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;
using LetterReader3.TextConverter;
using System.Windows.Controls;

namespace LetterReader3.Speecher
{
    internal class NewSpeecher
    {
        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        private NewTextConverter newTextConverter = new NewTextConverter();

        public void ConvertToSpeech(string filePath, ComboBox comboBox)
        {
            newTextConverter.SetLanguages(comboBox);
            string text = newTextConverter.ConvertToText(filePath);
            if (text != "")
            {
                synthesizer.SelectVoice(comboBox.Text);
                synthesizer.SpeakAsync(text);
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
        public void SetSpeechLanguage(ComboBox comboBox)
        {
            foreach (var voice in synthesizer.GetInstalledVoices())
            {
                comboBox.Items.Add(voice.VoiceInfo.Name);
            }
        }
    }
}
