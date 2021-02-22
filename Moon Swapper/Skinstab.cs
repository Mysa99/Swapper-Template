using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moon_Swapper
{
    public partial class Skinstab : UserControl
    {
        public Skinstab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new RenegadeRaider().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Galaxy_Girl().Show();
        }
    }
}
