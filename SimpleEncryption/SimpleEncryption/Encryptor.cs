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
            if (String.IsNullOrEmpty(text)) return text;

            // If n is <= 0 then return the input text.
            if (n <= 0 && text.Length == 1) return text;

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

            string output = encryptedText;
            while (n > 0)
            {
                output = Encryptor.DecodeString(output);
                n--;
            }

            return output;
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

        public static string DecodeString(string text) {
            // How many encrypt interactions are completed.
            int times = (int) (text.Length / TARGET_CHAR);

            String chars = text.Substring(0, times);
            String newString = text.Substring(times);

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < times; i++) {
                output.Append(newString.Substring(i, TARGET_CHAR - 1));
                output.Append(chars.Substring(i, TARGET_CHAR - 1));
            }

            if (chars.Length < newString.Length) {
                output.Append(newString.Substring(times));
            }


            return output.ToString();
        }
    }
}
