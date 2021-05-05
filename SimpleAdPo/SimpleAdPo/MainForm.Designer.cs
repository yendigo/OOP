/*
 * Created by SharpDevelop.
 * User: SANGGALANG
 * Date: 4/24/2021
 * Time: 2:36 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SimpleAdPo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox xtextBox;
		private System.Windows.Forms.TextBox ytextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.xtextBox = new System.Windows.Forms.TextBox();
			this.ytextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// xtextBox
			// 
			this.xtextBox.Location = new System.Drawing.Point(245, 39);
			this.xtextBox.Name = "xtextBox";
			this.xtextBox.Size = new System.Drawing.Size(152, 22);
			this.xtextBox.TabIndex = 0;
			this.xtextBox.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// ytextBox
			// 
			this.ytextBox.Location = new System.Drawing.Point(245, 85);
			this.ytextBox.Name = "ytextBox";
			this.ytextBox.Size = new System.Drawing.Size(152, 22);
			this.ytextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Lagay mo first number mo po.";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(227, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Lagay mo second number mo po.";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 136);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(187, 23);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ang sum po nyan ay:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(124, 206);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(187, 29);
			this.button1.TabIndex = 5;
			this.button1.Text = "Edi iadd mo po.";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// resultLabel
			// 
			this.resultLabel.Location = new System.Drawing.Point(245, 136);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(152, 29);
			this.resultLabel.TabIndex = 6;
			this.resultLabel.Click += new System.EventHandler(this.ResultLabelClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(124, 251);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(187, 31);
			this.button2.TabIndex = 7;
			this.button2.Text = "Iklaro mo po.";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(124, 295);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(187, 31);
			this.button3.TabIndex = 8;
			this.button3.Text = "Edi umalis ka na po.";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(428, 362);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ytextBox);
			this.Controls.Add(this.xtextBox);
			this.Name = "MainForm";
			this.Text = "SimpleAdPo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
