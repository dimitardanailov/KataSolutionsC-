using System;

namespace SimpleEncryption
{
    /**
     * Requirements: https://www.codewars.com/kata/simple-encryption-number-1-alternating-split
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Encrypt
            testing(Encryptor.Encrypt("This is a test!", 1), "hsi  etTi sats!");
            testing(Encryptor.Encrypt("This is a test!", 2), "s eT ashi tist!");

            Console.WriteLine("");
            Console.WriteLine("^^^^^^^^^^");
            Console.WriteLine("");

            // Decrypt
            testing(Encryptor.Decrypt("hsi  etTi sats!", 1), "This is a test!");
            testing(Encryptor.Decrypt("s eT ashi tist!", 2), "This is a test!");
        }

        static void testing(string output, string expectation)
        {
            Console.WriteLine("output: {0} --- expectation:{1}", output, expectation);
            Console.WriteLine("----------");
        }
    }
}
