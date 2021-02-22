using Microsoft.WindowsAPICodePack.Dialogs;
using Moon_Swapper.Properties;
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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Settings.Default.paksPath = dialog.FileName;
                Settings.Default.Save();
                textBox1.Text = Settings.Default.paksPath;
            }
        }

        public static string GetPaksFolder
        {
            get { return Settings.Default.paksPath; }
        }



        public static string GetStrechedFolder
        {
            get { return Settings.Default.strechedFolder; }
        }

    }
    }

