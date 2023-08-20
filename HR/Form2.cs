using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;");
        private void txt_update_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || txt_name.Text == "" || txt_add.Text == "" || txt_ph.Text == "")
            {
                MessageBox.Show("Cannot set values to null!\nyou can delete the employee by clicking on delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (txt_ph.Text.Length != 10)
            //{
            //    MessageBox.Show("Please enter a 10 digit phone number");
            //    return;
            //}
            con.Open();
            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;"))
            {
                con.Open();

                int depID = 0;
                string depName = cb_dep.Text; // Assuming cb_dep is a ComboBox with department names

                // Retrieve depID based on depName
                using (SqlCommand depCommand = new SqlCommand("SELECT depID FROM hrdbDepartment WHERE depName = @depName", con))
                {
                    depCommand.Parameters.AddWithValue("@depName", depName);
                    object depIDResult = depCommand.ExecuteScalar();
                    if (depIDResult != null && depIDResult != DBNull.Value)
                    {
                        depID = Convert.ToInt32(depIDResult);
                    }
                }

                // Update data in hrdbEmployee table
                SqlCommand cmd = new SqlCommand("UPDATE hrdbEmployee SET employeeName = @employeeName, employeeAddress = @employeeAddress, employeePhone = @employeePhone, employeeEmail = @employeeEmail, employeeAccount = @employeeAccount, empDepID = @empDepID WHERE employeeID = @employeeID", con);
                cmd.Parameters.AddWithValue("@employeeName", txt_name.Text);
                cmd.Parameters.AddWithValue("@employeeAddress", txt_add.Text);
                cmd.Parameters.AddWithValue("@employeePhone", txt_ph.Text);
                cmd.Parameters.AddWithValue("@employeeEmail", txt_email.Text);
                cmd.Parameters.AddWithValue("@employeeAccount", CreateAcc);
                cmd.Parameters.AddWithValue("@empDepID", depID); // Set the department ID
                cmd.Parameters.AddWithValue("@employeeID", txt_id.Text); // Assuming txt_id is a TextBox containing the employee ID

                cmd.ExecuteNonQuery();
            }

            if (CreateAcc)
            {
                DbFunctions.accCreation(CreateAcc, txt_id.SelectedItem.ToString(), txt_name.Text);
            }
            
            MessageBox.Show("Data Updated Successfully.");
            con.Close();
        }

        private void txt_insert_Click(object sender, EventArgs e)
        {
            
            if (txt_name.Text == "" || txt_add.Text == "" || txt_ph.Text == "")
            {
                MessageBox.Show("Please fill all the entities !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txt_ph.Text.Length > 15)
            {
                MessageBox.Show("Phone number maximum digits is 14", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string employeeName = DbFunctions.CapitalizeFirstLetterOfWords(txt_name.Text.Trim());
            string employeePhone = txt_ph.Text.Trim();

            if (DbFunctions.Exist(con, "hrdbEmployee", "employeeName", employeeName))
            //FROM hrdbEmployee WHERE employeeName = @name AND employeePhone = @phone"
            {
                MessageBox.Show("Employee record already exists in the database.");
                return;
            }

            using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;"))
            {
                con.Open();

                int depID = 0;
                string depName = cb_dep.Text; // Assuming cb_dep is a ComboBox with department names

                // Retrieve depID based on depName
                using (SqlCommand depCommand = new SqlCommand("SELECT depID FROM hrdbDepartment WHERE depName = @depName", con))
                {
                    depCommand.Parameters.AddWithValue("@depName", depName);
                    object depIDResult = depCommand.ExecuteScalar();
                    if (depIDResult != null && depIDResult != DBNull.Value)
                    {
                        depID = Convert.ToInt32(depIDResult);
                    }
                }

                // Insert data into hrdbEmployee table
                SqlCommand cmd = new SqlCommand("INSERT INTO hrdbEmployee (employeeName, employeeAddress, employeePhone, employeeEmail, employeeAccount, empDepID) VALUES (@employeeName, @employeeAddress, @employeePhone, @employeeEmail, @employeeAccount, @empDepID)", con);
                cmd.Parameters.AddWithValue("@employeeName", txt_name.Text);
                cmd.Parameters.AddWithValue("@employeeAddress", txt_add.Text);
                cmd.Parameters.AddWithValue("@employeePhone", txt_ph.Text);
                cmd.Parameters.AddWithValue("@employeeEmail", txt_email.Text);
                cmd.Parameters.AddWithValue("@employeeAccount", CreateAcc);
                cmd.Parameters.AddWithValue("@empDepID", depID); // Set the department ID

                cmd.ExecuteNonQuery();
            }



            //con.Open();
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Data Inserted Successfully.");
            //con.Close();
            //con.Open();
            //cmd.ExecuteNonQuery();
            //con.Close();
            txt_id.Items.Clear();
            DbFunctions.refreshCB(con, ref txt_id);
            RefreshComboBox(txt_name.Text);
            
            if (CreateAcc)
            {
                DbFunctions.accCreation(CreateAcc, txt_id.SelectedItem.ToString(), txt_name.Text); // will update employeeAccount
            }



            con.Open();
            SqlCommand salaryCmd = new SqlCommand("INSERT INTO hrdbSalary (employeeID, basicSalary, Transportation) VALUES (@employeeID, @basicSalary, @Transportation)", con);
            salaryCmd.Parameters.AddWithValue("@employeeID", txt_id.SelectedItem.ToString());
            salaryCmd.Parameters.AddWithValue("@basicSalary", 500);
            salaryCmd.Parameters.AddWithValue("@Transportation", 0);
            salaryCmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Inserted Successfully.");

        }

        private void txt_delete_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {
                MessageBox.Show("Please insert the id to delete !");
                return;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("delete from hrdbEmployee where employeeID = '" + txt_id.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Successfully.");
            txt_id.Text = "";
            txt_name.Text = "";
            txt_add.Text = "";
            txt_ph.Text = "";
            con.Close();
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            DbFunctions.RetrieveEmployeeData( txt_id.Text , ref txt_name, ref txt_add, ref txt_ph, ref txt_email, ref cb_dep, CheckBox_acc);

            
            //con.Open();
            //string selectquery = "select * from hrdbEmployee where employeeID =" + int.Parse(txt_id.Text);
            //SqlCommand cmd = new SqlCommand(selectquery, con);
            //SqlDataReader reader1;
            //reader1 = cmd.ExecuteReader();
            //if (reader1.Read())
            //{
            //    txt_name.Text = reader1.GetValue(1).ToString();
            //    txt_add.Text = reader1.GetValue(2).ToString();
            //    txt_ph.Text = reader1.GetValue(3).ToString();
            //}
            //else
            //{
            //    MessageBox.Show("NO DATA FOUND");
            //}
            //con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DepComboRefresh();
            DbFunctions.refreshCB(con, ref txt_id);
            if(Form1.loggedUser != "admin")
            {
                DbFunctions.RetrieveEmployeeData( Form1.loggedID, ref txt_name, ref txt_add, ref txt_ph, ref txt_email, ref cb_dep, CheckBox_acc);
                RefreshComboBox(txt_name.Text);
            }
            if (Form1.loggedAdmin)
            {
                txt_insert.Enabled = true;
                txt_delete.Enabled = true;
                txt_id.Enabled = true;
                txt_name.Enabled = true;
                CheckBox_acc.Enabled = true;
            }
            else
            {

                txt_insert.Enabled = false;
                txt_delete.Enabled = false;
                txt_id.Enabled = false;
                txt_name.Enabled = false;
                CheckBox_acc.Enabled = false;
            }
        }

        private void txt_clear_Click(object sender, EventArgs e)
        {
            txt_id.SelectedItem = null;
            txt_name.Clear();
            txt_add.Clear();
            txt_ph.Clear();
        }

        private void txt_Keyph(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Only digits are allowed in phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        //public bool Exist(string txt_name, string txt_ph, string table, string column1, string column2)
        //{
        //    con.Open();
        //    string query = "SELECT COUNT(*) FROM hrdbEmployee WHERE employeeName = @name AND employeePhone = @phone"; 
        //    using (SqlCommand command = new SqlCommand(query, con))
        //    {
        //        command.Parameters.AddWithValue("@table", table);
        //        command.Parameters.AddWithValue("@c1", column1);
        //        command.Parameters.AddWithValue("@c2", column2);
        //        command.Parameters.AddWithValue("@name", txt_name); 
        //        command.Parameters.AddWithValue("@phone", txt_ph); 
        //        int itemCount = (int)command.ExecuteScalar();
        //        con.Close();
        //        return itemCount > 0;   
        //    }
        //}

        private void ClearInputFields()
        {
            txt_name.Clear();
            txt_add.Clear();
            txt_ph.Clear();
        }

        private void BackF2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private bool CreateAcc = false; //CheckBox off by default

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         // Update the CreateAcc variable based on the checkbox's checked state
            CreateAcc = CheckBox_acc.Checked;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_id.SelectedIndex != -1) // Check if an item is selected bc -1 means no items are selected
            {
                DbFunctions.RetrieveEmployeeData(txt_id.Text, ref txt_name, ref txt_add, ref txt_ph, ref txt_email, ref cb_dep, CheckBox_acc);
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void RefreshComboBox(string employeeName)
        {
            con.Open();
            string query = "SELECT employeeID FROM hrdbEmployee WHERE employeeName = @employeeName";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@employeeName", employeeName);

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    int newEmployeeId = Convert.ToInt32(result);
                    txt_id.SelectedItem = newEmployeeId;
                }
            }
            con.Close();
        }

        private void DepComboRefresh()
        {
            string connectionString = @"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;"; // Replace with your actual connection string

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT depName FROM hrdbDepartment ORDER BY depName"; // Add ORDER BY clause

                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string depName = reader["depName"].ToString();
                        cb_dep.Items.Add(depName);
                    }
                }
            }
        }

    }
}

//{     SQL TRIGGER, ENTER NEW QUERRY
//      NB: the value that were gonna copy to (here employeeID) cannot be set as an identifier, and cannot have the increment option on

//      CREATE TRIGGER after_employee_insert
//      ON hrdbEmployee
//      AFTER INSERT
//      AS
//      BEGIN
//      INSERT INTO hrdbSalary (employeeID)
//       SELECT employeeID FROM inserted;
//      END;    }
