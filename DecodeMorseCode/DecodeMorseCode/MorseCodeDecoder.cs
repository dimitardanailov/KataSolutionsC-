using System.Collections.Generic;
using System;
using System.Text;

class MorseCodeDecoder
{
    public static string Decode(string morseCode)
    {
        morseCode = morseCode.Trim();
        Console.WriteLine(morseCode);

        char[] delimiterChars = { ' ' };
        string[] subCodes = morseCode.Split(delimiterChars);
        Dictionary<string, string> morse = MorseCodeDecoder.Codes();
        string output;
        StringBuilder sb = new StringBuilder();
        int i = 0;
        foreach (string code in subCodes)
        {
            if (morse.ContainsKey(code))
            {
                morse.TryGetValue(code, out output);
                sb.Append(output);
                Console.WriteLine(output);
            }
            else
            {
                if (code.Length == 0 && i + 1 < subCodes.Length)
                {
                    if (subCodes[i + 1].Length == 0) sb.Append(" ");
                }
            }
            i++;
        }

        return sb.ToString();
    }

    public static Dictionary<string, string> Codes()
    {

        Dictionary<string, string> morse = new Dictionary<string, string>();

        morse.Add(".-", "A");
        morse.Add("-...", "B");
        morse.Add("-.-.", "C");
        morse.Add("-..", "D");
        morse.Add(".", "E");
        morse.Add("..-.", "F");
        morse.Add("--.", "G");
        morse.Add("....", "H");
        morse.Add("..", "I");
        morse.Add(".---", "J");
        morse.Add("-.-", "K");
        morse.Add(".-..", "L");
        morse.Add("--", "M");
        morse.Add("-.", "N");
        morse.Add("---", "O");
        morse.Add(".--.", "P");
        morse.Add("--.-", "Q");
        morse.Add(".-.", "R");
        morse.Add("...", "S");
        morse.Add("-", "T");
        morse.Add("..-", "U");
        morse.Add("...-", "V");
        morse.Add(".--", "W");
        morse.Add("-..-", "X");
        morse.Add("-.--", "Y");
        morse.Add("--..", "Z");
        morse.Add(".----", "1");
        morse.Add("..---", "2");
        morse.Add("...--", "3");
        morse.Add("....-", "4");
        morse.Add(".....", "5");
        morse.Add("-....", "6");
        morse.Add("--...", "7");
        morse.Add("---..", "8");
        morse.Add("----.", "9");
        morse.Add("-----", "0");
        morse.Add("--..--", ",");
        morse.Add(".-.-.-", ".");
        morse.Add("..--..", "?");
        morse.Add("-.-.--", "!");
        morse.Add("...---...", "SOS");

        return morse;
    }
}