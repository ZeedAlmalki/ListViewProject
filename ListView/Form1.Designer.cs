namespace ListView
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.IDD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Namee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gmaill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.JobTitlee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DOBB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Salaryy = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMalesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showFamalesOnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnFillRandom = new System.Windows.Forms.Button();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbDetails = new System.Windows.Forms.RadioButton();
            this.gbView = new System.Windows.Forms.GroupBox();
            this.rbList = new System.Windows.Forms.RadioButton();
            this.rbLargeIcon = new System.Windows.Forms.RadioButton();
            this.rbTile = new System.Windows.Forms.RadioButton();
            this.rbSmallIcon = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtSearchWithNumber = new System.Windows.Forms.TextBox();
            this.btnSearchWithNumber = new System.Windows.Forms.Button();
            this.txtEditWithNumber = new System.Windows.Forms.TextBox();
            this.btnEditWithNumber = new System.Windows.Forms.Button();
            this.txtRemoveWithNumber = new System.Windows.Forms.TextBox();
            this.btnRemoveWithNumber = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.personToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuStripOfListView = new System.Windows.Forms.MenuStrip();
            this.personToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataInTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImporttDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStripListView.SuspendLayout();
            this.gbView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.MenuStripOfListView.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LightCoral;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDD,
            this.Namee,
            this.Gmaill,
            this.JobTitlee,
            this.DOBB,
            this.Salaryy});
            this.listView1.ContextMenuStrip = this.contextMenuStripListView;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(0, 421);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1524, 283);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // IDD
            // 
            this.IDD.Text = "ID";
            this.IDD.Width = 150;
            // 
            // Namee
            // 
            this.Namee.Text = "Name";
            this.Namee.Width = 333;
            // 
            // Gmaill
            // 
            this.Gmaill.Text = "Gmail";
            this.Gmaill.Width = 325;
            // 
            // JobTitlee
            // 
            this.JobTitlee.Text = "JobTitle";
            this.JobTitlee.Width = 325;
            // 
            // DOBB
            // 
            this.DOBB.Text = "DOB";
            this.DOBB.Width = 237;
            // 
            // Salaryy
            // 
            this.Salaryy.Text = "Salary";
            this.Salaryy.Width = 150;
            // 
            // contextMenuStripListView
            // 
            this.contextMenuStripListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem1,
            this.updateToolStripMenuItem,
            this.cardToolStripMenuItem,
            this.copyDetailsToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.contextMenuStripListView.Name = "contextMenuStripListView";
            this.contextMenuStripListView.Size = new System.Drawing.Size(141, 114);
            this.contextMenuStripListView.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripListView_Opening);
            // 
            // removeToolStripMenuItem1
            // 
            this.removeToolStripMenuItem1.Name = "removeToolStripMenuItem1";
            this.removeToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.removeToolStripMenuItem1.Text = "Remove";
            this.removeToolStripMenuItem1.Click += new System.EventHandler(this.removeToolStripMenuItem1_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // cardToolStripMenuItem
            // 
            this.cardToolStripMenuItem.Name = "cardToolStripMenuItem";
            this.cardToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.cardToolStripMenuItem.Text = "Card";
            this.cardToolStripMenuItem.Click += new System.EventHandler(this.cardToolStripMenuItem_Click);
            // 
            // copyDetailsToolStripMenuItem
            // 
            this.copyDetailsToolStripMenuItem.Name = "copyDetailsToolStripMenuItem";
            this.copyDetailsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.copyDetailsToolStripMenuItem.Text = "Copy Details";
            this.copyDetailsToolStripMenuItem.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showMalesOnlyToolStripMenuItem,
            this.showFamalesOnlyToolStripMenuItem,
            this.showAllToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // showMalesOnlyToolStripMenuItem
            // 
            this.showMalesOnlyToolStripMenuItem.CheckOnClick = true;
            this.showMalesOnlyToolStripMenuItem.Name = "showMalesOnlyToolStripMenuItem";
            this.showMalesOnlyToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.showMalesOnlyToolStripMenuItem.Text = "Show Males Only";
            this.showMalesOnlyToolStripMenuItem.Click += new System.EventHandler(this.FilterViewList);
            // 
            // showFamalesOnlyToolStripMenuItem
            // 
            this.showFamalesOnlyToolStripMenuItem.CheckOnClick = true;
            this.showFamalesOnlyToolStripMenuItem.Name = "showFamalesOnlyToolStripMenuItem";
            this.showFamalesOnlyToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.showFamalesOnlyToolStripMenuItem.Text = "Show Females Only";
            this.showFamalesOnlyToolStripMenuItem.Click += new System.EventHandler(this.FilterViewList);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Checked = true;
            this.showAllToolStripMenuItem.CheckOnClick = true;
            this.showAllToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.showAllToolStripMenuItem.Text = "Show All";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.FilterViewList);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Boy.jpg");
            this.imageList2.Images.SetKeyName(1, "Girl.jpg");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Boy.jpg");
            this.imageList1.Images.SetKeyName(1, "Girl.jpg");
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(4, 78);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(40, 23);
            this.lblID.TabIndex = 17;
            this.lblID.Text = "ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(4, 104);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 23);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 81);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(204, 20);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "1";
            this.txtID.Validating += new System.ComponentModel.CancelEventHandler(this.txtID_Validating);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 20);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "30";
            this.txtName.Text = "Rayan Ali";
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtInfo_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 281);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 34);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(170, 281);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(152, 34);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnFillRandom
            // 
            this.btnFillRandom.Enabled = false;
            this.btnFillRandom.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillRandom.Location = new System.Drawing.Point(172, 321);
            this.btnFillRandom.Name = "btnFillRandom";
            this.btnFillRandom.Size = new System.Drawing.Size(152, 34);
            this.btnFillRandom.TabIndex = 6;
            this.btnFillRandom.Text = "Fill Random";
            this.btnFillRandom.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(12, 257);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(49, 18);
            this.rbMale.TabIndex = 7;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(91, 257);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(63, 18);
            this.rbFemale.TabIndex = 3;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbDetails
            // 
            this.rbDetails.AutoSize = true;
            this.rbDetails.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDetails.Location = new System.Drawing.Point(31, 27);
            this.rbDetails.Name = "rbDetails";
            this.rbDetails.Size = new System.Drawing.Size(60, 18);
            this.rbDetails.TabIndex = 12;
            this.rbDetails.TabStop = true;
            this.rbDetails.Tag = "";
            this.rbDetails.Text = "Details";
            this.rbDetails.UseVisualStyleBackColor = true;
            this.rbDetails.CheckedChanged += new System.EventHandler(this.ChangeView);
            // 
            // gbView
            // 
            this.gbView.Controls.Add(this.rbList);
            this.gbView.Controls.Add(this.rbLargeIcon);
            this.gbView.Controls.Add(this.rbTile);
            this.gbView.Controls.Add(this.rbSmallIcon);
            this.gbView.Controls.Add(this.rbDetails);
            this.gbView.Location = new System.Drawing.Point(548, 27);
            this.gbView.Name = "gbView";
            this.gbView.Size = new System.Drawing.Size(274, 157);
            this.gbView.TabIndex = 15;
            this.gbView.TabStop = false;
            this.gbView.Text = "View";
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbList.Location = new System.Drawing.Point(149, 69);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(43, 18);
            this.rbList.TabIndex = 10;
            this.rbList.TabStop = true;
            this.rbList.Tag = "";
            this.rbList.Text = "List";
            this.rbList.UseVisualStyleBackColor = true;
            this.rbList.CheckedChanged += new System.EventHandler(this.ChangeView);
            // 
            // rbLargeIcon
            // 
            this.rbLargeIcon.AutoSize = true;
            this.rbLargeIcon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLargeIcon.Location = new System.Drawing.Point(149, 27);
            this.rbLargeIcon.Name = "rbLargeIcon";
            this.rbLargeIcon.Size = new System.Drawing.Size(83, 18);
            this.rbLargeIcon.TabIndex = 8;
            this.rbLargeIcon.TabStop = true;
            this.rbLargeIcon.Tag = "";
            this.rbLargeIcon.Text = "Large Icon";
            this.rbLargeIcon.UseVisualStyleBackColor = true;
            this.rbLargeIcon.CheckedChanged += new System.EventHandler(this.ChangeView);
            // 
            // rbTile
            // 
            this.rbTile.AutoSize = true;
            this.rbTile.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTile.Location = new System.Drawing.Point(31, 107);
            this.rbTile.Name = "rbTile";
            this.rbTile.Size = new System.Drawing.Size(44, 18);
            this.rbTile.TabIndex = 11;
            this.rbTile.TabStop = true;
            this.rbTile.Tag = "";
            this.rbTile.Text = "Tile";
            this.rbTile.UseVisualStyleBackColor = true;
            this.rbTile.CheckedChanged += new System.EventHandler(this.ChangeView);
            // 
            // rbSmallIcon
            // 
            this.rbSmallIcon.AutoSize = true;
            this.rbSmallIcon.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmallIcon.Location = new System.Drawing.Point(31, 69);
            this.rbSmallIcon.Name = "rbSmallIcon";
            this.rbSmallIcon.Size = new System.Drawing.Size(80, 18);
            this.rbSmallIcon.TabIndex = 9;
            this.rbSmallIcon.TabStop = true;
            this.rbSmallIcon.Tag = "";
            this.rbSmallIcon.Text = "Small Icon";
            this.rbSmallIcon.UseVisualStyleBackColor = true;
            this.rbSmallIcon.CheckedChanged += new System.EventHandler(this.ChangeView);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "DOB:";
            // 
            // txtGmail
            // 
            this.txtGmail.Location = new System.Drawing.Point(131, 137);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(204, 20);
            this.txtGmail.TabIndex = 3;
            this.txtGmail.Tag = "50";
            this.txtGmail.Text = "RayanAli@gmail.com";
            this.txtGmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtInfo_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Gmail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "JOB TITLE:";
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(131, 164);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(204, 20);
            this.txtJobTitle.TabIndex = 4;
            this.txtJobTitle.Tag = "30";
            this.txtJobTitle.Text = "Backend Developer";
            this.txtJobTitle.Validating += new System.ComponentModel.CancelEventHandler(this.txtInfo_Validating);
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(131, 216);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(207, 20);
            this.dtpDateOfBirth.TabIndex = 6;
            this.dtpDateOfBirth.Value = new System.DateTime(2005, 6, 10, 0, 0, 0, 0);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(328, 281);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(152, 34);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "Copy Details";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(12, 321);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(152, 34);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSearchWithNumber
            // 
            this.txtSearchWithNumber.Location = new System.Drawing.Point(867, 33);
            this.txtSearchWithNumber.Name = "txtSearchWithNumber";
            this.txtSearchWithNumber.Size = new System.Drawing.Size(204, 20);
            this.txtSearchWithNumber.TabIndex = 24;
            this.txtSearchWithNumber.Text = "1";
            this.txtSearchWithNumber.Visible = false;
            this.txtSearchWithNumber.Leave += new System.EventHandler(this.txtSearchWithNumber_Leave);
            // 
            // btnSearchWithNumber
            // 
            this.btnSearchWithNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchWithNumber.Location = new System.Drawing.Point(1085, 27);
            this.btnSearchWithNumber.Name = "btnSearchWithNumber";
            this.btnSearchWithNumber.Size = new System.Drawing.Size(186, 34);
            this.btnSearchWithNumber.TabIndex = 13;
            this.btnSearchWithNumber.TabStop = false;
            this.btnSearchWithNumber.Text = "Search By ID";
            this.btnSearchWithNumber.UseVisualStyleBackColor = true;
            this.btnSearchWithNumber.Visible = false;
            this.btnSearchWithNumber.Click += new System.EventHandler(this.btnSearchWithNumber_Click);
            // 
            // txtEditWithNumber
            // 
            this.txtEditWithNumber.Location = new System.Drawing.Point(867, 81);
            this.txtEditWithNumber.Name = "txtEditWithNumber";
            this.txtEditWithNumber.Size = new System.Drawing.Size(204, 20);
            this.txtEditWithNumber.TabIndex = 26;
            this.txtEditWithNumber.TabStop = false;
            this.txtEditWithNumber.Text = "1";
            this.txtEditWithNumber.Visible = false;
            // 
            // btnEditWithNumber
            // 
            this.btnEditWithNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditWithNumber.Location = new System.Drawing.Point(1085, 81);
            this.btnEditWithNumber.Name = "btnEditWithNumber";
            this.btnEditWithNumber.Size = new System.Drawing.Size(186, 34);
            this.btnEditWithNumber.TabIndex = 14;
            this.btnEditWithNumber.TabStop = false;
            this.btnEditWithNumber.Text = "Edit By ID";
            this.btnEditWithNumber.UseVisualStyleBackColor = true;
            this.btnEditWithNumber.Visible = false;
            this.btnEditWithNumber.Click += new System.EventHandler(this.btnEditWithNumber_Click);
            // 
            // txtRemoveWithNumber
            // 
            this.txtRemoveWithNumber.Location = new System.Drawing.Point(867, 132);
            this.txtRemoveWithNumber.Name = "txtRemoveWithNumber";
            this.txtRemoveWithNumber.Size = new System.Drawing.Size(204, 20);
            this.txtRemoveWithNumber.TabIndex = 28;
            this.txtRemoveWithNumber.TabStop = false;
            this.txtRemoveWithNumber.Text = "1";
            this.txtRemoveWithNumber.Visible = false;
            // 
            // btnRemoveWithNumber
            // 
            this.btnRemoveWithNumber.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveWithNumber.Location = new System.Drawing.Point(1085, 125);
            this.btnRemoveWithNumber.Name = "btnRemoveWithNumber";
            this.btnRemoveWithNumber.Size = new System.Drawing.Size(186, 34);
            this.btnRemoveWithNumber.TabIndex = 15;
            this.btnRemoveWithNumber.TabStop = false;
            this.btnRemoveWithNumber.Text = "Remove By ID";
            this.btnRemoveWithNumber.UseVisualStyleBackColor = true;
            this.btnRemoveWithNumber.Visible = false;
            this.btnRemoveWithNumber.Click += new System.EventHandler(this.btnRemoveWithNumber_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Image = global::ListView.Properties.Resources.Logout1;
            this.btnLogout.Location = new System.Drawing.Point(1474, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(50, 50);
            this.btnLogout.TabIndex = 30;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Salary:";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(131, 190);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(204, 20);
            this.txtSalary.TabIndex = 5;
            this.txtSalary.Text = "7000";
            this.txtSalary.Validating += new System.ComponentModel.CancelEventHandler(this.txtSalary_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 26);
            // 
            // personToolStripMenuItem1
            // 
            this.personToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showSearchToolStripMenuItem,
            this.showEditToolStripMenuItem,
            this.showRemoveToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem1});
            this.personToolStripMenuItem1.Name = "personToolStripMenuItem1";
            this.personToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.personToolStripMenuItem1.Text = "Person";
            // 
            // showSearchToolStripMenuItem
            // 
            this.showSearchToolStripMenuItem.Name = "showSearchToolStripMenuItem";
            this.showSearchToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.showSearchToolStripMenuItem.Text = "Show Search";
            this.showSearchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // showEditToolStripMenuItem
            // 
            this.showEditToolStripMenuItem.Name = "showEditToolStripMenuItem";
            this.showEditToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.showEditToolStripMenuItem.Text = "Show Edit";
            this.showEditToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // showRemoveToolStripMenuItem
            // 
            this.showRemoveToolStripMenuItem.Name = "showRemoveToolStripMenuItem";
            this.showRemoveToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.showRemoveToolStripMenuItem.Text = "Show Remove";
            this.showRemoveToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(146, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // MenuStripOfListView
            // 
            this.MenuStripOfListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personToolStripMenuItem});
            this.MenuStripOfListView.Location = new System.Drawing.Point(0, 0);
            this.MenuStripOfListView.Name = "MenuStripOfListView";
            this.MenuStripOfListView.Size = new System.Drawing.Size(1524, 24);
            this.MenuStripOfListView.TabIndex = 32;
            this.MenuStripOfListView.Text = "menuStrip1";
            // 
            // personToolStripMenuItem
            // 
            this.personToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveDataInTxtToolStripMenuItem,
            this.ImporttDataToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.personToolStripMenuItem.Name = "personToolStripMenuItem";
            this.personToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.personToolStripMenuItem.Text = "Person";
            // 
            // saveDataInTxtToolStripMenuItem
            // 
            this.saveDataInTxtToolStripMenuItem.Name = "saveDataInTxtToolStripMenuItem";
            this.saveDataInTxtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveDataInTxtToolStripMenuItem.Text = "Save Data in Txt";
            this.saveDataInTxtToolStripMenuItem.Click += new System.EventHandler(this.saveDataInTxtToolStripMenuItem_Click);
            // 
            // ImporttDataToolStripMenuItem
            // 
            this.ImporttDataToolStripMenuItem.Name = "ImporttDataToolStripMenuItem";
            this.ImporttDataToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ImporttDataToolStripMenuItem.Text = "Import Data";
            this.ImporttDataToolStripMenuItem.Click += new System.EventHandler(this.importDataToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1524, 704);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.MenuStripOfListView);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRemoveWithNumber);
            this.Controls.Add(this.txtRemoveWithNumber);
            this.Controls.Add(this.btnEditWithNumber);
            this.Controls.Add(this.txtEditWithNumber);
            this.Controls.Add(this.btnSearchWithNumber);
            this.Controls.Add(this.txtSearchWithNumber);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbView);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.btnFillRandom);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStripListView.ResumeLayout(false);
            this.gbView.ResumeLayout(false);
            this.gbView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.MenuStripOfListView.ResumeLayout(false);
            this.MenuStripOfListView.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnFillRandom;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbDetails;
        private System.Windows.Forms.GroupBox gbView;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.RadioButton rbLargeIcon;
        private System.Windows.Forms.RadioButton rbTile;
        private System.Windows.Forms.RadioButton rbSmallIcon;
        private System.Windows.Forms.ColumnHeader IDD;
        private System.Windows.Forms.ColumnHeader Namee;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ColumnHeader Gmaill;
        private System.Windows.Forms.ColumnHeader JobTitlee;
        private System.Windows.Forms.ColumnHeader DOBB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSearchWithNumber;
        private System.Windows.Forms.Button btnSearchWithNumber;
        private System.Windows.Forms.TextBox txtEditWithNumber;
        private System.Windows.Forms.Button btnEditWithNumber;
        private System.Windows.Forms.TextBox txtRemoveWithNumber;
        private System.Windows.Forms.Button btnRemoveWithNumber;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ColumnHeader Salaryy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showSearchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showRemoveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripListView;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMalesOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showFamalesOnlyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip MenuStripOfListView;
        private System.Windows.Forms.ToolStripMenuItem personToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataInTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImporttDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

