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
    public partial class Form2 : Form
    {
        double n1 = 0.0;

        double n2 = 0.0;
        double result = 0.0;
        char operatorr = '0';
        double n11 = 1;
        double n12 = 1.0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1.ActiveForm.Visible = true;
            Form1 form1 = new Form1();

            Form2.ActiveForm.Visible = false;
            form1.ShowDialog();
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void button23_Click(object sender, EventArgs e)
        {
            if (operatorr=='0' )
            {
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                if (n1 == 0 || n1 == 1)
                {
                    textBox1.Text = Convert.ToString(1);
                }
                else
                {
                   
                    for (double i =1  ; i <= n1; i++)
                    {
                       n11*= i;
                        
                    }
                     textBox1.Text = Convert.ToString(n11);
                }
               

            }
            if (operatorr!='0')
            {
                n2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                if (n2 == 0 || n2 == 1)
                {
                    textBox1.Text = Convert.ToString(1);
                }
                else
                {
                   for (int i = 1; i <= n2; i++)
                   {
                    
                    n12 *= i;

                   }
                   textBox1.Text = Convert.ToString(n12);
                }
                
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (operatorr == '0')
            {
                n1 = Convert.ToDouble(textBox1.Text);
                if (n1 < 0)
                {
                    textBox1.Text = Convert.ToString(n1 * (-1));
                }

            }
            if (operatorr != '0')
            {
                n2 = Convert.ToDouble(textBox1.Text);
                if (n2 < 0)
                {
                    textBox1.Text = Convert.ToString(n2 * (-1));
                }

            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (operatorr == '0')
            {
                n1 = Convert.ToDouble(textBox1.Text);
                if (n1 == 0) { MessageBox.Show("! بر صفر ممکن نیست"); }
                else {textBox1.Text = Convert.ToString(1 / n1); }
            }
            if (operatorr != '0')
            {
                n2 = Convert.ToDouble(textBox1.Text);
                if (n2 == 0) { MessageBox.Show("! بر صفر ممکن نیست"); }
                else { textBox1.Text = Convert.ToString(1 / n2);}
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operatorr = '^';
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (operatorr == '0')
            {
                n1 = Convert.ToDouble(textBox1.Text);
                if (n1 > 0)
                {
                    textBox1.Text = Convert.ToString(Math.Log(n1));
                }
            }
            if (operatorr != '0')
            {
                n2 = Convert.ToDouble(textBox1.Text);
                if (n2 > 0)
                {
                    textBox1.Text = Convert.ToString(Math.Log(n2));
                }
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (operatorr == '0')
            {
                n1 = Convert.ToDouble(textBox1.Text);
                if (n1 > 0)
                {
                    textBox1.Text = Convert.ToString(Math.Log(n1, 2.7182818284590452353602874713527));
                }
            }
            if (operatorr != '0')
            {
                n2 = Convert.ToDouble(textBox1.Text);
                if (n2 > 0)
                {
                    textBox1.Text = Convert.ToString(Math.Log(n2, 2.7182818284590452353602874713527));
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operatorr = Convert.ToChar(button11.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operatorr = Convert.ToChar(button12.Text);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (operatorr == '0')
            {
                n1 = Convert.ToDouble(textBox1.Text);
                n1 = n1 * (Math.PI / 180.0);
                    textBox1.Text = Convert.ToString(Math.Sin(n1));
                
            }
            if (operatorr != '0')
            {
                n2 = Convert.ToDouble(textBox1.Text);
                n2 = n2 * (Math.PI / 180.0);
                    textBox1.Text = Convert.ToString(Math.Sin(n2));
                
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (operatorr == '0')
            {
                n1 = Convert.ToDouble(textBox1.Text);
                n1 = n1 * (Math.PI / 180.0);
                textBox1.Text = Convert.ToString(Math.Cos(n1));

            }
            if (operatorr != '0')
            {
                n2 = Convert.ToDouble(textBox1.Text);
                n2 = n2 * (Math.PI / 180.0);
                textBox1.Text = Convert.ToString(Math.Cos(n2));

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {

            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operatorr = Convert.ToChar(button13.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operatorr = Convert.ToChar(button14.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
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

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text;
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

                case '^':
                    result = Math.Pow(n1, n2);
                    textBox1.Text = result.ToString();
                    break;

            }
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

        private void button17_Click(object sender, EventArgs e)
        {
            if (operatorr == '0')
            {
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text += '.';
            }
            if (operatorr != '0')
            {
                n2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text += '.';
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (operatorr == '0')
            {
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(n1 * (-1));
            }
            if (operatorr != '0')
            {
                n2 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(n2 * (-1));
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            result = Math.Pow(n1, 2);
            textBox1.Text = "";
            textBox1.Text = result.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            operatorr = Convert.ToChar(button20.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text;
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

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += button10.Text;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void standardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2.ActiveForm.Visible = false;
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void scientificToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1.ActiveForm.Visible = false;
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
