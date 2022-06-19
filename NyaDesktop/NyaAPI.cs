using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using static System.Windows.Forms.LinkLabel;

namespace NyaDesktop
{
    class NyaAPI
    {
        static readonly HttpClient client = new HttpClient();
        public static List<Endpoint> endpoints;

        public static async Task<String> PullNyaImageURL(Endpoint selectedEndpoint, bool nsfw, string endpoint)
        {
            string Nyaurl = "";
            if (nsfw) {
                Nyaurl = selectedEndpoint.NsfwEndpoint + "/" + endpoint;
            } else {
                Nyaurl = selectedEndpoint.SfwEndpoint + "/" + endpoint;
            }
            try
            {
                HttpResponseMessage response = await client.GetAsync(Nyaurl);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // you know this works for now and i know it's not super cool but idc
                int sIn = responseBody.IndexOf(":") + 2;
                int length = responseBody.LastIndexOf("}") - 1 - sIn;
                string url = responseBody.Substring(sIn, length);
                
                return url;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return "https://i.imgur.com/5JFEDXs.png";
            }
        }

        public static void LoadEndpoints() {
            string temp = NyaDesktop.Properties.Resources.JSONendpoints;
            endpoints = JsonConvert.DeserializeObject<List<Endpoint>>(temp);
        }

        public struct Endpoint {
            public string name;
            public string apiInfo;
            public string SfwEndpoint;
            public string NsfwEndpoint;
            public List<string> SfwEndpoints;
            public List<string> NsfwEndpoints;
        }
    }
}

/*
 *  public static async Task<String> PullNyaImageURL(string type, string endpoint)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(@"https://api.waifu.pics/" + type + "/" + endpoint);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                int sIn = responseBody.IndexOf(":") + 2;
                int length = responseBody.LastIndexOf("}") - 1 - sIn;
                string url = responseBody.Substring(sIn, length);
                
                return url;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return "https://cdn.discordapp.com/attachments/839294618062553098/901663348280684604/API_Error.png";
            }
        }
*/