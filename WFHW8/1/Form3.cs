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

namespace WFHW8
{
    public partial class Form3 : Form
    {
        List<string> file_list = new List<string>();
        public delegate void DataTransfer(List<string> data);
        public event DataTransfer data_transfer;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folder.SelectedPath;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Поля не можуть бути пустими", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            foreach(string item in Directory.GetFileSystemEntries(textBox1.Text, textBox2.Text))
            {
                FileInfo file = new FileInfo(item);
                file_list.Add(file.Name);
            }
            this.data_transfer(file_list);
            file_list.Clear();
            this.Close();
        }
    }
}
