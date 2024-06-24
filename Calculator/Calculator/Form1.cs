using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double fstNum, secNum;
        string oper;

        public Calculator()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if(txtDisplay.Text == "0")
            {
                txtDisplay.Text = "7";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "7";  
            }
        }


        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "8";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "9";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "9";
            }
        }

        private void bnt4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "4";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "5";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "6";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "6";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "1";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "2";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "2";


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "3";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "3";
            }

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "0";
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + "0";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtDisplay.Text);
            oper = "+";
            txtDisplay.Text = "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtDisplay.Text);
            oper = "-";
            txtDisplay.Text = "";
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtDisplay.Text);
            oper = "*";
            txtDisplay.Text = "";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            fstNum = double.Parse(txtDisplay.Text);
            oper = "/";
            txtDisplay.Text = "";
        }

       

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

            string f, s;

            f = Convert.ToString(fstNum);
            s = Convert.ToString(secNum);

            f = "";
            s = "";
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "")
            {
                txtDisplay.Text = "0";
            }
        }

        private void buttonEqu_Click(object sender, EventArgs e)
        {
            secNum = double.Parse(txtDisplay.Text);
            switch (oper)
            {
                case "+":
                    txtDisplay.Text = $"{fstNum} + {secNum} = {(fstNum + secNum)}";
                    break;
                case "-":
                    txtDisplay.Text = $"{fstNum} - {secNum} = {(fstNum - secNum)}";
                    break;
                case "*":
                    txtDisplay.Text = $"{fstNum} * {secNum} = {(fstNum * secNum)}";
                    break;
                case "/":
                    txtDisplay.Text = $"{fstNum} / {secNum} = {(fstNum / secNum)}";
                    break;
                default:
                    break;
            }

            /* switch(oper)
             {
                 case "+":
                     txtDisplay.Text = (fstNum + secNum).ToString();
                     break;


                 case "-":
                     txtDisplay.Text = (fstNum - secNum).ToString();
                     break;


                 case "*":
                     txtDisplay.Text = (fstNum * secNum).ToString();
                     break;

                 case "/":
                     txtDisplay.Text = (fstNum / secNum).ToString();
                     break;

                 default:
                     break;
             }*/
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDec_Click(object sender, EventArgs e)
        {
            if (buttonDec.Text == ".")
            { if (!txtDisplay.Text.Contains(".")) 
                { 
                    txtDisplay.Text = txtDisplay.Text + buttonDec.Text;
                } 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
