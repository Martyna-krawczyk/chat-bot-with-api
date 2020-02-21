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
            Dark,
            Miscellaneous
        }
        public static void RunJokesApp()
        {
            string[] categoryArray = Enum.GetNames(typeof(Categories));

            for (int i = 0; i < categoryArray.Length; i++)
            {
                Console.WriteLine($"Please type {i} for {categoryArray[i]}");
            }

            string selection = Console.ReadKey(true).KeyChar.ToString();
            int intSelection = Convert.ToInt32(selection);
            Console.WriteLine("You've selected " + ((Categories)intSelection).ToString());


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
