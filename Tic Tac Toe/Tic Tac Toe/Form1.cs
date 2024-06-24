using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;
        void Enable_False()
        {

            btnTic1.Enabled = false;
            btnTic2.Enabled = false;

            btnTic3.Enabled = false;

            btnTic4.Enabled = false;
            btnTic5.Enabled = false;

            btnTic6.Enabled = false;

            btnTic7.Enabled = false;
            btnTic8.Enabled = false;

            btnTic9.Enabled = false;
        }

void score()
        {
            if (btnTic1.Text == "X" && btnTic2.Text == "X" && btnTic3.Text == "X")
            {
                btnTic1.BackColor = Color.PowderBlue;
                btnTic2.BackColor = Color.PowderBlue;
                btnTic3.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
    }





    public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
