using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
/*
 * Aviraj Gill
 * 4:35
 * 2021-04-20
 * This part takes care of students lets you add them and edit also delete
 * List blow
 Student Management
- Profile form
•    student ID (auto-created) added(function)
•    first name added(UI)
•    last name added(UI) 
•    gender added(UI)
•    date of birth added(UI)
•    email added(UI) 
•    address added(UI) 
•    enrolled program added(UI)
•    start date added(UI)
•    semester status added(UI)
-  Add / edit/ delete button added(UI) added(function)
- Table that shows all students added(UI) added(function)
- 
 */
namespace CollegeManagementSystem
{
    public partial class StudentForm : Form
    {
        //thanks to Yunna for the Connection Queries help

        //DB connection
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CollegeDB.accdb; Persist Security Info=True");

        public StudentForm()
        {
            InitializeComponent();
            AddListToCombobox();//set the drop down options
        }
        private void setTable()// function to set up the table
        {
            try
            {
                if (!connection.State.Equals(ConnectionState.Open)) connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                //command for sql
                command.CommandText = "Select * from students";

                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable Table = new DataTable();
                //fill
                adapter.Fill(Table);
                dataview.DataSource = Table;

                //close
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);//Error check
            }
        }
        private int RandomStudentID()// makes a random num 16 long
        {
            for (int i = 0; i < 16;)
                return new Random().Next();
            return 0;
        }
        private void AddListToCombobox()// function fills the combobox
        {
            //Gender box
            genderBox.Items.Add("Male");
            genderBox.Items.Add("Female");
            //Status for Attending
            Status.Items.Add("Attending");
            Status.Items.Add("Not attending");
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            setTable();//on load it'll set table
        }
        private bool isIDboxempty()//function to check if ID box is null or not
        {
            if (idbox.Text == null)
                return true;
            return false;
        }
        private void addbutton_Click(object sender, EventArgs e)//addes new id and stuff 
        {
            try
            {
                if (!connection.State.Equals(ConnectionState.Open)) connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                //command for sql
                command.CommandText = "Insert into students (ID, firstName, lastName, gender, DateOfBirth, email, address, course, startdata) Values (@ID, @firstName, @lastName, @gender, @DateOfBirth, @email, @address, @course, @startdata)";
                //fill parameters
                //right
                command.Parameters.AddWithValue("@firstName", fNameBox.Text);
                command.Parameters.AddWithValue("@lastName", lNameBox.Text);
                command.Parameters.AddWithValue("@email", email.Text);
                command.Parameters.AddWithValue("@DateOfBirth", dobpicker.Value.Date);
                //left
                command.Parameters.AddWithValue("@startdata", startdatapicker.Value.Date);
                command.Parameters.AddWithValue("@gender", genderBox.Text);
                command.Parameters.AddWithValue("@course", enrolledprogramBox.Text);
                //command.Parameters.AddWithValue("@Status", Status.Text);//not in use 
                //bottom
                command.Parameters.AddWithValue("@address", richTextBox1.Text);
                //misc 
                if(isIDboxempty()) idbox.Text = RandomStudentID().ToString();
                command.Parameters.AddWithValue("@ID", idbox.Text);

                command.ExecuteNonQuery();
                connection.Close();
                setTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void editbutton_Click(object sender, EventArgs e)//edits the student profile
        {
            if (isIDboxempty())
                MessageBox.Show("Error: ", "Enter student ID(Top left)");
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    //command code
                    command.CommandText = "UPDATE students SET firstName = '"
                        + fNameBox.Text
                        + "', lastName = '"
                        + lNameBox.Text
                        + "', gender = '" + genderBox.Text
                        + "', DateOfBirth = '" + dobpicker.Value.Date
                        + "', email = '" + email.Text
                        + "', address = '" + richTextBox1.Text
                        + "', course = '" + enrolledprogramBox.Text
                        + "' WHERE ID = "
                        + idbox.Text + "";

                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully Edited");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)//deletes the student
        {
            if (isIDboxempty())
                MessageBox.Show("Error: ", "Enter student ID(Top left)");
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    //command code
                    command.CommandText = "DELETE FROM teachers WHERE ID = "
                        + idbox.Text + "";

                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully Deleted");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
        }
    }
}
