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
                var fizz = i % 3 == 0;
                var buzz = i % 5 == 0;
                
                if (fizz && buzz)
                    Console.WriteLine("FizzBuzz");
                else if (fizz)
                    Console.WriteLine("Fizz");
                else if (buzz)
                    Console.WriteLine("Buzz");
                else 
                    Console.WriteLine(i);
            }
        }
    }
}