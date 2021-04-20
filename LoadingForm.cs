/** Application Purpose: A loading page with progressbar
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
using System.Timers;
using System.Windows.Forms;

namespace CollegeManagementSystem
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            this.loadingpageprogressbartimer1.Start();
        }


        private void loadingpageprogressbartimer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.progressBar1.Maximum = 1000;
            progressBar1.PerformStep();
            
            if (progressBar1.Value == 1000)
            {
                loadingpageprogressbartimer1.Enabled = false;   
                LoginForm user = new LoginForm(); 
                user.Show();
                this.Hide();
            }
        }
    }
}
