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

            bool run = true;

            while (run)
            {
                Random randomNumber = new Random();
                int random = randomNumber.Next(1, 100);
                Console.WriteLine("I'm thinking of aw number between 1 and 100.");
                Console.WriteLine("Try to guess it, n00b.\n");

                Console.Write("Enter your lousy guess: ");
                string guessString = Console.ReadLine();

                int guess = isValidInteger(guessString);
                if (guess == -1)
                {
                    return;
                }
                if (guess == random)
                {
                    Console.WriteLine("You must be seriously amazing slash telepathic!\n!");
                    Console.Write("Try again? (y/n): ");
                }
                Console.WriteLine(guess);
            }
        }

        static public int isValidInteger(string guessString)
        {
            int guess;
            if (!int.TryParse(guessString, out guess))
            {
                Console.WriteLine("Error: Input is not an integer");
                return -1;
            }
            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Error: Input is not between 1 and 100");
                return -1;
            }
            return guess;
        }
    }
}
