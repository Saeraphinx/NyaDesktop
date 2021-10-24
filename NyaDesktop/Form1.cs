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

namespace NyaDesktop
{
    public partial class Form1 : Form
    {

        bool sfw;
        string save_path = "";
        string curr_image_url = "";
        WebClient webclient = new WebClient();
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox1.SelectedItem == "sfw")
            {
                sfw_comboBox.Enabled = true;
                sfw_comboBox.Visible = true;
                nsfw_comboBox.Enabled = false;
                nsfw_comboBox.Visible = false;
                sfw = true;
            } else if ((string)comboBox1.SelectedItem == "nsfw")
            {
                nsfw_comboBox.Enabled = true;
                nsfw_comboBox.Visible = true;
                sfw_comboBox.Enabled = false;
                sfw_comboBox.Visible = false;
                sfw = false;
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
            } else { return "broke"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                save_path = folderBrowserDialog1.SelectedPath;
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(curr_image_url);
            string savefile = save_path + "\\" + curr_image_url.Substring(curr_image_url.IndexOf(".pics") + 6);
            webclient.DownloadFileAsync(uri, savefile);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string endpoint = getEndPoint();
            string type = (string)comboBox1.SelectedItem;
            curr_image_url = Task.Run(() => NyaAPI.PullNyaImageURL(type, endpoint)).Result;
            pictureBox1.Load(curr_image_url);
            Form1.ActiveForm.Refresh();
        }
    }
}
