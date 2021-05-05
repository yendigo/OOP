/*
 * Created by SharpDevelop.
 * User: SANGGALANG
 * Date: 4/24/2021
 * Time: 4:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Activity_1po
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
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{

		}
		void Button1Click(object sender, EventArgs e)
		{
	        int x = Convert.ToInt16(atextBox.Text);
	       	int y = Convert.ToInt16(btextBox.Text);
			
			int result = x + y;
			resultLabel.Text = result.ToString();
		}
		void Button2Click(object sender, EventArgs e)
		{
	        int x = Convert.ToInt16(atextBox.Text);
	       	int y = Convert.ToInt16(btextBox.Text);
			
			int result = x * y;
			resultLabel.Text = result.ToString();
		}
		void Button4Click(object sender, EventArgs e)
		{
			atextBox.Clear();
			btextBox.Clear();
			resultLabel.Text = (" ");	
		}
		void Button3Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		}
	}

