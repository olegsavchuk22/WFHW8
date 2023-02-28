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
    public partial class Form4 : Form
    {
        List<ComputerShop> compos = new List<ComputerShop>() { new ComputerShop("PC1", new List<Accessories> { new Accessories("Monitor", 10000), new Accessories("Case", 5000), new Accessories("Keyboard", 1000)}, "Intel i7/ RTX3090/ DDR5", 50000),
                                                               new ComputerShop("PC2", new List<Accessories> { new Accessories("Monitor", 8000), new Accessories("Case", 3000), new Accessories("Keyboard", 800)}, "Intel i5/ RTX2080TI/ DDR5", 40000),
                                                               new ComputerShop("PC3", new List<Accessories> { new Accessories("Monitor", 6000), new Accessories("Case", 3000), new Accessories("Keyboard", 500)}, "Intel XENON/ 1650TI/ DDR5", 30500),};
        public Form4()
        {
            InitializeComponent();
            for (int i = 0; i < compos.Count; i++)
            {
                comboBox1.Items.Add(compos[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedItem);
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            ComputerShop tmp = (ComputerShop)listBox1.SelectedItem;
            textBox1.Text = tmp.price.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal tmp_price = 0;
            foreach(ComputerShop item in listBox1.Items)
            {
                tmp_price+=item.price;
            }
            MessageBox.Show($"Загальна ціна: {tmp_price}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems == null || listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Виберіть елемент для видалення!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            textBox1.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems != null && listBox1.SelectedIndex != -1)
            {
                int index = listBox1.SelectedIndex;
                Form5 form = new Form5(new ComputerShop((ComputerShop)listBox1.SelectedItem));
                form.ShowDialog();
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Insert(index, form.tmp_shop);
                textBox1.Text = form.tmp_shop.price.ToString();
                return;
            }
            MessageBox.Show("Виберіть елемент!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
