
namespace Cruise_Ship
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCabin = new System.Windows.Forms.RadioButton();
            this.radTourist = new System.Windows.Forms.RadioButton();
            this.radEconomy = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkVIP = new System.Windows.Forms.CheckBox();
            this.chkMeals = new System.Windows.Forms.CheckBox();
            this.chkBed = new System.Windows.Forms.CheckBox();
            this.chkTV = new System.Windows.Forms.CheckBox();
            this.chkAircon = new System.Windows.Forms.CheckBox();
            this.chkToilet = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radCabin);
            this.groupBox1.Controls.Add(this.radTourist);
            this.groupBox1.Controls.Add(this.radEconomy);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(26, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accomodation Type";
            // 
            // radCabin
            // 
            this.radCabin.AutoSize = true;
            this.radCabin.BackColor = System.Drawing.Color.Transparent;
            this.radCabin.Location = new System.Drawing.Point(25, 132);
            this.radCabin.Name = "radCabin";
            this.radCabin.Size = new System.Drawing.Size(73, 23);
            this.radCabin.TabIndex = 2;
            this.radCabin.TabStop = true;
            this.radCabin.Text = "Cabin";
            this.radCabin.UseVisualStyleBackColor = false;
            this.radCabin.CheckedChanged += new System.EventHandler(this.radCabin_CheckedChanged);
            // 
            // radTourist
            // 
            this.radTourist.AutoSize = true;
            this.radTourist.BackColor = System.Drawing.Color.Transparent;
            this.radTourist.Location = new System.Drawing.Point(25, 92);
            this.radTourist.Name = "radTourist";
            this.radTourist.Size = new System.Drawing.Size(77, 23);
            this.radTourist.TabIndex = 1;
            this.radTourist.TabStop = true;
            this.radTourist.Text = "Tourist";
            this.radTourist.UseVisualStyleBackColor = false;
            this.radTourist.CheckedChanged += new System.EventHandler(this.radTourist_CheckedChanged);
            // 
            // radEconomy
            // 
            this.radEconomy.AutoSize = true;
            this.radEconomy.BackColor = System.Drawing.Color.Transparent;
            this.radEconomy.Location = new System.Drawing.Point(25, 51);
            this.radEconomy.Name = "radEconomy";
            this.radEconomy.Size = new System.Drawing.Size(99, 23);
            this.radEconomy.TabIndex = 0;
            this.radEconomy.TabStop = true;
            this.radEconomy.Text = "Economy";
            this.radEconomy.UseVisualStyleBackColor = false;
            this.radEconomy.CheckedChanged += new System.EventHandler(this.radEconomy_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.chkVIP);
            this.groupBox2.Controls.Add(this.chkMeals);
            this.groupBox2.Controls.Add(this.chkBed);
            this.groupBox2.Controls.Add(this.chkTV);
            this.groupBox2.Controls.Add(this.chkAircon);
            this.groupBox2.Controls.Add(this.chkToilet);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(287, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amenities";
            // 
            // chkVIP
            // 
            this.chkVIP.AutoSize = true;
            this.chkVIP.BackColor = System.Drawing.Color.Transparent;
            this.chkVIP.Location = new System.Drawing.Point(26, 249);
            this.chkVIP.Name = "chkVIP";
            this.chkVIP.Size = new System.Drawing.Size(58, 23);
            this.chkVIP.TabIndex = 5;
            this.chkVIP.Text = "VIP";
            this.chkVIP.UseVisualStyleBackColor = false;
            // 
            // chkMeals
            // 
            this.chkMeals.AutoSize = true;
            this.chkMeals.BackColor = System.Drawing.Color.Transparent;
            this.chkMeals.Location = new System.Drawing.Point(26, 211);
            this.chkMeals.Name = "chkMeals";
            this.chkMeals.Size = new System.Drawing.Size(73, 23);
            this.chkMeals.TabIndex = 4;
            this.chkMeals.Text = "Meals";
            this.chkMeals.UseVisualStyleBackColor = false;
            // 
            // chkBed
            // 
            this.chkBed.AutoSize = true;
            this.chkBed.BackColor = System.Drawing.Color.Transparent;
            this.chkBed.Location = new System.Drawing.Point(26, 171);
            this.chkBed.Name = "chkBed";
            this.chkBed.Size = new System.Drawing.Size(60, 23);
            this.chkBed.TabIndex = 3;
            this.chkBed.Text = "Bed";
            this.chkBed.UseVisualStyleBackColor = false;
            this.chkBed.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chkTV
            // 
            this.chkTV.AutoSize = true;
            this.chkTV.BackColor = System.Drawing.Color.Transparent;
            this.chkTV.Location = new System.Drawing.Point(26, 132);
            this.chkTV.Name = "chkTV";
            this.chkTV.Size = new System.Drawing.Size(100, 23);
            this.chkTV.TabIndex = 2;
            this.chkTV.Text = "Television";
            this.chkTV.UseVisualStyleBackColor = false;
            this.chkTV.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkAircon
            // 
            this.chkAircon.AutoSize = true;
            this.chkAircon.BackColor = System.Drawing.Color.Transparent;
            this.chkAircon.Location = new System.Drawing.Point(26, 92);
            this.chkAircon.Name = "chkAircon";
            this.chkAircon.Size = new System.Drawing.Size(79, 23);
            this.chkAircon.TabIndex = 1;
            this.chkAircon.Text = "Aircon";
            this.chkAircon.UseVisualStyleBackColor = false;
            // 
            // chkToilet
            // 
            this.chkToilet.AutoSize = true;
            this.chkToilet.BackColor = System.Drawing.Color.Transparent;
            this.chkToilet.Location = new System.Drawing.Point(26, 51);
            this.chkToilet.Name = "chkToilet";
            this.chkToilet.Size = new System.Drawing.Size(67, 23);
            this.chkToilet.TabIndex = 0;
            this.chkToilet.Text = "Toilet";
            this.chkToilet.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total Fare :";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(130, 305);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(120, 27);
            this.txtTotal.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(34, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(583, 488);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Cruise Ship";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCabin;
        private System.Windows.Forms.RadioButton radTourist;
        private System.Windows.Forms.RadioButton radEconomy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkTV;
        private System.Windows.Forms.CheckBox chkAircon;
        private System.Windows.Forms.CheckBox chkToilet;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox chkMeals;
        private System.Windows.Forms.CheckBox chkBed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkVIP;
    }
}

