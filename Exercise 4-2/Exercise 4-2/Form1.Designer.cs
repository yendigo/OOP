
namespace Exercise_4_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.radButton1 = new System.Windows.Forms.RadioButton();
            this.radButton2 = new System.Windows.Forms.RadioButton();
            this.radButton3 = new System.Windows.Forms.RadioButton();
            this.radButton4 = new System.Windows.Forms.RadioButton();
            this.lblCall = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(23, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(176, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "High School Level:";
            // 
            // radButton1
            // 
            this.radButton1.AutoSize = true;
            this.radButton1.BackColor = System.Drawing.Color.Transparent;
            this.radButton1.Location = new System.Drawing.Point(35, 68);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(89, 24);
            this.radButton1.TabIndex = 1;
            this.radButton1.TabStop = true;
            this.radButton1.Text = "First Year";
            this.radButton1.UseVisualStyleBackColor = false;
            this.radButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radButton2
            // 
            this.radButton2.AutoSize = true;
            this.radButton2.BackColor = System.Drawing.Color.Transparent;
            this.radButton2.Location = new System.Drawing.Point(35, 116);
            this.radButton2.Name = "radButton2";
            this.radButton2.Size = new System.Drawing.Size(111, 24);
            this.radButton2.TabIndex = 2;
            this.radButton2.TabStop = true;
            this.radButton2.Text = "Second Year";
            this.radButton2.UseVisualStyleBackColor = false;
            this.radButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radButton3
            // 
            this.radButton3.AutoSize = true;
            this.radButton3.BackColor = System.Drawing.Color.Transparent;
            this.radButton3.Location = new System.Drawing.Point(35, 165);
            this.radButton3.Name = "radButton3";
            this.radButton3.Size = new System.Drawing.Size(96, 24);
            this.radButton3.TabIndex = 3;
            this.radButton3.TabStop = true;
            this.radButton3.Text = "Third Year";
            this.radButton3.UseVisualStyleBackColor = false;
            this.radButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radButton4
            // 
            this.radButton4.AutoSize = true;
            this.radButton4.BackColor = System.Drawing.Color.Transparent;
            this.radButton4.Location = new System.Drawing.Point(35, 211);
            this.radButton4.Name = "radButton4";
            this.radButton4.Size = new System.Drawing.Size(72, 24);
            this.radButton4.TabIndex = 4;
            this.radButton4.TabStop = true;
            this.radButton4.Text = "Fourth";
            this.radButton4.UseVisualStyleBackColor = false;
            this.radButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // lblCall
            // 
            this.lblCall.AutoSize = true;
            this.lblCall.BackColor = System.Drawing.Color.Transparent;
            this.lblCall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCall.Location = new System.Drawing.Point(23, 260);
            this.lblCall.Name = "lblCall";
            this.lblCall.Size = new System.Drawing.Size(115, 20);
            this.lblCall.TabIndex = 5;
            this.lblCall.Text = "is also called as:";
            // 
            // txtLevel
            // 
            this.txtLevel.BackColor = System.Drawing.Color.White;
            this.txtLevel.Location = new System.Drawing.Point(161, 257);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(194, 27);
            this.txtLevel.TabIndex = 6;
            this.txtLevel.TextChanged += new System.EventHandler(this.txtLevel_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 384);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.lblCall);
            this.Controls.Add(this.radButton4);
            this.Controls.Add(this.radButton3);
            this.Controls.Add(this.radButton2);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Exercise 4-2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton radButton1;
        private System.Windows.Forms.RadioButton radButton2;
        private System.Windows.Forms.RadioButton radButton3;
        private System.Windows.Forms.RadioButton radButton4;
        private System.Windows.Forms.Label lblCall;
        private System.Windows.Forms.TextBox txtLevel;
    }
}

