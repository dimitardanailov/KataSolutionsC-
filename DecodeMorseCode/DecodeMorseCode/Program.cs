using System.Collections.Generic;
using System;
using System.Text;

namespace DecodeMorseCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MorseCodeDecoder.Decode("...---..."));
        }
    }
}
