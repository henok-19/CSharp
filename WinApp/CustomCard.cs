using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class CustomCard : UserControl
    {
        private string _inventoryNo;
        private string _title;
        private string _count;
        private string _price;
        private string _availablity;


        public string Inventoryno
        {
            get { return _inventoryNo; }
            set { _inventoryNo = value; lblinven.Text = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; lblName.Text = value; }
        }
        public string Count
        {
            get { return _count; }
            set { _count = value; lblCount.Text = value; }
        }
        public string Price
        {
            get { return _price; }
            set { _price = value; lblPrice.Text = value; }
        }
        public string Availiablity
        {
            get { return _availablity; }
            set { _availablity = value; lblAvail.Text = value; }
        }

        public CustomCard()
        {
            InitializeComponent();
        }

        private void CustomCard_Load(object sender, EventArgs e)
        {
            
        }
    }
}
