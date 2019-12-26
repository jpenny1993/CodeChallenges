using System;

namespace GreatestCommonDenominator
{
    /// <summary>
    /// Write a method that finds the greatest common denominator of two integers, which are not all zero.
    /// The gcd is the largest positive integer that divides each of the integers without a remainder.
    /// For example, the gcd of 8 and 12 is 4.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var items = new[]
            {
                (25, 55),
                (16, 64),
                (49, 91),
                (15, 65),
                (55, 54),
                (48, 60)
            };

            foreach (var pair in items)
            {
                var result = Gcd(pair.Item1, pair.Item2);
                Console.WriteLine("The GCD of {0} and {1} is {2}", pair.Item1, pair.Item2, result);
            }
        }

        private static int Gcd(int p, int q)
        {
            if (q == 0)
                return p;

            return Gcd(q, p % q);
        }
    }
}