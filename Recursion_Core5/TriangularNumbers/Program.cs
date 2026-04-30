// Joseph Sutton 4/29/2026
// cs233n c# intermediate.
// Recursive Lab: Triangular Numbers

// Write a recursive method to calculate the nth triangular number and use it
// to write an application that displays the first 10 triangular numbers.

// The method should take an integer n as its parameter and return an integer.

// A triangular number is the sum of the first n natural numbers. For example, the 4th
// triangular number is 1 + 2 + 3 + 4 = 10. The formula for calculating the nth triangular
// number is T(n) = n * (n + 1) / 2.


using System;

namespace TriangularNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangular Numbers 0-10");
            for (int n = 1; n <= 10; n++)
                Console.WriteLine(String.Format("{0,2}th triangular number is {1,2}", n, GetTriangularNumber(n)));
            Console.WriteLine();
        }

        // formula is: T(n) = n * (n + 1) / 2
        // Algorithm for triangle number 
        // get x
        // start algorithm and one and work down to 1.
        // GetTriangularNumber(4) = 4 + GetTriangularNumber(3)....
        // when/if x is 1 return 1.
        static int GetTriangularNumber(int x)
        {
            // Base case: The 1st triangular number is 1, and 0th is 0.
            if (x <= 1)
            {
                return x;
            }

            // Recursive step: x + (x-1) + (x-2)...
            return x + GetTriangularNumber(x - 1); // Recursive case: T(n) = n + T(n - 1). This will keep adding n until it reaches the base case.
        }
    }
}
