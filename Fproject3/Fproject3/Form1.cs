using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fproject3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "12345")
            {
                MessageBox.Show("ID Accepted..." + "\n" + "Name: Richard Gwapo", "ID Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form2 voteForm = new Form2();
                voteForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Password...", "ID Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
