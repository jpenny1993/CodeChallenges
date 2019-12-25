using System;

namespace FibonacciNumber
{
    /// <summary>
    ///  Write a method that returns the nth element of the Fibonacci Sequence
    /// The Fibonacci Sequence is the series of numbers: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34,...
    /// The next number is found by adding up the two numbers before it.
    /// Assume that indexes start at zero, e.g., fib(0) = 0, fib(1) = 1, ...
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 100; i++)
            {
                var n = Fib(i);
                Console.Write("{0}, ", n);
            }
        }

        static ulong Fib(int index)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index), "Index must be zero or greater.");

            ulong first = index >= 1 ? 1u : 0u;
            ulong second = 0u;

            for (var i = 0; i < index; i++) {
                var temp = second;
                second = first + second;
                first = temp;
                if (second < temp)
                    throw new OverflowException("The calculated value has exceeded the capacity of a ulong.");
            }

            return second;
        }
    }
}