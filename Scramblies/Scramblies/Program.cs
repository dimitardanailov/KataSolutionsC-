using System;

namespace Scramblies
{
    class Program
    {
        static void Main(string[] args)
        {
            testing(Scramblies.Scramble("rkqodlw", "world"), true);
            testing(Scramblies.Scramble("cedewaraaossoqqyt", "codewars"), true);
            testing(Scramblies.Scramble("katas", "steak"), false);
            testing(Scramblies.Scramble("scriptjavx", "javascript"), false);
            testing(Scramblies.Scramble("scriptingjava", "javascript"), true);
            testing(Scramblies.Scramble("scriptsjava", "javascripts"), true);
            testing(Scramblies.Scramble("javscripts", "javascript"), false);
            testing(Scramblies.Scramble("aabbcamaomsccdd", "commas"), true);
            testing(Scramblies.Scramble("commas", "commas"), true);
            testing(Scramblies.Scramble("sammoc", "commas"), true);
        }

        static void testing(bool output, bool expectation) {
            Console.WriteLine("output: {0}, expectation:{1}", output, expectation);
            Console.WriteLine("----------");
        }
    }
}
