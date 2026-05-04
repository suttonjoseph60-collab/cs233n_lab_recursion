// Joseph Sutton 5/4/2026
// cs233n c# intermediate.
// Recursive Lab: Palindromes

using System;
using System.Reflection.Metadata.Ecma335;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a word or phrase to determine if it is a palindrome:");
            string amIPalindrome = Console.ReadLine();
            if (IsPalindrome(amIPalindrome))
            {
                Console.WriteLine($"\"{amIPalindrome}\" is a palindrome.");
            }
            else
            {
                Console.WriteLine($"\"{amIPalindrome}\" is not a palindrome.");
            }

            Console.WriteLine("Would you like to try another? (y/n)");
            bool tryAnother = Console.ReadLine().ToLower() == "y";
            if (tryAnother)
            {
                Main(args); // Call Main again to allow the user to try another word or phrase.
            } 
            else 
            {
                Console.WriteLine("Thanks for playing palindromes!");
            }
        }

        static bool IsPalindrome(string s)
        {
            // Base case: An empty string or a single character is a palindrome.
            if (s.Length <= 1)
            {
                return true;
            }
            // Recursive case: Check if the first and last characters are the same,
            // and if the substring excluding those characters is also a palindrome.
            if (s[0] == s[s.Length - 1])
            {
                // this calls the substring(1, s.Length - 2) which is the 2nd character from start and
                // 2nd character from last so each time this gets ran the string shortens one character
                // from beginning and one from the end.
                return IsPalindrome(s.Substring(1, s.Length - 2));             }
            // If the first and last characters are not the same, it's not a palindrome.
            return false;
        }
    }
}
