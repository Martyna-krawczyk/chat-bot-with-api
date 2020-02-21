using System;
using Newtonsoft.Json;
using static ChatBot.JokesMethods;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine((Categories)1);

            Console.WriteLine("Hi There!");

            Console.WriteLine("What joke category would you like?");

            RunJokesApp();

            
        }
    }
}
