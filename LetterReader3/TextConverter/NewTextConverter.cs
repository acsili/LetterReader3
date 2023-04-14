using IronOcr;
using System;
using System.Windows;

namespace LetterReader3.TextConverter
{
    internal class NewTextConverter
    {
        public static IronTesseract IronOcr = new IronTesseract();

        public string ConvertToText(string filePath)
        {
            try
            {
                var Result = IronOcr.Read(filePath);
                return Result.Text;
            }
            catch 
            {
                MessageBox.Show("No picture");
                return "";
            }
            
        }
        
    }
}
