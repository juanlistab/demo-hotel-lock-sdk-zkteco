namespace TestDemo
{
    partial class Form1
    {
        /// <summary>
        /// 
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 

        /// <summary>
        /// 
        /// 
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cobBaud = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.texBRes = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port：COM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(14, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 48);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "USB port";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "serial port";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(25, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "baud rate：";
            // 
            // cobBaud
            // 
            this.cobBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobBaud.FormattingEnabled = true;
            this.cobBaud.Location = new System.Drawing.Point(302, 21);
            this.cobBaud.Name = "cobBaud";
            this.cobBaud.Size = new System.Drawing.Size(68, 21);
            this.cobBaud.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 5;
            this.button1.Text = "open port";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 25);
            this.button2.TabIndex = 6;
            this.button2.Text = "close port";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(14, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 25);
            this.button3.TabIndex = 7;
            this.button3.Text = "device buzzer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(248, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 8;
            this.button4.Text = "guest card";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(230, 23);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 25);
            this.button5.TabIndex = 9;
            this.button5.Text = "read non-record card";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(371, 23);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 25);
            this.button6.TabIndex = 10;
            this.button6.Text = "clear card type";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(457, 51);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 25);
            this.button7.TabIndex = 11;
            this.button7.Text = "exit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // texBRes
            // 
            this.texBRes.Location = new System.Drawing.Point(545, 13);
            this.texBRes.Multiline = true;
            this.texBRes.Name = "texBRes";
            this.texBRes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.texBRes.Size = new System.Drawing.Size(257, 383);
            this.texBRes.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Location = new System.Drawing.Point(14, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(518, 89);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "authorizing";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(272, 24);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(222, 54);
            this.textBox2.TabIndex = 18;
            // 
            // button13
            // 
            this.button13.AutoSize = true;
            this.button13.Location = new System.Drawing.Point(149, 53);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(117, 25);
            this.button13.TabIndex = 17;
            this.button13.Text = "getting parameter";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.AutoSize = true;
            this.button12.Location = new System.Drawing.Point(14, 53);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(123, 25);
            this.button12.TabIndex = 16;
            this.button12.Text = "getting valid date";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Location = new System.Drawing.Point(149, 22);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 25);
            this.button8.TabIndex = 15;
            this.button8.Text = "register";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button11
            // 
            this.button11.AutoSize = true;
            this.button11.Location = new System.Drawing.Point(14, 22);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(129, 25);
            this.button11.TabIndex = 14;
            this.button11.Text = "getting information";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.Location = new System.Drawing.Point(113, 23);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 25);
            this.button9.TabIndex = 15;
            this.button9.Text = "read record card";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.AutoSize = true;
            this.button10.Location = new System.Drawing.Point(371, 65);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(105, 25);
            this.button10.TabIndex = 16;
            this.button10.Text = "clear card data";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Visible = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button10);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.button9);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Location = new System.Drawing.Point(14, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(518, 63);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "buzzer/read card/clear card";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button29);
            this.groupBox4.Controls.Add(this.button28);
            this.groupBox4.Controls.Add(this.button27);
            this.groupBox4.Controls.Add(this.button26);
            this.groupBox4.Controls.Add(this.button25);
            this.groupBox4.Controls.Add(this.button24);
            this.groupBox4.Controls.Add(this.button23);
            this.groupBox4.Controls.Add(this.button22);
            this.groupBox4.Controls.Add(this.button21);
            this.groupBox4.Controls.Add(this.button20);
            this.groupBox4.Controls.Add(this.button19);
            this.groupBox4.Controls.Add(this.button18);
            this.groupBox4.Controls.Add(this.button17);
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.button14);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(14, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(518, 150);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "write card";
            // 
            // button29
            // 
            this.button29.AutoSize = true;
            this.button29.Location = new System.Drawing.Point(14, 151);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(165, 25);
            this.button29.TabIndex = 24;
            this.button29.Text = "card for changing address";
            this.button29.UseVisualStyleBackColor = true;
            this.button29.Visible = false;
            // 
            // button28
            // 
            this.button28.AutoSize = true;
            this.button28.Location = new System.Drawing.Point(14, 22);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(111, 25);
            this.button28.TabIndex = 23;
            this.button28.Text = "anthorizing card";
            this.button28.UseVisualStyleBackColor = true;
            this.button28.Click += new System.EventHandler(this.button28_Click);
            // 
            // button27
            // 
            this.button27.AutoSize = true;
            this.button27.Location = new System.Drawing.Point(404, 85);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 25);
            this.button27.TabIndex = 22;
            this.button27.Text = "floor card";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button26
            // 
            this.button26.AutoSize = true;
            this.button26.Location = new System.Drawing.Point(305, 85);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(93, 25);
            this.button26.TabIndex = 21;
            this.button26.Text = "building card";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button25
            // 
            this.button25.AutoSize = true;
            this.button25.Location = new System.Drawing.Point(119, 116);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(81, 25);
            this.button25.TabIndex = 20;
            this.button25.Text = "master card";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button24
            // 
            this.button24.AutoSize = true;
            this.button24.Location = new System.Drawing.Point(14, 116);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(99, 25);
            this.button24.TabIndex = 19;
            this.button24.Text = "emergency card";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // button23
            // 
            this.button23.AutoSize = true;
            this.button23.Location = new System.Drawing.Point(185, 85);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(117, 25);
            this.button23.TabIndex = 18;
            this.button23.Text = "group number card";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click);
            // 
            // button22
            // 
            this.button22.AutoSize = true;
            this.button22.Location = new System.Drawing.Point(329, 53);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(99, 25);
            this.button22.TabIndex = 17;
            this.button22.Text = "check out card";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.AutoSize = true;
            this.button21.Location = new System.Drawing.Point(185, 151);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(171, 25);
            this.button21.TabIndex = 16;
            this.button21.Text = "card for changing password";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Visible = false;
            // 
            // button20
            // 
            this.button20.AutoSize = true;
            this.button20.Location = new System.Drawing.Point(14, 85);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(165, 25);
            this.button20.TabIndex = 15;
            this.button20.Text = "group number setting card";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button19
            // 
            this.button19.AutoSize = true;
            this.button19.Location = new System.Drawing.Point(404, 22);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(81, 25);
            this.button19.TabIndex = 14;
            this.button19.Text = "lost card 2";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.AutoSize = true;
            this.button18.Location = new System.Drawing.Point(317, 22);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(81, 25);
            this.button18.TabIndex = 13;
            this.button18.Text = "lost card 1";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button17
            // 
            this.button17.AutoSize = true;
            this.button17.Location = new System.Drawing.Point(212, 22);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(99, 25);
            this.button17.TabIndex = 12;
            this.button17.Text = "time sync card";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button16
            // 
            this.button16.AutoSize = true;
            this.button16.Location = new System.Drawing.Point(14, 53);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(111, 25);
            this.button16.TabIndex = 11;
            this.button16.Text = "room number card";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.AutoSize = true;
            this.button15.Location = new System.Drawing.Point(131, 53);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(111, 25);
            this.button15.TabIndex = 10;
            this.button15.Text = "record card";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.AutoSize = true;
            this.button14.Location = new System.Drawing.Point(131, 22);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 25);
            this.button14.TabIndex = 9;
            this.button14.Text = "close card";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(376, 51);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(75, 25);
            this.button30.TabIndex = 19;
            this.button30.Text = "version information";
            this.button30.UseVisualStyleBackColor = true;
            this.button30.Click += new System.EventHandler(this.button30_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 405);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.texBRes);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cobBaud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cobBaud;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox texBRes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.TextBox textBox2;
    }
}

