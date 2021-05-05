/*
 * Created by SharpDevelop.
 * User: SANGGALANG
 * Date: 4/24/2021
 * Time: 10:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Activity_1dinpo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox atextBox;
		private System.Windows.Forms.TextBox btextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.Button button2;
		
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
			this.atextBox = new System.Windows.Forms.TextBox();
			this.btextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// atextBox
			// 
			this.atextBox.Location = new System.Drawing.Point(88, 103);
			this.atextBox.Name = "atextBox";
			this.atextBox.Size = new System.Drawing.Size(101, 22);
			this.atextBox.TabIndex = 0;
			this.atextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btextBox
			// 
			this.btextBox.BackColor = System.Drawing.Color.White;
			this.btextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.btextBox.Location = new System.Drawing.Point(350, 103);
			this.btextBox.Name = "btextBox";
			this.btextBox.Size = new System.Drawing.Size(101, 22);
			this.btextBox.TabIndex = 1;
			this.btextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.btextBox.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
			this.label1.Location = new System.Drawing.Point(248, 103);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 31);
			this.label1.TabIndex = 2;
			this.label1.Text = "+";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(203, 172);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(121, 46);
			this.button1.TabIndex = 3;
			this.button1.Text = "Compute";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// resultLabel
			// 
			this.resultLabel.BackColor = System.Drawing.Color.White;
			this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.resultLabel.Location = new System.Drawing.Point(191, 259);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(145, 47);
			this.resultLabel.TabIndex = 5;
			this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.White;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(203, 350);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(121, 46);
			this.button2.TabIndex = 6;
			this.button2.Text = "Clear";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(534, 439);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btextBox);
			this.Controls.Add(this.atextBox);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.DoubleBuffered = true;
			this.Name = "MainForm";
			this.Text = "Activity#1dinpo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
