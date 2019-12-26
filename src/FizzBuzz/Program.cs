using System;

namespace FizzBuzz
{
    /// <summary>
    /// Write a method that returns 'Fizz' for multiples of three and 'Buzz' for the multiples of five.
    /// For numbers which are multiples of both three and five return 'FizzBuzz'.
    /// For numbers that are neither, return the input number. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 1; i <= 100; i++)
            {
                var result = DoFizzBuzz(i);
                Console.WriteLine(result);
            }
        }
        
        private static string DoFizzBuzz(int value)
        {
            var fizz = value % 3 == 0 
                ? "Fizz"
                : string.Empty;
            
            var buzz = value % 5 == 0
                ? "Buzz"
                : string.Empty;
            
            var str = string.Concat(fizz, buzz);
            
            return string.IsNullOrEmpty(str)
                ? value.ToString() 
                : str;
        }
    }
}