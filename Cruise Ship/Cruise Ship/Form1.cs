using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cruise_Ship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            radCabin.Checked = false;
            radEconomy.Checked = false;
            radTourist.Checked = false;
            chkAircon.Checked = false;
            chkBed.Checked = false;
            chkMeals.Checked = false;
            chkToilet.Checked = false;
            chkTV.Checked = false;
            chkVIP.Checked = false;
            txtTotal.Clear();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radEconomy_CheckedChanged(object sender, EventArgs e)
        {
            chkToilet.Checked = true;
            chkMeals.Checked = true;
            txtTotal.Text = "Php 1,500";
        }

        private void radTourist_CheckedChanged(object sender, EventArgs e)
        {
            chkToilet.Checked = true;
            chkAircon.Checked = true;
            chkBed.Checked = true;
            chkMeals.Checked = true;
            txtTotal.Text = "Php 2,500";
        }

        private void radCabin_CheckedChanged(object sender, EventArgs e)
        {
            chkToilet.Checked = true;
            chkAircon.Checked = true;
            chkBed.Checked = true;
            chkMeals.Checked = true;
            chkTV.Checked = true;
            chkVIP.Checked = true;
            txtTotal.Text = "Php 4,000";
        }
    }
}
