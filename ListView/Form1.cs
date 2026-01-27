using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbLargeIcon.Tag = View.LargeIcon;
            rbSmallIcon.Tag = View.SmallIcon;
            rbList.Tag = View.List;
            rbTile.Tag = View.Tile;
            rbDetails.Tag = View.Details;
        }

        public enum enGenderImage
        {
            Male = 0,
            Female = 1
        };

        enGenderImage GetImageIndex()
        {
            return (rbMale.Checked ? enGenderImage.Male : enGenderImage.Female);
        }

        int getGenderImageIndex()
        {
            return rbMale.Checked ? 0 : 1;
        }

        void ChangeImage(ListViewItem item)
        {
            item.ImageIndex = (int)GetImageIndex();
        }

        void resetControls()
        {
            txtName.Clear();
            txtGmail.Clear();
            txtJobTitle.Clear();
            txtSalary.Clear();
            rbMale.Checked = true;
            rbDetails.Checked = true;
            txtID.Clear();
            txtID.Focus();
        }

        string getTextID()
        {
            return txtID.Text.Trim();
        }

        string getTextName()
        {
            return txtName.Text.Trim();
        }

        string getTextGmail()
        {
            return txtGmail.Text.Trim();
        }

        string getTextJobTitle()
        {
            return txtJobTitle.Text.Trim();
        }

        string getTextDOB()
        {
            return dtpDateOfBirth.Text.Trim();
        }

        bool isOverlimitOfFields()
        {
            int nameSize = Convert.ToInt32(txtName.Tag);
            if (getTextName().Length > nameSize)
            {
                MessageBox.Show($"The Name Field accepts only {nameSize} letters", "Above acceptable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            int gmailSize = Convert.ToInt32(txtGmail.Tag);
            if (getTextGmail().Length > gmailSize)
            {
                MessageBox.Show($"The Gmail Field accepts only {gmailSize} letters", "Above acceptable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            int jobTitleSize = Convert.ToInt32(txtJobTitle.Tag);
            if (getTextJobTitle().Length > jobTitleSize)
            {
                MessageBox.Show($"The Job Title Field accepts only {jobTitleSize} letters", "Above acceptable", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;

        }

        bool isNumberValid(int From, int To)
        {
            try
            {
                int id = int.Parse(getTextID());

                if (id < From || id > To)
                {
                    MessageBox.Show($"Please Enter ID An Between {From} TO {To}", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (System.OverflowException)
            {
                MessageBox.Show($"Please Enter ID BETWEEN {From} TO {To}", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Only Numbers Are Allowed In The ID Field", "Numbers Only", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        bool isSalaryValid()
        {
            decimal salary;

            if (!decimal.TryParse(txtSalary.Text, out salary))
            {
                MessageBox.Show("Invalid Salary, Please enter a valid numeric value", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (salary <= 3000)
            {
                MessageBox.Show("Salary Must Be Greater Than 3000", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        bool isFieldEmpties()
        {
            if ((string.IsNullOrEmpty(getTextID())) || (string.IsNullOrEmpty(getTextName())) || (string.IsNullOrEmpty(getTextGmail())) || string.IsNullOrEmpty(getTextJobTitle())
           || string.IsNullOrEmpty(getTextDOB()))
            {
                MessageBox.Show("Please Fill In All Fields", "Fill The Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            return false;
        }

        bool isInputValid()
        {
            if (isFieldEmpties())
                return false;

            if (!(isNumberValid(1, 5000)))
                return false;

            if (isOverlimitOfFields())
                return false;

            if (!(isSalaryValid()))
                return false;



            return true;
        }


        double getSalary()
        {
            if (!isSalaryValid())
                return 0;

            return Convert.ToDouble(txtSalary.Text);
        }

        stItem sItem;
        List<stItem> InfoList = new List<stItem>();

        void FillListWithItem()
        {
            sItem.Name = getTextName();
            sItem.Gmail = getTextGmail();
            sItem.DOB = getTextDOB();
            sItem.genderImage = (global::enGenderImage)(GetImageIndex());
            sItem.JobTitle = getTextJobTitle();
            sItem.ID = getTextID();
            sItem.salary = getSalary();

            InfoList.Add(sItem);
            RefreshViewList();
        }

        ListViewItem addMainItem()
        {
            ListViewItem item = new ListViewItem(getTextID(), (int)GetImageIndex());
            return item;
        }

        ListViewItem addSubItems(ListViewItem Item)
        {
            Item.SubItems.Add(getTextName());
            Item.SubItems.Add(getTextGmail());
            Item.SubItems.Add(getTextJobTitle());
            Item.SubItems.Add(getTextDOB());
            Item.SubItems.Add(Convert.ToString(getSalary()));
            return Item;
        }




        bool CheckIfIDExist()
        {
            foreach (stItem itm in InfoList)
            {
                if (itm.ID == getTextID())
                {
                    MessageBox.Show("This ID Is Already Exists", "ID EXISTS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }


        ListViewItem addItems()
        {
            ListViewItem item = new ListViewItem();
            item = addMainItem();
            item = addSubItems(item);
            return item;
        }

        void addListItem()
        {
            if (!isInputValid())
                return;

            listView1.Items.Add(addItems());
            FillListWithItem();
            resetControls();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckIfIDExist())
            {
                return;
            }
            addListItem();
        }

        void RemoveSelectionItem()
        {
            while (listView1.SelectedItems.Count > 0)
            {
                listView1.Items.Remove(listView1.SelectedItems[0]);
            }
        }

        void RemoveInList()
        {
            if (isSelectedItemsNULL())
            {
                return;
            }

            for (int i = 0; i < InfoList.Count; i++)
            {

                if (InfoList[i].ID == listView1.SelectedItems[0].Text)
                {
                    InfoList.Remove(InfoList[i]);
                    return;
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveInList();
            RemoveSelectionItem();
        }


        // int NumberOfPerson = 0;
        //void RandomFill()
        //{


        //    for (int i = 1; i <= 10; i++)
        //    {
        //        NumberOfPerson++;
        //        ListViewItem item = new ListViewItem(NumberOfPerson.ToString());
        //        sItem.ID = i.ToString();
        //        sItem.Name = "Person" + NumberOfPerson.ToString();
        //        sItem.Gmail = "allahuAkbr@gmail.com";
        //        sItem.JobTitle = "Developer";
        //        sItem.DOB = DateTime.Now.ToString("dddd,MMMM dd,yyyy");
        //        sItem.genderImage = (global::enGenderImage)((i % 2 == 0) ? enGenderImage.Male : enGenderImage.Female);

        //        item.ImageIndex = (int)sItem.genderImage;

        //        item.SubItems.Add(sItem.Name);
        //        item.SubItems.Add(sItem.Gmail);
        //        item.SubItems.Add(sItem.JobTitle);
        //        item.SubItems.Add(sItem.DOB);
        //        listView1.Items.Add(item);


        //      InfoList.Add(sItem);

        //    }

        //}

        //private void btnFillRandom_Click(object sender, EventArgs e)
        //{
        //    RandomFill();
        //}

        private void ChangeView(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                listView1.View = (View)radioButton.Tag;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbMale.Checked = true;
            rbDetails.Checked = true;
            txtID.Focus();
        }

        bool isSelectedItemsNULL()
        {
            if (!(listView1.SelectedItems.Count > 0))
            {
                MessageBox.Show("Please choose an item from the list.", "Select Item", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;
            }
            return false;

        }
        void Display()
        {
            if (isSelectedItemsNULL())
            {
                return;
            }
            txtID.Text = listView1.SelectedItems[0].Text;
            txtName.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtGmail.Text = listView1.SelectedItems[0].SubItems[2].Text;
            txtJobTitle.Text = listView1.SelectedItems[0].SubItems[3].Text;
            dtpDateOfBirth.Value = Convert.ToDateTime(listView1.SelectedItems[0].SubItems[4].Text);
            txtSalary.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Display();
        }

        void EditInViewList()
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            //listView1.SelectedItems[0].Text = getTextID();
            listView1.SelectedItems[0].SubItems[1].Text = getTextName();
            listView1.SelectedItems[0].SubItems[2].Text = getTextGmail();
            listView1.SelectedItems[0].SubItems[3].Text = getTextJobTitle();
            listView1.SelectedItems[0].SubItems[4].Text = getTextDOB();
            listView1.SelectedItems[0].SubItems[5].Text = Convert.ToString(getSalary());
            listView1.SelectedItems[0].ImageIndex = (int)GetImageIndex();
            listView1.SelectedItems.Clear();



        }

        void EditInViewListWithValidate()
        {
            if (listView1.SelectedItems.Count > 0)
            {
                EditInViewList();
            }
        }

        stItem EditInList(stItem item)
        {
            // item.ID = getTextID();
            item.Name = getTextName();
            item.DOB = getTextDOB();
            item.JobTitle = getTextJobTitle();
            item.Gmail = getTextGmail();
            item.salary = getSalary();
            item.genderImage = (global::enGenderImage)(GetImageIndex());
            return item;
        }
        void EditInListWithValidate()
        {
            if (isSelectedItemsNULL())
            {
                return;
            }

            for (int i = 0; i < InfoList.Count; i++)
            {
                if (InfoList[i].ID == listView1.SelectedItems[0].Text)
                {
                    InfoList[i] = EditInList(InfoList[i]);
                    txtID.Text = InfoList[i].ID;
                    return;
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtID.Text = "1";

            if (!isInputValid())
                return;



            //if (CheckIfIDExist())
            //    return;

            EditInListWithValidate();
            EditInViewListWithValidate();
        }

        ListViewItem AddItemsInRefresh(stItem sItem)
        {
            ListViewItem item = new ListViewItem(sItem.ID, (int)sItem.genderImage);
            item.SubItems.Add(sItem.Name.ToString());
            item.SubItems.Add(sItem.Gmail.ToString());
            item.SubItems.Add(sItem.JobTitle.ToString());
            item.SubItems.Add(sItem.DOB.ToString());
            item.SubItems.Add(sItem.salary.ToString());
            return item;
        }

        public void RefreshViewList()
        {
            var sortedList =
                   from item in InfoList
                   orderby int.Parse(item.ID) ascending
                   select item;
            InfoList = sortedList.ToList();
            // Linq Statement ^

            listView1.Items.Clear();

            if (showMalesOnlyToolStripMenuItem.Checked)
            {
                foreach (stItem sItem in InfoList)
                {
                    if (sItem.genderImage == (global::enGenderImage.Male))
                        listView1.Items.Add(AddItemsInRefresh(sItem));
                }
            }
            else if (showFamalesOnlyToolStripMenuItem.Checked)
            {
                foreach (stItem sItem in InfoList)
                {
                    if (sItem.genderImage == (global::enGenderImage.Female))
                        listView1.Items.Add(AddItemsInRefresh(sItem));
                }
            }
            else
            {
                foreach (stItem sItem in InfoList)
                { 
                    listView1.Items.Add(AddItemsInRefresh(sItem));
                }
            }

        }

        string CalculateAge(DateTime dob)
        {
            DateTime today = DateTime.Today;

            int years = today.Year - dob.Year;
            int months = today.Month - dob.Month;


            if (today.Day < dob.Day)
                months--;


            if (months < 0)
            {
                years--;
                months += 12;
            }

            return $"{years} Years Old, {months} Months";
        }

        void idNotFoundMessage()
        {
            MessageBox.Show("ID NOT FOUND", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void turnOffSearch()
        {
            txtSearchWithNumber.Visible = false;
            btnSearchWithNumber.Visible = false;
            txtID.Focus();
        }

        void showInfo(stItem item)
        {
            string Gender = String.Empty;
            string Age = (CalculateAge(Convert.ToDateTime(item.DOB)));
            Gender = ((int)item.genderImage == 0) ? enGenderImage.Male.ToString() : enGenderImage.Female.ToString();
            SearchForm srchfrm = new SearchForm(item.ID, item.Name, item.Gmail, item.JobTitle, Age, Gender, item.salary);
            srchfrm.ShowDialog();
        }
        private void btnSearchWithNumber_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < InfoList.Count; i++)
            {

                if (InfoList[i].ID == txtSearchWithNumber.Text)
                {
                    showInfo(InfoList[i]);
                    turnOffSearch();
                    return;
                }
            }
            idNotFoundMessage();
            turnOffSearch();
        }

        void turnOffEdit()
        {
            txtEditWithNumber.Visible = false;
            btnEditWithNumber.Visible = false;
            txtID.Focus();
        }

        private void btnEditWithNumber_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < InfoList.Count; i++)
            {
                if (InfoList[i].ID == txtEditWithNumber.Text)
                {
                    EditScreen frmEdit = new EditScreen(InfoList[i]);
                    if (frmEdit.ShowDialog() == DialogResult.OK)
                        InfoList[i] = frmEdit.EditedItem;
                    RefreshViewList();
                    turnOffEdit();
                    return;
                }
            }
            turnOffEdit();
            idNotFoundMessage();
        }

        void turnOffRemove()
        {
            txtRemoveWithNumber.Visible = false;
            btnRemoveWithNumber.Visible = false;
            txtID.Focus();
        }

        private void btnRemoveWithNumber_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < InfoList.Count; i++)
            {
                if (InfoList[i].ID == txtRemoveWithNumber.Text)
                {
                    InfoList.Remove(InfoList[i]);
                    RefreshViewList();
                    turnOffRemove();
                    return;
                }
            }
            idNotFoundMessage();
            turnOffRemove();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void CheckIfWithNumbersVisible()
        {
            if (btnRemoveWithNumber.Visible == true)
            {
                btnRemoveWithNumber.Visible = false;
                txtRemoveWithNumber.Visible = false;
            }

            if (btnSearchWithNumber.Visible == true)
            {
                btnSearchWithNumber.Visible = false;
                txtSearchWithNumber.Visible = false;
            }

            if (btnEditWithNumber.Visible == true)
            {
                txtEditWithNumber.Visible = false;
                btnEditWithNumber.Visible = false;
            }
        }
        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIfWithNumbersVisible();
            txtSearchWithNumber.Visible = true;
            btnSearchWithNumber.Visible = true;
            txtSearchWithNumber.Focus();
        }

        private void txtSearchWithNumber_Leave(object sender, EventArgs e)
        {
            txtID.Focus();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIfWithNumbersVisible();
            txtEditWithNumber.Visible = true;
            btnEditWithNumber.Visible = true;
            txtEditWithNumber.Focus();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckIfWithNumbersVisible();
            txtRemoveWithNumber.Visible = true;
            btnRemoveWithNumber.Visible = true;
            txtRemoveWithNumber.Focus();
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (isSelectedItemsNULL())
            {
                return;
            }

            string selectedID = (listView1.SelectedItems[0].SubItems[0].Text);

            for (int i=0; i<InfoList.Count; i++)
            {
                if (InfoList[i].ID == selectedID)
                {
                    InfoList.Remove(InfoList[i]);
                    RefreshViewList();
                    return;
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (isSelectedItemsNULL())
            {
                return;
            }

            string selectedID = (listView1.SelectedItems[0].SubItems[0].Text);

            for (int i = 0; i < InfoList.Count; i++)
            {
                if (InfoList[i].ID == selectedID)
                {
                    EditScreen frmEdit = new EditScreen(InfoList[i]);
                    if (frmEdit.ShowDialog() == DialogResult.OK)
                        InfoList[i] = frmEdit.EditedItem;
                    RefreshViewList();
                    return;
                }
            }
        }

        void SetteingscontextMenuStripListView(bool isTrue = true)
        {
            if (isTrue)
            {
                copyDetailsToolStripMenuItem.Enabled = true;
                cardToolStripMenuItem.Enabled = true;
                updateToolStripMenuItem.Enabled = true;
                removeToolStripMenuItem1.Enabled = true;
            }
            else
            {
                copyDetailsToolStripMenuItem.Enabled = false;
                cardToolStripMenuItem.Enabled = false;
                updateToolStripMenuItem.Enabled = false;
                removeToolStripMenuItem1.Enabled = false;
            }
        }
        private void contextMenuStripListView_Opening(object sender, CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                SetteingscontextMenuStripListView(true);
            }
            else
            {
                SetteingscontextMenuStripListView(false);
                foreach (ToolStripMenuItem tsim in filterToolStripMenuItem.DropDownItems)
                {
                    tsim.Enabled = true;
                }
            }
        }

        private void cardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isSelectedItemsNULL())
            {
                return;
            }


            string SelectedID = listView1.SelectedItems[0].SubItems[0].Text;

            for (int i = 0; i < InfoList.Count; i++)
            {
                if (InfoList[i].ID == SelectedID)
                {
                    showInfo(InfoList[i]);
                }
            }
        }

        private void CheckedOnClick(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            if (clickedItem == null)
                return;

            foreach (ToolStripMenuItem item in filterToolStripMenuItem.DropDownItems)
                item.Checked = false;

            clickedItem.Checked = true;
        }

        private void FilterViewList(object sender, EventArgs e)
        {
            CheckedOnClick(sender, e);
            RefreshViewList();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveDataInTxtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\";

            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Title = "Save View List Data";
            saveFileDialog1.Filter = "Text Fiels *.txt |*.txt";

            string Line = "";
            foreach (stItem item in InfoList)
            {
                Line += item.ID + "#//#" + item.genderImage + "#//#" + item.Name + "#//#" + item.Gmail + "#//#" + item.JobTitle + "#//#" + item.DOB + "#//#" + item.salary + "#//#" + Environment.NewLine;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, Line);
                MessageBox.Show("Data Has Been Added Successfully");
            }
        }

        private void importDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";

            openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.Title = "Import Data In View List Data";
            openFileDialog1.Filter = "Text Fiels *.txt |*.txt";
            string[] lines = new string[] {};
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lines = File.ReadAllLines(openFileDialog1.FileName);
            }

            foreach (string line in lines)
            {
                string[] parts = line.Split(new string[] { "#//#" }, StringSplitOptions.None);
                stItem item = new stItem();
                item.ID = parts[0];
                string genderValue = parts[1];
                item.genderImage = (genderValue == "Male") ? global::enGenderImage.Male : global::enGenderImage.Female;
                item.Name = parts[2];
                item.Gmail = parts[3];
                item.JobTitle = parts[4];
                item.DOB = parts[5];
                item.salary = Convert.ToDouble(parts[6]);

                InfoList.Add(item);
            }
            RefreshViewList();
            MessageBox.Show("Data Has Been Imported Successfully");

        }

        void txtValidating(TextBox txt, CancelEventArgs e, int maxLength)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, $"{txt.Name} Field Should have a value");
            }
            else if (txt.Text.Length > maxLength)
            {
                e.Cancel = true;
                txt.Focus();
                errorProvider1.SetError(txt, $"{txt.Name} Field Should Be Less Than {maxLength} Letters");
            }
            else
            {
                errorProvider1.SetError(txt, "");
                e.Cancel = false;
            }
        }

        private void txtID_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int id;
            if (!int.TryParse(txtID.Text, out id))
            {
                errorProvider1.SetError(txtID, "ID Must be a Number");
                txtID.Focus();
                e.Cancel = true;

                return;
            }

            if (id > 5000 || id <= 0)
            {
                errorProvider1.SetError(txtID, "ID Must Be Between 1 And 5000");
                txtID.Focus();
                e.Cancel = true;

                return;
            }

            foreach (stItem itm in InfoList)
            {
                if (itm.ID == getTextID())
                {
                    errorProvider1.SetError(txtID, "ID Already Exists");
                    txtID.Focus();
                    e.Cancel = true;

                    return;
                }
            }


            errorProvider1.SetError(txtID, "");
            e.Cancel = false;
        }





        private void txtSalary_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            decimal salary;

            if (!decimal.TryParse(txtSalary.Text, out salary))
            {
                errorProvider1.SetError(txtSalary, "Salary Must be a Number");
                txtSalary.Focus();
                e.Cancel = true;

                return;
            }

            if (salary <= 3000)
            {
                errorProvider1.SetError(txtSalary, "Salary Must be Greater than 3000");
                txtSalary.Focus();
                e.Cancel = true;

                return;
            }

            errorProvider1.SetError(txtSalary, "");
            e.Cancel = false;

        }



        private void txtInfo_Validating(object sender, CancelEventArgs e)
        {
            int value = Convert.ToInt32(((TextBox)sender).Tag);
            txtValidating((TextBox)sender, e, value);
        }

    }
}