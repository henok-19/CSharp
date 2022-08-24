using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string save()
        {
            student.Add(this);
            return FirstName;
        }

        public static List<Student> getAll()
        {
            return student;
        }
    }
}
