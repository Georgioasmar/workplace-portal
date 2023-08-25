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
using Business;

namespace Client
{
    public partial class Form5 : Form
    {

        private int txt_id;
        private string txt_name;
        private bool isAdmin = false; //CheckBox off by default
        private bool resetNext = false;
        
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;");

        public Form5(string id, string name)
        {
            InitializeComponent();
            txt_id = Convert.ToInt32(id);
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

        private void txt_insrt_Click(object sender, EventArgs e)
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

            using (var context = new HrDbContext()) // Replace with your actual context creation
            {
                int employeeId = txt_id;

                var employee = context.Employees.FirstOrDefault(emp => emp.Id == employeeId);

                if (employee != null)
                {
                    employee.Acc.User = txt_accUsername.Text;
                    employee.Acc.Pass = txt_accPassword.Text;
                    employee.Acc.isAdmin = isAdmin;
                    employee.Acc.resetNext = resetNext;

                    context.SaveChanges();

                    MessageBox.Show("Account Updated Successfully.");
                }
                else
                {
                    MessageBox.Show("Employee not found.");
                }
            }
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
                using (var context = new HrDbContext()) // Replace with your actual context creation
                {
                    var employee = context.Employees.FirstOrDefault(emp => emp.Id == txt_id);

                    if (employee != null)
                    {
                        checkBox_admin.Checked = employee.Acc.isAdmin;
                        isAdmin = employee.Acc.isAdmin;
                    }
                    else
                    {
                        checkBox_admin.Checked = false;
                        isAdmin = false;
                    }
                }


            }
            using (var context = new HrDbContext()) // Replace with your actual context creation
            {
                var employee = context.Employees.FirstOrDefault(emp => emp.Id == txt_id);

                if (employee != null)
                {
                    checkBox_changePass.Checked = employee.Acc.resetNext;
                    resetNext = employee.Acc.resetNext;
                }
                else
                {
                    checkBox_changePass.Checked = false;
                    resetNext = false;
                }
            }

            //locking checkboxes if not admin


            using (var context = new HrDbContext()) // Replace with your actual context creation
            {
                var employee = context.Employees.FirstOrDefault(emp => emp.Id == txt_id);

                if (employee != null)
                {
                    if (!string.IsNullOrEmpty(employee.Acc.User))
                    {
                        txt_accUsername.Text = employee.Acc.User;
                        txt_accPassword.Text = employee.Acc.Pass;
                        txt_accUsername.Enabled = false;
                    }
                    else
                    {
                        // Autofill based on name if Username is empty
                        DbFunctions.AutofillFields(employee.Name.ToLower(), ref txt_accUsername, ref txt_accPassword);
                        txt_accUsername.Enabled = true;
                    }
                }
                else
                {
                    // No record found for the selected ID, handle accordingly
                    // For example, show an error message or clear the fields
                }
            }

        }



    }
}
