using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria
{
    public partial class Form1 : Form
    {
        List<Order> orderList = new List<Order>();
        Order order = new Order();
        public Form1()
        {
            InitializeComponent();
        }

        private void rdCafe_CheckedChanged(object sender, EventArgs e)
        {

        }
        public string getItem()
        {
            string item;
            if (rdQahwa.Checked)
            {
                item = rdQahwa.Text;
            }
            else if (rdCafe.Checked)
            {
                item = rdCafe.Text;
            }
            else
            {
                item = rdTea.Text;
            }
            return item;
        }
        public string getSize()
        {
            string size ;
            if (rd2xl.Checked)
            {
                size = rd2xl.Text;
            }
            else if (rdXl.Checked)
            {
                size = rdXl.Text;
            }
            else if (rdMd.Checked)
            {
                size = rdMd.Text;
            }
            else
            {
                size = "small";
            }
            return size;
        }
        public int getQuantity()
        {
            int quantity;
            if (rdQ1.Checked)
            {
                quantity = int.Parse(rdQ1.Text);
            }
            else if (rdQ2.Checked)
            {
                quantity = int.Parse(rdQ2.Text);
            }
            else
            {
                quantity = int.Parse(tbxQcustom.Text);
            }
            return quantity;
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            order.Item = getItem();
            order.Quantity = getQuantity();
            order.Size = getSize();

            lblitem.Text = order.Item;
            lblQuant.Text = order.Quantity.ToString();
            lblSize.Text = order.Size;
            lblPrice.Text = order.getPrice().ToString();
        }

        private void tbxQcus_TextChanged(object sender, EventArgs e)
        {
                rdQ1.Checked = false;
                rdQ2.Checked = false;

        }

        private void rdQ2_CheckedChanged(object sender, EventArgs e)
        {
            tbxQcustom.Text = "";
        }

        private void rdQ4_CheckedChanged(object sender, EventArgs e)
        {
            tbxQcustom.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            rd2xl.Checked = false;
            rdMd.Checked = false;
            rdXl.Checked = false;
        }
        void clear()
        {
            order.Item = "";
            order.Quantity = 0;
            order.Size = "";

            lblitem.Text = "...........";
            lblPrice.Text = "..................";
            lblQuant.Text = "..............";
            lblSize.Text = "...........";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            orderList.Add(order);
            MessageBox.Show("order success ");
            clear();

        }
    }
}
