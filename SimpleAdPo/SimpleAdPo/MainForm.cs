/*
 * Created by SharpDevelop.
 * User: SANGGALANG
 * Date: 4/24/2021
 * Time: 2:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleAdPo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			int x = Convert.ToInt16(xtextBox.Text);
			int y = Convert.ToInt16(ytextBox.Text);
			
			int result = x + y;
			resultLabel.Text = result.ToString();
		}
		void Button2Click(object sender, EventArgs e)
		{
			xtextBox.Clear();
			ytextBox.Clear();
			resultLabel.Text = (" ");
		}
		void ResultLabelClick(object sender, EventArgs e)
		{
	
		}
	}
}
