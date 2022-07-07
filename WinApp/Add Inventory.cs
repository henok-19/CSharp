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
    public partial class Add_Inventory : Form
    {
        public Add_Inventory()
        {
            InitializeComponent();
        }

        private void Add_Inventory_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Item item = new Item();

            item.number = Convert.ToInt32(txt_number.Text);
            item.dates = Convert.ToDateTime(dateTimePicker1.Value);
            item.inventory_number = Convert.ToInt32(txt_number.Text);
            item.object_name = txt_objectname.Text;
            item.count = Convert.ToInt32(txt_count.Text);
            item.price = Convert.ToDouble(txt_price.Text);

            MessageBox.Show(item.save() + " has been Successfully Added!!!");
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
    }
}
