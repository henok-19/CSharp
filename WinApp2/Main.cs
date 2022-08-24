using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
            }

            StudentReg add = new StudentReg();
            add.MdiParent = this;
            add.Show();
        }

        private void tabularFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
            }

            DisplayTabular dt = new DisplayTabular();
            dt.MdiParent = this;
            dt.Show();
        }

        private void customFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
            }

            DisplayCustom dc = new DisplayCustom();
            dc.MdiParent = this;
            dc.Show();
        }
    }
}
