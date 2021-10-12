using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialGuessGame
{
    class Program
    {
        // This is a number guessing game.
        // The program will generate a random number between 1 and 10 and the player will then have to guess the correct number.

        static void Main(string[] args)
        {
            int randomNum;
            int guessedNum = 0;

            Console.WriteLine("Welcome to the number guessing game.");
            Console.WriteLine("A number between 1 and 10 will be generated.");
            Console.WriteLine("If you guessed the correct number, you win!");

            Random random = new Random();

            randomNum = random.Next(1, 11);

            Console.WriteLine("The AI has chosen a number, so let us start.");
            
            while(guessedNum != randomNum)
            {
                Console.WriteLine("Please pick a number");

                guessedNum = int.Parse(Console.ReadLine());         // Weitere Alternative: int guess = Convert.ToInt32(Console.ReadLine());


                if (guessedNum < randomNum)
                {
                    Console.WriteLine("Number too low. Please try again.");
                }
                else if (guessedNum > randomNum)
                {
                    Console.WriteLine("Your number was too high. Please try again.");
                }
            }

            Console.WriteLine("You won. The number was " + randomNum);
            
            Console.ReadKey();          // this is so the user has to do an input, before the window closes.
        }
    }
}
