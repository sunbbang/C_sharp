using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 엑셀
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Open_btn_Click(object sender, EventArgs e)
        {
            /*
             * 1. 파일선택기를 연다.
             * 2. 선택된 파일을 읽는다.
             * */
            string filePath = "D:/jeongseop/성적.csv";
            StreamReader file = new StreamReader(filePath);
            DataTable table = new DataTable();
            table.Columns.Add("이름");
            table.Columns.Add("국어");
            table.Columns.Add("영어");
            table.Columns.Add("수학");
            table.Columns.Add("총점");
            table.Columns.Add("평균");

            while(!file.EndOfStream)
            {
                string line = file.ReadLine();

                String[] data = line.Split(',');

                int totalScore = int.Parse(data[1]) + int.Parse(data[2]) + int.Parse(data[3]);
                double avgScore = (double)totalScore / 4;

                table.Rows.Add(data[0], data[1], data[2], data[3], totalScore, Math.Round(avgScore, 2));
            }
            
            dataGridView1.DataSource = table;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = true;

            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void data(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int chgRow = e.RowIndex;
            int chgCol = e.ColumnIndex;

            int korScore = int.Parse(dataGridView1.Rows[chgRow].Cells[1].Value.ToString());
            int EngScore = int.Parse(dataGridView1.Rows[chgRow].Cells[2].Value.ToString());
            int mathScore = int.Parse(dataGridView1.Rows[chgRow].Cells[3].Value.ToString());

            int totalScore = korScore + EngScore + mathScore; ;
            double avgScore = (double)totalScore / 4;

            dataGridView1.Rows[chgRow].Cells[4].Value = totalScore.ToString();
            dataGridView1.Rows[chgRow].Cells[5].Value = Math.Round(avgScore).ToString();
        }
    }
}
