using System.Data.SqlClient;
using System.Windows.Forms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HR
{
    public class DbFunctions
    {
        public static bool GetAdminStatusForUser(string username)
        {
            string connectionString = @"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = $"SELECT Admin FROM hrdblogin WHERE Username = '{username}'";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    object result = command.ExecuteScalar();

                    if (result != null && result != System.DBNull.Value)
                    {
                        return (bool)result;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public static bool GetEmployeeAccountValueForCurrentUser(string username)
            {
                string connectionString = @"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string selectQuery = $"SELECT employeeAccount FROM hrdbEmployee WHERE Username = '{username}'";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != null && result != System.DBNull.Value)
                        {
                            return (bool)result;
                        }
                        else
                        {
                            // Handle case where user not found or employeeAccount status is null
                            // For now, assuming default to false if not found
                            return false;
                        }
                    }
                }
            }

        //public void RetrieveEmployeeData(ref ComboBox comboBox, ref TextBox txt_name, ref TextBox txt_add, ref TextBox txt_ph)
        //{
        //    if (int.TryParse(comboBox.SelectedItem?.ToString(), out int employeeID))
        //    {
        //        string connectionString = @"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;";

        //        using (SqlConnection con = new SqlConnection(connectionString))
        //        {
        //            con.Open();
        //            string selectQuery = "SELECT * FROM hrdbEmployee WHERE employeeID = @EmployeeID";

        //            using (SqlCommand cmd = new SqlCommand(selectQuery, con))
        //            {
        //                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

        //                using (SqlDataReader reader1 = cmd.ExecuteReader())
        //                {
        //                    if (reader1.Read())
        //                    {
        //                        txt_name.Text = reader1.GetValue(1).ToString();
        //                        txt_add.Text = reader1.GetValue(2).ToString();
        //                        txt_ph.Text = reader1.GetValue(3).ToString();
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("NO DATA FOUND");
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid employee ID selected.");
        //    }
        //}

        public static void RetrieveEmployeeData(string id, ref TextBox txt_name, ref TextBox txt_add, ref TextBox txt_ph, ref TextBox txt_email, ref ComboBox txt_dep, CheckBox checkBox_acc)
        {
            string connectionString = @"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string selectQuery = "SELECT * FROM hrdbEmployee WHERE employeeID = @EmployeeID";

                using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", id);

                    using (SqlDataReader reader1 = cmd.ExecuteReader())
                    {
                        if (reader1.Read())
                        {
                            txt_name.Text = reader1.GetValue(1).ToString();
                            txt_add.Text = reader1.GetValue(2).ToString();
                            txt_ph.Text = reader1.GetValue(3).ToString();

                            // Retrieve the value of the employeeEmail column
                            txt_email.Text = reader1.GetValue(5).ToString(); // Assuming employeeEmail is the 4th column (0-based index)

                            // Retrieve the value of the empDepID column
                            int empDepID = reader1.GetInt32(6); // Assuming empDepID is the 5th column (0-based index)

                            // Close the reader before executing another command
                            reader1.Close();

                            // Retrieve depName based on empDepID
                            string depName = string.Empty;
                            using (SqlCommand depCommand = new SqlCommand("SELECT depName FROM hrdbDepartment WHERE depID = @empDepID", con))
                            {
                                depCommand.Parameters.AddWithValue("@empDepID", empDepID);
                                object depNameResult = depCommand.ExecuteScalar();
                                if (depNameResult != null && depNameResult != DBNull.Value)
                                {
                                    depName = depNameResult.ToString();
                                }
                            }

                            // Set the department name in the ComboBox
                            txt_dep.Text = depName;

                            // Execute the command to retrieve isEmployeeAcc
                            using (SqlCommand accCommand = new SqlCommand("SELECT employeeAccount FROM hrdbEmployee WHERE employeeID = @EmployeeID", con))
                            {
                                accCommand.Parameters.AddWithValue("@EmployeeID", id);
                                bool isEmployeeAcc = Convert.ToBoolean(accCommand.ExecuteScalar());

                                // Update the state of the CheckBox_acc control based on the value
                                checkBox_acc.Checked = isEmployeeAcc;
                            }
                        }
                        else
                        {
                            MessageBox.Show("NO DATA FOUND");
                        }
                    }
                }
            }
        }



        //overload
        public static void RetrieveEmployeeData(string id, ref TextBox txt_name, ref TextBox txt_add, ref TextBox txt_ph, ref TextBox txt_email, ref ComboBox txt_dep)
        {
            string connectionString = @"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string selectQuery = "SELECT * FROM hrdbEmployee WHERE employeeID = @EmployeeID";

                using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", id);

                    using (SqlDataReader reader1 = cmd.ExecuteReader())
                    {
                        if (reader1.Read())
                        {
                            txt_name.Text = reader1.GetValue(1).ToString();
                            txt_add.Text = reader1.GetValue(2).ToString();
                            txt_ph.Text = reader1.GetValue(3).ToString();

                            // Retrieve the value of the employeeEmail column
                            txt_email.Text = reader1.GetValue(4).ToString(); // Assuming employeeEmail is the 4th column (0-based index)

                            // Retrieve the value of the empDepID column
                            int empDepID = reader1.GetInt32(5); // Assuming empDepID is the 5th column (0-based index)

                            // Retrieve depName based on empDepID
                            string depName = string.Empty;
                            using (SqlCommand depCommand = new SqlCommand("SELECT depName FROM hrdbDepartment WHERE depID = @empDepID", con))
                            {
                                depCommand.Parameters.AddWithValue("@empDepID", empDepID);
                                object depNameResult = depCommand.ExecuteScalar();
                                if (depNameResult != null && depNameResult != DBNull.Value)
                                {
                                    depName = depNameResult.ToString();
                                }
                            }

                            // Set the department name in the ComboBox
                            txt_dep.Text = depName;
                        }
                        else
                        {
                            MessageBox.Show("NO DATA FOUND");
                        }
                    }
                }
            }
        }


        public static void RetrieveEmployeeSalary(string id, ref TextBox salName, ref TextBox txt_Bsly, ref TextBox txt_trans)
        {
            string connectionString = @"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string selectQuery = "SELECT * FROM hrdbSalary WHERE employeeID = @EmployeeID";

                using (SqlCommand cmd = new SqlCommand(selectQuery, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", id );

                    using (SqlDataReader reader1 = cmd.ExecuteReader())
                    {
                        if (reader1.Read())
                        {
                            txt_Bsly.Text = "$" + reader1.GetValue(1).ToString() + " USD";
                            txt_trans.Text = "$" + reader1.GetValue(2).ToString() + " USD";
                        }
                        else
                        {
                            MessageBox.Show("NO DATA FOUND");
                        }
                    }
                    con.Close();
                }

                con.Open();
                string selectNameQuery = "SELECT * FROM hrdbemployee WHERE employeeID = @EmployeeID";

                using (SqlCommand cmd = new SqlCommand(selectNameQuery, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", id);

                    using (SqlDataReader reader1 = cmd.ExecuteReader())
                    {
                        if (reader1.Read())
                        {
                            salName.Text = reader1.GetValue(1).ToString();
                        }
                        else
                        {
                            MessageBox.Show("NO NAME FOUND");
                        }
                    }
                    con.Close();
                }
            }
        }

        public static void RetrieveSalaryAndEmployeeName(SqlConnection con, string employeeID, ref TextBox txt_Bsly, ref TextBox txt_trans, ref TextBox salName)
        {
            con.Open();

            // Retrieve salary information
            string selectSalaryQuery = "SELECT basicSalary, Transportation FROM hrdbSalary WHERE employeeID = @employeeID";
            SqlCommand salaryCmd = new SqlCommand(selectSalaryQuery, con);
            salaryCmd.Parameters.AddWithValue("@employeeID", employeeID);
            SqlDataReader salaryReader = salaryCmd.ExecuteReader();

            if (salaryReader.Read())
            {
                txt_Bsly.Text = salaryReader.GetValue(0).ToString();
                txt_trans.Text = salaryReader.GetValue(1).ToString();
            }
            else
            {
                MessageBox.Show("Salary Data NOT FOUND");
            }
            salaryReader.Close();

            // Retrieve employee name
            string selectNameQuery = "SELECT employeeName FROM hrdbEmployee WHERE employeeID = @employeeID";
            SqlCommand nameCmd = new SqlCommand(selectNameQuery, con);
            nameCmd.Parameters.AddWithValue("@employeeID", employeeID);
            object employeeNameResult = nameCmd.ExecuteScalar();

            if (employeeNameResult != null)
            {
                salName.Text = employeeNameResult.ToString();
            }
            else
            {
                MessageBox.Show("Employee Name NOT FOUND");
            }

            con.Close();
        }


        public static void accCreation(bool CreateAcc, string txt_id, string txt_name)
        {
            string connectionString = @"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string updateQuery = "UPDATE hrdbEmployee SET employeeAccount = @EmployeeAcc WHERE employeeID = @EmployeeID";
                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", txt_id);
                    cmd.Parameters.AddWithValue("@EmployeeAcc", CreateAcc);
                    cmd.ExecuteNonQuery();
                }


                if (CreateAcc)
                {
                    Form5 f5 = new Form5(txt_id, txt_name); ;
                    f5.Show();
                }
            }
        }

        public static void AutofillFields(string txt_name, ref TextBox txt_accUsername, ref TextBox txt_accPassword)
        {
            // Generate the username based on txt_name
            string[] nameParts = txt_name.ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string username = "";

            for (int i = 0; i < nameParts.Length; i++)
            {
                string part = nameParts[i];
                if (part != "el" && part != "al" && part != "abou")
                {
                    if (i == nameParts.Length - 1)
                    {
                        username += part + ".";
                    }
                    else
                    {
                        username += part[0] + ".";
                    }
                }
            }

            if (username.EndsWith("."))
            {
                username = username.Remove(username.Length - 1);
            }

            txt_accUsername.Text = username;
            txt_accPassword.Text = "123";


        }

        //public static bool Exist(SqlConnection con, string table, string column1, string value1, string column2, string value2)
        //{
        //    con.Open();
        //    string query = "SELECT COUNT(*) FROM @table WHERE @c1 = @v1 AND @c2 = @v2";
        //    using (SqlCommand command = new SqlCommand(query, con))
        //    {
        //        command.Parameters.AddWithValue("@table", table);
        //        command.Parameters.AddWithValue("@c1", column1);               
        //        command.Parameters.AddWithValue("@v1", value1);
        //        command.Parameters.AddWithValue("@c2", column2);
        //        command.Parameters.AddWithValue("@v2", value2);
        //        int itemCount = (int)command.ExecuteScalar();
        //        con.Close();
        //        return itemCount > 0;
        //    }
        //}

        public static bool Exist(SqlConnection con, string table, string column1, string value1)
        {
            con.Open();
            string query = $"SELECT COUNT(*) FROM {table} WHERE {column1} = @v1"; //you need to use concatenation for table and column names you cannot replace them with variables like with the value v1
            using (SqlCommand command = new SqlCommand(query, con))
            {
                //command.Parameters.AddWithValue("@table", table);
                //command.Parameters.AddWithValue("@c1", column1);
                command.Parameters.AddWithValue("@v1", value1);
     
                int itemCount = (int)command.ExecuteScalar();
                con.Close();
                return itemCount > 0;
            }
        }

        public static bool Update(SqlConnection con, string table, string column1, string value1)
        {
            con.Open();
            string query = $"SELECT COUNT(*) FROM {table} WHERE {column1} = @v1"; //you need to use concatenation for table and column names you cannot replace them with variables like with the value v1
            using (SqlCommand command = new SqlCommand(query, con))
            {
                //command.Parameters.AddWithValue("@table", table);
                //command.Parameters.AddWithValue("@c1", column1);
                command.Parameters.AddWithValue("@v1", value1);

                int itemCount = (int)command.ExecuteScalar();
                con.Close();
                return itemCount > 0;
            }
        }

        public static bool ContainsSpaces(string input)
        {
            return input.Contains(" ");
        }

        public static void refreshCB(SqlConnection con, ref ComboBox txt_id)
        {
            con.Open();
            string query = "SELECT employeeID FROM hrdbEmployee";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int employeeID = reader.GetInt32(0);
                        txt_id.Items.Add(employeeID);
                    }
                }
            }
            con.Close();
        }

        public static void checkPassReset(SqlConnection con, string loggedID)
        {
            string resetNextQuery = "SELECT resetNext FROM hrdblogin WHERE ID = @id";
            {
                using (SqlCommand command = new SqlCommand(resetNextQuery, con))
                {
                    command.Parameters.AddWithValue("@id", loggedID); // Use your txt_id control or value here

                    con.Open(); // Open the connection here
                    object result = command.ExecuteScalar();
                    con.Close(); // Close the connection after executing

                    if (result != null && result != DBNull.Value && (bool)result)
                    {
                        // Launch the new form
                        Form6 form6 = new Form6(loggedID);
                        form6.Show();

                        // Return from this method
                        return;
                    }
                }
            }
        }

        public static string CapitalizeFirstLetterOfWords(string input)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(input);
        }






    }
}
