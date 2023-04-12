using IronOcr;
using System;

namespace LetterReader3.TextConverter
{
    internal class NewTextConverter
    {
        public static IronTesseract IronOcr = new IronTesseract();

        public string ConvertToText(string filePath)
        {
            var Result = IronOcr.Read(filePath);
            return Result.Text;
        }
        
    }
}
