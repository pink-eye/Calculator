namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.delast = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.pow = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 29);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(12, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(116, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(187, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(134, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(47, 22);
            this.textBox4.TabIndex = 3;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(19, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonsALL);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(74, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.buttonsALL);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.Location = new System.Drawing.Point(129, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 41);
            this.button3.TabIndex = 6;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.buttonsALL);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button4.Location = new System.Drawing.Point(19, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 41);
            this.button4.TabIndex = 7;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.buttonsALL);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Silver;
            this.button5.Location = new System.Drawing.Point(74, 173);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 41);
            this.button5.TabIndex = 8;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.buttonsALL);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Silver;
            this.button6.Location = new System.Drawing.Point(129, 173);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 41);
            this.button6.TabIndex = 9;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.buttonsALL);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button7.Location = new System.Drawing.Point(19, 214);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 41);
            this.button7.TabIndex = 10;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.buttonsALL);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Silver;
            this.button8.Location = new System.Drawing.Point(74, 214);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 41);
            this.button8.TabIndex = 11;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.buttonsALL);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Silver;
            this.button9.Location = new System.Drawing.Point(129, 214);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 41);
            this.button9.TabIndex = 12;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.buttonsALL);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightPink;
            this.button10.Location = new System.Drawing.Point(74, 255);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 41);
            this.button10.TabIndex = 13;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.buttonsALL);
            // 
            // dot
            // 
            this.dot.BackColor = System.Drawing.Color.LightPink;
            this.dot.Location = new System.Drawing.Point(129, 255);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(55, 41);
            this.dot.TabIndex = 14;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = false;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // delast
            // 
            this.delast.BackColor = System.Drawing.Color.LightPink;
            this.delast.Location = new System.Drawing.Point(19, 255);
            this.delast.Name = "delast";
            this.delast.Size = new System.Drawing.Size(55, 41);
            this.delast.TabIndex = 15;
            this.delast.Text = "C";
            this.delast.UseVisualStyleBackColor = false;
            this.delast.Click += new System.EventHandler(this.textClear);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.PaleGreen;
            this.div.Location = new System.Drawing.Point(184, 92);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(55, 41);
            this.div.TabIndex = 16;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.operChoose);
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.Color.PeachPuff;
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mult.Location = new System.Drawing.Point(184, 133);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(55, 41);
            this.mult.TabIndex = 17;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.operChoose);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.PeachPuff;
            this.minus.Location = new System.Drawing.Point(184, 174);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(55, 41);
            this.minus.TabIndex = 18;
            this.minus.Text = "—";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.operChoose);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.PeachPuff;
            this.plus.Location = new System.Drawing.Point(184, 215);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(55, 41);
            this.plus.TabIndex = 19;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.operChoose);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.LightPink;
            this.equal.Location = new System.Drawing.Point(184, 255);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(110, 41);
            this.equal.TabIndex = 20;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.Color.PaleGreen;
            this.sqrt.Location = new System.Drawing.Point(19, 92);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(55, 41);
            this.sqrt.TabIndex = 21;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = false;
            this.sqrt.Click += new System.EventHandler(this.funcChoose);
            // 
            // pow
            // 
            this.pow.BackColor = System.Drawing.Color.PaleGreen;
            this.pow.Location = new System.Drawing.Point(74, 92);
            this.pow.Name = "pow";
            this.pow.Size = new System.Drawing.Size(55, 41);
            this.pow.TabIndex = 22;
            this.pow.Text = "^";
            this.pow.UseVisualStyleBackColor = false;
            this.pow.Click += new System.EventHandler(this.operChoose);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.PaleGreen;
            this.del.Location = new System.Drawing.Point(129, 92);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(55, 41);
            this.del.TabIndex = 23;
            this.del.Text = "<--";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // exp
            // 
            this.exp.BackColor = System.Drawing.Color.PaleGreen;
            this.exp.Location = new System.Drawing.Point(239, 92);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(55, 41);
            this.exp.TabIndex = 24;
            this.exp.Text = "exp";
            this.exp.UseVisualStyleBackColor = false;
            this.exp.Click += new System.EventHandler(this.funcChoose);
            // 
            // Form1
            // 
            this.AcceptButton = this.equal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(315, 311);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.del);
            this.Controls.Add(this.pow);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.div);
            this.Controls.Add(this.delast);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button delast;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button pow;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button exp;
    }
}

