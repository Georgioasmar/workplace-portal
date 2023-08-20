using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HR
{
    public partial class Form3 : Form
    {

        public static string fullName;
        public Form3()
        {
            InitializeComponent();
            InitializeMenuText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void txt_salary_Click(object sender, EventArgs e)
        {
            if (Form1.loggedAdmin)
            {
                //this.Hide();
                //Form4 f4 = new Form4();
                //f4.Show();

                this.Hide();
                Form7 f7 = new Form7();
                f7.Show();

            }
            else
            {
                MessageBox.Show("You do not have the required privileges.");
                return;
            }
            
        }

        private void signout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txt_welcome.Text = "Welcome " + GetFirstName(Form1.loggedID) + "!";

            if (Form1.loggedAdmin)
            {
                txt_salary.Enabled = true;
            }
            else
            {
                txt_salary.Enabled = false;
            }
            if (Form1.loggedID == null)
            {
                mySalaryToolStripMenuItem.Enabled = false;
                myProfileToolStripMenuItem.Enabled = false;
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void InitializeMenuText()
        {
            
            usernameToolStripMenuItem.Text = Form1.loggedUser + " ▾";
            usernameToolStripMenuItem.ForeColor = Color.Gray; // Set color for user's name

            if (Form1.loggedAdmin)
            {
                usernameToolStripMenuItem.ForeColor = Color.Green; // Set color for user's role if admin
            }
        }

        private void OpenProfileForm(string loggedID)
        {
            // Hide the current form
            this.Hide();

            // Show the new instance of FormProfile with the loggedID argument
            FormProfile formProfile = new FormProfile(loggedID);
            formProfile.ShowDialog(); // Show the form as a modal dialog

            // Close the current form when the profile form is closed
            this.Close();
        }

        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenProfileForm(Form1.loggedID);
        }

        private void resetPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(Form1.loggedID);
            form6.Show();
        }

        private void usernameToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            OpenProfileForm(Form1.loggedID);
        }

        private void sIgnOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        public string GetFirstName(string loggedID)
        {
            string firstName = "";

            if (loggedID == null)
            {
                return "User";
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;"))
            {
                connection.Open();

                string query = "SELECT TOP 1 employeeName FROM hrdbemployee WHERE employeeID = @LoggedID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LoggedID", loggedID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string employeeName = reader["employeeName"].ToString();
                            fullName = employeeName;
                            int indexOfSpace = employeeName.IndexOf(' ');
                            if (indexOfSpace != -1)
                            {
                                firstName = employeeName.Substring(0, indexOfSpace);
                            }
                            else
                            {
                                firstName = employeeName;
                            }
                        }
                    }
                }
            }

            return firstName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            depStats fstats = new depStats();
            fstats.Show();
        }

        private void mySalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }
    }
}
