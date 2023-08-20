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
    public partial class FormProfile : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;");

        private string ID;
        public FormProfile(string loggedID)
        {
            InitializeComponent();
            ID = loggedID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(ID);
            form6.Show();
        }

        private void BackF2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            if (Form1.loggedUser != "admin")
            {
                txt_id.Text = ID;
                txt_accUsername.Text = Form1.loggedUser;
                DbFunctions.RetrieveEmployeeData(txt_id.Text, ref txt_name, ref txt_add, ref txt_ph, ref txt_email, ref cb_dep, cb_isAdmin);
                txt_dep.Text = cb_dep.Text;
            }

            if (Form1.loggedAdmin)
            {
                cb_isAdmin.Checked = true;
            }
            else
            {
                cb_isAdmin.Checked = false;
            }


            txt_accUsername.Text = Form1.loggedUser;

            txt_dep.ReadOnly = true;
            cb_isAdmin.Enabled = false;
            txt_id.ReadOnly = true;
            txt_name.ReadOnly = true;
            txt_accUsername.ReadOnly = true;
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

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
                SqlCommand cmd = new SqlCommand("UPDATE hrdbEmployee SET employeeName = @employeeName, employeeAddress = @employeeAddress, employeePhone = @employeePhone, employeeEmail = @employeeEmail, empDepID = @empDepID WHERE employeeID = @employeeID", con);
                cmd.Parameters.AddWithValue("@employeeName", txt_name.Text);
                cmd.Parameters.AddWithValue("@employeeAddress", txt_add.Text);
                cmd.Parameters.AddWithValue("@employeePhone", txt_ph.Text);
                cmd.Parameters.AddWithValue("@employeeEmail", txt_email.Text);
                cmd.Parameters.AddWithValue("@empDepID", depID); // Set the department ID
                cmd.Parameters.AddWithValue("@employeeID", txt_id.Text); // Assuming txt_id is a TextBox containing the employee ID

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Updated Successfully.");
            }

        }
    }
}
