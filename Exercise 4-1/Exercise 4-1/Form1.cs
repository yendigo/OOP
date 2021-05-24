using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.txtRad.Text = "Radio button 1 clicked";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.txtRad.Text = "Radio button 2 clicked";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.txtRad.Text = "Radio button 3 clicked";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCheck.Text = "Check box 1 clicked";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCheck.Text = "Check box 2 clicked";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.txtCheck.Text = "Check box 3 clicked";
        }
    }
}
