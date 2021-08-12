using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radDeluxe.Checked)
            {
                chkCheese.Checked = true;
                chkBacon.Checked = true;
                chkOnions.Checked = true;
                txtPrice.Text = "Php 185.00";
            }
        }

        private void radSpecial_CheckedChanged(object sender, EventArgs e)
        {
            if (radSpecial.Checked)
            {
                chkCheese.Checked = true;
                chkPepper.Checked = true;
                chkBacon.Checked = true;
                chkMushroom.Checked = true;
                chkOnions.Checked = true;
                txtPrice.Text = "Php 275.00";
            }
        }

        private void radPrimo_CheckedChanged(object sender, EventArgs e)
        {
            if (radPrimo.Checked)
            {
                chkCheese.Checked = true;
                chkPepper.Checked = true;
                chkBacon.Checked = true;
                chkMushroom.Checked = true;
                chkOnions.Checked = true;
                chkTomato.Checked = true;
                chkSalami.Checked = true;
                txtPrice.Text = "Php 350.00";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtQuantity.Text);

            if (radDeluxe.Checked)
            {
                int result1 = 185 * x;
                txtAmount.Text = result1.ToString();
            }
            else if (radSpecial.Checked)
            {
                int result2 = 275 * x;
                txtAmount.Text = result2.ToString();
            }
            else if (radPrimo.Checked)
            {
                int result3 = 350 * x;
                txtAmount.Text = result3.ToString();
            }
        }
    }
}
