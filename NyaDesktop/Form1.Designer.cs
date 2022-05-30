
namespace NyaDesktop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSaveDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endpointToolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.SFWToolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.serviceToolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(84, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 1;
            this.button2.Text = "Save Image";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(165, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 21);
            this.button3.TabIndex = 2;
            this.button3.Text = "Nya";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(12, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 23);
            this.panel1.TabIndex = 9;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Nya";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowImageMargin = false;
            this.contextMenuStrip1.Size = new System.Drawing.Size(36, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem,
            this.endpointToolStripComboBox2,
            this.SFWToolStripComboBox1,
            this.serviceToolStripComboBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 328);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 27);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSaveDirectoryToolStripMenuItem});
            this.SettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.SettingsToolStripMenuItem.Text = "Settings";
            // 
            // setSaveDirectoryToolStripMenuItem
            // 
            this.setSaveDirectoryToolStripMenuItem.Name = "setSaveDirectoryToolStripMenuItem";
            this.setSaveDirectoryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setSaveDirectoryToolStripMenuItem.Text = "Set Save Directory";
            this.setSaveDirectoryToolStripMenuItem.Click += new System.EventHandler(this.setSaveDirectoryToolStripMenuItem_Click);
            // 
            // endpointToolStripComboBox2
            // 
            this.endpointToolStripComboBox2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.endpointToolStripComboBox2.BackColor = System.Drawing.Color.Black;
            this.endpointToolStripComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.endpointToolStripComboBox2.ForeColor = System.Drawing.Color.White;
            this.endpointToolStripComboBox2.Name = "endpointToolStripComboBox2";
            this.endpointToolStripComboBox2.Size = new System.Drawing.Size(75, 23);
            // 
            // SFWToolStripComboBox1
            // 
            this.SFWToolStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.SFWToolStripComboBox1.BackColor = System.Drawing.Color.Black;
            this.SFWToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SFWToolStripComboBox1.ForeColor = System.Drawing.Color.White;
            this.SFWToolStripComboBox1.Items.AddRange(new object[] {
            "sfw",
            "nsfw"});
            this.SFWToolStripComboBox1.Name = "SFWToolStripComboBox1";
            this.SFWToolStripComboBox1.Size = new System.Drawing.Size(75, 23);
            // 
            // serviceToolStripComboBox1
            // 
            this.serviceToolStripComboBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.serviceToolStripComboBox1.BackColor = System.Drawing.Color.Black;
            this.serviceToolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serviceToolStripComboBox1.ForeColor = System.Drawing.Color.White;
            this.serviceToolStripComboBox1.Name = "serviceToolStripComboBox1";
            this.serviceToolStripComboBox1.Size = new System.Drawing.Size(100, 23);
            this.serviceToolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.serviceToolStripComboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(426, 355);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(442, 372);
            this.Name = "Form1";
            this.Text = "Nya";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProgramCloser);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSaveDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox endpointToolStripComboBox2;
        private System.Windows.Forms.ToolStripComboBox SFWToolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox serviceToolStripComboBox1;
    }
}

