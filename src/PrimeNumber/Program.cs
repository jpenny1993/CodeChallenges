using System;

namespace PrimeNumber
{
    /// <summary>
    /// A prime number is a natural number greater than 1 that has no positive divisors other than 1 and itself.
    /// Write a method that checks if a number is prime number. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 1000; i++)
            {
                var str = IsPrime(i) ? "prime" : "not prime";
                Console.WriteLine("{0} is {1}.", i, str);
            }
        }

        private static bool IsPrime(int value)
        {
            if (value <= 1)
                return false;
            
            for (var n = value - 1; n > 1; n--)
            {
                var remainder = value % n;
                if (remainder == 0)
                    return false;
            }

            return true;
        }
    }
}