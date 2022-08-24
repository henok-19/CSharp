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
    public partial class CustomControl : UserControl
    {
        private string _title;
        private string _lastname;
        private string _gender;

        public string Title
        {
            get { return _title; }
            set { _title = value; lblname.Text = value; }
        }
        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; lblLast.Text = value; }
        }
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; lblgender.Text = value; }
        }
        
        public CustomControl()
        {
            InitializeComponent();
        }
    }
}
