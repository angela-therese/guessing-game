using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Let's play a guessing game!");
            Console.Write("Choose a level:");
            Console.Write("easy, medium, or hard.  ");
            string level = Console.ReadLine();
            int allowedTries;

            if (level == "easy")
            {
                allowedTries = 8;
            }
            else if (level == "medium")
            {
                allowedTries = 6;
            }
            else if (level == "hard")
            {
                allowedTries = 4;
            }
            else
            {

                Console.WriteLine("Not a choice. Game over.");
                allowedTries = 0;
            }


            Console.WriteLine("I have a secret! It's a number. Can you guess the secret number?");
            int secretNumber = new Random().Next(1, 100);
            int guess = Convert.ToInt32(Console.ReadLine());


            int numberOfTries = 0;

            while (true)
            {
                
                numberOfTries++;

                if (numberOfTries == allowedTries)
                {
                    Console.WriteLine($"I'm sorry, you've run out of tries! The number was {secretNumber}.");
                    break;
                }

                else if (guess > secretNumber)
                {

                    Console.WriteLine($"Nope, too high! Try again! You have {allowedTries - numberOfTries}  tries left.");
                    guess = Convert.ToInt32(Console.ReadLine());

                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine($"Nope, too low! Try again! You have {allowedTries - numberOfTries} tries left.");
                    guess = Convert.ToInt32(Console.ReadLine());

                }

                else if (guess == secretNumber)
                {
                    Console.WriteLine($"The answer was {secretNumber}! How'd you know that?");
                    break;
                }


            }

        }


    }

}





// if (success)

// int allowedTries = 4;
// string guess = Console.ReadLine();
// int guessValue;
// bool success = int.TryParse(guess, out guessValue);
// string level = "E";

// else
// {
//     Console.WriteLine("Sorry, that's not a number. Game over!");
// }
// success = int.TryParse(guess, out guessValue);
// success = int.TryParse(guess, out guessValue);