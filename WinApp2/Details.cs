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
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }
        public Details(string name)
        {
            InitializeComponent();
            var student = Student.findOne(name);
            lblName.Text = student.FirstName;
            lblFname.Text = student.FirstName;
            lblLname.Text = student.LastName;
            lblGender.Text = student.Gender;
            lblAddress.Text = student.Address;  
            lblYear.Text = student.SchoolYear;
            
        }

        private void Details_Load(object sender, EventArgs e)
        {

        }
    }
}
