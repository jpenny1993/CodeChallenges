using System;
using System.Linq;

namespace CaesarCipher
{
    /// <summary>
    /// The Caesar cipher is a basic encryption technique used by Julius Caesar to securely communicate with his generals.
    /// Each letter is replaced by another letter N positions down the english alphabet.
    /// For example, for a rotation of 5, the letter 'c' would be replaced by an 'h'.
    /// In case of a 'z', the alphabet rotates and it is transformed into a 'd'.
    /// Implement a decoder for the Caesar cipher where N = 4.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var list = new[]
            {
                "dahhk sknhz",
                "sexxha",
                "iannu ydneopiwo"
            };
            foreach (var message in list)
            {
                var result = Decode(message, 4);
                Console.WriteLine(result);
            }
        }

        private static string Decode(string input, int n)
        {
            const char start = 'a';
            const char end = 'z';
            const int length = end - start + 1;
            var charArray = input.ToLowerInvariant().Select(c =>
            {
                if (!char.IsLetterOrDigit(c))
                    return c;
                
                var shiftedChar = c + n;
                
                if (shiftedChar < start)
                    shiftedChar = shiftedChar + length;
                else if (shiftedChar > end)
                    shiftedChar = shiftedChar - length;
                
                return (char)shiftedChar;
            }).ToArray();
            return new String(charArray);
        }
    }
}