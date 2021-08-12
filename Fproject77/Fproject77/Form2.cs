using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Fproject77
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string day = DateTime.Now.Day.ToString();
            string month = DateTime.Now.ToString("MMMM");
            string year = DateTime.Now.Year.ToString();

            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDay.Text = DateTime.Today.DayOfWeek.ToString();
            lblDate.Text = month + " " + day + ", " + year;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'offData.Stl' table. You can move, or remove it, as needed.
            this.stlTableAdapter.Fill(this.offData.Stl);

            timer1.Start();
        }

        private void Edit (bool value)
        {
            txtName.Enabled = value;
            cmbCourse.Enabled = value;
            cmbYear.Enabled = value;
            cmbSection.Enabled = value;
            btnSearch.Enabled = value;
            cmbCourse.Text = "";
            cmbYear.Text = "";
            cmbSection.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                btnSave.Enabled = true;
                offData.Stl.AddStlRow(offData.Stl.NewStlRow());
                stlBindingSource.MoveLast();
                txtName.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                offData.Stl.RejectChanges();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit(true);
            txtName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                btnSearch.Enabled = true;
                stlBindingSource.EndEdit();
                stlTableAdapter.Update(offData.Stl);
                dataGridView1.Refresh();
                txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                offData.Stl.RejectChanges();
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                stlBindingSource.RemoveCurrent();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
            btnDel.Enabled = true;
            object myValue;

            string message = "Enter Student Number";
            string title = "Search";
            string defaultValue = "Input here";

            myValue = Interaction.InputBox(message, title, defaultValue);

            if ((string)myValue == studentNumberDataGridViewTextBoxColumn.Name)
            {
                MessageBox.Show("Student Number found");
            }
            else
            {
                MessageBox.Show("Student Number not found");
            }
        }

        private void lstSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
        
        }

        private void btnASearch_Click(object sender, EventArgs e)
        {
            Form3 adv = new Form3();
            adv.Show();
        }
    }
}
