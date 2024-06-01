using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 간단한계산기
{
    public partial class Form1 : Form
    {
        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None;
        Boolean operatorChangedFlag = false;
        int firstOperand = 0;
        int secondOperand = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_rst_Click(object sender, EventArgs e)
        {
            secondOperand = Int32.Parse(display.Text);
            if(currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                display.Text = firstOperand.ToString();
            } else if(currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            }
        }

        private void zero(object sender, EventArgs e)
        {
            if (operatorChangedFlag == true)
            {
                display.Text = "";
                operatorChangedFlag = false;
            }
            string strNumber = display.Text += "0";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (operatorChangedFlag == true)
            {
                display.Text = "";
                operatorChangedFlag = false;
            }
            string strNumber = display.Text += "1";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (operatorChangedFlag == true)
            {
                display.Text = "";
                operatorChangedFlag = false;
            }
            string strNumber = display.Text += "2";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (operatorChangedFlag == true)
            {
                display.Text = "";
                operatorChangedFlag = false;
            }
            string strNumber = display.Text += "3";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (operatorChangedFlag == true)
            {
                display.Text = "";
                operatorChangedFlag = false;
            }
            string strNumber = display.Text += "4";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (operatorChangedFlag == true)
            {
                display.Text = "";
                operatorChangedFlag = false;
            }
            string strNumber = display.Text += "5";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (operatorChangedFlag == true)
            {
                display.Text = "";
                operatorChangedFlag = false;
            }
            string strNumber = display.Text += "6";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (operatorChangedFlag == true)
            {
                display.Text = "";
                operatorChangedFlag = false;
            }
            string strNumber = display.Text += "7";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (operatorChangedFlag == true)
            {
                display.Text = "";
                operatorChangedFlag = false;
            }
            string strNumber = display.Text += "8";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (operatorChangedFlag == true)
            {
                display.Text = "";
                operatorChangedFlag = false;
            }
            string strNumber = display.Text += "9";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }
    }
}
