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
        bool nsfw = false;
        NyaAPI.Endpoint currEndpoint;

        public Form1(DiscordRpcClient client)
        {
            InitializeComponent();
            DiscordClient = client;
            DiscordClient.Initialize();
            updatePrecense();
            if (Properties.Settings.Default.path != "")
            {
                save_path = Properties.Settings.Default.path;
            }
            LoadEndpointInfo();

        }

        public void LoadEndpointInfo(){
            NyaAPI.LoadEndpoints();
            NyaAPI.endpoints.ForEach(x => {
                serviceToolStripComboBox1.Items.Add(x.name);
            });
            SFWToolStripComboBox1.SelectedIndex = 0;
            serviceToolStripComboBox1.SelectedIndex = 0;
            endpointToolStripComboBox2.SelectedIndex = 0;

        }

        private void serviceToolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            endpointToolStripComboBox2.Items.Clear();
            NyaAPI.endpoints.ForEach(x => {
                currEndpoint = x;
                if (x.name == serviceToolStripComboBox1.SelectedItem.ToString()) {
                    endpointToolStripComboBox2.Items.Clear();
                    
                    if (SFWToolStripComboBox1.SelectedItem.ToString() == "nsfw") {
                        x.NsfwEndpoints.ForEach(y => {
                            endpointToolStripComboBox2.Items.Add(y);
                        });
                        nsfw = true;
                    } else {
                        x.SfwEndpoints.ForEach(y => {
                            endpointToolStripComboBox2.Items.Add(y);
                        });
                        nsfw = false;
                    }
                }
            });
            endpointToolStripComboBox2.SelectedIndex = 0;
        }

        private void setSaveDirectoryToolStripMenuItem_Click(object sender, EventArgs e) {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
                save_path = folderBrowserDialog1.SelectedPath;
                button2.Enabled = true;
                Properties.Settings.Default.path = save_path;
                Properties.Settings.Default.Save();
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
            string endpoint = endpointToolStripComboBox2.SelectedItem.ToString();
            try
            {
                curr_image_url = Task.Run(() => NyaAPI.PullNyaImageURL(currEndpoint, nsfw, endpoint)).Result;
                pictureBox1.Load(curr_image_url);
            }
            catch
            {
                pictureBox1.Load("https://i.imgur.com/5JFEDXs.png");
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
