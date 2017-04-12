﻿using System;
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

                    if (checkGuess(guess, random, guessAmount))
                    {
                        if (continueApp())
                        {
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
                Console.WriteLine("Error: Input is not an integer.\n");
                return -1;
            }
            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Error: Input is not between 1 and 100.\n");
                return -1;
            }
            return guess;
        }
        public static bool checkGuess(int guess, int random, int guessAmount)
        {
            guessAmount++;
            if (guess == random)
            {
                Console.WriteLine("You must be seriously amazing slash telepathic!\n");
                return true;
            }
            else if (guess > random)
            {
                Console.WriteLine("Too high! Try again.\n");
                return false;
            }
            else
            {
                Console.WriteLine("Too low, joe. Try again.\n");
                return false;
            }
        }
        public static bool continueApp()
        {
            while (true)
            {
                Console.Write("Try again? (y/n): ");
                string continueInput = Console.ReadLine().ToLower();

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
