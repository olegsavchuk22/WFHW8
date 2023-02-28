using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFHW8
{
    public partial class Form5 : Form
    {
        public ComputerShop tmp_shop = null;
        public Form5(ComputerShop computerShop)
        {
            InitializeComponent();
            this.tmp_shop = new ComputerShop(computerShop);
            textBox1.Text = this.tmp_shop.name;
            for (int i = 0; i < this.tmp_shop.accessories.Count; i++)
            {
                listBox1.Items.Add(this.tmp_shop.accessories[i]);
            }
            textBox2.Text = this.tmp_shop.descr;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            tmp_shop.price -= tmp_shop.accessories[listBox1.SelectedIndex].price;
            listBox1.Items.RemoveAt(index);
            tmp_shop.accessories.RemoveAt(index);
            textBox3.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            textBox3.Text = tmp_shop.accessories[listBox1.SelectedIndex].price.ToString();
        }
    }
}
