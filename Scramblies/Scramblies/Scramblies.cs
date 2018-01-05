using System;
using System.Linq;

namespace Scramblies
{
    public class Scramblies
    {
        public static bool Scramble(string str1, string str2)
        {
            string sortedStr = Scramblies.SortString(str1);
            char[] characters = sortedStr.ToArray();

            int matches = 0;
            int count1, count2;
            foreach (char letter in characters) {
                count1 = str1.Count(c => c == letter);
                count2 = str2.Count(c => c == letter);

                if (count1 < count2) return false;

                matches = matches + count2;
            }

            return matches == str2.Length ? true : false;
        }

        public static string SortString(string str) {
            return String.Concat(str.OrderBy(c => c).Distinct());
        }
    }
}
