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
    public partial class Form6 : Form
    {
        private string ID; // WE CREATE THE VARIABLE HERE SO WE CAN ACCESS IT FORM WIDE
        public Form6(string loggedID)
        {
            ID = loggedID;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_pas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_log_Click(object sender, EventArgs e)
        {
            if (txt_newPass.Text == txt_reenter.Text)
            {
                string updatePasswordQuery = "UPDATE hrdblogin SET Password = @newPass WHERE ID = @id";

                using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;")) // Initialize a new SqlConnection
                using (SqlCommand command = new SqlCommand(updatePasswordQuery, con))
                {
                    command.Parameters.AddWithValue("@newPass", txt_newPass.Text); // Use the new password value
                    command.Parameters.AddWithValue("@id", ID); // Use the loggedID value

                    try
                    {
                        con.Open(); // Open the connection here
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password updated successfully.");
                            //con.Close();
                            //con.Open();

                            string updateResetNextQuery = "UPDATE hrdblogin SET resetNext = 0 WHERE ID = @id";

                            using (SqlCommand toFalse_command = new SqlCommand(updateResetNextQuery, con))
                            {
                                toFalse_command.Parameters.AddWithValue("@id", Form1.loggedID);
                                toFalse_command.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password update failed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        con.Close(); // Close the connection after executing or in case of exception
                    }
                }

            }
            else
            {
                MessageBox.Show("Passwords do not match. Please reenter the same password.");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_us_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
