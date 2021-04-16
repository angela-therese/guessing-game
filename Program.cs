using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Let's play a guessing game!");
            Console.WriteLine("I have a secret! It's a number. Can you guess the secret number?");

            int secretNumber = new Random().Next(1, 100);
            string guess = Console.ReadLine();
            int guessValue;
            bool success = int.TryParse(guess, out guessValue);


            if (success)
            {
                int allowedTries = 4;
                int numberOfTries = 0;

                while (true)
                {
                    numberOfTries++;

                    if (guessValue > secretNumber)
                    {
                        Console.WriteLine($"Nope, Too high! Try again! You have {allowedTries - numberOfTries}  tries left.");
                        guess = Console.ReadLine();
                        success = int.TryParse(guess, out guessValue);
                    }
                    if (guessValue < secretNumber)
                    {
                        Console.WriteLine($"Nope, too low! Try again! You have {allowedTries - numberOfTries} tries left.");
                        guess = Console.ReadLine();
                        success = int.TryParse(guess, out guessValue);
                    }
                
                    if (guessValue == secretNumber)
                    {
                        Console.WriteLine($"The answer was {secretNumber}! How'd you know that?");
                        break;
                    }
                    if (numberOfTries == allowedTries -1)
                    {
                        Console.WriteLine($"I'm sorry, you've run out of tries! The number was {secretNumber}");
                        break;
                    }

                }

            }
            else
            {
                Console.WriteLine($"Numbers only, please.");
            }

        }

    }
}

//  string level = Console.ReadLine();
//             if (level != "E" && level != "M" && level != "D")
//             {
//                 Console.WriteLine("Invalid response. Which level do you want? E, M, or D?");
//                 level = Console.ReadLine();
//             }
