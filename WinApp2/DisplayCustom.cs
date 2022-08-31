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
    public partial class DisplayCustom : Form
    {
        public DisplayCustom()
        {
            InitializeComponent();
            //foreach (var student in Student.getAll())
            //{
            //    CustomControl cust = new CustomControl();
            //    cust.Title = student.FirstName;
            //    cust.Lastname = student.LastName;
            //    cust.Gender = student.Gender;

            //    cust.Click += (s, t) =>
            //    {
            //        Details d = new Details(cust.Title);
            //        d.Show();
            //    };
            //    flowLayoutPanel1.Controls.Add(cust);
            //}
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TV36L87C\SQLEXPRESS;
                                                    Initial Catalog=C#;
                                                    Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select Id,FirstName, LastName, Address,SchoolYear,Gender from Students", con);
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                int r = 0;
                while (sdr.Read())
                {
                    CustomControl cust = new CustomControl();
                    cust.Title = sdr["FirstName"].ToString();
                    cust.Lastname = sdr["LastName"].ToString();
                    cust.Gender = sdr["Gender"].ToString();

                   cust.Click += (s, t) =>
                   {
                       Details d = new Details(cust.Title);
                       d.Show();
                   };
                    flowLayoutPanel1.Controls.Add(cust);
                    r++;
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }
    }
}
