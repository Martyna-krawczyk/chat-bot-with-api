using System;
using Newtonsoft.Json;
using static ChatBot.Jokes;

namespace ChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi!");

            Console.WriteLine("What joke category would you like?");
            string category = Console.ReadLine();
            ReturnAJoke(category);

            static void ReturnAJoke(string category)
            {
                string wordJSON = WebAndJSON.AccessJokes(category);

                RootObject APIResults = JsonConvert.DeserializeObject<RootObject>(wordJSON);

                Console.WriteLine(APIResults.joke);
            }
        }
    }
}
