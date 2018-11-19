namespace Jadwin_Lab4
{
    partial class CalcForm
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
            this.calcTextBox = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.sqroot = new System.Windows.Forms.Button();
            this.reciprocal = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.negPos = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.memClr = new System.Windows.Forms.Button();
            this.memRecall = new System.Windows.Forms.Button();
            this.memSave = new System.Windows.Forms.Button();
            this.memAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // calcTextBox
            // 
            this.calcTextBox.Location = new System.Drawing.Point(12, 12);
            this.calcTextBox.Name = "calcTextBox";
            this.calcTextBox.ReadOnly = true;
            this.calcTextBox.Size = new System.Drawing.Size(250, 20);
            this.calcTextBox.TabIndex = 0;
            this.calcTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // back
            // 
            this.back.ForeColor = System.Drawing.Color.Red;
            this.back.Location = new System.Drawing.Point(63, 39);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(76, 32);
            this.back.TabIndex = 1;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Clear
            // 
            this.Clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Clear.ForeColor = System.Drawing.Color.Red;
            this.Clear.Location = new System.Drawing.Point(146, 39);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(116, 32);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // seven
            // 
            this.seven.ForeColor = System.Drawing.Color.Blue;
            this.seven.Location = new System.Drawing.Point(63, 77);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(35, 34);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.ForeColor = System.Drawing.Color.Blue;
            this.eight.Location = new System.Drawing.Point(104, 77);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(35, 34);
            this.eight.TabIndex = 10;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.ForeColor = System.Drawing.Color.Blue;
            this.nine.Location = new System.Drawing.Point(145, 77);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(35, 34);
            this.nine.TabIndex = 11;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // div
            // 
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.ForeColor = System.Drawing.Color.Red;
            this.div.Location = new System.Drawing.Point(186, 77);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(35, 34);
            this.div.TabIndex = 12;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = true;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // sqroot
            // 
            this.sqroot.ForeColor = System.Drawing.Color.Blue;
            this.sqroot.Location = new System.Drawing.Point(227, 77);
            this.sqroot.Name = "sqroot";
            this.sqroot.Size = new System.Drawing.Size(35, 34);
            this.sqroot.TabIndex = 13;
            this.sqroot.Text = "sqrt";
            this.sqroot.UseVisualStyleBackColor = true;
            this.sqroot.Click += new System.EventHandler(this.sqroot_Click);
            // 
            // reciprocal
            // 
            this.reciprocal.ForeColor = System.Drawing.Color.Blue;
            this.reciprocal.Location = new System.Drawing.Point(227, 117);
            this.reciprocal.Name = "reciprocal";
            this.reciprocal.Size = new System.Drawing.Size(35, 34);
            this.reciprocal.TabIndex = 18;
            this.reciprocal.Text = "1/X";
            this.reciprocal.UseVisualStyleBackColor = true;
            this.reciprocal.Click += new System.EventHandler(this.reciprocal_Click);
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.ForeColor = System.Drawing.Color.Red;
            this.mult.Location = new System.Drawing.Point(186, 117);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(35, 34);
            this.mult.TabIndex = 17;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // six
            // 
            this.six.ForeColor = System.Drawing.Color.Blue;
            this.six.Location = new System.Drawing.Point(145, 117);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(35, 34);
            this.six.TabIndex = 16;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.ForeColor = System.Drawing.Color.Blue;
            this.five.Location = new System.Drawing.Point(104, 117);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(35, 34);
            this.five.TabIndex = 15;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.ForeColor = System.Drawing.Color.Blue;
            this.four.Location = new System.Drawing.Point(63, 117);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(35, 34);
            this.four.TabIndex = 14;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // subtract
            // 
            this.subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtract.ForeColor = System.Drawing.Color.Red;
            this.subtract.Location = new System.Drawing.Point(186, 157);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(35, 34);
            this.subtract.TabIndex = 22;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.subtract_Click);
            // 
            // three
            // 
            this.three.ForeColor = System.Drawing.Color.Blue;
            this.three.Location = new System.Drawing.Point(145, 157);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(35, 34);
            this.three.TabIndex = 21;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.ForeColor = System.Drawing.Color.Blue;
            this.two.Location = new System.Drawing.Point(104, 157);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(35, 34);
            this.two.TabIndex = 20;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.ForeColor = System.Drawing.Color.Blue;
            this.one.Location = new System.Drawing.Point(63, 157);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(35, 34);
            this.one.TabIndex = 19;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus.ForeColor = System.Drawing.Color.Red;
            this.plus.Location = new System.Drawing.Point(186, 197);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(35, 34);
            this.plus.TabIndex = 26;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // dec
            // 
            this.dec.ForeColor = System.Drawing.Color.Blue;
            this.dec.Location = new System.Drawing.Point(145, 197);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(35, 34);
            this.dec.TabIndex = 25;
            this.dec.Text = ".";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.dec_Click);
            // 
            // negPos
            // 
            this.negPos.ForeColor = System.Drawing.Color.Blue;
            this.negPos.Location = new System.Drawing.Point(104, 197);
            this.negPos.Name = "negPos";
            this.negPos.Size = new System.Drawing.Size(35, 34);
            this.negPos.TabIndex = 24;
            this.negPos.Text = "+/-";
            this.negPos.UseVisualStyleBackColor = true;
            this.negPos.Click += new System.EventHandler(this.negPos_Click);
            // 
            // zero
            // 
            this.zero.ForeColor = System.Drawing.Color.Blue;
            this.zero.Location = new System.Drawing.Point(63, 197);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(35, 34);
            this.zero.TabIndex = 23;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.ForeColor = System.Drawing.Color.Red;
            this.equal.Location = new System.Drawing.Point(227, 157);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(35, 74);
            this.equal.TabIndex = 27;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(45, 32);
            this.textBox1.TabIndex = 28;
            // 
            // memClr
            // 
            this.memClr.ForeColor = System.Drawing.Color.Red;
            this.memClr.Location = new System.Drawing.Point(12, 77);
            this.memClr.Name = "memClr";
            this.memClr.Size = new System.Drawing.Size(45, 34);
            this.memClr.TabIndex = 29;
            this.memClr.Text = "MC";
            this.memClr.UseVisualStyleBackColor = true;
            // 
            // memRecall
            // 
            this.memRecall.ForeColor = System.Drawing.Color.Red;
            this.memRecall.Location = new System.Drawing.Point(12, 117);
            this.memRecall.Name = "memRecall";
            this.memRecall.Size = new System.Drawing.Size(45, 34);
            this.memRecall.TabIndex = 30;
            this.memRecall.Text = "MR";
            this.memRecall.UseVisualStyleBackColor = true;
            // 
            // memSave
            // 
            this.memSave.ForeColor = System.Drawing.Color.Red;
            this.memSave.Location = new System.Drawing.Point(13, 157);
            this.memSave.Name = "memSave";
            this.memSave.Size = new System.Drawing.Size(44, 34);
            this.memSave.TabIndex = 31;
            this.memSave.Text = "MS";
            this.memSave.UseVisualStyleBackColor = true;
            // 
            // memAdd
            // 
            this.memAdd.ForeColor = System.Drawing.Color.Red;
            this.memAdd.Location = new System.Drawing.Point(12, 197);
            this.memAdd.Name = "memAdd";
            this.memAdd.Size = new System.Drawing.Size(45, 34);
            this.memAdd.TabIndex = 32;
            this.memAdd.Text = "M+";
            this.memAdd.UseVisualStyleBackColor = true;
            // 
            // CalcForm
            // 
            this.AcceptButton = this.equal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Clear;
            this.ClientSize = new System.Drawing.Size(273, 241);
            this.Controls.Add(this.memAdd);
            this.Controls.Add(this.memSave);
            this.Controls.Add(this.memRecall);
            this.Controls.Add(this.memClr);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.negPos);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.reciprocal);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.sqroot);
            this.Controls.Add(this.div);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.back);
            this.Controls.Add(this.calcTextBox);
            this.Name = "CalcForm";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox calcTextBox;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button sqroot;
        private System.Windows.Forms.Button reciprocal;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button negPos;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button memClr;
        private System.Windows.Forms.Button memRecall;
        private System.Windows.Forms.Button memSave;
        private System.Windows.Forms.Button memAdd;
    }
}

