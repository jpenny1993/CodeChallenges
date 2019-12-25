using System;
using System.Linq;

namespace Anagram
{
    /// <summary>
    /// Anagrams are words or phrases made by mixing up the letters of other words or phrases.
    /// Write a method that detects if a string is an anagram of another.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var list = new[]
            {
                ("hello", "world"),
                ("tabu", "tuba"),
                ("eat", "ate"),
                ("general", "enlarge"),
            };

            foreach (var pair in list)
            {
                var str = IsAnagram(pair.Item1, pair.Item2)
                    ? "an anagram"
                    : "not an anagram";
                Console.WriteLine("{0} is {1} of {2}.", pair.Item1, str, pair.Item2);   
            }
        }
        
        public static bool IsAnagram(string strA, string strB)
        {
            if (string.IsNullOrEmpty(strA) ||
                string.IsNullOrEmpty(strB) ||
                strA.Length != strB.Length)
            {
                return false;
            }

            string OrderString(string str)
            {
                return string.Join(string.Empty, str.ToUpperInvariant().OrderBy(c => c));
            }

            var orderedStrA = OrderString(strA);
            var orderedStrB = OrderString(strB);
            return string.Equals(orderedStrA, orderedStrB);
        }
    }
}