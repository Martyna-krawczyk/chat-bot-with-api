using System;
using Newtonsoft.Json;
using System.Net.Http;
using static ChatBot.Jokes;

namespace ChatBot
{
    public class JokesMethods
    {
        public enum Categories
        {
            Any,
            Programming,
            Miscellaneous
        }
        public static void RunJokesApp()
        {
            Console.WriteLine("What joke category would you like?");

            string[] categoryArray = Enum.GetNames(typeof(Categories));

                for (int i = 0; i < categoryArray.Length; i++)
                {
                    Console.WriteLine($"Please type {i} for {categoryArray[i]}");
                }
            

            string selection = Console.ReadKey(true).KeyChar.ToString();
            int intSelection = Convert.ToInt32(selection);

            string stringCategories = Convert.ToString(intSelection);

            if (intSelection > 2) {
                Console.WriteLine("Sorry, that is not a valid option.");
                RunJokesApp();
            }
            Console.WriteLine("Just one moment whilst we load your joke!");
            ReturnAJoke(((Categories)intSelection).ToString());



            static void ReturnAJoke(string category)
            {
                string wordJSON = WebAndJSON.AccessJokes(category);

                RootObject APIResults = JsonConvert.DeserializeObject<RootObject>(wordJSON);

                Console.WriteLine(APIResults.joke);
            }
        }
    }
}
