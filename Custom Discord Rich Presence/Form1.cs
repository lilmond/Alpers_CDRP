using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using DiscordRPC.Logging;

namespace Custom_Discord_Rich_Presence
{
    public partial class Form1 : Form
    {
        public DiscordRpcClient client;
        public bool Initialized = false;
        public bool TimeEnabled = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button2.BackColor = Color.FromArgb(250, 100, 100);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Initialized == false)
            {
                Initialized = true;
                button1.Enabled = false;
                button1.BackColor = Color.FromArgb(90, 90, 90);
                button2.BackColor = Color.FromArgb(250, 50, 50);
                button2.Enabled = true;
                client = new DiscordRpcClient($"{textBox1.Text}");
                client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };
                client.Initialize();
                client.SetPresence(new DiscordRPC.RichPresence()
                {
                    Details = $"{textBox2.Text}",
                    State = $"{textBox3.Text}",
                    Timestamps = Timestamps.Now,
                    Assets = new Assets()
                    {
                        LargeImageKey = $"{textBox4.Text}",
                        LargeImageText = $"{textBox5.Text}",
                        SmallImageKey = "",
                    }
                });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Initialized == true)
            {
                button1.Enabled = true;
                button1.BackColor = Color.FromArgb(50, 50, 50);
                button2.Enabled = false;
                button2.BackColor = Color.FromArgb(250, 100, 100);
                Initialized = false;
                client.ClearPresence();
            }
        }
    }
}
