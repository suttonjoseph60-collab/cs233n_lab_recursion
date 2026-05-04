// Joseph Sutton 5/4/2026
// cs233n c# intermediate.
// Recursive Lab: Tower of Hanoi

// Using the Visual Studio Solution provided in the starting files as a starting point, write a recursive
// method to solve the Tower of Hanoi puzzle with n discs.  The method should take an integer n representing
// the number of discs and a string representing the name of the tower on which the discs start, a string
// representing the name of the tower to which the discs must be moved and a string representing the name
// of the extra tower as its parameters.  The method does not return a value but displays a message describing
// each move.  Use your method to write an application that asks the user to enter how many discs they would
// like and then displays the moves necessary to solve the puzzle.

// IPO 
// Input
    // number of discs
// Processing 
    // move n-1 discs from start to extra
    // move 1 disc from start to dest
    // move n-1 discs from extra to dest
// Output
    // console write each move to solve.

using System;

namespace TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {           

            Console.WriteLine("Welcome to the Tower of Hanoi game! How many discs would you like me to solve?");
            int numberOfDiscs = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name of start tower:");
            string startTower = Console.ReadLine();
            Console.WriteLine("Enter the name of destination tower:");
            string destTower = Console.ReadLine();
            Console.WriteLine("Enter the name of extra tower:");
            string extraTower = Console.ReadLine();
            Console.WriteLine($"Here are the moves to solve the Tower of Hanoi puzzle with {numberOfDiscs} discs:");

            TowerOfHanoi(numberOfDiscs, startTower, extraTower, destTower);

        }

        static void TowerOfHanoi(int numberOfDiscs, string startTower, string extraTower, string destTower)
        {
            // algorithm:
            // if number of discs is 1, move disc from start to dest
            // give each disc a number from 1 to n. 1 will be the smallest. 
            // cant place bigger disc on top of smaller disc. 
            if (numberOfDiscs == 1)
                {
                    Console.WriteLine($"Move disc {numberOfDiscs} from {startTower} to {destTower}");
                    return;
            }

            TowerOfHanoi(numberOfDiscs - 1, startTower, destTower, extraTower);
            Console.WriteLine($"Move disc {numberOfDiscs} from {startTower} to {destTower}");
            TowerOfHanoi(numberOfDiscs - 1, extraTower, startTower, destTower);
        }
    }
}
