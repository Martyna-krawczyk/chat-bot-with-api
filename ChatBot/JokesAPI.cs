using System;
using Newtonsoft.Json;
using System.Net.Http;

namespace ChatBot
{
    public class Jokes
    {
        public class RootObject
        {
            public string joke;
            public string category { get; set; }
        }

        public class WebAndJSON
        {
            public static string chosenCategory;

            public static string AccessJokes(string chosenCategory)
            {
                HttpClient client = new HttpClient();

                var response = client.GetAsync("https://sv443.net/jokeapi/v2/joke/" + chosenCategory + "?type=single?blacklistFlags=nsfw,racist,sexist,religious").Result;

                return response.Content.ReadAsStringAsync().Result;
            }
        }


    }


}
