
namespace PayrollGUI__1_
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.SSBox = new System.Windows.Forms.TextBox();
            this.RateBox = new System.Windows.Forms.TextBox();
            this.HourBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.EmpInf = new System.Windows.Forms.Label();
            this.DisName = new System.Windows.Forms.Label();
            this.DisSS = new System.Windows.Forms.Label();
            this.DisRate = new System.Windows.Forms.Label();
            this.DisHour = new System.Windows.Forms.Label();
            this.DisGross = new System.Windows.Forms.Label();
            this.DisFed = new System.Windows.Forms.Label();
            this.DisState = new System.Windows.Forms.Label();
            this.DisNet = new System.Windows.Forms.Label();
            this.lineLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payroll";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(36, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Social Security number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(36, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rate/hour (Php):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(36, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Number of hours worked:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(266, 76);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(304, 27);
            this.NameBox.TabIndex = 5;
            // 
            // SSBox
            // 
            this.SSBox.Location = new System.Drawing.Point(266, 110);
            this.SSBox.Name = "SSBox";
            this.SSBox.Size = new System.Drawing.Size(304, 27);
            this.SSBox.TabIndex = 6;
            // 
            // RateBox
            // 
            this.RateBox.Location = new System.Drawing.Point(266, 142);
            this.RateBox.Name = "RateBox";
            this.RateBox.Size = new System.Drawing.Size(304, 27);
            this.RateBox.TabIndex = 7;
            // 
            // HourBox
            // 
            this.HourBox.Location = new System.Drawing.Point(266, 174);
            this.HourBox.Name = "HourBox";
            this.HourBox.Size = new System.Drawing.Size(304, 27);
            this.HourBox.TabIndex = 8;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.White;
            this.SubmitButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitButton.Location = new System.Drawing.Point(110, 235);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(131, 42);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // EmpInf
            // 
            this.EmpInf.AutoSize = true;
            this.EmpInf.BackColor = System.Drawing.Color.Transparent;
            this.EmpInf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmpInf.Location = new System.Drawing.Point(31, 341);
            this.EmpInf.Name = "EmpInf";
            this.EmpInf.Size = new System.Drawing.Size(191, 34);
            this.EmpInf.TabIndex = 11;
            this.EmpInf.Text = "                      ";
            // 
            // DisName
            // 
            this.DisName.AutoSize = true;
            this.DisName.BackColor = System.Drawing.Color.Transparent;
            this.DisName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisName.Location = new System.Drawing.Point(36, 384);
            this.DisName.Name = "DisName";
            this.DisName.Size = new System.Drawing.Size(70, 23);
            this.DisName.TabIndex = 12;
            this.DisName.Text = "            ";
            // 
            // DisSS
            // 
            this.DisSS.AutoSize = true;
            this.DisSS.BackColor = System.Drawing.Color.Transparent;
            this.DisSS.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisSS.Location = new System.Drawing.Point(36, 417);
            this.DisSS.Name = "DisSS";
            this.DisSS.Size = new System.Drawing.Size(70, 23);
            this.DisSS.TabIndex = 13;
            this.DisSS.Text = "            ";
            // 
            // DisRate
            // 
            this.DisRate.AutoSize = true;
            this.DisRate.BackColor = System.Drawing.Color.Transparent;
            this.DisRate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisRate.Location = new System.Drawing.Point(36, 450);
            this.DisRate.Name = "DisRate";
            this.DisRate.Size = new System.Drawing.Size(70, 23);
            this.DisRate.TabIndex = 14;
            this.DisRate.Text = "            ";
            // 
            // DisHour
            // 
            this.DisHour.AutoSize = true;
            this.DisHour.BackColor = System.Drawing.Color.Transparent;
            this.DisHour.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisHour.Location = new System.Drawing.Point(36, 478);
            this.DisHour.Name = "DisHour";
            this.DisHour.Size = new System.Drawing.Size(70, 23);
            this.DisHour.TabIndex = 15;
            this.DisHour.Text = "            ";
            // 
            // DisGross
            // 
            this.DisGross.AutoSize = true;
            this.DisGross.BackColor = System.Drawing.Color.Transparent;
            this.DisGross.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisGross.Location = new System.Drawing.Point(36, 511);
            this.DisGross.Name = "DisGross";
            this.DisGross.Size = new System.Drawing.Size(70, 23);
            this.DisGross.TabIndex = 16;
            this.DisGross.Text = "            ";
            // 
            // DisFed
            // 
            this.DisFed.AutoSize = true;
            this.DisFed.BackColor = System.Drawing.Color.Transparent;
            this.DisFed.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisFed.Location = new System.Drawing.Point(36, 542);
            this.DisFed.Name = "DisFed";
            this.DisFed.Size = new System.Drawing.Size(70, 23);
            this.DisFed.TabIndex = 17;
            this.DisFed.Text = "            ";
            // 
            // DisState
            // 
            this.DisState.AutoSize = true;
            this.DisState.BackColor = System.Drawing.Color.Transparent;
            this.DisState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisState.Location = new System.Drawing.Point(36, 575);
            this.DisState.Name = "DisState";
            this.DisState.Size = new System.Drawing.Size(70, 23);
            this.DisState.TabIndex = 18;
            this.DisState.Text = "            ";
            // 
            // DisNet
            // 
            this.DisNet.AutoSize = true;
            this.DisNet.BackColor = System.Drawing.Color.Transparent;
            this.DisNet.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisNet.Location = new System.Drawing.Point(36, 605);
            this.DisNet.Name = "DisNet";
            this.DisNet.Size = new System.Drawing.Size(70, 23);
            this.DisNet.TabIndex = 19;
            this.DisNet.Text = "            ";
            // 
            // lineLabel
            // 
            this.lineLabel.AutoSize = true;
            this.lineLabel.BackColor = System.Drawing.Color.Transparent;
            this.lineLabel.Location = new System.Drawing.Point(19, 305);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(101, 20);
            this.lineLabel.TabIndex = 20;
            this.lineLabel.Text = "                       ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(276, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 42);
            this.button1.TabIndex = 21;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 699);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.DisNet);
            this.Controls.Add(this.DisState);
            this.Controls.Add(this.DisFed);
            this.Controls.Add(this.DisGross);
            this.Controls.Add(this.DisHour);
            this.Controls.Add(this.DisRate);
            this.Controls.Add(this.DisSS);
            this.Controls.Add(this.DisName);
            this.Controls.Add(this.EmpInf);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.HourBox);
            this.Controls.Add(this.RateBox);
            this.Controls.Add(this.SSBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox SSBox;
        private System.Windows.Forms.TextBox RateBox;
        private System.Windows.Forms.TextBox HourBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label EmpInf;
        private System.Windows.Forms.Label DisName;
        private System.Windows.Forms.Label DisSS;
        private System.Windows.Forms.Label DisRate;
        private System.Windows.Forms.Label DisHour;
        private System.Windows.Forms.Label DisGross;
        private System.Windows.Forms.Label DisFed;
        private System.Windows.Forms.Label DisState;
        private System.Windows.Forms.Label DisNet;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.Button button1;
    }
}

