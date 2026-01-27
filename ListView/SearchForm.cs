using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class SearchForm : Form
    {
        
        public SearchForm(string ID, string Name, string Gmail, string JobTitle,string DOB, string Gender,double salary)
        {
            InitializeComponent();
            lblID.Text = ID;
            lblName.Text = Name;
            lblGmail.Text = Gmail;
            lblJobTitle.Text = JobTitle;
            lblAge.Text = DOB;
            lblGender.Text = Gender;
            lblSalary.Text = Convert.ToString(salary);
        }

    }
}
