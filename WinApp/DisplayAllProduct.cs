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
    public partial class DisplayAllProduct : Form
    {
        public DisplayAllProduct ()
        {
            InitializeComponent();
            Item item = new Item();
            dataGridView.DataSource = null;
            dataGridView.DataSource = Item.getAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
    }
}
