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
    public partial class Form5 : Form
    {

        private string txt_id;
        private string txt_name;
        private bool isAdmin = false; //CheckBox off by default
        private bool resetNext = false;
        
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;");

        public Form5(string id, string name)
        {
            InitializeComponent();
            txt_id = id;
            txt_name = name;
            //Form5_Load(sender, e)
            //DbFunctions.AutofillFields(txt_name, ref txt_accUsername, ref txt_accPassword);
        }

        private void txt_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form2 f2 = new Form2();
            //f2.ShowDialog();
        }

        private void txt_insrt_Click(object sender, EventArgs e) //aka SAVE
        {
            if (txt_accUsername.Text == "" || txt_accPassword.Text == "")
            {
                MessageBox.Show("Please fill all the entities !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DbFunctions.ContainsSpaces(txt_accUsername.Text) || DbFunctions.ContainsSpaces(txt_accPassword.Text))
            {
                MessageBox.Show("One of the input fields contains spaces.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (DbFunctions.Exist( con, "hrdblogin", "Username", txt_accUsername.Text))
            {
                //MessageBox.Show("Employee record already exists in the database.");
                con.Open();

                string query = "UPDATE hrdblogin SET Password = @password, Admin = @admin, resetNext = @resetNext WHERE ID = @id OR Username = @username; ";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@password", txt_accPassword.Text);
                    command.Parameters.AddWithValue("@id", txt_id);
                    command.Parameters.AddWithValue("@username", txt_accUsername.Text);
                    command.Parameters.AddWithValue("@admin", isAdmin);
                    command.Parameters.AddWithValue("@resetNext", resetNext);

                    command.ExecuteNonQuery();
                }

                //cmd.ExecuteNonQuery();
                MessageBox.Show("Password Updated Successfully.");
                con.Close();
                return;
            }
            else
            {
                con.Open();

                string query = "INSERT INTO hrdblogin (ID, Username, Password, Admin) VALUES (@id, @username, @password, @Admin)";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", txt_id); // is already transformed to string no need for .Text
                    command.Parameters.AddWithValue("@username", txt_accUsername.Text); // Use .Text --> string
                    command.Parameters.AddWithValue("@password", txt_accPassword.Text); // Use .Text --> string
                    command.Parameters.AddWithValue("@Admin", isAdmin); //updating the admin

                    command.ExecuteNonQuery();
                    con.Close();
                }
                MessageBox.Show("Account Saved Successfully.");
            }

            //// Set Admin column value for the same ID
            //string admin_query = "UPDATE hrdblogin SET Admin = @Admin WHERE ID = @id";

            //using (SqlCommand command = new SqlCommand(admin_query, con))
            //{
            //    command.Parameters.AddWithValue("@Admin", isAdmin);
            //    command.Parameters.AddWithValue("@id", txt_id); // Use .SelectedItem to get the selected ID

            //    command.ExecuteNonQuery();
            //}

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //admin privileges
        {
            isAdmin = checkBox_admin.Checked;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e) //password change
        {
            resetNext = checkBox_changePass.Checked;
        }

        private void txt_updt_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // Loading checkbox
            {
                string auto_query = "SELECT Admin FROM hrdblogin WHERE ID = @id";

                using (SqlCommand command = new SqlCommand(auto_query, con))
                {
                    command.Parameters.AddWithValue("@id", txt_id); // Use your txt_id control or value here

                    con.Open(); // Open the connection here
                    object result = command.ExecuteScalar();
                    con.Close(); // Close the connection after executing

                    if (result != null && result != DBNull.Value && (bool)result)
                    {
                        checkBox_admin.Checked = true;
                        isAdmin = true;
                    }
                    else
                    {
                        checkBox_admin.Checked = false;
                        isAdmin = false;
                    }
                }


            }
            {
                string resetNextQuery = "SELECT resetNext FROM hrdblogin WHERE ID = @id";

                using (SqlCommand command = new SqlCommand(resetNextQuery, con))
                {
                    command.Parameters.AddWithValue("@id", txt_id); // Use your txt_id control or value here

                    con.Open(); // Open the connection here
                    object result = command.ExecuteScalar();
                    con.Close(); // Close the connection after executing

                    if (result != null && result != DBNull.Value && (bool)result)
                    {
                        checkBox_changePass.Checked = true;
                        resetNext = true;
                    }
                    else
                    {
                        checkBox_changePass.Checked = false;
                        resetNext = false;
                    }
                }
            }

            //locking checkboxes if not admin


            // Autofills if there's data or not
            string query = "SELECT Username, Password FROM hrdblogin WHERE ID = @id";
            con.Open();
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@id", txt_id); // Use .SelectedItem to get the selected ID

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string username = reader["Username"].ToString();
                        string password = reader["Password"].ToString();

                        if (!string.IsNullOrEmpty(username))
                        {
                            txt_accUsername.Text = username;
                            txt_accPassword.Text = password;
                            txt_accUsername.Enabled = false;
                        }
                        else
                        {
                            // Autofill if Username is empty
                            DbFunctions.AutofillFields(txt_name.ToLower(), ref txt_accUsername, ref txt_accPassword);
                            txt_accUsername.Enabled = true;
                        }
                    }
                    else
                    {
                        DbFunctions.AutofillFields(txt_name, ref txt_accUsername, ref txt_accPassword);
                        txt_accUsername.Enabled = true;
                        // No record found for the selected ID, handle accordingly
                    }
                }
            }
            con.Close();

        }



    }
}
