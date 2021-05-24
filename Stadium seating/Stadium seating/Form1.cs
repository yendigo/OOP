using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_seating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cA = Convert.ToInt32(textBoxA.Text);
            int cB = Convert.ToInt32(textBoxB.Text);
            int cC = Convert.ToInt32(textBoxC.Text);

            int totalA = cA * 15;
            labelA.Text = ("$ " + totalA);

            int totalB = cB * 12;
            labelB.Text = ("$ " + totalB);

            int totalC = cC * 9;
            labelC.Text = ("$ " + totalC);

            int total = totalA + totalB + totalC;
            labelD.Text = ("$ " + total);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            labelA.Text = (" ");
            labelB.Text = (" ");
            labelC.Text = (" ");
            labelD.Text = (" ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
