using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using DiscordRPC;

namespace NyaDesktop
{
    public partial class Form1 : Form
    {
        string curr_image_url = "";
        string save_path = "";
        int saveCount = 0, nyaCount = 0;
        readonly WebClient webclient = new WebClient();
        readonly DiscordRpcClient DiscordClient;
        string emergcencySave = "";

        public Form1(DiscordRpcClient client)
        {
            InitializeComponent();
            DiscordClient = client;
            DiscordClient.Initialize();
            updatePrecense();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "sfw")
            {
                sfw_comboBox.Enabled = true;
                sfw_comboBox.Visible = true;
                nsfw_comboBox.Enabled = false;
                nsfw_comboBox.Visible = false;
            }
            else if ((string)comboBox1.SelectedItem == "nsfw")
            {
                nsfw_comboBox.Enabled = true;
                nsfw_comboBox.Visible = true;
                sfw_comboBox.Enabled = false;
                sfw_comboBox.Visible = false;
            }
        }
        private string getEndPoint()
        {
            if ((string)comboBox1.SelectedItem == "sfw")
            {
                return (string)sfw_comboBox.SelectedItem;
            }
            else if ((string)comboBox1.SelectedItem == "nsfw")
            {
                return (string)nsfw_comboBox.SelectedItem;
            }
            else { return "broke"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                save_path = folderBrowserDialog1.SelectedPath;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Uri uri = new Uri(curr_image_url);
                emergcencySave = curr_image_url;
                string savefile = save_path + "\\" + curr_image_url.Substring(curr_image_url.IndexOf(".pics") + 6);
                //throw new Exception("I Failed for no reason.");
                webclient.DownloadFileAsync(uri, savefile);
                saveCount++;
            }
            catch
            {
                notifyIcon1.ShowBalloonTip(10000, "The Download Failed", "The URL of the image is " + emergcencySave, ToolTipIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string endpoint = getEndPoint();
                string type = (string)comboBox1.SelectedItem;
                curr_image_url = Task.Run(() => NyaAPI.PullNyaImageURL(type, endpoint)).Result;
                pictureBox1.Load(curr_image_url);
            }
            catch
            {
                pictureBox1.Load("https://cdn.discordapp.com/attachments/839294618062553098/901663348280684604/API_Error.png");
            }
            nyaCount++;
            updatePrecense();

            if(nyaCount%10 == 9)
            {
                GC.Collect();
            }

            contextMenuStrip1.Items.Add(curr_image_url);
            if(contextMenuStrip1.Items.Count >= 10)
            {
                contextMenuStrip1.Items.Remove(contextMenuStrip1.Items[0]);
            }

        }

        private void ProgramCloser(object sender, FormClosedEventArgs e)
        {
            Program.ProgramCloser();
        }

        private void updatePrecense()
        {
            DiscordClient.SetPresence(new RichPresence()
            {
                Details = "Save Count: " +saveCount,
                State = "Nya Count: " + nyaCount,
                Assets = new Assets()
                {
                    LargeImageKey = "favicon-1",
                    LargeImageText = "using waifu.pics",
                }
            });
        }
    }
}
