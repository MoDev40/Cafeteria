namespace Cafeteria
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rd2xl = new System.Windows.Forms.RadioButton();
            this.rdXl = new System.Windows.Forms.RadioButton();
            this.rdMd = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdQ2 = new System.Windows.Forms.RadioButton();
            this.rdQ1 = new System.Windows.Forms.RadioButton();
            this.tbxQcustom = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdTea = new System.Windows.Forms.RadioButton();
            this.rdCafe = new System.Windows.Forms.RadioButton();
            this.rdQahwa = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblitem = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnOrder);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.rd2xl);
            this.groupBox4.Controls.Add(this.rdXl);
            this.groupBox4.Controls.Add(this.rdMd);
            this.groupBox4.Location = new System.Drawing.Point(170, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(113, 251);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "SIze";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Default small";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rd2xl
            // 
            this.rd2xl.AutoSize = true;
            this.rd2xl.Location = new System.Drawing.Point(18, 34);
            this.rd2xl.Name = "rd2xl";
            this.rd2xl.Size = new System.Drawing.Size(52, 28);
            this.rd2xl.TabIndex = 0;
            this.rd2xl.TabStop = true;
            this.rd2xl.Text = "2xl";
            this.rd2xl.UseVisualStyleBackColor = true;
            // 
            // rdXl
            // 
            this.rdXl.AutoSize = true;
            this.rdXl.Location = new System.Drawing.Point(18, 80);
            this.rdXl.Name = "rdXl";
            this.rdXl.Size = new System.Drawing.Size(46, 28);
            this.rdXl.TabIndex = 0;
            this.rdXl.TabStop = true;
            this.rdXl.Text = "Xl";
            this.rdXl.UseVisualStyleBackColor = true;
            // 
            // rdMd
            // 
            this.rdMd.AutoSize = true;
            this.rdMd.Location = new System.Drawing.Point(18, 127);
            this.rdMd.Name = "rdMd";
            this.rdMd.Size = new System.Drawing.Size(55, 28);
            this.rdMd.TabIndex = 0;
            this.rdMd.TabStop = true;
            this.rdMd.Text = "Md";
            this.rdMd.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdQ2);
            this.groupBox5.Controls.Add(this.rdQ1);
            this.groupBox5.Controls.Add(this.tbxQcustom);
            this.groupBox5.Location = new System.Drawing.Point(289, 54);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(148, 251);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Quantity";
            // 
            // rdQ2
            // 
            this.rdQ2.AutoSize = true;
            this.rdQ2.Location = new System.Drawing.Point(27, 80);
            this.rdQ2.Name = "rdQ2";
            this.rdQ2.Size = new System.Drawing.Size(38, 28);
            this.rdQ2.TabIndex = 0;
            this.rdQ2.TabStop = true;
            this.rdQ2.Text = "2";
            this.rdQ2.UseVisualStyleBackColor = true;
            this.rdQ2.CheckedChanged += new System.EventHandler(this.rdQ4_CheckedChanged);
            // 
            // rdQ1
            // 
            this.rdQ1.AutoSize = true;
            this.rdQ1.Location = new System.Drawing.Point(27, 34);
            this.rdQ1.Name = "rdQ1";
            this.rdQ1.Size = new System.Drawing.Size(38, 28);
            this.rdQ1.TabIndex = 0;
            this.rdQ1.TabStop = true;
            this.rdQ1.Text = "1";
            this.rdQ1.UseVisualStyleBackColor = true;
            this.rdQ1.CheckedChanged += new System.EventHandler(this.rdQ2_CheckedChanged);
            // 
            // tbxQcustom
            // 
            this.tbxQcustom.Location = new System.Drawing.Point(27, 127);
            this.tbxQcustom.Name = "tbxQcustom";
            this.tbxQcustom.Size = new System.Drawing.Size(101, 29);
            this.tbxQcustom.TabIndex = 1;
            this.tbxQcustom.TextChanged += new System.EventHandler(this.tbxQcus_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdTea);
            this.groupBox3.Controls.Add(this.rdCafe);
            this.groupBox3.Controls.Add(this.rdQahwa);
            this.groupBox3.Location = new System.Drawing.Point(16, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(148, 251);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Items";
            // 
            // rdTea
            // 
            this.rdTea.AutoSize = true;
            this.rdTea.Location = new System.Drawing.Point(18, 83);
            this.rdTea.Name = "rdTea";
            this.rdTea.Size = new System.Drawing.Size(61, 28);
            this.rdTea.TabIndex = 0;
            this.rdTea.TabStop = true;
            this.rdTea.Text = "Tea";
            this.rdTea.UseVisualStyleBackColor = true;
            // 
            // rdCafe
            // 
            this.rdCafe.AutoSize = true;
            this.rdCafe.Location = new System.Drawing.Point(18, 37);
            this.rdCafe.Name = "rdCafe";
            this.rdCafe.Size = new System.Drawing.Size(66, 28);
            this.rdCafe.TabIndex = 0;
            this.rdCafe.TabStop = true;
            this.rdCafe.Text = "Cafe";
            this.rdCafe.UseVisualStyleBackColor = true;
            this.rdCafe.CheckedChanged += new System.EventHandler(this.rdCafe_CheckedChanged);
            // 
            // rdQahwa
            // 
            this.rdQahwa.AutoSize = true;
            this.rdQahwa.Location = new System.Drawing.Point(18, 130);
            this.rdQahwa.Name = "rdQahwa";
            this.rdQahwa.Size = new System.Drawing.Size(88, 28);
            this.rdQahwa.TabIndex = 0;
            this.rdQahwa.TabStop = true;
            this.rdQahwa.Text = "Qahwa";
            this.rdQahwa.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(119, 334);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(192, 47);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblQuant);
            this.groupBox2.Controls.Add(this.lblSize);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblitem);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(492, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 396);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your Order";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(145, 205);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(137, 20);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "................................";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Price";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(145, 159);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(109, 20);
            this.lblQuant.TabIndex = 0;
            this.lblQuant.Text = ".........................";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(145, 115);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(85, 20);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "...................";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantitiy";
            // 
            // lblitem
            // 
            this.lblitem.AutoSize = true;
            this.lblitem.Location = new System.Drawing.Point(145, 72);
            this.lblitem.Name = "lblitem";
            this.lblitem.Size = new System.Drawing.Size(57, 20);
            this.lblitem.TabIndex = 0;
            this.lblitem.Text = "............";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Item";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdMd;
        private System.Windows.Forms.RadioButton rdQahwa;
        private System.Windows.Forms.RadioButton rdQ2;
        private System.Windows.Forms.RadioButton rdQ1;
        private System.Windows.Forms.RadioButton rdXl;
        private System.Windows.Forms.RadioButton rd2xl;
        private System.Windows.Forms.RadioButton rdTea;
        private System.Windows.Forms.RadioButton rdCafe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.TextBox tbxQcustom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblitem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label1;
    }
}

