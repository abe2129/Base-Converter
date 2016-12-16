namespace WindowsFormsApplication1
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
            this.dec = new System.Windows.Forms.TextBox();
            this.bin = new System.Windows.Forms.TextBox();
            this.oct = new System.Windows.Forms.TextBox();
            this.hex = new System.Windows.Forms.TextBox();
            this.ieeesp = new System.Windows.Forms.TextBox();
            this.ieeesph = new System.Windows.Forms.TextBox();
            this.ieeedp = new System.Windows.Forms.TextBox();
            this.ieeedph = new System.Windows.Forms.TextBox();
            this.ieeesp1 = new System.Windows.Forms.TextBox();
            this.ieeedp1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ieeeoct1 = new System.Windows.Forms.TextBox();
            this.ieeeoct2 = new System.Windows.Forms.TextBox();
            this.prec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dec
            // 
            this.dec.Location = new System.Drawing.Point(199, 28);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(401, 20);
            this.dec.TabIndex = 0;
            this.dec.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bin
            // 
            this.bin.Location = new System.Drawing.Point(199, 68);
            this.bin.Name = "bin";
            this.bin.Size = new System.Drawing.Size(401, 20);
            this.bin.TabIndex = 1;
            // 
            // oct
            // 
            this.oct.Location = new System.Drawing.Point(199, 114);
            this.oct.Name = "oct";
            this.oct.Size = new System.Drawing.Size(401, 20);
            this.oct.TabIndex = 2;
            // 
            // hex
            // 
            this.hex.Location = new System.Drawing.Point(199, 155);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(401, 20);
            this.hex.TabIndex = 3;
            // 
            // ieeesp
            // 
            this.ieeesp.Location = new System.Drawing.Point(199, 201);
            this.ieeesp.Name = "ieeesp";
            this.ieeesp.Size = new System.Drawing.Size(401, 20);
            this.ieeesp.TabIndex = 4;
            // 
            // ieeesph
            // 
            this.ieeesph.Location = new System.Drawing.Point(199, 274);
            this.ieeesph.Name = "ieeesph";
            this.ieeesph.Size = new System.Drawing.Size(174, 20);
            this.ieeesph.TabIndex = 5;
            // 
            // ieeedp
            // 
            this.ieeedp.Location = new System.Drawing.Point(199, 316);
            this.ieeedp.Name = "ieeedp";
            this.ieeedp.Size = new System.Drawing.Size(401, 20);
            this.ieeedp.TabIndex = 6;
            // 
            // ieeedph
            // 
            this.ieeedph.Location = new System.Drawing.Point(199, 400);
            this.ieeedph.Name = "ieeedph";
            this.ieeedph.Size = new System.Drawing.Size(174, 20);
            this.ieeedph.TabIndex = 7;
            // 
            // ieeesp1
            // 
            this.ieeesp1.Location = new System.Drawing.Point(199, 240);
            this.ieeesp1.Name = "ieeesp1";
            this.ieeesp1.Size = new System.Drawing.Size(401, 20);
            this.ieeesp1.TabIndex = 8;
            this.ieeesp1.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // ieeedp1
            // 
            this.ieeedp1.Location = new System.Drawing.Point(199, 354);
            this.ieeedp1.Name = "ieeedp1";
            this.ieeedp1.Size = new System.Drawing.Size(401, 20);
            this.ieeedp1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Binary";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Octal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Hex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "IEEE fp (single precision)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "IEEE fp Hex (single precision)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "IEEE fp (double precision)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "IEEE fp Hex (double precision)";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 243);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "IEEE fp normalized (single precision)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "IEEE fp normalized (double precision)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(619, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Digits after binary point";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(388, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Octal";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(388, 407);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Octal";
            // 
            // ieeeoct1
            // 
            this.ieeeoct1.Location = new System.Drawing.Point(426, 274);
            this.ieeeoct1.Name = "ieeeoct1";
            this.ieeeoct1.Size = new System.Drawing.Size(174, 20);
            this.ieeeoct1.TabIndex = 28;
            // 
            // ieeeoct2
            // 
            this.ieeeoct2.Location = new System.Drawing.Point(426, 400);
            this.ieeeoct2.Name = "ieeeoct2";
            this.ieeeoct2.Size = new System.Drawing.Size(174, 20);
            this.ieeeoct2.TabIndex = 29;
            this.ieeeoct2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // prec
            // 
            this.prec.Location = new System.Drawing.Point(638, 28);
            this.prec.Name = "prec";
            this.prec.Size = new System.Drawing.Size(75, 20);
            this.prec.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 432);
            this.Controls.Add(this.ieeeoct2);
            this.Controls.Add(this.ieeeoct1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.prec);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ieeedp1);
            this.Controls.Add(this.ieeesp1);
            this.Controls.Add(this.ieeedph);
            this.Controls.Add(this.ieeedp);
            this.Controls.Add(this.ieeesph);
            this.Controls.Add(this.ieeesp);
            this.Controls.Add(this.hex);
            this.Controls.Add(this.oct);
            this.Controls.Add(this.bin);
            this.Controls.Add(this.dec);
            this.Name = "Form1";
            this.Text = "Base Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dec;
        private System.Windows.Forms.TextBox bin;
        private System.Windows.Forms.TextBox oct;
        private System.Windows.Forms.TextBox hex;
        private System.Windows.Forms.TextBox ieeesp;
        private System.Windows.Forms.TextBox ieeesph;
        private System.Windows.Forms.TextBox ieeedp;
        private System.Windows.Forms.TextBox ieeedph;
        private System.Windows.Forms.TextBox ieeesp1;
        private System.Windows.Forms.TextBox ieeedp1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ieeeoct1;
        private System.Windows.Forms.TextBox ieeeoct2;
        private System.Windows.Forms.TextBox prec;
    }
}

