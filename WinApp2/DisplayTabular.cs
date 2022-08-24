using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp2.Model_Student;

namespace WinApp2
{
    public partial class DisplayTabular : Form
    {
        public DisplayTabular()
        {
            InitializeComponent();
            Student student = new Student();
            dgv.DataSource = null;
            dgv.DataSource = Student.getAll();
        }
    }
}
