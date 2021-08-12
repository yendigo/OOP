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

namespace Fproject7
{
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-JI639214\SQLEXPRESS;Initial Catalog=EMS;Integrated Security=True");

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
            disp_data();
            timer1.Start();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into EMS values('" + txtSNum.Text + "','" + txtName.Text + "','" + cmbCourse.Text + "','" + cmbYear.Text + "','" + cmbSec.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from EMS";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvList.DataSource = dt;
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from EMS where Student Name = '" + txtName.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
        }
    }
}
