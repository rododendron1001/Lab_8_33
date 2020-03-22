using System;
using FibonacciProject3.Library;

namespace FibonacciProject3
{
    class Program
    {
        static void Main(string[] args)
        {
            StringFibonacci();
        }

        private static void StringFibonacci()
        {
            int n = For_Console.ReadNumber(("Number of elements for the string Fibonacci : "), 3, 0);
            string fibonacci = Library.Fibonacci_Class.Fibonacci(n);
        }


    }
}
