using System;
using Newtonsoft.Json;
using static ChatBot.JokesMethods;
using static ChatBot.Game;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hi there! Welcome to the weirdest chatbot you've likely ever used");
            Console.WriteLine("How are you feeling today?");
            string feeling = Console.ReadLine();

            if (feeling.Contains("great") || feeling.Contains("good") || feeling.Contains("ok") || feeling.Contains("fine") || feeling.Contains("excellent") || feeling.Contains("not bad"))
            {
                Console.WriteLine("That's great news! >_< ");
                Console.WriteLine("Would you like to play a game?");

                if (Console.ReadLine() == "yes")
                {
                    GameOn();
                } else
                {
                Console.WriteLine("That's fair enough, It's a lame game anyway!");
                }
            }
            else
            {
                Console.WriteLine("Sounds like you need some cheering up!");
                RunJokesApp();

            }

        }
    }
}
