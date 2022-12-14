using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(a_in.Text);
                float b = float.Parse(b_in.Text);
                float c = float.Parse(c_in.Text);
                if ((a < 0) || (b < 0) || (c < 0))
                {
                    MessageBox.Show("Введите положительные числа");
                }
                else
                {
                    if ((a + b > c) && (a + c > b) && (b + c > a))
                    {
                        res_textBox.Text = "Существует";
                    }
                    else
                    {
                        res_textBox.Text = "Не существует";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
    }
}
