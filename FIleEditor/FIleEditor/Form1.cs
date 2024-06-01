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
using System.Windows.Forms.VisualStyles;

namespace FIleEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            String file_path = null;
            openFileDialog1.InitialDirectory = "C:\\";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file_path = openFileDialog1.FileName;
                txtFilePath.Text = file_path;
            }

            Console.WriteLine(file_path);
            string[] textvalue = System.IO.File.ReadAllLines(file_path);
            rchTxtBox.Clear();
            if (textvalue.Length > 0 )
            {
                for (int i = 0; i < textvalue.Length; i++)
                {
                    string svalue = textvalue[i];
                    rchTxtBox.AppendText(svalue + "\n");
                }
            }
           
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text (*.txt)|*.txt|모든파일(*.*)|*.*";

            if(save.ShowDialog() == DialogResult.OK)
            {
                FileStream file = new FileStream(save.FileName, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file);
                writer.WriteLine(rchTxtBox.Text);

                writer.Flush();
                writer.Close();
                file.Close();
            }
        }

        private void btnMake_Click(object sender, EventArgs e)
        {

        }
    }
}
