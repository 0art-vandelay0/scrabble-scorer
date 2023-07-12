using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("□ □ □ SCRABBLE! □ □ □");
            Console.WriteLine("--------------------- \n ");
            Console.WriteLine("Enter any single word: ");
            string word = Console.ReadLine();
            Console.WriteLine("\n");
            int score = 0;

            try
            {
                ScrabbleScore userScrabbleScore = new ScrabbleScore(word, score);
                Console.WriteLine("Your score is: " + ScrabbleScore.GetScore(word));
                TryAgain();

            }
            catch (Exception ex)
            {
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠  Error processing your input '" + word + "'\n" + ex.Message);
                Console.WriteLine("Please enter a valid word in the form of letters only.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Try again...");
                Console.WriteLine("\n");
                Console.ResetColor();
                Main();
            }
        }

        public static void TryAgain()
        {
            Console.WriteLine("Would you like to try another word? [Y/N]");
            string answer = Console.ReadLine();
            Console.WriteLine("\n");
            if (answer == "Y" || answer == "y")
            {
                Main();
            }
            else if (answer == "N" || answer == "n")
            {
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Please enter Y or N");
                TryAgain();
            }
        }
    }
}