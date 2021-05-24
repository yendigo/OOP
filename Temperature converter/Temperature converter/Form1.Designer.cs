
namespace Temperature_converter
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
            this.tempBox = new System.Windows.Forms.TextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.Fbutton = new System.Windows.Forms.Button();
            this.Cbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DisFah = new System.Windows.Forms.Label();
            this.DisCel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Deglabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature Converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the temperature you want to convert";
            // 
            // tempBox
            // 
            this.tempBox.Location = new System.Drawing.Point(375, 97);
            this.tempBox.Name = "tempBox";
            this.tempBox.Size = new System.Drawing.Size(108, 27);
            this.tempBox.TabIndex = 2;
            this.tempBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Fbutton
            // 
            this.Fbutton.BackColor = System.Drawing.Color.White;
            this.Fbutton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Fbutton.Location = new System.Drawing.Point(31, 179);
            this.Fbutton.Name = "Fbutton";
            this.Fbutton.Size = new System.Drawing.Size(130, 50);
            this.Fbutton.TabIndex = 3;
            this.Fbutton.Text = "Fahrenheit";
            this.Fbutton.UseVisualStyleBackColor = false;
            this.Fbutton.Click += new System.EventHandler(this.Fbutton_Click);
            // 
            // Cbutton
            // 
            this.Cbutton.BackColor = System.Drawing.Color.White;
            this.Cbutton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cbutton.Location = new System.Drawing.Point(31, 248);
            this.Cbutton.Name = "Cbutton";
            this.Cbutton.Size = new System.Drawing.Size(130, 50);
            this.Cbutton.TabIndex = 4;
            this.Cbutton.Text = "Celcius";
            this.Cbutton.UseVisualStyleBackColor = false;
            this.Cbutton.Click += new System.EventHandler(this.Cbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Convert to:";
            // 
            // DisFah
            // 
            this.DisFah.AutoSize = true;
            this.DisFah.BackColor = System.Drawing.Color.Transparent;
            this.DisFah.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisFah.Location = new System.Drawing.Point(184, 188);
            this.DisFah.Name = "DisFah";
            this.DisFah.Size = new System.Drawing.Size(122, 28);
            this.DisFah.TabIndex = 6;
            this.DisFah.Text = "                      ";
            // 
            // DisCel
            // 
            this.DisCel.AutoSize = true;
            this.DisCel.BackColor = System.Drawing.Color.Transparent;
            this.DisCel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DisCel.Location = new System.Drawing.Point(184, 257);
            this.DisCel.Name = "DisCel";
            this.DisCel.Size = new System.Drawing.Size(122, 28);
            this.DisCel.TabIndex = 7;
            this.DisCel.Text = "                      ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(31, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Deglabel
            // 
            this.Deglabel.AutoSize = true;
            this.Deglabel.BackColor = System.Drawing.Color.Transparent;
            this.Deglabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Deglabel.Location = new System.Drawing.Point(489, 99);
            this.Deglabel.Name = "Deglabel";
            this.Deglabel.Size = new System.Drawing.Size(72, 25);
            this.Deglabel.TabIndex = 9;
            this.Deglabel.Text = "            ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(651, 419);
            this.Controls.Add(this.Deglabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DisCel);
            this.Controls.Add(this.DisFah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cbutton);
            this.Controls.Add(this.Fbutton);
            this.Controls.Add(this.tempBox);
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
        private System.Windows.Forms.TextBox tempBox;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.Button Fbutton;
        private System.Windows.Forms.Button Cbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DisFah;
        private System.Windows.Forms.Label DisCel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Deglabel;
    }
}

