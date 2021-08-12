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
    public partial class Form1 : Form
    {
        public DialogResult Answer { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-JI639214\SQLEXPRESS;Initial Catalog=login;Integrated Security=True");
            string sql = "select * from login where UserName = '" + txtUn.Text + "' and Password = '" + txtPw.Text + "';";
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);

            if (dtbl.Rows.Count == 1)
            {
                Form2 trans = new Form2();
                trans.Show();
                this.Hide();
            }
            else if (txtUn.Text == "")
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
                    txtPw.Focus();
                }
            }
        }
    }
}
