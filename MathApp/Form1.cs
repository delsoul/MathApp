using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);
                double D = (b * b) - (4 * a * c);
                if (D < 0)
                {
                    label1.Text = "Корней нет!!!";
                }
                else if (D == 0)
                {
                    label1.Text = "Ответ х = " + (-b / 2 * a);
                }
                else if (D > 0)
                {
                    double x1 = (-b - Math.Sqrt(D)) / 2 * a;
                    double x2 = (-b + Math.Sqrt(D)) / 2 * a;
                    label1.Text = "Ответ х1, x2 = " + x1 + ", " + x2;
                }
                else
                {
                    label1.Text = "Неверный формат!!!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ой-ой!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
