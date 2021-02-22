using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moon_Swapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Swapper().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Storm" && textBox2.Text == "Dev")
            {
                this.Hide();
                new Swapper().Show();
            }
            else
            {
                MessageBox.Show("Oops, there was an Error! Do you have an Account? If yes please try it again If not just click Register.", "Login Error");
            }
            if (textBox1.Text == "X23" && textBox2.Text == "Dev")
            {
                new Swapper().Show();
            }
            else
            {
                MessageBox.Show("Oops, there was an Error! Do you have an Account? If yes please try it again If not just click Register.", "Login Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Make Sure to fill Out all of these Correctly. Please Only Create *ONE* Account!", "Register System Moon Swapper");
            Process.Start("https://forms.gle/v9NwQ3YmHSx8qnRN7");
        }
    }
}
