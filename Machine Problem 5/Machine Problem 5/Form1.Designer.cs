
namespace Machine_Problem_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.compare = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(67, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which is greater?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(78, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "First number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(78, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Second number:";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(269, 128);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(125, 27);
            this.num1.TabIndex = 3;
            this.num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(269, 182);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(125, 27);
            this.num2.TabIndex = 4;
            this.num2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // compare
            // 
            this.compare.BackColor = System.Drawing.Color.White;
            this.compare.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.compare.Location = new System.Drawing.Point(78, 298);
            this.compare.Name = "compare";
            this.compare.Size = new System.Drawing.Size(121, 39);
            this.compare.TabIndex = 5;
            this.compare.Text = "Compare";
            this.compare.UseVisualStyleBackColor = false;
            this.compare.Click += new System.EventHandler(this.compare_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.White;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clear.Location = new System.Drawing.Point(269, 298);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(121, 39);
            this.clear.TabIndex = 6;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(78, 247);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(55, 23);
            this.resultLabel.TabIndex = 7;
            this.resultLabel.Text = "         ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.compare);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Button compare;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultLabel;
    }
}

