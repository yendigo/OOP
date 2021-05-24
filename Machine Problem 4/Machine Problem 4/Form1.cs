using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_Problem_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            int x = Convert.ToInt32(start.Text);
            int y = Convert.ToInt32(end.Text);

            for (int range = x; range <= y; range++)
            {
                if (range % 5 == 0) count++;
            }

            string result = "There are " + count + " numbers";
            resultLabel.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            start.Clear();
            end.Clear();
            resultLabel.Text = (" ");
        }
    }
}
