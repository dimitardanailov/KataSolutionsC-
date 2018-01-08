using System;
using System.Text;

namespace SimpleEncryption
{
    public class Encryptor
    {
        private static int TARGET_CHAR = 2;
        
        public static string Encrypt(string text, int n)
        {
            // If the input-string is null or empty return exactly this value!
            if (String.IsNullOrEmpty(text) && text.Length == 1) return text;

            // If n is <= 0 then return the input text.
            if (n <= 0) return text;

            string output = text;
            while (n > 0) {
                output = Encryptor.GetTargetChars(output);
                n--;
            }

            return output;
        }

        public static string Decrypt(string encryptedText, int n)
        {
            // If the input-string is null or empty return exactly this value!
            if (String.IsNullOrEmpty(encryptedText)) return encryptedText;

            // If n is <= 0 then return the input text.
            if (n <= 0 && encryptedText.Length == 1) return encryptedText;

            return null;
        }

        /**
         * Take every TARGET_CHAR char from the string
         * , then the other chars, that are not every 2nd char, and concat them as new String.
         */
        public static string GetTargetChars(string text) 
        {
            StringBuilder chars = new StringBuilder();

            StringBuilder newString = new StringBuilder();
            int startIndex = 0;
            for (int i = (TARGET_CHAR - 1); i < text.Length; i = i + TARGET_CHAR) 
            {
                chars.Append(text[i]);

                newString.Append(text.Substring(startIndex, TARGET_CHAR - 1));
                startIndex = i + 1;
            }

            if (startIndex <= text.Length - 1) {
                newString.Append(text.Substring(startIndex));
            }

            return chars.ToString() + newString.ToString();
        }
    }
}
