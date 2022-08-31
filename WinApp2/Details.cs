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
using System.Data.SqlClient;

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
            //var student = Student.findOne(name);
            //lblName.Text = student.FirstName;
            //lblFname.Text = student.FirstName;
            //lblLname.Text = student.LastName;
            //lblGender.Text = student.Gender;
            //lblAddress.Text = student.Address;  
            //lblYear.Text = student.SchoolYear;
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TV36L87C\SQLEXPRESS;
                                                    Initial Catalog=C#;
                                                    Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from Students Where Firstname='"+name+"'", con);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                int r = 0;
                while (sdr.Read())
                {
                    
                    lblName.Text = sdr["FirstName"].ToString();
                    lblFname.Text = sdr["FirstName"].ToString();
                    lblLname.Text = sdr["LastName"].ToString();
                    lblAddress.Text = sdr["Address"].ToString();
                    lblYear.Text = sdr["SchoolYear"].ToString();
                    lblGender.Text = sdr["Gender"].ToString();
                    r++;
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }

        }

        private void Details_Load(object sender, EventArgs e)
        {

        }
    }
}
