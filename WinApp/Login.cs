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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username=txt_username.Text;
            string password=txt_password.Text;
            if(username == "Henok" && password == "password")
            {
                Add_Inventory add_Inventory = new Add_Inventory(username);
                //this.Visible = false;
                Hide();
                add_Inventory.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }
    }
}
