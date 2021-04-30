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

namespace Alpers_CDRP_v1._2
{
    public partial class Form1 : Form
    {
        public DiscordRpcClient client;
        public bool Enabled = false;
        public Form1()
        {
            InitializeComponent();
            ClearButton.Enabled = false;
            ClearButton.BackColor = Color.FromArgb(220, 120, 120);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (Enabled)
            {
                Enabled = false;
                client.ClearPresence();
                ClearButton.Enabled = false;
                ClearButton.BackColor = Color.FromArgb(220, 70, 70);
                SetButton.Enabled = true;
                SetButton.BackColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Enabled)
                {
                    Enabled = true;
                    client = new DiscordRpcClient($"{APPID.Text}");
                    client.Initialize();
                    client.SetPresence(new DiscordRPC.RichPresence()
                    {
                        Details = $"{DETAILS.Text}",
                        State = $"{STATE.Text}",
                        Timestamps = Timestamps.Now,
                        Assets = new Assets()
                        {
                            LargeImageKey = $"{ICON.Text}",
                            LargeImageText = $"{LABELLABEL.Text}",
                        }
                    });
                    SetButton.Enabled = false;
                    SetButton.BackColor = Color.FromArgb(100, 100, 100);
                    ClearButton.Enabled = true;
                    ClearButton.BackColor = Color.FromArgb(220, 70, 70);
                }
            }
            catch(System.ArgumentNullException)
            {
                APPID.Text = "Cannot be empty!";
                Enabled = false;
                return;
            }
        }
    }
}
