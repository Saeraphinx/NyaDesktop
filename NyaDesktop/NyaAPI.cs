using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NyaDesktop
{
    class NyaAPI
    {
        private static readonly HttpClient client = new HttpClient();

        // HttpClient is intended to be instantiated once per application, rather than per-use. See Remarks.
        public static async Task<String> PullNyaImageURL(string type, string endpoint)
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            try
            {
                HttpResponseMessage response = await client.GetAsync(@"https://api.waifu.pics/" + type + "/" + endpoint);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                int sIn = responseBody.IndexOf(":") + 2;
                int length = responseBody.LastIndexOf("}") - 1 - sIn;
                string url = responseBody.Substring(sIn, length);

                //string url = responseBody.Substring(responseBody.IndexOf(":") + 2, responseBody.LastIndexOf("}") - 3);
                return url;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return "https://cdn.discordapp.com/attachments/839294618062553098/901663348280684604/API_Error.png";
            }
        }
    }
}
