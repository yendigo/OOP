using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_Problem_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compare_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(num1.Text);
            int y = Convert.ToInt32(num2.Text);

            if ( x >= y)
            {
                resultLabel.Text = x + " is higher than " + y;
            }
            else
            {
                resultLabel.Text = y + " is higher than " + x;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            num1.Clear();
            num2.Clear();
            resultLabel.Text = (" ");
        }
    }
}
