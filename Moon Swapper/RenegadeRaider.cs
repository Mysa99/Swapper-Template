using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Moon_Swapper.Swapper;

namespace Moon_Swapper
{
    public partial class RenegadeRaider : Form
    {
        private long offset1 = 76000000;
        public RenegadeRaider()
        {
            InitializeComponent();
        }
        private static byte[] blabla1 = new byte[]
        {
         47,71,97,109,101,47,65,116,104,101,110,97,47,73,116,101,109,115,47,67,111,115,109,101,116,105,99,115,47,67,104,97,114,97,99,116,101,114,115,47,67,73,68,95,53,55,48,95,65,116,104,101,110,97,95,67,111,109,109,97,110,100,111,95,77,95,83,108,117,114,112,77,111,110,115,116,101,114,46,67,73,68,95,53,55,48,95,65,116,104,101,110,97,95,67,111,109,109,97,110,100,111,95,77,95,83,108,117,114,112,77,111,110,115,116,101,114
        };
        private static byte[] blabla2 = new byte[]
        {
         47,71,97,109,101,47,65,116,104,101,110,97,47,73,116,101,109,115,47,67,111,115,109,101,116,105,99,115,47,67,104,97,114,97,99,116,101,114,115,47,67,73,68,95,48,50,56,95,65,116,104,101,110,97,95,67,111,109,109,97,110,100,111,95,70,46,67,73,68,95,48,50,56,95,65,116,104,101,110,97,95,67,111,109,109,97,110,100,111,95,70,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };
        string filePath = Options.GetPaksFolder + "/pakchunk0-WindowsClient.pak";

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            ThreadHelperClass.SetText(this, richTextBox1, "Start Converting...");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Stream stream = File.OpenRead(filePath);
            try
            {
                foreach (long offset in Researcher.FindPosition(stream, 0, offset1, blabla1))
                {
                    stream.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(filePath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.Write(blabla2);
                    binaryWriter.Close();
                    ThreadHelperClass.SetText(this, richTextBox1, "Skin Sucfully Swapped!");
                    MessageBox.Show("Done!");
                }
            }
            finally
            {
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            Stream stream = File.OpenRead(filePath);
            try
            {
                foreach (long offset in Researcher.FindPosition(stream, 0, offset1, blabla2))
                {
                    stream.Close();
                    BinaryWriter binaryWriter = new BinaryWriter(File.Open(filePath, FileMode.Open, FileAccess.ReadWrite));
                    binaryWriter.Write(blabla2);
                    binaryWriter.Close();
                    ThreadHelperClass.SetText(this, richTextBox1, "Skin Sucfully Reverted!");
                    MessageBox.Show("Done!");
                }
            }
            finally
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker2.RunWorkerAsync();
            ThreadHelperClass.SetText(this, richTextBox1, "Start Reverting...");
        }

        private void RenegadeRaider_Load(object sender, EventArgs e)
        {

        }
    }
    }

