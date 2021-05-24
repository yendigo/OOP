
namespace RadioButton_and_CheckBox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk12 = new System.Windows.Forms.CheckBox();
            this.chk14 = new System.Windows.Forms.CheckBox();
            this.chk21 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rad15 = new System.Windows.Forms.RadioButton();
            this.rad10 = new System.Windows.Forms.RadioButton();
            this.rad5 = new System.Windows.Forms.RadioButton();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSub = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chk12);
            this.groupBox1.Controls.Add(this.chk14);
            this.groupBox1.Controls.Add(this.chk21);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(16, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 180);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select items here:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chk12
            // 
            this.chk12.AutoSize = true;
            this.chk12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk12.Location = new System.Drawing.Point(29, 126);
            this.chk12.Name = "chk12";
            this.chk12.Size = new System.Drawing.Size(195, 23);
            this.chk12.TabIndex = 2;
            this.chk12.Text = "TV 12\'\' (Php 5,000.00)";
            this.chk12.UseVisualStyleBackColor = true;
            this.chk12.CheckedChanged += new System.EventHandler(this.chk12_CheckedChanged);
            // 
            // chk14
            // 
            this.chk14.AutoSize = true;
            this.chk14.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk14.Location = new System.Drawing.Point(29, 82);
            this.chk14.Name = "chk14";
            this.chk14.Size = new System.Drawing.Size(195, 23);
            this.chk14.TabIndex = 1;
            this.chk14.Text = "TV 14\'\' (Php 7,500.00)";
            this.chk14.UseVisualStyleBackColor = true;
            this.chk14.CheckedChanged += new System.EventHandler(this.chk14_CheckedChanged);
            // 
            // chk21
            // 
            this.chk21.AutoSize = true;
            this.chk21.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chk21.Location = new System.Drawing.Point(29, 39);
            this.chk21.Name = "chk21";
            this.chk21.Size = new System.Drawing.Size(204, 23);
            this.chk21.TabIndex = 0;
            this.chk21.Text = "TV 21\'\' (Php 10,000.00)";
            this.chk21.UseVisualStyleBackColor = true;
            this.chk21.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rad15);
            this.groupBox2.Controls.Add(this.rad10);
            this.groupBox2.Controls.Add(this.rad5);
            this.groupBox2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(334, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 180);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Discount";
            // 
            // rad15
            // 
            this.rad15.AutoSize = true;
            this.rad15.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rad15.Location = new System.Drawing.Point(58, 125);
            this.rad15.Name = "rad15";
            this.rad15.Size = new System.Drawing.Size(63, 23);
            this.rad15.TabIndex = 2;
            this.rad15.TabStop = true;
            this.rad15.Text = "15%";
            this.rad15.UseVisualStyleBackColor = true;
            // 
            // rad10
            // 
            this.rad10.AutoSize = true;
            this.rad10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rad10.Location = new System.Drawing.Point(58, 81);
            this.rad10.Name = "rad10";
            this.rad10.Size = new System.Drawing.Size(63, 23);
            this.rad10.TabIndex = 1;
            this.rad10.TabStop = true;
            this.rad10.Text = "10%";
            this.rad10.UseVisualStyleBackColor = true;
            // 
            // rad5
            // 
            this.rad5.AutoSize = true;
            this.rad5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rad5.Location = new System.Drawing.Point(58, 38);
            this.rad5.Name = "rad5";
            this.rad5.Size = new System.Drawing.Size(54, 23);
            this.rad5.TabIndex = 0;
            this.rad5.TabStop = true;
            this.rad5.Text = "5%";
            this.rad5.UseVisualStyleBackColor = true;
            // 
            // btnCompute
            // 
            this.btnCompute.BackColor = System.Drawing.Color.White;
            this.btnCompute.Location = new System.Drawing.Point(16, 215);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(149, 39);
            this.btnCompute.TabIndex = 4;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = false;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(16, 260);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 39);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(16, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 39);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(205, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sub-Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(205, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Net Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(205, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Discount";
            // 
            // txtSub
            // 
            this.txtSub.Location = new System.Drawing.Point(334, 221);
            this.txtSub.Name = "txtSub";
            this.txtSub.ReadOnly = true;
            this.txtSub.Size = new System.Drawing.Size(154, 27);
            this.txtSub.TabIndex = 10;
            this.txtSub.TextChanged += new System.EventHandler(this.txtSub_TextChanged);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(334, 266);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.Size = new System.Drawing.Size(154, 27);
            this.txtDiscount.TabIndex = 11;
            // 
            // txtNet
            // 
            this.txtNet.Location = new System.Drawing.Point(334, 311);
            this.txtNet.Name = "txtNet";
            this.txtNet.ReadOnly = true;
            this.txtNet.Size = new System.Drawing.Size(154, 27);
            this.txtNet.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 369);
            this.Controls.Add(this.txtNet);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtSub);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "RadioButton & CheckBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chk12;
        private System.Windows.Forms.CheckBox chk14;
        private System.Windows.Forms.CheckBox chk21;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad15;
        private System.Windows.Forms.RadioButton rad10;
        private System.Windows.Forms.RadioButton rad5;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSub;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtNet;
    }
}

