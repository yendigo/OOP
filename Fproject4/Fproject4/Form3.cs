using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Fproject4
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
            fill_listbox();
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void fill_listbox()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-JI639214\SQLEXPRESS;Initial Catalog=appprice;Integrated Security=True");
            string sql = "select * from appprice";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string app = myreader.GetString(1);
                    lstApp.Items.Add(app);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void lstApp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstApp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-JI639214\SQLEXPRESS;Initial Catalog=appprice;Integrated Security=True");
            string sql = "select * from appprice where Appliance = '"+lstApp.Text+"';";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while (myreader.Read())
                {
                    string price = myreader.GetDecimal(2).ToString();
                    
                    if (numQuanti.Value > 0)
                    {
                        lstUnit.Items.Add(price);
                        int unit = 0;
                        unit = lstApp.SelectedIndex;
                    }

                    decimal pri = Convert.ToDecimal(price);
                    decimal quan = Convert.ToDecimal(numQuanti.Value);

                    decimal amount = pri * quan;

                    txtAmount.Text = amount.ToString();

                    if (lstUnit.Items.Count > 1)
                    {
                        int count = 1;
                        decimal subtotal;
                        decimal sub = Convert.ToDecimal(txtSub.Text);

                        while (count <= 1000)
                        {
                            subtotal = sub + amount;
                            count ++;
                            txtSub.Text = subtotal.ToString();
                        }
                    }
                    else
                    {
                        txtSub.Text = amount.ToString();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (numQuanti.Value > 0)
            {
                lstSold.Items.Add(lstApp.SelectedItem);
                int app = 0;
                app = lstApp.SelectedIndex;
            }
            else
            {
                MessageBox.Show("Please input a quantity", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            btnCompute.Visible = true;
            btnCompute.Enabled = true;
            grpCompute.Visible = true;
            grpCompute2.Visible = false;
            btnCompute2.Visible = false;
            grpCharge.Visible = false;
            lblCharge.Visible = false;
            txtTen.Text = "0.00";
            txtTendered.Text = "0.00";
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnClear.Enabled = true;
            btnClose.Enabled = true;

            double subtotal = Convert.ToDouble(txtSub.Text);

            double disc = subtotal * 0.05;
            double total = subtotal - disc;

            txtTotal.Text = total.ToString();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            double aTendered = Convert.ToDouble(txtTen.Text);
            double total = Convert.ToDouble(txtTotal.Text);

            if (aTendered >= total)
            {
                double tendered = aTendered - total;
                txtTendered.Text = tendered.ToString();
            }
            else
            {
                MessageBox.Show("Enter valid amount", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtTen_Click(object sender, EventArgs e)
        {

        }

        private void Form3_DoubleClick(object sender, EventArgs e)
        {
            txtTen.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            numQuanti.Value = 0;
            btnNew.Enabled = false;
            btnClear.Enabled = false;
            btnClose.Enabled = false;
            btnCompute.Enabled = false;
            lstSold.Items.Clear();
            lstUnit.Items.Clear();
            txtAmount.Text = "0.00";
            txtSub.Text = "0.00";
            txtTotal.Text = "0.00";
            txtTen.Text = "0.00";
            txtTendered.Text = "0.00";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numQuanti.Value = 0;
            lstSold.Items.Clear();
            lstUnit.Items.Clear();
            btnNew.Enabled = false;
            btnClear.Enabled = false;
            btnClose.Enabled = false;
            btnCompute.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCharge_Click(object sender, EventArgs e)
        {
            grpCharge.Visible = true;
            grpCompute2.Visible = true;
            lblCharge.Visible = true;
            btnCompute.Visible = false;
            btnCompute2.Visible = true;
        }

        private void btnCompute2_Click(object sender, EventArgs e)
        {
            btnNew.Enabled = true;
            btnClear.Enabled = true;
            btnClose.Enabled = true;

            double subtotal = Convert.ToDouble(txtSub.Text);

            double add = subtotal * 0.05;
            double total = subtotal + add;

            txtTotal.Text = total.ToString();
        }
    }
}
