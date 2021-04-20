/** Application Purpose: This form is the gate way to every management form 
* Author: Sukhmanpreet Singh 200460404
* Date: 20/4/2021
* Time: 6:13PM
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm student = new StudentForm();
            student.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherForm teacher = new TeacherForm();
            teacher.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CourseForm course = new CourseForm();
            course.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FeesForm fees = new FeesForm();
            fees.Show();
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
