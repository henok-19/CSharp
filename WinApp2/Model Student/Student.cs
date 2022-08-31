using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace WinApp2.Model_Student
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string SchoolYear { get; set; }
        public string Gender { get; set; }
        private static List<Student> student = new List<Student>();
        
        public static Student findOne(string name)
        {
            return student.Find(i => i.FirstName == name);
        }

        public void save()
        {
            //student.Add(this);
            //return FirstName;
            //cmd.CommandType=CommandType.Stored Procedure;  to execute stored procedure
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS; Initial Catalog=C#;Integrated Security=True");
            string q = "INSERT INTO STUDENTS VALUES(@Id,@FirstName,@LastName,@Address,@SchoolYear,@Gender) ";// ('" + this.Id + "','" + this.FirstName + "','" + this.LastName + "','" + this.Address + "','" + this.SchoolYear + "','" + this.Gender + "') ";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@id", this.Id);
            cmd.Parameters.AddWithValue("@FirstName", this.FirstName);
            cmd.Parameters.AddWithValue("@LastName", this.LastName);
            cmd.Parameters.AddWithValue("@Address", this.Address);
            cmd.Parameters.AddWithValue("@SchoolYear", this.SchoolYear);
            cmd.Parameters.AddWithValue("@Gender", this.Gender);
            try
            {
                con.Open();
                MessageBox.Show("Succefully connected");
                cmd.ExecuteNonQuery();
                //var result = cmd.ExecuteReader();
                //while (result.Read())
                //{
                //    string name = result[0].ToString();
                //    MessageBox.Show(Convert.ToString(result));
                //}
                con.Close();
                MessageBox.Show(this.FirstName+ " has been Successfully Added!!!");
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
           // return FirstName;
        }
        public void Displayall(DataGridView dgv)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-TV36L87C\SQLEXPRESS;Initial Catalog=C#;Integrated Security=True");
            string query = "spSelectAll";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                int r = 0;
                while (sdr.Read())
                {
                    dgv.Rows.Add(1);
                    dgv[0, r].Value = sdr["Id"].ToString();
                    dgv[1, r].Value = sdr["FirstName"].ToString();
                    dgv[2, r].Value = sdr["LastName"].ToString();
                    dgv[3, r].Value = sdr["Address"].ToString();
                    dgv[4, r].Value = sdr["SchoolYear"].ToString();
                    dgv[5, r].Value = sdr["Gender"].ToString();
                    r++;
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }
        public static List<Student> getAll()
        {
            return student;
        }
    }
}
