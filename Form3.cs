using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 0;
            dataGridView1.ColumnCount = 3;
            try
            {
                float a = float.Parse(a_in.Text);
                float b = float.Parse(b_in.Text);
                float c = float.Parse(c_in.Text);
                float d = float.Parse(d_in.Text);
                float f = float.Parse(e_in.Text);
                float[] floatArray = { a, b, c, d, f };

                for (int i = 0; i < floatArray.Length; i++)
                {
                    float elem = floatArray[i];
                    string float_str = elem.ToString();
                    string part = Num_handler(float_str);

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = Math.Abs((int)elem).ToString();
                    dataGridView1.Rows[i].Cells[1].Value = part;
                    if (elem >= 0)
                    {
                        dataGridView1.Rows[i].Cells[2].Value = "0";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[2].Value = "1";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода");
            }
        }
        private string Num_handler(string float_str)
        {
            string temp = "";
            int index = float_str.IndexOf(",");
            if (index != -1)
            {
                for (int j = 0; j < float_str.Length; j++)
                {
                    if (j > index)
                    {
                        temp += float_str[j];
                    }
                }
            }
            while (temp.Length < 5)
            {
                temp += "0";
            }
            if (temp.Length > 5)
            {
                temp = temp.Substring(0, 5);
            }
            return temp;
        }
    }
}
