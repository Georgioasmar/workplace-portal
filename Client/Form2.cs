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
using Business;

namespace Client
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;");
        //private void txt_update_Click(object sender, EventArgs e)
        //{
        //    if (txt_id.Text == "" || txt_name.Text == "" || txt_add.Text == "" || txt_ph.Text == "")
        //    {
        //        MessageBox.Show("Cannot set values to null!\nyou can delete the employee by clicking on delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }
        //    //if (txt_ph.Text.Length != 10)
        //    //{
        //    //    MessageBox.Show("Please enter a 10 digit phone number");
        //    //    return;
        //    //}
        //    con.Open();
        //    using (SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;"))
        //    {
        //        con.Open();

        //        int depID = 0;
        //        string depName = cb_dep.Text; // Assuming cb_dep is a ComboBox with department names

        //        // Retrieve depID based on depName
        //        using (SqlCommand depCommand = new SqlCommand("SELECT depID FROM hrdbDepartment WHERE depName = @depName", con))
        //        {
        //            depCommand.Parameters.AddWithValue("@depName", depName);
        //            object depIDResult = depCommand.ExecuteScalar();
        //            if (depIDResult != null && depIDResult != DBNull.Value)
        //            {
        //                depID = Convert.ToInt32(depIDResult);
        //            }
        //        }

        //        // Update data in hrdbEmployee table
        //        SqlCommand cmd = new SqlCommand("UPDATE hrdbEmployee SET employeeName = @employeeName, employeeAddress = @employeeAddress, employeePhone = @employeePhone, employeeEmail = @employeeEmail, employeeAccount = @employeeAccount, empDepID = @empDepID WHERE employeeID = @employeeID", con);
        //        cmd.Parameters.AddWithValue("@employeeName", txt_name.Text);
        //        cmd.Parameters.AddWithValue("@employeeAddress", txt_add.Text);
        //        cmd.Parameters.AddWithValue("@employeePhone", txt_ph.Text);
        //        cmd.Parameters.AddWithValue("@employeeEmail", txt_email.Text);
        //        cmd.Parameters.AddWithValue("@employeeAccount", CreateAcc);
        //        cmd.Parameters.AddWithValue("@empDepID", depID); // Set the department ID
        //        cmd.Parameters.AddWithValue("@employeeID", txt_id.Text); // Assuming txt_id is a TextBox containing the employee ID

        //        cmd.ExecuteNonQuery();
        //    }

        //    //if (CreateAcc)
        //    //{
        //    //    DbFunctions.accCreation(CreateAcc, txt_id.SelectedItem.ToString(), txt_name.Text);
        //    //}
            
        //    MessageBox.Show("Data Updated Successfully.");
        //    con.Close();
        //}

        private void txt_insert_Click(object sender, EventArgs e) //save
        {
            if (txt_name.Text == "")
            {
                MessageBox.Show("Please fill the Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cb_pos.Text == "")
            {
                cb_pos.SelectedIndex = 1;
            }
            if (txt_ph.Text.Length > 15)
            {
                MessageBox.Show("Phone number maximum digits is 14", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var context = new HrDbContext()) // Replace with your actual context creation
            {
                string employeeName = DbFunctions.CapitalizeFirstLetterOfWords(txt_name.Text.Trim());

                int? parsedEmployeeId = null; // Use nullable int to represent no ID selected

                if (!string.IsNullOrWhiteSpace(txt_id.Text))
                {
                    if (!int.TryParse(txt_id.Text, out int parsedId))
                    {
                        MessageBox.Show("Invalid Employee ID.");
                        return;
                    }
                    parsedEmployeeId = parsedId;
                }

                Employee existingEmployee = context.Employees.FirstOrDefault(emp => emp.Id == parsedEmployeeId);

                if (existingEmployee != null)
                {
                    // Employee already exists, update the properties
                    existingEmployee.Name = employeeName;
                    existingEmployee.Phone = int.Parse(txt_ph.Text);
                    existingEmployee.Address = txt_add.Text;
                    existingEmployee.Email = txt_email.Text;
                    existingEmployee.Job.Department = cb_dep.Text;
                    existingEmployee.Job.Position = cb_field.Text; //watch out for naming here
                    existingEmployee.Job.FullPos = cb_pos.Text;

                    context.SaveChanges();

                    MessageBox.Show("Data Saved Successfully (Updated existing employee).");
                }
                else
                {
                    if (context.Employees.Any(emp => emp.Name == employeeName))
                    {
                        MessageBox.Show("Employee record already exists in the database.");
                        return;
                    }

                    // Create a new Employee object and populate its properties
                    var newEmployee = new Employee
                    {
                        Name = employeeName,
                        Phone = int.Parse(txt_ph.Text),
                        Job = new Job { Department = cb_dep.Text, Position = cb_pos.Text},
                        Acc = new Account { User = null, Pass = null, isAdmin = false, resetNext = false },
                        Sal = new Salary() { Basic = 500, Trans = 0 }
                    };

                    context.Employees.Add(newEmployee);
                    context.SaveChanges();

                    txt_id.Items.Clear();
                    DbFunctions.RefreshCB(context, ref txt_id);
                    RefreshComboBox(txt_name.Text);

                    //DbFunctions.accCreation(CreateAcc, txt_id.SelectedItem.ToString(), txt_name.Text);

                    MessageBox.Show("Data Inserted Successfully.");
                }
            }
        }


        private void txt_delete_Click(object sender, EventArgs e)
        {
            if (txt_id.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee ID to delete.");
                return;
            }

            int employeeId = Convert.ToInt32(txt_id.SelectedItem);

            using (var context = new HrDbContext()) // Replace with your actual context creation
            {
                var employeeToDelete = context.Employees.FirstOrDefault(emp => emp.Id == employeeId);

                if (employeeToDelete != null)
                {
                    context.Employees.Remove(employeeToDelete);
                    context.SaveChanges();

                    // Refresh the ComboBox and other UI elements if needed
                    RefreshComboBox();
                    ClearTextBoxes();

                    MessageBox.Show($"Employee with ID {employeeId} deleted successfully.");
                }
                else
                {
                    MessageBox.Show($"Employee with ID {employeeId} not found.");
                }
            }
        }

        private void txt_search_Click(object sender, EventArgs e)
        {
            //string id = Convert.ToInt32(txt_id.Text);
            //DbFunctions.RetrieveEmployeeData( id , ref txt_name, ref txt_add, ref txt_ph, ref txt_email, ref cb_dep, CheckBox_acc);

            
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
            using (var context = new HrDbContext())
            {
                DepComboRefresh();
                DbFunctions.RefreshCB(context, ref txt_id);

            }
            
        }

        private void txt_clear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
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

        private void BackF2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
         // Update the CreateAcc variable based on the checkbox's checked state
            //CreateAcc = CheckBox_acc.Checked;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_id.SelectedIndex != -1) // Check if an item is selected bc -1 means no items are selected
            {

                DbFunctions.RetrieveEmployeeData(txt_id.Text, ref txt_name, ref txt_add, ref txt_ph, ref txt_email, ref cb_dep, ref cb_field, ref cb_pos);
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

        private void RefreshComboBox()
        {
            con.Open();
            string query = "SELECT employeeID FROM hrdbEmployee WHERE employeeName = @employeeName";
            using (SqlCommand command = new SqlCommand(query, con))
            {

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
            using (var context = new HrDbContext()) // Replace with your actual context creation
            {
                var existingDepartments = context.Departments.Select(dep => dep.depName).ToList();

                foreach (var depName in existingDepartments)
                {
                    if (!cb_dep.Items.Contains(depName))
                    {
                        cb_dep.Items.Add(depName);
                    }
                }
            }
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {
            if (txt_id.SelectedIndex != -1)
            {
                // Call the DbFunctions.RetrieveEmployeeData method with the parsed id
                DbFunctions.RetrieveEmployeeData(txt_id.Text, ref txt_name, ref txt_add, ref txt_ph, ref txt_email, ref cb_dep, ref cb_field, ref cb_pos);
            }
        }

        private void txt_id_TextUpdate(object sender, EventArgs e)
        {
            if (txt_id.SelectedIndex != -1)
            {
                // Call the DbFunctions.RetrieveEmployeeData method with the parsed id
                DbFunctions.RetrieveEmployeeData(txt_id.Text, ref txt_name, ref txt_add, ref txt_ph, ref txt_email, ref cb_dep, ref cb_field, ref cb_pos);
            }

        }

        private void ClearTextBoxes()
        {
            txt_id.SelectedItem = null;
            cb_dep.SelectedItem = null;
            cb_pos.SelectedItem = null;
            txt_name.Clear();
            txt_add.Clear();
            txt_ph.Clear();
            txt_email.Clear(); 
            cb_pos.Items.Clear();
            cb_pos.Text = "";
            
        }

        public static string ProcessPosText(string PosText, string txt_dep , string txt_field)
        {
            using (var context = new Business.HrDbContext())
            {

                // Retrieve the corresponding depPos using LINQ from the provided list
                string dash = txt_field;

                if (dash == null)
                {
                    // Department not found, handle this case appropriately
                    //return string.Empty;
                    return "hi";
                }

                string star = txt_dep;

                // Replace '*' with the star string and '-' with the dash string
                string result = PosText.Replace("*", star).Replace("-", dash);

                return result;
            }

        }

        public static string ProcessFieldText(string PosText, string txt_dep)
        {
            using (var context = new Business.HrDbContext())
            {

                // Retrieve the corresponding depPos using LINQ from the provided list
                string dash = context.Departments.FirstOrDefault(dep => dep.depName == txt_dep)?.depPos;

                if (dash == null)
                {
                    // Department not found, handle this case appropriately
                    //return string.Empty;
                    return "hi";
                }

                string star = txt_dep;

                // Replace '*' with the star string and '-' with the dash string
                string result = PosText.Replace("*", star).Replace("-", dash);

                return result;
            }

        }

        private void cb_dep_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_field.Items.Clear();
            cb_field.Text = "";

            cb_pos.Items.Clear();
            cb_pos.Text = "";

            if (cb_dep.SelectedIndex != -1)
            {

                try
                {
                    string txt_dep = cb_dep.Text; // Get the selected department from cb_dep
                    string txt_field = cb_field.Text;

                    using (HrDbContext context = new HrDbContext())
                    {
                        // Retrieve departments that match the selected department name
                        var matchingDepartments = context.Departments.Where(dep => dep.depName == txt_dep).ToList();

                        // Process and populate the combo box
                        foreach (var department in matchingDepartments)
                        {
                            // Call ProcessPosText method for each position and add the result to the combo box
                            string processedFieldText = department.depPos; // Passing the position as an argument
                            cb_field.Items.Add(processedFieldText); // Add processed text to combo box
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("An error occurred: " + ex.Message);
                }


                //----------------------------------------

                

            }
            

        }

        private void cb_dep_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(txt_id.Text, txt_name.Text);
            f5.Show();
        }

        private void cb_field_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_pos.Items.Clear();
            cb_pos.Text = "";


            if (cb_field.SelectedIndex != -1)
            {
                try
                {
                    //ComboBox cb_pos = (ComboBox)sender; // Assuming cb_pos is the name of your combo box
                    string txt_dep = cb_dep.Text; // Get the selected department from another combo box (cb_dep)
                    string txt_field = cb_field.Text;
                    using (HrDbContext context = new HrDbContext())
                    {
                        // Retrieve all positions from the Positions table
                        var positions = context.Positions.ToList();

                        // Process and populate the combo box
                        foreach (var position in positions)
                        {
                            // Call ProcessPosText method for each position and add the result to the combo box
                            string processedPosText = ProcessPosText(position.PosName, txt_dep, txt_field); // Passing the position as an argument
                            cb_pos.Items.Add(processedPosText); // Add processed text to combo box
                        }

                    }
                }

                catch (Exception ex)
                {
                    // Handle the exception here
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
