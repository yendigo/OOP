using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fproject4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            Form3 tran = new Form3();
            tran.Show();
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void contextMenuStrip3_Opening(object sender, CancelEventArgs e)
        {
            Form4 about = new Form4();
            about.Show();
        }

        private void contextMenuStrip3_Click(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void contextMenuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }
    }
}
