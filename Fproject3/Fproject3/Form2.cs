using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fproject3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 backForm = new Form1();
            backForm.Show();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cmbCand.Text == "NOLI")
            {
                lbl1.Text = "23";
                lbl2.Text = "37";
                lbl3.Text = "5";
                lbl4.Text = "100";
            }
            else if (cmbCand.Text == "VAL")
            {
                lbl1.Text = "22";
                lbl2.Text = "38";
                lbl3.Text = "5";
                lbl4.Text = "100";
            }
            else if (cmbCand.Text == "LESTER")
            {
                lbl1.Text = "22";
                lbl2.Text = "37";
                lbl3.Text = "6";
                lbl4.Text = "100";
            }
            else if (cmbCand.Text == "GWAPO")
            {
                lbl1.Text = "22";
                lbl2.Text = "37";
                lbl3.Text = "5";
                lbl4.Text = "101";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("And the winner is: Gwapo", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
