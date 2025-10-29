
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        bool playAgain = true;

        while (playAgain)
        {
            {
                Console.Write("What is the magic number? ");
                int Number = int.Parse(Console.ReadLine());
                int guess = -1;

                while (guess != Number)
                {
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());

                    if (guess < Number)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > Number)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                    }
                }
            }

            {
                Random randomGenerator = new Random();
                int magicNumber = randomGenerator.Next(1, 101);
                int userGuess = -1;

                while (userGuess != magicNumber)
                {
                    Console.Write("What is your guess? ");
                    userGuess = int.Parse(Console.ReadLine());

                    if (magicNumber > userGuess)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (magicNumber < userGuess)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                    }
                }
            }

            Console.Write("Would you like to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            while (response != "yes" && response != "no")
            {
                Console.Write("Invalid input. Please enter 'yes' or 'no': ");
                response = Console.ReadLine().ToLower();
            }

            playAgain = response == "yes";
        }
    }
}

