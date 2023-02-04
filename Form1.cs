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
    public partial class Form1 : Form
    {
        char operation;
        double value = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            txtDisplay.Text = txtDisplay.Text + ".";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            operation = '+';
            value = double.Parse(txtDisplay.Text);
            txtDisplay.Text = txtDisplay.Text + "+";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            operation = '-';
            value = double.Parse(txtDisplay.Text);
            txtDisplay.Text = txtDisplay.Text + "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            operation = '*';
            value = double.Parse(txtDisplay.Text);
            txtDisplay.Text = txtDisplay.Text + "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = "";
            }
            operation = '/';
            value = double.Parse(txtDisplay.Text);
            txtDisplay.Text = txtDisplay.Text + "/";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            string display = txtDisplay.Text;
            string D = "";
            for (int i = 0; i < display.Length - 1; i++)
            {
                D = D + display[i];
            }
            txtDisplay.Text = D;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            string display = txtDisplay.Text;
            string secValue = "";
            int count = 0;
            for (int i = 0; i < display.Length; i++)
            {
                if (display[i] == operation)
                {
                    count++;
                }
                if (count == 1)
                {
                    if (display[i] != operation)
                        secValue = secValue + display[i];
                }
            }
            if (operation == '+') 
            {
                double result = value + double.Parse(secValue);
                txtDisplay.Text = result.ToString();
            }
            if (operation == '-')
            {
                double result = value - double.Parse(secValue);
                txtDisplay.Text = result.ToString();
            }
            if (operation == '*')
            {
                double result = value * double.Parse(secValue);
                txtDisplay.Text = result.ToString();
            }
            if (operation == '/')
            {
                double result = value / double.Parse(secValue);
                txtDisplay.Text = result.ToString();
            }
        }

    }
}
