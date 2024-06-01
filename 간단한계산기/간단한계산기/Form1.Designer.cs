namespace 간단한계산기
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.display = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.multiple = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.btn_rst = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.AutoSize = true;
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(38, 12);
            this.display.TabIndex = 0;
            this.display.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.seven, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.eight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.nine, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.four, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.five, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.six, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.multiple, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.one, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.two, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.three, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.clear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.zero, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dot, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.minus, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.plus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.divide, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 75);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 318);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("굴림", 21F);
            this.seven.Location = new System.Drawing.Point(3, 3);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(85, 73);
            this.seven.TabIndex = 0;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("굴림", 21F);
            this.eight.Location = new System.Drawing.Point(94, 3);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(85, 73);
            this.eight.TabIndex = 1;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("굴림", 21F);
            this.nine.Location = new System.Drawing.Point(185, 3);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(85, 73);
            this.nine.TabIndex = 2;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("굴림", 21F);
            this.four.Location = new System.Drawing.Point(3, 82);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(85, 73);
            this.four.TabIndex = 4;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("굴림", 21F);
            this.five.Location = new System.Drawing.Point(94, 82);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(85, 73);
            this.five.TabIndex = 5;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("굴림", 21F);
            this.six.Location = new System.Drawing.Point(185, 82);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(85, 73);
            this.six.TabIndex = 6;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // multiple
            // 
            this.multiple.Font = new System.Drawing.Font("굴림", 21F);
            this.multiple.Location = new System.Drawing.Point(276, 82);
            this.multiple.Name = "multiple";
            this.multiple.Size = new System.Drawing.Size(87, 73);
            this.multiple.TabIndex = 7;
            this.multiple.Text = "x";
            this.multiple.UseVisualStyleBackColor = true;
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("굴림", 21F);
            this.one.Location = new System.Drawing.Point(3, 161);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(85, 73);
            this.one.TabIndex = 8;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("굴림", 21F);
            this.two.Location = new System.Drawing.Point(94, 161);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(85, 73);
            this.two.TabIndex = 9;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("굴림", 21F);
            this.three.Location = new System.Drawing.Point(185, 161);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(85, 73);
            this.three.TabIndex = 10;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("굴림", 21F);
            this.clear.Location = new System.Drawing.Point(3, 240);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(85, 75);
            this.clear.TabIndex = 12;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("굴림", 21F);
            this.zero.Location = new System.Drawing.Point(94, 240);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(85, 75);
            this.zero.TabIndex = 13;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("굴림", 21F);
            this.dot.Location = new System.Drawing.Point(185, 240);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(85, 75);
            this.dot.TabIndex = 14;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("굴림", 21F);
            this.minus.Location = new System.Drawing.Point(276, 240);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(87, 75);
            this.minus.TabIndex = 15;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("굴림", 21F);
            this.plus.Location = new System.Drawing.Point(276, 161);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(87, 73);
            this.plus.TabIndex = 3;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            this.divide.Font = new System.Drawing.Font("굴림", 21F);
            this.divide.Location = new System.Drawing.Point(276, 3);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(87, 73);
            this.divide.TabIndex = 11;
            this.divide.Text = "%";
            this.divide.UseVisualStyleBackColor = true;
            // 
            // btn_rst
            // 
            this.btn_rst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_rst.Font = new System.Drawing.Font("굴림", 21F);
            this.btn_rst.Location = new System.Drawing.Point(0, 396);
            this.btn_rst.Name = "btn_rst";
            this.btn_rst.Size = new System.Drawing.Size(368, 54);
            this.btn_rst.TabIndex = 16;
            this.btn_rst.Text = "=";
            this.btn_rst.UseVisualStyleBackColor = true;
            this.btn_rst.Click += new System.EventHandler(this.btn_rst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.display);
            this.Controls.Add(this.btn_rst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button multiple;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button btn_rst;
        private System.Windows.Forms.Button divide;
    }
}

