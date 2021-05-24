using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.txtLevel.Text = "Freshman!";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.txtLevel.Text = "Sophomore!";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.txtLevel.Text = "Junior!";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.txtLevel.Text = "Senior!";
        }

        private void txtLevel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
