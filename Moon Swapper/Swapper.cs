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

namespace Moon_Swapper
{
    public partial class Swapper : Form
    {
        private static void DiscordRPC(string Tab)
        {
            Swapper.presence.details = "MoonFN ";
            
            Swapper.presence.startTimestamp = Swapper.opened;
            Swapper.presence.largeImageKey = "https://cdn.discordapp.com/attachments/807905560657395752/812594165187739648/moonpaper.png";
            Swapper.presence.largeImageText = "MoonFN";
            Swapper.presence.smallImageKey = "Lol";
            Swapper.presence.smallImageText = "Made by Storm & X23.";
            DiscordRpc.UpdatePresence(ref Swapper.presence);
        }
        public Swapper()
        {
            InitializeComponent();
        }
        private static DiscordRpc.RichPresence presence;

        // Token: 0x04000044 RID: 68
        public static DiscordRpc.EventHandlers handlers;
        private static long opened { get; set; }
        public static class ThreadHelperClass
        {
            delegate void SetTextCallback(Form f, Control ctrl, string text);

            public static void SetText(Form form, Control ctrl, string text)
            {
                if (ctrl.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    form.Invoke(d, new object[] { form, ctrl, text });
                }
                else
                {
                    ctrl.Text = text;
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome To Moon Swapper! Please use this Swapper in *OLDER CLIENTS* of Fortnite Or you Risk a ban. If you have any bugs Make Sure to Report them in Our Discord.", "Moon Swapper");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            new Options().Show();
        }

        private void renegade1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Swapper_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hold Up! before you Continue DO NOT SWAP ANY ITEM ON YOUR MAIN FORTNITE FILES, IT COULD BAN YOU FOREVER. USE AN OLDER FORTNITE CLIENT!", "Warning");
            MessageBox.Show("This is the LAST Warning!", "Warning");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.skinstab1.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.skinstab1.Hide();
            MessageBox.Show("This Swapper is in Pre-release And for now Only Skins are avaible. Tommorow  we will Add Pickaxes and a bit more Skins!", "MoonFN Pre-release");
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new RenegadeRaider().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Storm & X23. Currently We are In Pre-release, Theres many bugs!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Swapper is in Pre-release And for now Only Skins are avaible. Tommorow  we will Add Pickaxes and a bit more Skins!", "MoonFN Pre-release");
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Text)
            {
                label3.Text = textBox1.Text;
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "Storm")
            {
                label3.Text = textBox1.Text;
            }
            else
            {
                MessageBox.Show("This User does not Exist! Create a new Account On The Login & Sign Up page.", "Invalid Username");
            }
        }
    }
}
