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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-JI639214\SQLEXPRESS;Initial Catalog=EMS;Integrated Security=True");
            string sql = "select * from EMD where UserID = '"+txtID.Text+ "' and UserPass = '"+txtPass.Text+"';";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                Form2 ems = new Form2();
                ems.Show();
                this.Hide();
            }
            else if (txtID.Text == "")
            {
                MessageBox.Show("Enter value for user name", "Password Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Invalid Password", "Password Entry", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.Cancel)
                {
                    this.Hide();
                    Application.Exit();
                }
                else
                {
                    txtPass.Focus();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
