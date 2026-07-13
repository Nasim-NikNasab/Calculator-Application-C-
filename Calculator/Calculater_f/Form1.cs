using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculater_f
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1 = 0.0;

        double n2 = 0.0;
        double result = 0.0;
        char operatorr = '0';
        double n11 = 0.0;
        double n12 = 0.0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Visible = false;
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
            else
            {
                if (textBox1.Text.Length <= 1)
                {
                    textBox1.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            if (n1 >= 0)
            {
                result = Math.Sqrt(n1);
                textBox1.Text = "";
                textBox1.Text = result.ToString();
            }
            else { MessageBox.Show("مقدار زیر رادیکال منفی نمیباشد"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operatorr = Convert.ToChar(button12.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operatorr = Convert.ToChar(button13.Text);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(n1, 2);
            textBox1.Text = "";
            textBox1.Text = result.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (n1 == null)
            {
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text += '.';
            }
            if (n1 != null)
            {
                n2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text += '.';
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operatorr = Convert.ToChar(button14.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operatorr = Convert.ToChar(button20.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (n1 == null)
            {
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(n1 * (-1));
            }
            if (n1 != null)
            {
                n2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(n2 * (-1));
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operatorr = Convert.ToChar(button11.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            switch (operatorr)
            {
                case '➕':
                    result = n1 + n2;
                    textBox1.Text = result.ToString();
                    break;

                case '➖':
                    result = n1 - n2;
                    textBox1.Text = result.ToString();
                    break;

                case '➗':
                    if (n2 != 0)
                    {
                        result = n1 / n2;
                        textBox1.Text = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("! بر صفر ممکن نیست");
                    }

                    break;

                case '✖':
                    result = n1 * n2;
                    textBox1.Text = result.ToString();
                    break;

                case '%':
                    result = n1 % n2;
                    textBox1.Text = result.ToString();
                    break;
            }    }
    }
}
