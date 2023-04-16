
<p align="left">
<img src="https://github.com/IlyaOvchinnikov-0/LetterReader3/blob/main/LetterReader3/Icon/iconLR3.png" width="70" />
</p>

# LetterReader3

## This application can convert any text from image to speech. LR3 has two languages that can be used when converting text: Russian and English.

## Used: 
> ### .NETFramework 4.8
> ### C#
> ### WPF
## Libraries: 
> ### System.Speech
> ### IronOcr
## IDE: Visual Studio 2022
## Main functions: 
* ### convert text from image to string
    ```cs
    public string ConvertToText(string filePath)
    ```
* ### convert text to speech
    ```cs
    public void ConvertToSpeech(string filePath, string speecher)
    ```
* ### opening a file
    ```cs
    public BitmapImage OpenImage()
    ```
* ### language selection
    ```cs
    public void GetLanguage(ComboBox comboBox, IronTesseract IronOcr)
    ```
## Application will be improved
