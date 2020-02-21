using System;

namespace ChatBot
{
    public  class Game
    {
        public static void GameOn()
        {

            Console.WriteLine("Awesome!  We're going to play WHAT NUMBER AM I THINKING OF");
            Console.WriteLine("Generating a Random Number");
            Console.WriteLine("I have generated a number between 1 and 100");

            Random random = new Random();
            int goalNumber = random.Next(100) + 1;
            int userGuess = 0;
            int userGuessCount = 0;
            Console.WriteLine(goalNumber);

            while (userGuess != goalNumber)
            {
                Console.Write("Enter your guess: ");
                int.TryParse(Console.ReadLine(), out userGuess);

                if (userGuess < goalNumber) {
                    userGuessCount++;
                    Console.WriteLine($"Your guess of {userGuess} is too low", userGuess);
                } else if (userGuess > goalNumber)
                {
                    userGuessCount++;
                    Console.WriteLine($"Your guess of {userGuess} is too high", userGuess);
                } else
                {
                    Console.WriteLine($"Congratulations!  Your guess of {userGuess} is correct!  You guessed the number in {userGuessCount} attempts");
                }
            }
        }
    }
}
