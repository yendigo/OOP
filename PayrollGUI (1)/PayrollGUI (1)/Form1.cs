using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI__1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            lineLabel.Text = ("----------------------------------------------------------------------------------------------------------------");

            EmpInf.Text = ("Employee information");

            string name = NameBox.Text;
            DisName.Text = (name);

            string ssnum = SSBox.Text;
            DisSS.Text = (ssnum);

            string rate = RateBox.Text;
            DisRate.Text = (rate + " / hour");

            string work = HourBox.Text;
            DisHour.Text = (work + " hours worked");

            double x = Convert.ToDouble(RateBox.Text);
            double y = Convert.ToDouble(HourBox.Text);

            double gross = x * y;
            DisGross.Text = ("Gross pay: Php " + Math.Round(gross, 3));

            double fed = gross * 15 / 100;
            DisFed.Text = ("Federal withholding tax: Php " + Math.Round(fed, 3));

            double state = gross * 5 / 100;
            DisState.Text = ("State withholding tax: Php " + Math.Round(state, 3));

            double net = gross - fed - state;
            DisNet.Text = ("Net pay: Php " + Math.Round(net, 3));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NameBox.Clear();
            SSBox.Clear();
            RateBox.Clear();
            HourBox.Clear();
            lineLabel.Text = (" ");
            EmpInf.Text = (" ");
            DisName.Text = (" ");
            DisSS.Text = (" ");
            DisRate.Text = (" ");
            DisHour.Text = (" ");
            DisGross.Text = (" ");
            DisFed.Text = (" ");
            DisState.Text = (" ");
            DisNet.Text = (" ");
        }
    }
}
