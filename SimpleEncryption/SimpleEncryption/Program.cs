using System;

namespace SimpleEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            testing(Encryptor.Encrypt("This is a test!", 1), "hsi  etTi sats!");
            testing(Encryptor.Encrypt("This is a test!", 2), "s eT ashi tist!");
        }

        static void testing(string output, string expectation)
        {
            Console.WriteLine("output: {0} --- expectation:{1}", output, expectation);
            Console.WriteLine("----------");
        }
    }
}
