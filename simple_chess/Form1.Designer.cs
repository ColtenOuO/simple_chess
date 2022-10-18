namespace simple_chess
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(253, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "開始遊戲";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "P1 準備階段";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(602, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "10";
            this.label2.TextChanged += new System.EventHandler(this.label2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "P1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1089, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = "P2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 78);
            this.button2.TabIndex = 5;
            this.button2.Text = "戰士: 1 顆";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(86, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 78);
            this.button3.TabIndex = 6;
            this.button3.Text = "法師: 1 顆";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(86, 524);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 78);
            this.button4.TabIndex = 7;
            this.button4.Text = "遊俠: 1 顆";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1051, 262);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 78);
            this.button5.TabIndex = 8;
            this.button5.Text = "戰士: 1 顆";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1051, 381);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 78);
            this.button6.TabIndex = 9;
            this.button6.Text = "法師: 1 顆";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1051, 515);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 78);
            this.button7.TabIndex = 10;
            this.button7.Text = "遊俠: 1 顆";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(22, 677);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(125, 55);
            this.button8.TabIndex = 11;
            this.button8.Text = "攻擊";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(181, 677);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(125, 55);
            this.button9.TabIndex = 12;
            this.button9.Text = "移動";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(22, 768);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(125, 55);
            this.button10.TabIndex = 13;
            this.button10.Text = "技能";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(181, 768);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(125, 55);
            this.button11.TabIndex = 14;
            this.button11.Text = "待機";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(1152, 677);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(125, 55);
            this.button13.TabIndex = 16;
            this.button13.Text = "移動";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(996, 768);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(125, 55);
            this.button14.TabIndex = 17;
            this.button14.Text = "技能";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(1152, 768);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(125, 55);
            this.button15.TabIndex = 18;
            this.button15.Text = "待機";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1083, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "label6";
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(996, 704);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(301, 90);
            this.button16.TabIndex = 21;
            this.button16.Text = "結束回合";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(996, 677);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(125, 55);
            this.button12.TabIndex = 15;
            this.button12.Text = "攻擊";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 881);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button12;
    }
}

