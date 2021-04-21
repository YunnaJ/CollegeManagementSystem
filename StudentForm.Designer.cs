
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
            this.startdatapicker = new System.Windows.Forms.DateTimePicker();
            this.dataview = new System.Windows.Forms.DataGridView();
            this.labelID = new System.Windows.Forms.Label();
            this.idbox = new System.Windows.Forms.TextBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.collegeDBDataSet1 = new CollegeManagementSystem.CollegeDBDataSet1();
            this.collegeDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dobpicker = new System.Windows.Forms.DateTimePicker();
            this.editbutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.dob = new System.Windows.Forms.Label();
            this.startdata = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDBDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startdatapicker
            // 
            this.startdatapicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startdatapicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdatapicker.Location = new System.Drawing.Point(323, 127);
            this.startdatapicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.startdatapicker.Name = "startdatapicker";
            this.startdatapicker.Size = new System.Drawing.Size(135, 20);
            this.startdatapicker.TabIndex = 72;
            // 
            // dataview
            // 
            this.dataview.AllowUserToAddRows = false;
            this.dataview.AllowUserToDeleteRows = false;
            this.dataview.AllowUserToResizeColumns = false;
            this.dataview.AllowUserToResizeRows = false;
            this.dataview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataview.Location = new System.Drawing.Point(12, 206);
            this.dataview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataview.Name = "dataview";
            this.dataview.RowHeadersWidth = 51;
            this.dataview.RowTemplate.Height = 27;
            this.dataview.Size = new System.Drawing.Size(469, 173);
            this.dataview.TabIndex = 70;
            // 
            // labelID
            // 
            this.labelID.Location = new System.Drawing.Point(153, 20);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(65, 23);
            this.labelID.TabIndex = 69;
            this.labelID.Text = "ID";
            // 
            // idbox
            // 
            this.idbox.Location = new System.Drawing.Point(12, 20);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(135, 20);
            this.idbox.TabIndex = 68;
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(405, 175);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(75, 23);
            this.deletebutton.TabIndex = 67;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            // 
            // collegeDBDataSet1
            // 
            this.collegeDBDataSet1.DataSetName = "CollegeDBDataSet1";
            this.collegeDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // collegeDBDataSet1BindingSource
            // 
            this.collegeDBDataSet1BindingSource.DataSource = this.collegeDBDataSet1;
            this.collegeDBDataSet1BindingSource.Position = 0;
            // 
            // dobpicker
            // 
            this.dobpicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dobpicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobpicker.Location = new System.Drawing.Point(99, 127);
            this.dobpicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dobpicker.Name = "dobpicker";
            this.dobpicker.Size = new System.Drawing.Size(135, 20);
            this.dobpicker.TabIndex = 71;
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(224, 177);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(75, 23);
            this.editbutton.TabIndex = 66;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = true;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(12, 177);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 65;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            // 
            // dob
            // 
            this.dob.Location = new System.Drawing.Point(28, 127);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(65, 23);
            this.dob.TabIndex = 64;
            this.dob.Text = "Data of birth";
            // 
            // startdata
            // 
            this.startdata.Location = new System.Drawing.Point(252, 127);
            this.startdata.Name = "startdata";
            this.startdata.Size = new System.Drawing.Size(65, 23);
            this.startdata.TabIndex = 63;
            this.startdata.Text = "Start Date";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(28, 156);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(79, 23);
            this.address.TabIndex = 62;
            this.address.Text = "Address";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(99, 153);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(359, 18);
            this.richTextBox1.TabIndex = 61;
            this.richTextBox1.Text = "";
            // 
            // enrolledprogram
            // 
            this.enrolledprogram.Location = new System.Drawing.Point(252, 104);
            this.enrolledprogram.Name = "enrolledprogram";
            this.enrolledprogram.Size = new System.Drawing.Size(65, 20);
            this.enrolledprogram.TabIndex = 60;
            this.enrolledprogram.Text = "Program";
            // 
            // enrolledprogramBox
            // 
            this.enrolledprogramBox.Location = new System.Drawing.Point(323, 98);
            this.enrolledprogramBox.Name = "enrolledprogramBox";
            this.enrolledprogramBox.Size = new System.Drawing.Size(135, 20);
            this.enrolledprogramBox.TabIndex = 59;
            // 
            // semesterstatus
            // 
            this.semesterstatus.Location = new System.Drawing.Point(252, 74);
            this.semesterstatus.Name = "semesterstatus";
            this.semesterstatus.Size = new System.Drawing.Size(65, 20);
            this.semesterstatus.TabIndex = 58;
            this.semesterstatus.Text = "Status";
            // 
            // Status
            // 
            this.Status.DisplayMember = "Male";
            this.Status.FormattingEnabled = true;
            this.Status.Location = new System.Drawing.Point(323, 71);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(135, 21);
            this.Status.TabIndex = 57;
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(252, 47);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(65, 20);
            this.gender.TabIndex = 56;
            this.gender.Text = "Gender";
            // 
            // genderBox
            // 
            this.genderBox.DisplayMember = "Male";
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Location = new System.Drawing.Point(323, 44);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(135, 21);
            this.genderBox.TabIndex = 55;
            this.genderBox.ValueMember = "Male";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(99, 101);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(135, 20);
            this.EmailBox.TabIndex = 54;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(28, 101);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(65, 23);
            this.email.TabIndex = 53;
            this.email.Text = "Email";
            // 
            // lNameBox
            // 
            this.lNameBox.Location = new System.Drawing.Point(99, 74);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.Size = new System.Drawing.Size(135, 20);
            this.lNameBox.TabIndex = 52;
            // 
            // fNameBox
            // 
            this.fNameBox.Location = new System.Drawing.Point(99, 47);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.Size = new System.Drawing.Size(135, 20);
            this.fNameBox.TabIndex = 51;
            // 
            // Lname
            // 
            this.Lname.Location = new System.Drawing.Point(28, 74);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(65, 13);
            this.Lname.TabIndex = 50;
            this.Lname.Text = "Last Name";
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(28, 47);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(65, 23);
            this.Fname.TabIndex = 49;
            this.Fname.Text = "First Name";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 398);
            this.Controls.Add(this.startdatapicker);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.dobpicker);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.startdata);
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
            ((System.ComponentModel.ISupportInitialize)(this.collegeDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDBDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startdatapicker;
        private System.Windows.Forms.DataGridView dataview;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox idbox;
        private System.Windows.Forms.Button deletebutton;
        private CollegeDBDataSet1 collegeDBDataSet1;
        private System.Windows.Forms.BindingSource collegeDBDataSet1BindingSource;
        private System.Windows.Forms.DateTimePicker dobpicker;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Label dob;
        private System.Windows.Forms.Label startdata;
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
    }
}