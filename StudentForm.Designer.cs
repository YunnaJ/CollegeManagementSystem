
namespace CollegeManagementSystem
{
    partial class StudentForm
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
            this.deletebutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.dob = new System.Windows.Forms.Label();
            this.startdatapicker = new System.Windows.Forms.DateTimePicker();
            this.startdata = new System.Windows.Forms.Label();
            this.dobpicker = new System.Windows.Forms.DateTimePicker();
            this.address = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.enrolledprogram = new System.Windows.Forms.Label();
            this.enrolledprogramBox = new System.Windows.Forms.TextBox();
            this.semesterstatus = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.ComboBox();
            this.gender = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.lNameBox = new System.Windows.Forms.TextBox();
            this.fNameBox = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.Label();
            this.Fname = new System.Windows.Forms.Label();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.collegeDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDBDataSet1 = new CollegeManagementSystem.CollegeDBDataSet1();
            this.idbox = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(405, 233);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 42;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(202, 233);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(75, 23);
            this.editbutton.TabIndex = 41;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(12, 235);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 40;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(28, 119);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(65, 23);
            this.dob.TabIndex = 39;
            this.dob.Text = "Data of birth";
            // 
            // startdatapicker
            // 
            this.startdatapicker.Location = new System.Drawing.Point(323, 119);
            this.startdatapicker.Name = "startdatapicker";
            this.startdatapicker.Size = new System.Drawing.Size(135, 20);
            this.startdatapicker.TabIndex = 38;
            // 
            // startdata
            // 
            this.startdata.Location = new System.Drawing.Point(252, 119);
            this.startdata.Name = "startdata";
            this.startdata.Size = new System.Drawing.Size(65, 23);
            this.startdata.TabIndex = 37;
            this.startdata.Text = "Start Data";
            // 
            // dobpicker
            // 
            this.dobpicker.Location = new System.Drawing.Point(99, 119);
            this.dobpicker.Name = "dobpicker";
            this.dobpicker.Size = new System.Drawing.Size(135, 20);
            this.dobpicker.TabIndex = 36;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(28, 148);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(79, 23);
            this.address.TabIndex = 35;
            this.address.Text = "Address";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(99, 145);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(359, 18);
            this.richTextBox1.TabIndex = 34;
            this.richTextBox1.Text = "";
            // 
            // enrolledprogram
            // 
            this.enrolledprogram.Location = new System.Drawing.Point(252, 96);
            this.enrolledprogram.Name = "enrolledprogram";
            this.enrolledprogram.Size = new System.Drawing.Size(65, 20);
            this.enrolledprogram.TabIndex = 33;
            this.enrolledprogram.Text = "Program";
            // 
            // enrolledprogramBox
            // 
            this.enrolledprogramBox.Location = new System.Drawing.Point(323, 90);
            this.enrolledprogramBox.Name = "enrolledprogramBox";
            this.enrolledprogramBox.Size = new System.Drawing.Size(135, 20);
            this.enrolledprogramBox.TabIndex = 32;
            // 
            // semesterstatus
            // 
            this.semesterstatus.Location = new System.Drawing.Point(252, 66);
            this.semesterstatus.Name = "semesterstatus";
            this.semesterstatus.Size = new System.Drawing.Size(65, 20);
            this.semesterstatus.TabIndex = 31;
            this.semesterstatus.Text = "Status";
            // 
            // Status
            // 
            this.Status.DisplayMember = "Male";
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(323, 63);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(135, 21);
            this.Status.TabIndex = 30;
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(252, 39);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(65, 20);
            this.gender.TabIndex = 29;
            this.gender.Text = "Gender";
            // 
            // genderBox
            // 
            this.genderBox.DisplayMember = "Male";
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Location = new System.Drawing.Point(323, 36);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(135, 21);
            this.genderBox.TabIndex = 28;
            this.genderBox.ValueMember = "Male";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(99, 93);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(135, 20);
            this.EmailBox.TabIndex = 27;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(28, 93);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(65, 23);
            this.email.TabIndex = 26;
            this.email.Text = "Email";
            // 
            // lNameBox
            // 
            this.lNameBox.Location = new System.Drawing.Point(99, 66);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(135, 20);
            this.lNameBox.TabIndex = 25;
            // 
            // fNameBox
            // 
            this.fNameBox.Location = new System.Drawing.Point(99, 39);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(135, 20);
            this.fNameBox.TabIndex = 24;
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(28, 66);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(65, 13);
            this.Lname.TabIndex = 23;
            this.Lname.Text = "Last Name";
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(28, 39);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(65, 23);
            this.Fname.TabIndex = 22;
            this.Fname.Text = "First Name";
            // 
            // dataview
            // 
            this.dataview.AutoGenerateColumns = false;
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.DataSource = this.collegeDBDataSet1BindingSource;
            this.dataview.Location = new System.Drawing.Point(31, 169);
            this.dataview.Name = "dataview";
            this.dataview.Size = new System.Drawing.Size(427, 58);
            this.dataview.TabIndex = 43;
            // 
            // collegeDBDataSet1BindingSource
            // 
            this.collegeDBDataSet1BindingSource.DataSource = this.collegeDBDataSet1;
            this.collegeDBDataSet1BindingSource.Position = 0;
            // 
            // collegeDBDataSet1
            // 
            this.collegeDBDataSet1.DataSetName = "CollegeDBDataSet1";
            this.collegeDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(12, 12);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(135, 20);
            this.idbox.TabIndex = 44;
            // 
            // labelID
            // 
            this.labelID.Location = new System.Drawing.Point(153, 12);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(65, 23);
            this.labelID.TabIndex = 45;
            this.labelID.Text = "ID";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 259);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.startdatapicker);
            this.Controls.Add(this.startdata);
            this.Controls.Add(this.dobpicker);
            this.Controls.Add(this.address);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.enrolledprogram);
            this.Controls.Add(this.enrolledprogramBox);
            this.Controls.Add(this.semesterstatus);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lNameBox);
            this.Controls.Add(this.fNameBox);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.DateTimePicker startdatapicker;
        private System.Windows.Forms.Label startdata;
        private System.Windows.Forms.DateTimePicker dobpicker;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label enrolledprogram;
        private System.Windows.Forms.TextBox enrolledprogramBox;
        private System.Windows.Forms.Label semesterstatus;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox lNameBox;
        private System.Windows.Forms.TextBox fNameBox;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Fname;
        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.BindingSource collegeDBDataSet1BindingSource;
        private CollegeDBDataSet1 collegeDBDataSet1;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Label labelID;
    }
}