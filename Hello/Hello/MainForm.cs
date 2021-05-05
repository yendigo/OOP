/*
 * Created by SharpDevelop.
 * User: SANGGALANG
 * Date: 4/24/2021
 * Time: 2:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Hello
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
		void Button1Click(object sender, EventArgs e)
		{
			label1.Text = "Hello, kamusta ka naman?";
		}
		void Button2Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	        
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
	}
}
