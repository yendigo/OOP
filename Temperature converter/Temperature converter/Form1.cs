using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tempBox.Clear();
            DisFah.Text = (" ");
            DisCel.Text = (" ");
            Deglabel.Text = (" ");
        }

        private void Fbutton_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(tempBox.Text);

            double fah = (1.8 * x) + 32;
            DisFah.Text = ("= " + Math.Round(fah, 2) + " °F");

            Deglabel.Text = ("°C");
        }

        private void Cbutton_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(tempBox.Text);

            double cel = (x - 32) * 0.55555556;
            DisCel.Text = ("= " + Math.Round(cel, 2) + " °C");

            Deglabel.Text = ("°F");
        }
    }
}
