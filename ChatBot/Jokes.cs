using System;
using Newtonsoft.Json;
using System.Net.Http;

namespace ChatBot
{
    public class Jokes
    {
        public class Flags
        {
            public bool nsfw { get; set; }
            public bool religious { get; set; }
            public bool political { get; set; }
            public bool racist { get; set; }
            public bool sexist { get; set; }
        }

        public class RootObject
        {
            public string joke;
            public string category { get; set; }
            public string type { get; set; }
            public int id { get; set; }
            public bool error { get; set; }
            public Flags flags { get; set; }
        }

        public class WebAndJSON
        {
            public static string chosenCategory;

            public static string AccessJokes(string chosenCategory)
            {
                HttpClient client = new HttpClient();

                var response = client.GetAsync("https://sv443.net/jokeapi/v2/joke/" + chosenCategory + "?type=single").Result;

                
                return response.Content.ReadAsStringAsync().Result;
            }
        }


    }


}
