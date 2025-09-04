using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HardDriveInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Environment.GetLogicalDrives());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            DriveInfo drive = new DriveInfo(comboBox1.SelectedItem.ToString());

            label1.Text = "Drive Name: " + drive.Name;
            label2.Text = "Volume Label: " + drive.VolumeLabel;
            label3.Text = "Drive Type: " + drive.DriveType;
            label4.Text = "Drive Format: " + drive.DriveFormat;
            label5.Text = "Total Size: " + (drive.TotalSize / (1024 * 1024 * 1024)) + " GB";
            label6.Text = "Free Disk Space: " + (drive.TotalFreeSpace / (1024 * 1024 * 1024)) + " GB";
            label7.Text = "Drive Ready: " + drive.IsReady;
        }
    }
}
