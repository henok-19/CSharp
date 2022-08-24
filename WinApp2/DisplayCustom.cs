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
    public partial class DisplayCustom : Form
    {
        public DisplayCustom()
        {
            InitializeComponent();
            foreach (var student in Student.getAll())
            {
                CustomControl cust = new CustomControl();
                cust.Title = student.FirstName;
                cust.Lastname = student.LastName;
                cust.Gender = student.Gender;

                cust.Click += (s, t) =>
                {
                    Details d = new Details(cust.Title);
                    d.Show();
                };
                flowLayoutPanel1.Controls.Add(cust);
            }
        }
    }
}
