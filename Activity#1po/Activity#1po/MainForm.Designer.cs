/*
 * Created by SharpDevelop.
 * User: SANGGALANG
 * Date: 4/24/2021
 * Time: 4:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Activity_1po
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox atextBox;
		private System.Windows.Forms.TextBox btextBox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.Button button4;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.atextBox = new System.Windows.Forms.TextBox();
			this.btextBox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.resultLabel = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(31, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(303, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please enter your first number:";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Yu Gothic Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(31, 117);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(303, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Please enter your second number:";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// atextBox
			// 
			this.atextBox.Location = new System.Drawing.Point(340, 79);
			this.atextBox.Name = "atextBox";
			this.atextBox.Size = new System.Drawing.Size(100, 22);
			this.atextBox.TabIndex = 2;
			this.atextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btextBox
			// 
			this.btextBox.Location = new System.Drawing.Point(340, 117);
			this.btextBox.Name = "btextBox";
			this.btextBox.Size = new System.Drawing.Size(100, 22);
			this.btextBox.TabIndex = 3;
			this.btextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(31, 227);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 39);
			this.button1.TabIndex = 4;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(141, 227);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(82, 39);
			this.button2.TabIndex = 5;
			this.button2.Text = "Multiply";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.White;
			this.button3.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.Color.Black;
			this.button3.Location = new System.Drawing.Point(358, 227);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(82, 39);
			this.button3.TabIndex = 6;
			this.button3.Text = "Exit";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(31, 171);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(201, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = "The answer is:";
			// 
			// resultLabel
			// 
			this.resultLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.resultLabel.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultLabel.Location = new System.Drawing.Point(327, 165);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(121, 38);
			this.resultLabel.TabIndex = 8;
			this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.White;
			this.button4.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(249, 227);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(82, 39);
			this.button4.TabIndex = 9;
			this.button4.Text = "Clear";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(480, 358);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btextBox);
			this.Controls.Add(this.atextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Name = "MainForm";
			this.Text = "Activity#1po";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
