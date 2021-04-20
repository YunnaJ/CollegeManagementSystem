/** Application Purpose: A form to pay student fees 
* Author: Sukhmanpreet Singh 200460404
* Date: 20/4/2021
* Time: 6:13PM
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeManagementSystem
{
    public partial class FeesForm : Form
    {
        public FeesForm()
        {
            InitializeComponent();
        }
        
        OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\CollegeDB.accdb; Persist Security Info=True");
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
            
            if (studentIDtext.Text != "")
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;

                command.CommandText = " select firstname from students where ID = " + studentIDtext.Text + "";
            
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (ds.Tables[0].Rows.Count!= 0)
                {
                    label5.Text = ds.Tables[0].Rows[0][0].ToString(); 
                }
                else
                {
                    label5.Text = "";
                }
                
            }
            else
            {
                studentIDtext.Text = "";
                label5.Text = "________";
                feesTextBox.Text = "";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connect;

            cmd.CommandText = " select * from fees where ID = " + studentIDtext.Text + "";
            
            OleDbDataAdapter DA = new OleDbDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            if (DS.Tables[0].Rows.Count == 0)
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connect;

                command.CommandText = "insert into fees(ID,amount) values (" + studentIDtext.Text + "," + feesTextBox.Text + ")";
                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);

                if (MessageBox.Show("Fees Submition Successfull.","Success", MessageBoxButtons.OK,MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    studentIDtext.Text = "";
                    label5.Text = "________";
                    feesTextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Fees has already submitted.");
                studentIDtext.Text = "";
                label5.Text = "________";
                feesTextBox.Text = "";
            }
        }
    }
}
