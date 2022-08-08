using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp.Model_Item;

namespace WinApp
{
    public partial class Add_Inventory : Form
    {
       
        public Add_Inventory(string user)
        {
            InitializeComponent();
            label7.Text = user;
        }
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
            bool flag = false;
            //@ sign is used to skip escape character
            //$ sign indicates end of string 
            Regex regex = new Regex(@"^[a-z]{2}$");

            item.number = Convert.ToInt32(txt_number.Text);
            item.dates = Convert.ToDateTime(dateTimePicker1.Value);
            item.inventory_number = Convert.ToInt32(txt_inventoryno.Text);
            item.object_name = txt_objectname.Text;
            item.count = Convert.ToInt32(txt_count.Text);
            item.price = Convert.ToDouble(txt_price.Text);
            item.isAvailable= checkBox1.Checked;
            
             //Checks if the Number entered has atleast 5 digits 
            if (txt_number.Text.Length < 5)
            {
                errorprovider.SetError(txt_number, "Digits must be 5");
            }
            //Checks if the Object name is given  
            else if(string.IsNullOrEmpty(txt_objectname.Text))
            {
                errorprovider.SetError(txt_objectname, "Object name is required");
            }
            else if ((regex.IsMatch(txt_objectname.Text)))
            {
                errorprovider.SetError(txt_objectname, "Must start with letters");
            }
            //Checks if count is entered
            else if (txt_count.Text.Length < 1)
            {
                errorprovider.SetError(txt_count, "Count is required");
            }
            else
            {
                errorprovider.Clear();
                flag = true;
            }

            //Validate if Object name starts with characters 
            


            if (flag)
            {
                MessageBox.Show(item.save() + " has been Successfully Added!!!");
                //Item.getAll();
                dgv.DataSource = null;
                dgv.DataSource = Item.getAll();
            }

          
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbtn1.Checked)
                MessageBox.Show("Simple");
            else if (rdbtn2.Checked)
                MessageBox.Show("Variable");
            else
                Console.WriteLine(" ");

            string message = " ";
            foreach(var choice in chkList.CheckedItems)
            {
                message += choice.ToString()+" ";
            }
            MessageBox.Show(message);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rdbtn2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
