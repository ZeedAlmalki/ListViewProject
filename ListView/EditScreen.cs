using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class EditScreen : Form
    {
        public stItem EditedItem;
        stItem item2;
        public EditScreen(stItem item)
        {
            InitializeComponent();
            txtID.Enabled = false;

            txtID.Text = item.ID;
            txtName.Text = item.Name;
            txtGmail.Text = item.Gmail;
            txtJobTitle.Text = item.JobTitle;
            txtSalary.Text = Convert.ToString(item.salary);
            
            dtpDateOfBirth.Value = Convert.ToDateTime(item.DOB);
            if ((int)item.genderImage == 0)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;

            item2 = item;
        }
        bool isInputValid()
        {
            if ((string.IsNullOrEmpty(txtID.Text)) || (string.IsNullOrEmpty(txtName.Text)) || (string.IsNullOrEmpty(txtGmail.Text)) || string.IsNullOrEmpty(txtJobTitle.Text)
                || string.IsNullOrEmpty(dtpDateOfBirth.Text))
            {
                MessageBox.Show("Please Fill All The Records", "Fill The Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }


            return true;
        }


        bool isSalaryValid()
        {
            decimal salary;

            if (!decimal.TryParse(txtSalary.Text, out salary))
            {
                MessageBox.Show("Only numbers are allowed in Salary field", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (salary <= 3000)
            {
                MessageBox.Show("Salary must be greater than 3000", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }
        stItem EditInfo()
        {
            
            EditedItem.Name = txtName.Text ?? "";
            EditedItem.ID = txtID.Text ?? "";
            EditedItem.Gmail = txtGmail.Text ?? "";
            EditedItem.JobTitle = txtJobTitle.Text ?? "";
            EditedItem.salary = Convert.ToDouble(txtSalary.Text);
            EditedItem.DOB = dtpDateOfBirth.Text.Trim();

            EditedItem.genderImage = rbMale.Checked ? enGenderImage.Male : enGenderImage.Female;

            return EditedItem;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isInputValid())
                return;

            if (!(isSalaryValid()))
                return;

                EditInfo();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
