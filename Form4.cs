using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int f1 = int.Parse(textBox1.Text);
                int d1 = int.Parse(textBox2.Text);
                int f2 = int.Parse(textBox4.Text);
                int d2 = int.Parse(textBox3.Text);
                int n = int.Parse(textBox5.Text);

                EngMer value1 = new EngMer(f1, d1) * n;
                EngMer value2 = new EngMer(f2, d2) * n;

                textBox1.Text = value1.f.ToString();
                textBox2.Text = value1.d.ToString();
                textBox4.Text = value2.f.ToString();
                textBox3.Text = value2.d.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int f1 = int.Parse(textBox1.Text);
                int d1 = int.Parse(textBox2.Text);
                int f2 = int.Parse(textBox4.Text);
                int d2 = int.Parse(textBox3.Text);
                int n = int.Parse(textBox5.Text);

                EngMer value1 = new EngMer(f1, d1) / n;
                EngMer value2 = new EngMer(f2, d2) / n;

                textBox1.Text = value1.f.ToString();
                textBox2.Text = value1.d.ToString();
                textBox4.Text = value2.f.ToString();
                textBox3.Text = value2.d.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int f1 = int.Parse(textBox1.Text);
                int d1 = int.Parse(textBox2.Text);
                int f2 = int.Parse(textBox4.Text);
                int d2 = int.Parse(textBox3.Text);

                EngMer value1 = new EngMer(f1, d1);
                EngMer value2 = new EngMer(f2, d2);
                EngMer result = value1 + value2;

                textBox6.Text = result.f.ToString();
                textBox7.Text = result.d.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int f1 = int.Parse(textBox1.Text);
                int d1 = int.Parse(textBox2.Text);
                int f2 = int.Parse(textBox4.Text);
                int d2 = int.Parse(textBox3.Text);

                EngMer value1 = new EngMer(f1, d1);
                EngMer value2 = new EngMer(f2, d2);
                EngMer result = value1 - value2;

                textBox6.Text = result.f.ToString();
                textBox7.Text = result.d.ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
    }
}
