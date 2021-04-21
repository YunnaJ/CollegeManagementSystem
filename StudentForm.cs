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
                if (!connection.State.Equals(ConnectionState.Open))
                {
                    connection.Open();
                }
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "Select * from students";

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataview.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
                connection.Close();// if fatel it should still close

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
            if (idbox.Text == "")
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
<<<<<<< HEAD
                //command.CommandText = "Insert into students (ID, firstName, lastName, gender, DateOfBirth, email, address, course, startDate) Values (@ID, @firstName, @lastName, @gender, @DateOfBirth, @email, @address, @course, @startDate)";
                //NO ID CODE
                command.CommandText = "Insert into students (firstName, lastName, gender, DateOfBirth, email, address, course, startDate) Values (@firstName, @lastName, @gender, @DateOfBirth, @email, @address, @course, @startDate)";
=======
                command.CommandText = "Insert into students (firstName, lastName, gender, DateOfBirth, email, address, course, startDate) Values (@firstName, @lastName, @gender, @DateOfBirth, @email, @address, @course,'2020-09-14')";
                //command.CommandText = "Insert into students (firstName) Values (@firstName)";//Test

>>>>>>> e8edcac9a550ba6ebd8877c2a36cfa216a6e2d48
                //fill parameters
                command.Parameters.AddWithValue("@firstName", fNameBox.Text);
                command.Parameters.AddWithValue("@lastName", lNameBox.Text);
                command.Parameters.AddWithValue("@email", EmailBox.Text);
                command.Parameters.AddWithValue("@DateOfBirth", dobpicker.Value.Date);
<<<<<<< HEAD
                //left
                command.Parameters.AddWithValue("@startDate", startdatapicker.Value.Date);
=======
                //command.Parameters.AddWithValue("@startDate", startdatapicker.Value.Date);//Test
>>>>>>> e8edcac9a550ba6ebd8877c2a36cfa216a6e2d48
                command.Parameters.AddWithValue("@gender", genderBox.Text);
                command.Parameters.AddWithValue("@course", enrolledprogramBox.Text);
                command.Parameters.AddWithValue("@address", richTextBox1.Text);
<<<<<<< HEAD
                //misc //Take out the 2 lines below IF NO ID
                //if (isIDboxempty()) idbox.Text = RandomStudentID().ToString();
                //int id = Convert.ToInt32(idbox.Text);
                //command.Parameters.AddWithValue("@ID", id);
=======

>>>>>>> e8edcac9a550ba6ebd8877c2a36cfa216a6e2d48

                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Successfully Added");
                setTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                connection.Close();//so you can try again
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
                        + "', startDate = '" + startdatapicker.Value.Date
                        + "' WHERE ID = "
                        + idbox.Text + "";

                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Successfully Edited");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    connection.Close();//so you can try again
                }
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)//deletes the student
        {
            if (isIDboxempty())
                MessageBox.Show("Enter student ID(Top left)", "Error");
            else
            {
                try
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    //command code
                    command.CommandText = "DELETE FROM students WHERE ID = "
                        + idbox.Text + "";

                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Successfully Deleted");
                    setTable();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                    connection.Close();//so you can try again
                }
            }
        }
    }
}