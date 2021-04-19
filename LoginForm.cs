/** Application Purpose: A class to operate teacher form
* Author: Yunna Jang 200455726
* Date: 17/4/2021
* Time: 10:13PM
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

namespace CollegeManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // When user click the login button
        private void loginButton_Click(object sender, EventArgs e)
        {
            // If the textbox is empty, ask user to fill it
            if(nameTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Enter Name and Password");
            }
            // If the user input the correct name and password, login the user
            else if (nameTextBox.Text == "Manager" && Int32.Parse(passwordTextBox.Text) == 1234)
            {
                MessageBox.Show("Successfully Logged In");
                MainForm obj = new MainForm();
                obj.Show();
                this.Hide();
            } 
            // If the user input wrong name or password, inform to user
            else
            {
                MessageBox.Show("Wrong Name or Password");
            }
        }

        // If user click the Reset label, clear the textbox fields
        private void resetLabel_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        // If the user click the exit icon, terminate the application
        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
