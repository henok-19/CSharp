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
    public partial class DisplayByCustom : Form
    {
        public DisplayByCustom()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            //List<string> list = new List<string>
            //{
            //    "Item 1","Item 2" ,"Item 3","Item 4"

            //};
            
            foreach (var item in Item.getAll())
            {
                CustomCard card = new CustomCard();
                card.Title = item.object_name;
                card.Inventoryno = Convert.ToString(item.inventory_number);
                card.Count = Convert.ToString(item.count);
                card.Price = Convert.ToString(item.price);
                if (item.isAvailable)
                    card.Availiablity = "Yes";
                else
                    card.Availiablity = "No";
                flowLayoutPanel1.Controls.Add(card);
            }
        }
    }
}
