using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distance_traveled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(SpeedBox.Text);

            int fivehrs = x * 5;
            label5.Text = (fivehrs + " miles");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(SpeedBox.Text);

            int eighthrs = x * 8;
            label8.Text = (eighthrs + " miles");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(SpeedBox.Text);

            int twelvehrs = x * 12;
            label12.Text = (twelvehrs + " miles");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SpeedBox.Clear();
            label5.Text = (" ");
            label8.Text = (" ");
            label12.Text = (" ");
        }
    }
}
