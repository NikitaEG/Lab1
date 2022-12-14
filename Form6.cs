using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form6 : Form
    {
        int n = 0;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int n = int.Parse(n_in.Text);
                this.n = n;
                dataGridView1.ColumnCount = n;
                dataGridView1.RowCount = n;
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i < j)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = rand.Next(3);
                    }
                    else if (i == j)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = 0;
                    }
                    else if (i > j)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = 2 - (int)dataGridView1.Rows[j].Cells[i].Value;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            int res_count = 0;
            for (int i = 0; i < n; i++)
            {
                int win_count = 0;
                int lose_count = 0;
                bool flag = true;
                for (int j = 0; j < n; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString() == "2")
                    {
                        win_count += 1;
                    }
                    if (i != j)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString() == "0" && (i != j))
                        {
                            lose_count += 1;
                            flag = false;
                        }
                    }
                }
                if (win_count > lose_count)
                {
                    res_count++;    
                }
                if (flag)
                {
                    textBox2.Text += (i + 1).ToString() + " ";
                }
            }
            textBox1.Text = res_count.ToString();
        }
    }
}
