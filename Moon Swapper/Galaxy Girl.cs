using System;
using System.IO;
using System.Windows.Forms;
using static Moon_Swapper.Swapper;

namespace Moon_Swapper
{
    public partial class Galaxy_Girl : Form
    {
        public static void ReplaceBytes(string pak, long offset, byte[] bytes)
        {
            BinaryWriter binaryWriter = new BinaryWriter((Stream)File.Open(pak, FileMode.Open, FileAccess.ReadWrite));
            binaryWriter.BaseStream.Seek(offset, SeekOrigin.Begin);
            binaryWriter.Write(bytes);
            binaryWriter.Close();
        }

        public Galaxy_Girl()
        {
            InitializeComponent();
        }

        private static byte[] byte1 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,47,83,107,105,110,115,47,65,117,114,111,114,97,95,71,108,111,119,47,77,97,116,101,114,105,97,108,115,47,77,95,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,95,65,117,114,111,114,97,71,108,111,119,46,77,95,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,95,65,117,114,111,114,97,71,108,111,119
        };

        private static byte[] byte2 = new byte[]
        {
            47,71,97,109,101,47,87,101,97,112,111,110,115,47,70,79,82,84,95,77,101,108,101,101,47,77,97,116,101,114,105,97,108,115,47,77,73,95,70,79,82,84,95,77,101,108,101,101,95,80,105,99,107,95,67,101,108,101,115,116,105,97,108,46,77,73,95,70,79,82,84,95,77,101,108,101,101,95,80,105,99,107,95,67,101,108,101,115,116,105,97,108,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] byte3 = new byte[]
        {
            69,70,111,114,116,67,117,115,116,111,109,71,101,110,100,101,114,58,58,70,101,109,97,108,101
        };

        private static byte[] byte4 = new byte[]
        {
            69,70,111,114,116,67,117,115,116,111,109,71,101,110,100,101,114,58,58,68,101,120,120,101,121
        };

        private static byte[] byte5 = new byte[]
        {
47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,47,83,107,105,110,115,47,65,117,114,111,114,97,95,71,108,111,119,47,77,97,116,101,114,105,97,108,115,47,70,95,77,69,68,95,67,111,109,109,97,110,100,111,95,72,101,97,100,95,48,49,95,65,117,114,111,114,97,71,108,111,119,46,70,95,77,69,68,95,67,111,109,109,97,110,100,111,95,72,101,97,100,95,48,49,95,65,117,114,111,114,97,71,108,111,119
        };

        private static byte[] byte6 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,77,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,77,95,77,101,100,95,83,111,108,100,105,101,114,95,48,52,47,83,107,105,110,115,47,71,97,108,97,120,121,47,77,97,116,101,114,105,97,108,115,47,77,95,77,69,68,95,72,73,83,95,83,112,97,114,107,115,95,72,101,97,100,95,67,101,108,101,115,116,105,97,108,46,77,95,77,69,68,95,72,73,83,95,83,112,97,114,107,115,95,72,101,97,100,95,67,101,108,101,115,116,105,97,108,0,0,0,0,0,0,0,0,0,0,0
        };

        private static byte[] byte7 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,70,101,109,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,70,95,77,101,100,95,83,111,108,100,105,101,114,95,48,49,47,83,107,105,110,115,47,65,117,114,111,114,97,95,71,108,111,119,47,77,97,116,101,114,105,97,108,115,47,70,95,77,69,68,95,67,111,109,109,97,110,100,111,95,72,97,105,114,95,48,49,95,65,117,114,111,114,97,71,108,111,119,46,70,95,77,69,68,95,67,111,109,109,97,110,100,111,95,72,97,105,114,95,48,49,95,65,117,114,111,114,97,71,108,111,119
        };

        private static byte[] byte8 = new byte[]
        {
            47,71,97,109,101,47,67,104,97,114,97,99,116,101,114,115,47,80,108,97,121,101,114,47,77,97,108,101,47,77,101,100,105,117,109,47,66,111,100,105,101,115,47,77,95,77,101,100,95,83,111,108,100,105,101,114,95,48,52,47,83,107,105,110,115,47,71,97,108,97,120,121,47,77,97,116,101,114,105,97,108,115,47,77,95,77,69,68,95,72,73,83,95,83,112,97,114,107,115,95,72,97,105,114,95,67,101,108,101,115,116,105,97,108,46,77,95,77,69,68,95,72,73,83,95,83,112,97,114,107,115,95,72,97,105,114,95,67,101,108,101,115,116,105,97,108,0,0,0,0,0,0,0,0,0,0,0
        };

        string filePath = Options.GetPaksFolder + "/pakchunk10_s2-WindowsClient.pak";
        string filePathhead = Options.GetPaksFolder + "/pakchunk10_s3-WindowsClient.pak";
        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            ReplaceBytes(filePath, 1163185213, byte1);
            ReplaceBytes(filePath, 1163185213, byte2);
            richTextBox1.AppendText("\nAdded Body 1/2");
            ReplaceBytes(filePath, 1163185939, byte3);
            ReplaceBytes(filePath, 1163185939, byte4);
            richTextBox1.AppendText("\nAdded Body 2/2");
            ReplaceBytes(filePathhead, 117994517, byte5);
            ReplaceBytes(filePathhead, 117994517, byte6);
            richTextBox1.AppendText("\nAdded Head 1/1");
            ReplaceBytes(filePathhead, 117994219, byte7);
            ReplaceBytes(filePathhead, 117994219, byte8);
            richTextBox1.AppendText("\nAdded Hair 1/1");
            richTextBox1.AppendText("\nDone!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            ReplaceBytes(filePath, 1163185213, byte2);
            ReplaceBytes(filePath, 1163185213, byte1);
            richTextBox1.AppendText("\nRemoved Body 1/2");
            ReplaceBytes(filePath, 1163185939, byte4);
            ReplaceBytes(filePath, 1163185939, byte3);
            richTextBox1.AppendText("\nRemoved Body 2/2");
            ReplaceBytes(filePathhead, 117994517, byte6);
            ReplaceBytes(filePathhead, 117994517, byte5);
            richTextBox1.AppendText("\nRemoved Head 1/1");
            ReplaceBytes(filePathhead, 117994219, byte8);
            ReplaceBytes(filePathhead, 117994219, byte7);
            richTextBox1.AppendText("\nRemoved Hair 1/1");
            richTextBox1.AppendText("\nDone!");
            //now your good to swap we just need to add it to the Usercontrol and to our mainform!
            //credits to Dexxotri
        }

        private void Galaxy_Girl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            ReplaceBytes(filePath, 1163185213, byte1);
            ReplaceBytes(filePath, 1163185213, byte2);
            richTextBox1.AppendText("\nAdded Body 1/2");
            ReplaceBytes(filePath, 1163185939, byte3);
            ReplaceBytes(filePath, 1163185939, byte4);
            richTextBox1.AppendText("\nAdded Body 2/2");
            ReplaceBytes(filePathhead, 117994517, byte5);
            ReplaceBytes(filePathhead, 117994517, byte6);
            richTextBox1.AppendText("\nAdded Head 1/1");
            ReplaceBytes(filePathhead, 117994219, byte7);
            ReplaceBytes(filePathhead, 117994219, byte8);
            richTextBox1.AppendText("\nAdded Hair 1/1");
            richTextBox1.AppendText("\nDone!");
            MessageBox.Show("Done Swapping! Galaxy Girl, Thank you for Using Moon Swapper! (Join Our Discord here: https://discord.gg/UBMDXnZcM8)");
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }
    }
}