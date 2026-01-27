namespace ListView
{
    partial class EditScreen
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
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtJobTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(312, 217);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(207, 20);
            this.dtpDateOfBirth.TabIndex = 28;
            this.dtpDateOfBirth.Value = new System.DateTime(2006, 6, 18, 0, 0, 0, 0);
            // 
            // txtJobTitle
            // 
            this.txtJobTitle.Location = new System.Drawing.Point(312, 188);
            this.txtJobTitle.Name = "txtJobTitle";
            this.txtJobTitle.Size = new System.Drawing.Size(204, 20);
            this.txtJobTitle.TabIndex = 27;
            this.txtJobTitle.Text = "Full stack WebDeveloper";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "JOB TITLE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Gmail:";
            // 
            // txtGmail
            // 
            this.txtGmail.Location = new System.Drawing.Point(312, 154);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(204, 20);
            this.txtGmail.TabIndex = 26;
            this.txtGmail.Text = "zeed71071@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "DOB:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(312, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 20);
            this.txtName.TabIndex = 25;
            this.txtName.Text = "Zaid Al-Malki";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(312, 86);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(204, 20);
            this.txtID.TabIndex = 24;
            this.txtID.Text = "1134";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(196, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(72, 23);
            this.lblName.TabIndex = 29;
            this.lblName.Text = "Name:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(196, 86);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(40, 23);
            this.lblID.TabIndex = 30;
            this.lblID.Text = "ID:";
            // 
            // button1
            // 
            this.button1.Image = global::ListView.Properties.Resources.Edit;
            this.button1.Location = new System.Drawing.Point(371, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 34;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(373, 394);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Edit";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(407, 306);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(63, 18);
            this.rbFemale.TabIndex = 36;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(333, 306);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(49, 18);
            this.rbMale.TabIndex = 37;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(312, 246);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(204, 20);
            this.txtSalary.TabIndex = 39;
            this.txtSalary.Text = "30000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(196, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "Salary:";
            // 
            // EditScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.txtJobTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Name = "EditScreen";
            this.Text = "EditScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtJobTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label label5;
    }
}