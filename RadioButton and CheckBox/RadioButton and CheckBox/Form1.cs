using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_and_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSub_TextChanged(object sender, EventArgs e)
        {

        }

        private void chk14_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void chk12_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            if (chk21.Checked == true)
            {
                this.txtSub.Text = "10,000.00";
            }
            else if (chk21.Checked == true && chk14.Checked == true)
            {
                this.txtSub.Text = "17,500.00";
            }
            else if (chk21.Checked == true && chk12.Checked == true)
            {
                this.txtSub.Text = "15,000.00";
            }
            if (chk14.Checked == true)
            {
                this.txtSub.Text = "7,500.00";
            }
            else if (chk14.Checked == true && chk12.Checked == true)
            {
                this.txtSub.Text = "12,500.00";
            }
            if (chk12.Checked == true)
            {
                this.txtSub.Text = "5,000.00";
            }
            if (chk21.Checked == true && chk14.Checked == true && chk12.Checked == true)
            {
                this.txtSub.Text = "22,500.00";
            }
            if (chk21.Checked == false && chk14.Checked == false && chk12.Checked == false)
            {
                this.txtSub.Text = "0.00";
            }

            if (chk21.Checked == true && rad5.Checked == true)
            {
                this.txtDiscount.Text = "500.00";
            }
            else if (chk14.Checked == true && rad5.Checked == true)
            {
                this.txtDiscount.Text = "375.00";
            }
            else if (chk12.Checked == true && rad5.Checked == true)
            {
                this.txtDiscount.Text = "250.00";
            }

            if (chk21.Checked == true && rad10.Checked == true)
            {
                this.txtDiscount.Text = "1,000.00";
            }
            else if (chk14.Checked == true && rad10.Checked == true)
            {
                this.txtDiscount.Text = "750.00";
            }
            else if (chk12.Checked == true && rad10.Checked == true)
            {
                this.txtDiscount.Text = "500.00";
            }

            if (chk21.Checked == true && rad15.Checked == true)
            {
                this.txtDiscount.Text = "1,500.00";
            }
            else if (chk14.Checked == true && rad15.Checked == true)
            {
                this.txtDiscount.Text = "1,125.00";
            }
            else if (chk12.Checked == true && rad15.Checked == true)
            {
                this.txtDiscount.Text = "750.00";
            }
            if (rad5.Checked == false && rad10.Checked == false && rad15.Checked == false)
            {
                this.txtDiscount.Text = "0.00";
            }

            if (chk21.Checked == true && rad5.Checked == true)
            {
                this.txtNet.Text = "9,500.00";
            }
            else if (chk14.Checked == true && rad5.Checked == true)
            {
                this.txtNet.Text = "7,125.00";
            }
            else if (chk12.Checked == true && rad5.Checked == true)
            {
                this.txtNet.Text = "4,750.00";
            }

            if (chk21.Checked == true && rad10.Checked == true)
            {
                this.txtNet.Text = "9,000.00";
            }
            else if (chk14.Checked == true && rad10.Checked == true)
            {
                this.txtNet.Text = "6,750.00";
            }
            else if (chk12.Checked == true && rad10.Checked == true)
            {
                this.txtNet.Text = "4,500.00";
            }

            if (chk21.Checked == true && rad15.Checked == true)
            {
                this.txtNet.Text = "8,500.00";
            }
            else if (chk14.Checked == true && rad15.Checked == true)
            {
                this.txtNet.Text = "6,375.00";
            }
            else if (chk12.Checked == true && rad15.Checked == true)
            {
                this.txtNet.Text = "4,250.00";
            }
            if (rad5.Checked == false && rad10.Checked == false && rad15.Checked == false)
            {
                this.txtNet.Text = "0.00";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            chk12.Checked = false;
            chk21.Checked = false;
            chk14.Checked = false;
            rad5.Checked = false;
            rad10.Checked = false;
            rad15.Checked = false;
            txtSub.Clear();
            txtDiscount.Clear();
            txtNet.Clear();
        }
    }
}
