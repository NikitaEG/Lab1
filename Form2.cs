using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form2 : Form
    {
        public Form2()
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
                if (a > 0)
                {
                    a_out.Text = Math.Pow(a, 2).ToString();
                }
                else
                {
                    a_out.Text = Math.Pow(a, 4).ToString();
                }
                if (b > 0)
                {
                    b_out.Text = Math.Pow(b, 2).ToString();
                }
                else
                {
                    b_out.Text = Math.Pow(b, 4).ToString();
                }
                if (c > 0)
                {
                    c_out.Text = Math.Pow(c, 2).ToString();
                }
                else
                {
                    c_out.Text = Math.Pow(c, 4).ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
    }
}
