using IronOcr;
using System;
using System.Windows.Controls;
using System.Speech.Synthesis;
using System.Collections.Generic;

namespace LetterReader3.TextConverter.Languages
{
    internal class NewLanguage
    {
        public void SetLanguages(ComboBox comboBox)
        {
            comboBox.Items.Add("Русский");
            comboBox.Items.Add("Английский");
        }
        public void SetSpeechLanguage(ComboBox comboBoxSpeecher, SpeechSynthesizer synthesizer)
        {
            foreach (var voice in synthesizer.GetInstalledVoices())
            {
                comboBoxSpeecher.Items.Add(voice.VoiceInfo.Name);
            }
        }
        public void GetLanguage(ComboBox comboBox, IronTesseract IronOcr)
        {
            if (comboBox.SelectedIndex == 0)
            {
                IronOcr.Language = OcrLanguage.Russian;
            }
            else if (comboBox.SelectedIndex == 1)
            {
                IronOcr.Language = OcrLanguage.English;
            }

        }
    }
}
