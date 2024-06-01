using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 정빈이가_여친_생길_확률_계산기
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double score1 = Convert.ToDouble(txt1.Text);
                double score2 = Convert.ToDouble(txt2.Text);
                double score3 = Convert.ToDouble(txt3.Text);
                double score4 = Convert.ToDouble(txt4.Text);
                double score5 = Convert.ToDouble(txt5.Text);

                double totalscore = score1 + score2 + score3 + score4 + score5;
                    ;
                double avergescore = totalscore/5;

                txt_total.Text = totalscore.ToString();
                txt_avg.Text = avergescore.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("점수를 올바르게 입력해주세요.");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back) || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }
    }
}
