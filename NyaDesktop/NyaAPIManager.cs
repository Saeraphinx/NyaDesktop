using DiscordRPC;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyaDesktop
{
    static class NyaAPIManager
    {
        public static DiscordRpcClient DiscordClient { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            startRichPrecense();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(DiscordClient));
        }

        public static void startRichPrecense()
        {
            DiscordClient = new DiscordRpcClient("901892124679741541");  //Creates the client
        }

        public static void ProgramCloser()
        {
            DiscordClient.Dispose();
        }
    }
}
