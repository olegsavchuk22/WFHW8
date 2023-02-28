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

namespace WFHW8._3
{
    public partial class Form3_1 : Form
    {
        string path = string.Empty;
        public Form3_1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "All files (*.*)|*.*|txt files (*.txt)|*.txt";
            fileDialog.FilterIndex = 2;
            path = fileDialog.FileName;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader streamReader = File.OpenText(fileDialog.FileName);
                textBox1.Text = streamReader.ReadToEnd();
                streamReader.Close();
            }
            btnEdit.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form3_2 form = new Form3_2(textBox1.Text);
            form.SendData += DataRecive;
            form.Show();
            if (form.DialogResult == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(path);
                streamWriter.Write(textBox1.Text);
                streamWriter.Close();
            }
        }

        private void DataRecive(string text)
        {
            this.textBox1.Text = text;
        }
    }
}
