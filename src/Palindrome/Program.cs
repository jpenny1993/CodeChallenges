using System;

namespace Palindrome
{
    class Program
    {
        /// <summary>
        /// A palindrome is a word which reads the same backward or forward. 'abcba' is a palindrome.
        /// Write a method that detects if a string is a palindrome.
        /// </summary>
        static void Main(string[] args)
        {
            var list = new[]
            {
                "abcba",
                "anna",
                "bicycle",
                "kayak",
                "level"
            };

            foreach (var word in list)
            {
                var str = IsPalindrome(word)
                    ? "a palindrome"
                    : "not a palindrome";
                Console.WriteLine("{0} is {1}.", word, str);   
            }
        }
        
        private static bool IsPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            var range = input.Length / 2;
            var lastIndex = input.Length - 1;
            for (var index = 0; index < range; index++)
            {
                if (input[index] != input[lastIndex - index])
                {
                    return false;
                }
            }

            return true;
        }
    }
}