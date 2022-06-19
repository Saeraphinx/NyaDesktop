using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace EndpointSetup {
    internal class Program {
        public struct Endpoint {
            public string name;
            public string apiInfo;
            public string SfwEndpoint;
            public string NsfwEndpoint;
            public List<string> SfwEndpoints;
            public List<string> NsfwEndpoints;
        }
        public static List<Endpoint> endpoints = new List<Endpoint>();
        
        static void Main(string[] args) {
            
            endpoints.Add(new Endpoint {
                name = "waifu.pics",
                apiInfo = "url",
                SfwEndpoint = "https://api.waifu.pics/sfw",
                NsfwEndpoint = "https://api.waifu.pics/nsfw",
                SfwEndpoints = new List<string> { "waifu", "neko", "shinobu", "megumin", "bully", "cuddle", "cry", "hug", "awoo", "kiss", "lick", "pat", "smug", "bonk", "yeet", "blush", "smile", "wave", "highfive", "handhold", "nom", "bite", "glomp", "slap", "kill", "kick", "happy", "wink", "poke", "dance", "cringe" },
                NsfwEndpoints = new List<string> { "waifu", "neko", "trap", "blowjob" }
            });
            
            endpoints.Add(new Endpoint {
                name = "nekos.life",
                SfwEndpoint = "https://nekos.life/api/v2/img/",
                NsfwEndpoint = "https://nekos.life/api/v2/img/",
                apiInfo = "url",
                SfwEndpoints = new List<string>
                                    {
                        "neko", "waifu", "tickle", "slap", "pat", "meow", "lizard", "kiss", "hug", "fox_girl","feed", "cuddle", "ngif", "smug", "woof", "wallpaper", "goose", "gecg", "avatar"
                    },
                NsfwEndpoints = new List<string>() { "lewd" }
            });

            endpoints.Add(new Endpoint {
                name = "xsky.dev",
                SfwEndpoint = "https://api.xsky.dev/",
                NsfwEndpoint = "https://api.xsky.dev/",
                apiInfo = "url",
                SfwEndpoints = new List<string> { "neko", "catboy" },
                NsfwEndpoints = new List<string> { "hentai", "bdsm", "furry", "ff", "feet", "trap", "gif", "futa" }
            });

            endpoints.Add(new Endpoint {
                name = "anime-images",
                SfwEndpoint = "https://anime-api.hisoka17.repl.co/img/",
                NsfwEndpoint = "https://anime-api.hisoka17.repl.co/img/",
                apiInfo = "url",
                SfwEndpoints = new List<string> { "hug", "kiss", "slap", "wink", "pat", "kill", "cuddle", "punch", "waifu" },
                NsfwEndpoints = new List<string> { "hentai", "boobs", "lesbian" }
            });





            Console.WriteLine(JsonConvert.SerializeObject(endpoints, Formatting.Indented));
            Console.ReadKey();
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.WriteLine(JsonConvert.SerializeObject(endpoints, Formatting.None));
        }
    }
}
