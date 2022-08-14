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
    public partial class Main_Window : Form
    {
        public Main_Window()
        {
            InitializeComponent();
        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if(activeScreen != null) {
                activeScreen.Close(); 
            }
               
            Add_Inventory add = new Add_Inventory();
            add.MdiParent = this;
            add.Show();
        }

        private void Main_Window_Load(object sender, EventArgs e)
        {

        }

        private void displayStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
                DisplayAllProduct dis = new DisplayAllProduct();
                dis.MdiParent = this;
                dis.Show();
            }
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
                Search s = new Search();
                s.MdiParent = this;
                s.Show();
            }
        }

        private void displayByCustomCardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
                DisplayByCustom s = new DisplayByCustom();
                s.MdiParent = this;
                s.Show();
            }
        }
    }
}
