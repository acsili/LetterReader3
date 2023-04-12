using IronOcr;
using System;
using System.Windows.Controls;
using System.Speech.Synthesis;
using System.Collections.Generic;

namespace LetterReader3.TextConverter.Languages
{
    internal class NewLanguage
    {
        List<string> speechers = new List<string>();
        public void SetLanguages(ComboBox comboBox)
        {
            comboBox.Items.Add("Русский");
            comboBox.Items.Add("Английский");
        }
        public void SetSpeechLanguage(SpeechSynthesizer synthesizer)
        {
            foreach (var voice in synthesizer.GetInstalledVoices())
            {
                speechers.Add(voice.VoiceInfo.Name);
            }
        }
        public void GetLanguage(ComboBox comboBox, IronTesseract IronOcr, SpeechSynthesizer synthesizer)
        {
            if (comboBox.SelectedIndex == 0)
            {
                IronOcr.Language = OcrLanguage.Russian;
                synthesizer.SelectVoice(speechers[0]);
            }
            else if (comboBox.SelectedIndex == 1)
            {
                IronOcr.Language = OcrLanguage.English;
                synthesizer.SelectVoice(speechers[1]);
            }

        }
    }
}
