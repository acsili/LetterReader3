using IronOcr;
using System;
using System.Windows.Controls;
using System.Speech.Synthesis;
using System.Collections.Generic;

namespace LetterReader3.TextConverter.Languages
{
    internal class NewLanguage
    {
        public string speecher = string.Empty;

        /// <summary>
        /// Method fills ComboBox with language names
        /// </summary>
        /// <param name="comboBox">ComboBox with language names</param>
        public void SetLanguages(ComboBox comboBox)
        {
            comboBox.Items.Add("Russian");
            comboBox.Items.Add("English");
        }

        /// <summary>
        /// Method puts the corresponding voice in the "speecher" for the selected language
        /// </summary>
        /// <param name="comboBox">ComboBox with language names</param>
        /// <param name="IronOcr">IronTesseract from NewTextConverter class</param>
        public void GetLanguage(ComboBox comboBox, IronTesseract IronOcr)
        {
            if (comboBox.SelectedIndex == 0)
            {
                IronOcr.Language = OcrLanguage.Russian;
                speecher = "Microsoft Irina Desktop";
            }
            else if (comboBox.SelectedIndex == 1)
            {
                IronOcr.Language = OcrLanguage.English;
                speecher = "Microsoft Zira Desktop";
            }
        }
    }
}
