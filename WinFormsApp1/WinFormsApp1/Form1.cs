using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        double x, y;
        string islem;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtbox1.Text == "0")
            {
                txtbox1.Text = "1";
            }
            else
            {
                txtbox1.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtbox1.Text == "0")
            {
                txtbox1.Text = "2";
            }
            else
            {
                txtbox1.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtbox1.Text == "0")
            {
                txtbox1.Text = "3";
            }
            else
            {
                txtbox1.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtbox1.Text == "0")
            {
                txtbox1.Text = "4";
            }
            else
            {
                txtbox1.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtbox1.Text == "0")
            {
                txtbox1.Text = "5";
            }
            else
            {
                txtbox1.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtbox1.Text == "0")
            {
                txtbox1.Text = "6";
            }
            else
            {
                txtbox1.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtbox1.Text == "0")
            {
                txtbox1.Text = "7";
            }
            else
            {
                txtbox1.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtbox1.Text == "0")
            {
                txtbox1.Text = "8";
            }
            else
            {
                txtbox1.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtbox1.Text == "0")
            {
                txtbox1.Text = "9";
            }
            else
            {
                txtbox1.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtbox1.Text == "0")
            {
                txtbox1.Text = "0";
            }
            else
            {
                txtbox1.Text += "0";
            }
        }

        private void btnbackspace_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtbox1.Text) > 0)
            {
                txtbox1.Text = txtbox1.Text.Remove(txtbox1.TextLength - 1, 1);
                if (txtbox1.Text.Length == 0)
                {
                    txtbox1.Text = "0";
                }
            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtbox1.Text);
            islem = "+";
            label1.Text = txtbox1.Text + "+";
            txtbox1.Text = "0";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            y = Convert.ToDouble(txtbox1.Text);
            if (islem == "+")
            {
                txtbox1.Text = Convert.ToString(x + y);
                label1.Text = "";
            }
            if (islem == "-")
            {
                txtbox1.Text = Convert.ToString(x - y);
                label1.Text = "";
            }
            if (islem == "/")
            {
                txtbox1.Text = Convert.ToString(x / y);
                label1.Text = "";
            }
            if (islem == "*")
            {
                txtbox1.Text = Convert.ToString(x * y);
                label1.Text = "";
            }
            if (islem == "percent")
            {
                txtbox1.Text = Convert.ToString(x % y);
                label1.Text = "";
            }
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtbox1.Text);
            islem = "-";
            label1.Text = txtbox1.Text + "-";
            txtbox1.Text = "0";
        }

        private void btndivision_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtbox1.Text);
            islem = "/";
            label1.Text = txtbox1.Text + "/";
            txtbox1.Text = "0";
        }

        private void vurma_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtbox1.Text);
            islem = "*";
            label1.Text = txtbox1.Text + "*";
            txtbox1.Text = "0";
        }

        private void exponential_Click(object sender, EventArgs e)
        {
            double exp = Convert.ToDouble(txtbox1.Text);
            exp = Math.Pow(exp, 2);
            txtbox1.Text = Convert.ToString(exp);
        }

        private void square_Click(object sender, EventArgs e)
        {
            double sqr = Convert.ToDouble(txtbox1.Text);
            sqr = Math.Sqrt(sqr);
            txtbox1.Text = Convert.ToString(sqr);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double bolumx= Convert.ToDouble(txtbox1.Text);
            bolumx = 1/(bolumx);
            txtbox1.Text = Convert.ToString(bolumx);
        }

        private void btnpercent_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(txtbox1.Text);
            islem = "percent";
            label1.Text = txtbox1.Text + "(prcnt)";
            txtbox1.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtbox1.Text = "0";
            label1.Text = "";
        }
    }
}
