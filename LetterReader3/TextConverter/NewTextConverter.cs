using IronOcr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace LetterReader3.TextConverter
{
    internal class NewTextConverter
    {
        private IronTesseract IronOcr = new IronTesseract();

        public string ConvertToText(string filePath)
        {
            var Result = IronOcr.Read(filePath);
            return Result.Text;
        }
        public void SetLanguages(ComboBox comboBox)
        {
            comboBox.Items.Add("Английский");
            comboBox.Items.Add("Русский");
        }
    }
}
