using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WinApp2.Model_Student;
using System.Data.SqlClient;

namespace WinApp2
{
    public partial class StudentReg : Form
    {
        public StudentReg()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            Regex reg = new Regex (@"^[a-zA-Z]+$");//Pattern to Check String
            Regex regi = new Regex(@"^[0-9]{5}$");
            Regex ri = new Regex(@"^[0-9] ");

            //Validation to check if Id is Empty or not
            if (string.IsNullOrEmpty(txtId.Text))
            {
                error.SetError(txtId, "ID is required");

            }
            else
            {
                error.Clear();
            }
            // Validation to check if FirstName is Empty or not
            if (string.IsNullOrEmpty(txtfname.Text))
            {
                error.SetError(txtfname, "First Name is required");
            }
            else
            {
                error.Clear();
            }
            // Validation to check if LastName is Empty or not
            if (string.IsNullOrEmpty(txtlname.Text))
            {
                error.SetError(txtlname, "Last Name is required");
            }
            else
            {
                error.Clear();
            }
            // Validation to check if Address is Empty or not
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                error.SetError(txtAddress, "Address is required");
            }
            else
            {
                error.Clear();
            }
            // Validation to check if School Year is Empty or not
            if (string.IsNullOrEmpty(cmbSchoolyr.Text))
            {
                error.SetError(cmbSchoolyr, "School Year is required");
            }
            else
            {
                error.Clear();
                //Validation using Regex for First and Last Name is they are strings
                if (reg.IsMatch(txtfname.Text)==false)
                {
                    error.SetError(txtfname, "Must be letters");
                }

                if (reg.IsMatch(txtlname.Text)==false)
                {
                    error.SetError(txtlname, "Must be letters");
                }
                else
                {
                    error.Clear();
                    student.Id = Convert.ToInt32(txtId.Text);
                    student.FirstName = txtfname.Text;
                    student.LastName = txtlname.Text;
                    student.Address = txtAddress.Text;
                    student.SchoolYear = cmbSchoolyr.SelectedItem.ToString();
                    student.Gender = rbtnFemale.Checked ? "Female" : "Male";

                    int Id = Convert.ToInt32(txtId.Text);
                    string FirstName = txtfname.Text;
                    string LastName = txtlname.Text;
                    string Address = txtAddress.Text;
                    string SchoolYear = cmbSchoolyr.SelectedItem.ToString();
                    string Gender = rbtnFemale.Checked ? "Female" : "Male";
                    txtId.Text = "";
                    txtfname.Text = "";
                    txtlname.Text = "";
                    txtAddress.Text = "";
                    //cm.Text = "";
                    student.save();

                   

                }
            }
                  
           
        }
    }
}
