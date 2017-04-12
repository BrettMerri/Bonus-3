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

            int guessAmount = 0;
            Random rnd = new Random();

            while (true) //infinite loop
            {
                int random = rnd.Next(1, 100);

                Console.WriteLine("I'm thinking of aw number between 1 and 100.");
                Console.WriteLine("Try to guess it, n00b.\n");

                bool correctGuess = false;

                while (!correctGuess)
                {
                    Console.Write("Enter your lousy guess: ");

                    string guessString = Console.ReadLine();

                    int guess = isValidInteger(guessString);
                    if (guess == -1)
                    {
                        continue;
                    }
                    guessAmount++;
                    if (checkGuess(guess, random, guessAmount))
                    {
                        if (continueApp())
                        {
                            guessAmount = 0;
                            correctGuess = true;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }

        public static int isValidInteger(string guessString)
        {
            int guess;
            if (!int.TryParse(guessString, out guess))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Input is not an integer.\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                return -1;
            }
            if (guess < 1 || guess > 100)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Input is not between 1 and 100.\n");
                Console.ForegroundColor = ConsoleColor.Gray;
                return -1;
            }
            return guess;
        }
        public static bool checkGuess(int guess, int random, int guessAmount)
        {
            if (guess == random)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You got it in {0} tries.", guessAmount);
                if (guessAmount == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You must be seriously amazing slash telepathic!\n");
                }
                else if (guessAmount <= 4)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Very good, dog!");
                }
                else if (guessAmount <= 6)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Pretty good, I guess. I bet you can do better, though.");
                }
                else if (guessAmount <= 8)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Decent at best. Give it another go!");
                }
                else if (guessAmount <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Not good... Try again!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("My Granny could do better... Try again!");
                }
                Console.ForegroundColor = ConsoleColor.Gray;

                Console.WriteLine();

                return true;
            }
            else if (guess > random)
            {
                if (guess - 10 > random)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You're crazy high, dog. Try again.\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Too high! Try again.\n");
                }

                Console.ForegroundColor = ConsoleColor.Gray;
                return false;
            }
            else
            {
                if (guess + 10 < random)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You're crazy low, bro. Try again.\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Too low, joe. Try again.\n");
                }
                
                Console.ForegroundColor = ConsoleColor.Gray;
                return false;
            }
        }
        public static bool continueApp()
        {
            while (true)
            {
                Console.Write("Try again? (y/n): ");

                string continueInput = Console.ReadLine().ToLower();

                Console.WriteLine();

                if (continueInput == "y")
                {
                    return true;
                }
                else if (continueInput == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Error: Input is not y or n.\n");
                }
            }
        }
    }
}