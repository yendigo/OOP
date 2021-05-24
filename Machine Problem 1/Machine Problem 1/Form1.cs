using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Machine_Problem_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int x = Convert.ToInt16(atextBox.Text);
            int y = Convert.ToInt16(btextBox.Text);
            int z = Convert.ToInt16(ctextBox.Text);

            int result = x + y + z;
            Labelresult.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            atextBox.Clear();
            btextBox.Clear();
            ctextBox.Clear();
            Labelresult.Text = (" ");
        }
    }
}
