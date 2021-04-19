/** Application Purpose: A class to operate teacher form
* Author: Yunna Jang 200455726
* Date: 17/4/2021
* Time: 9:13PM
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CollegeManagementSystem
{
    public partial class TeacherForm : Form
    {
        // Make a database connection object
        OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CollegeDB.accdb; Persist Security Info=True");
        
        public TeacherForm()
        {
            InitializeComponent();
      
        }

        // Method that load the data table
        private void loadTable()
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "Select * from teachers";

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                teacherDataGridView.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        // When click the Save buton
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                connection.Open();
                // Make a command object
                OleDbCommand command = new OleDbCommand();
                // Connect the command object to the database
                command.Connection = connection;

                // Prepare the insert query
                command.CommandText = "Insert into teachers (firstName, lastName, gender, DateOfBirth, email, address, course) Values (@firstName, @lastName, @gender, @DateOfBirth, @email, @address, @course)";
                // Fill the query parameters
                command.Parameters.AddWithValue("@firstName", firstNameTextBox.Text);
                command.Parameters.AddWithValue("@lastName", lastNameTextBox.Text);
                command.Parameters.AddWithValue("@gender", genderComboBox.Text);
                command.Parameters.AddWithValue("@DateOfBirth", DOBPicker.Value.Date);
                command.Parameters.AddWithValue("@email", emailTextBox.Text);
                command.Parameters.AddWithValue("@address", addressRichTextBox.Text);
                command.Parameters.AddWithValue("@course", courseTextBox.Text);

                // Execute the query
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved");
                connection.Close();

                // Clear the id fields
                idTextBox.Text = "";

                // Load the table
                loadTable();
            }
            catch (Exception ex)
            {
                // Show Error message box if there is an error
                MessageBox.Show("Error" + ex);
            }
        }

        // When click the Edit button
        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                connection.Open();
                // Make a command object
                OleDbCommand command = new OleDbCommand();
                // Connect the command object to the database
                command.Connection = connection;

                // Create the update query
                command.CommandText = "UPDATE teachers SET firstName = '"+ firstNameTextBox.Text + "', lastName = '" + lastNameTextBox.Text + "', gender = '" + genderComboBox.Text + "', DateOfBirth = '" + DOBPicker.Value.Date + "', email = '" + emailTextBox.Text + "', address = '" + addressRichTextBox.Text + "', course = '" + courseTextBox.Text + "' WHERE teacherID = " + idTextBox.Text + "";

                // Execute the query
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Edited");
                connection.Close();

                // Clear the id fields
                idTextBox.Text = "";

                // Load the table
                loadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                connection.Open();
                // Make a command object
                OleDbCommand command = new OleDbCommand();
                // Connect the command object to the database
                command.Connection = connection;

                // Create the update query
                command.CommandText = "DELETE FROM teachers WHERE teacherID = " + idTextBox.Text + "";

                // Execute the query
                command.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
                connection.Close();

                // Clear the id fields
                idTextBox.Text = "";

                // Load the table
                loadTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        // When click the reset button
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Clear the textbox fileds
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            genderComboBox.Text = "";
            DOBPicker.Value = DateTime.Now;
            emailTextBox.Text = "";
            addressRichTextBox.Text = "";
            courseTextBox.Text = "";
        }

        // If click the go back icon, close the teacherForm and open mainForm
        private void backPictureBox_Click(object sender, EventArgs e)
        {
            MainForm obj = new MainForm();
            obj.Show();
            this.Hide();
        }

        // If click the exit icon, terminate this program
        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            // Load the table
            loadTable();
        }

        // When a row is selected from dataGridView
        private void teacherDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Unable the Save button
            saveButton.Enabled = false;
            saveButton.BackColor = SystemColors.ButtonShadow;

            // Take the data of the selected row
            int indexRow = e.RowIndex;
            DataGridViewRow row = teacherDataGridView.Rows[indexRow];

            // Load the data of selected row to the textfields
            idTextBox.Text = row.Cells[0].Value.ToString();
            firstNameTextBox.Text = row.Cells[1].Value.ToString();
            lastNameTextBox.Text = row.Cells[2].Value.ToString();
            genderComboBox.Text = row.Cells[3].Value.ToString();
            DOBPicker.Value = Convert.ToDateTime(row.Cells[4].Value);
            emailTextBox.Text = row.Cells[5].Value.ToString();
            addressRichTextBox.Text = row.Cells[6].Value.ToString();
            courseTextBox.Text = row.Cells[7].Value.ToString();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            // Clear row selection
            teacherDataGridView.ClearSelection();

            // Enable the Save button
            saveButton.Enabled = true;
            saveButton.BackColor = System.Drawing.Color.GreenYellow;

            // Clear the id fields
            idTextBox.Text = "";
        }
    }
}
