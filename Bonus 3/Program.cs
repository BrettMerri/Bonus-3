using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Guess a Number Game!";
            Console.WriteLine("Welcome to the Guass a Number Game!");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++\n");

            Console.WriteLine("I'm thinking of aw number between 1 and 100.");
            Console.WriteLine("Try to guess it, n00b.\n");

            Console.Write("Enter your lousy guess: ");
            string guessString = Console.ReadLine();

            int guess = isInteger(guessString);
            if (guess == -1)
            {
                return;
            }

            Console.WriteLine(guess);
        }

        static public int isInteger(string guessString)
        {
            int guess;
            if (!int.TryParse(guessString, out guess))
            {
                Console.WriteLine("Error: Input is not an integer");
                return -1;
            }
            return guess;
        }
    }
}
