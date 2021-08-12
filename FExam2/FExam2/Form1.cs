using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FExam2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            double sub = Convert.ToDouble(txtNum.Text);
            txtSub.Text = sub.ToString("0.00");

            if (sub < 100)
            {
                double tax1 = sub * 0.05;
                txtTax.Text = tax1.ToString("0.00");
            }
            else if (sub >= 100 && sub <= 499)
            {
                double tax2 = sub * 0.075;
                txtTax.Text = tax2.ToString("0.00");
            }
            else if (sub >= 499)
            {
                double tax3 = sub * 0.10;
                txtTax.Text = tax3.ToString("0.00");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNum.Text == "0.00")
            {
                txtNum.Clear();
            }

            Button button = (Button)sender;
            txtNum.Text = txtNum.Text + button.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNum.Text = "0.00";
            txtSub.Text = "$0.00";
            txtTax.Text = "$0.00";
            txtTotal.Text = "$0.00";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtNum.Text = "0.00";
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double sub = Convert.ToDouble(txtSub.Text);
            double tax = Convert.ToDouble(txtTax.Text);

            double total = sub + tax;
            txtTotal.Text = total.ToString("0.00");
        }
    }
}
