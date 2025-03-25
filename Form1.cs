using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Silly : Form
    {
        public Silly()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=QEarTWhsL44");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=UnktCDi-BVs");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Shutdown, -s -t 00");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@TheSillyHaxor");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
            System.Diagnostics.Process.Start("calc.exe");
            System.Diagnostics.Process.Start("calc.exe");
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void button8_Click(object sender, EventArgs e)
        {
                System.Diagnostics.Process.Start("calc.exe");
                System.Diagnostics.Process.Start("cmd.exe");
                System.Diagnostics.Process.Start("notepad.exe");
                System.Diagnostics.Process.Start("powershell.exe");
                System.Diagnostics.Process.Start("mspaint.exe");
                System.Diagnostics.Process.Start("msedge.exe");
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=o527mub_kDY");
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=HhN4wdpbPrg");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=HhN4wdpbPrg");
        }

        private int ClickCount = 0;

        private void button10_Click(object sender, EventArgs e)
        {
            ClickCount++;

            switch (ClickCount)
            {
                case 1:
                    MessageBox.Show("Hey don't click me >:c");
                    break;
                case 2:
                    MessageBox.Show("I told you to not click me >:(");
                    break;
                case 3:
                    MessageBox.Show("I'm warning you >:[");
                    break;
                case 4:
                    MessageBox.Show("I'm going to crash your computer if you click me again...");
                    break;
                case 5:
                    MessageBox.Show("Good job you broke it dummy! >:(");
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=S3vIoXflw5k");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=6MjoD6D5wMc");
        }
    }
}

