using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\resources\1_1.jpg");
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\resources\1_2.jpg");
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\resources\1_3.jpg");
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\resources\1_4.jpg");
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"..\..\resources\1_5.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f2 = new Form2();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            f5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f6 = new Form6();
            f6.Show();
        }
    }
}
