using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHW8._3
{
    public delegate void SendData(string text);
    public partial class Form3_2 : Form
    {
        public event SendData SendData;
        public Form3_2(string text)
        {
            InitializeComponent();
            this.textBox1.Text = text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.SendData(textBox1.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
