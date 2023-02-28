using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHW8
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.data_transfer += AddData;
            form3.Show();
        }

        private void AddData(List<string> fls)
        {
            if (listBox1.Items.Count != 0)
            {
                listBox1.Items.Clear();
            }
            for (int i = 0; i < fls.Count; i++)
            {
                listBox1.Items.Add(fls[i]);
            }
        }
    }
}
