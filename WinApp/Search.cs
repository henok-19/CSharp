using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp.Model_Item;

namespace WinApp
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var item = Item.findOne(txtItemName.Text);
            if (item == null)
            {
                MessageBox.Show("Item not found");
            }
            else 
            { 
                lblName.Text = item.object_name;
                lblno.Text = Convert.ToString(item.inventory_number);
                lblcount.Text = Convert.ToString(item.count);
                lblprice.Text = Convert.ToString(item.price);
            }
           
        }
    }
}
