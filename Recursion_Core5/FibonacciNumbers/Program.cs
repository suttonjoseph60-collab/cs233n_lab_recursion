// Joseph Sutton 4/29/2026
// cs233n c# intermediate.
// Recursive Lab: Fibonacci Numbers

// Write a recursive method to calculate the nth Fibonacci number and use it
// to write an application that displays the first 10 Fibonacci numbers.

// The method should take an integer n as its parameter and return an integer.

// A Fibonacci number is defined as follows:
// F(0) = 0, F(1) = 1
// F(n) = F(n-1) + F(n-2) for n > 1

using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci Numbers 0-10");
            for (int n = 1; n <= 10; n++)
                Console.WriteLine(String.Format("{0,2} fibonacci number is {1,3}", n, GetFibonacciNumber(n)));
            Console.WriteLine();
        }

        // Pseudo code for Fibonacci number:
            // Get x
            // calculate Fibonacci number for x
            // if x is 0 return 0
            // if x is 1 return 1
            // return Fibonacci number for x-1 + Fibonacci number for x-2

        // algorithm?
            // x = (x-1) + (x-2)
            // 

        static int GetFibonacciNumber(int x)
        {
            if (x <= 1) // Base case: F(0) = 0, F(1) = 1. This meets criteria per lab instructions of including 0, 1 because condition is x <- 1.
            {
                return x;
            }
            return GetFibonacciNumber(x - 1) + GetFibonacciNumber(x - 2);
        }
    }
}
