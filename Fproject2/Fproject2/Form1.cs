using System;
using System.Windows.Forms;

namespace Fproject2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtDays.Clear();
            txtAmount.Clear();
            radSuite.Checked = false;
            radDeluxe.Checked = false;
            radRegular.Checked = false;
            cmbRoom.Text = "";
            lstPayment.SelectedItem = null;
            dateIn.ResetText();
            dateOut.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime CheckIn = dateIn.Value.Date;
            DateTime CheckOut = dateOut.Value.Date;

            int numDay = ((TimeSpan)(CheckOut - CheckIn)).Days;

            if (CheckIn == CheckOut)
            {
                txtDays.Text = "1";
            }
            else
            {
                txtDays.Text = numDay.ToString();
            }

            if (cmbRoom.Text == "")
            {
                MessageBox.Show("No selected room capacity", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (radSuite.Checked == false && radDeluxe.Checked == false && radRegular.Checked == false)
            {
                MessageBox.Show("No selected room type", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (lstPayment.SelectedItem == null)
            {
                MessageBox.Show("No selected type of payment", "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int totalDay = Convert.ToInt32(txtDays.Text);

            if (cmbRoom.Text == "Single")
            {
                if (radRegular.Checked == true)
                {
                    if (lstPayment.Text == "Cash")
                    {
                        int reg = totalDay * 100;
                        txtAmount.Text = reg.ToString();
                    }
                    else if (lstPayment.Text == "Check")
                    {
                        int reg = totalDay * 100;
                        double perReg = reg * 0.05;
                        double totalReg = reg + perReg;
                        txtAmount.Text = totalReg.ToString();
                    }
                    else if (lstPayment.Text == "Credit Card")
                    {
                        int reg = totalDay * 100;
                        double perReg = reg * 0.10;
                        double totalReg = reg + perReg;
                        txtAmount.Text = totalReg.ToString();
                    }
                }
                else if (radDeluxe.Checked == true)
                {
                    if (lstPayment.Text == "Cash")
                    {
                        int luxe = totalDay * 300;
                        txtAmount.Text = luxe.ToString();
                    }
                    else if (lstPayment.Text == "Check")
                    {
                        int luxe = totalDay * 300;
                        double perLuxe = luxe * 0.05;
                        double totalLuxe = luxe + perLuxe;
                        txtAmount.Text = totalLuxe.ToString();
                    }
                    else if (lstPayment.Text == "Credit Card")
                    {
                        int luxe = totalDay * 300;
                        double perLuxe = luxe * 0.10;
                        double totalLuxe = luxe + perLuxe;
                        txtAmount.Text = totalLuxe.ToString();
                    }
                }
                else if (radSuite.Checked == true)
                {
                    if (lstPayment.Text == "Cash")
                    {
                        int suite = totalDay * 500;
                        txtAmount.Text = suite.ToString();
                    }
                    else if (lstPayment.Text == "Check")
                    {
                        int suite = totalDay * 500;
                        double perSuite = suite * 0.05;
                        double totalSuite = suite + perSuite;
                        txtAmount.Text = totalSuite.ToString();
                    }
                    else if (lstPayment.Text == "Credit Card")
                    {
                        int suite = totalDay * 500;
                        double perSuite = suite * 0.10;
                        double totalSuite = suite + perSuite;
                        txtAmount.Text = totalSuite.ToString();
                    }
                }
            }
            else if (cmbRoom.Text == "Double")
            {
                if (radRegular.Checked == true)
                {
                    if (lstPayment.Text == "Cash")
                    {
                        int reg = totalDay * 200;
                        txtAmount.Text = reg.ToString();
                    }
                    else if (lstPayment.Text == "Check")
                    {
                        int reg = totalDay * 200;
                        double perReg = reg * 0.05;
                        double totalReg = reg + perReg;
                        txtAmount.Text = totalReg.ToString();
                    }
                    else if (lstPayment.Text == "Credit Card")
                    {
                        int reg = totalDay * 200;
                        double perReg = reg * 0.10;
                        double totalReg = reg + perReg;
                        txtAmount.Text = totalReg.ToString();
                    }
                }
                else if (radDeluxe.Checked == true)
                {
                    if (lstPayment.Text == "Cash")
                    {
                        int luxe = totalDay * 500;
                        txtAmount.Text = luxe.ToString();
                    }
                    else if (lstPayment.Text == "Check")
                    {
                        int luxe = totalDay * 500;
                        double perLuxe = luxe * 0.05;
                        double totalLuxe = luxe + perLuxe;
                        txtAmount.Text = totalLuxe.ToString();
                    }
                    else if (lstPayment.Text == "Credit Card")
                    {
                        int luxe = totalDay * 500;
                        double perLuxe = luxe * 0.10;
                        double totalLuxe = luxe + perLuxe;
                        txtAmount.Text = totalLuxe.ToString();
                    }
                }
                else if (radSuite.Checked == true)
                {
                    if (lstPayment.Text == "Cash")
                    {
                        int suite = totalDay * 800;
                        txtAmount.Text = suite.ToString();
                    }
                    else if (lstPayment.Text == "Check")
                    {
                        int suite = totalDay * 800;
                        double perSuite = suite * 0.05;
                        double totalSuite = suite + perSuite;
                        txtAmount.Text = totalSuite.ToString();
                    }
                    else if (lstPayment.Text == "Credit Card")
                    {
                        int suite = totalDay * 800;
                        double perSuite = suite * 0.10;
                        double totalSuite = suite + perSuite;
                        txtAmount.Text = totalSuite.ToString();
                    }
                }
            }
            else if (cmbRoom.Text == "Family")
            {
                if (radRegular.Checked == true)
                {
                    if (lstPayment.Text == "Cash")
                    {
                        int reg = totalDay * 500;
                        txtAmount.Text = reg.ToString();
                    }
                    else if (lstPayment.Text == "Check")
                    {
                        int reg = totalDay * 500;
                        double perReg = reg * 0.05;
                        double totalReg = reg + perReg;
                        txtAmount.Text = totalReg.ToString();
                    }
                    else if (lstPayment.Text == "Credit Card")
                    {
                        int reg = totalDay * 500;
                        double perReg = reg * 0.10;
                        double totalReg = reg + perReg;
                        txtAmount.Text = totalReg.ToString();
                    }
                }
                else if (radDeluxe.Checked == true)
                {
                    if (lstPayment.Text == "Cash")
                    {
                        int luxe = totalDay * 750;
                        txtAmount.Text = luxe.ToString();
                    }
                    else if (lstPayment.Text == "Check")
                    {
                        int luxe = totalDay * 750;
                        double perLuxe = luxe * 0.05;
                        double totalLuxe = luxe + perLuxe;
                        txtAmount.Text = totalLuxe.ToString();
                    }
                    else if (lstPayment.Text == "Credit Card")
                    {
                        int luxe = totalDay * 750;
                        double perLuxe = luxe * 0.10;
                        double totalLuxe = luxe + perLuxe;
                        txtAmount.Text = totalLuxe.ToString();
                    }
                }
                else if (radSuite.Checked == true)
                {
                    if (lstPayment.Text == "Cash")
                    {
                        int suite = totalDay * 1000;
                        txtAmount.Text = suite.ToString();
                    }
                    else if (lstPayment.Text == "Check")
                    {
                        int suite = totalDay * 1000;
                        double perSuite = suite * 0.05;
                        double totalSuite = suite + perSuite;
                        txtAmount.Text = totalSuite.ToString();
                    }
                    else if (lstPayment.Text == "Credit Card")
                    {
                        int suite = totalDay * 1000;
                        double perSuite = suite * 0.10;
                        double totalSuite = suite + perSuite;
                        txtAmount.Text = totalSuite.ToString();
                    }
                }   
            }
        }
    }
}
