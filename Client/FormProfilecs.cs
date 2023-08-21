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
    public partial class FormProfile : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;");

        private string ID;
        public FormProfile(int loggedID)
        {
            InitializeComponent();
            ID = loggedID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(Form1.loggedemp.Id);
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
            txt_accUsername.Text = Form1.loggedemp.Acc.User;


            if (Form1.loggedUser != "admin")
            {
                txt_id.Text = ID;
                DbFunctions.RetrieveEmployeeData(Form1.loggedemp.Id.ToString(), ref txt_name, ref txt_add, ref txt_ph, ref txt_email, ref cb_dep, ref txt_pos);
                txt_dep.Text = cb_dep.Text;
                txt_accUsername.Text = Form1.loggedemp.Acc.User;
            }

            if (Form1.loggedemp.Acc.isAdmin)
            {
                cb_isAdmin.Checked = true;
            }
            else
            {
                cb_isAdmin.Checked = false;
            }

            txt_dep.ReadOnly = true;
            cb_isAdmin.Enabled = false;
            txt_id.ReadOnly = true;
            txt_name.ReadOnly = true;
            txt_accUsername.ReadOnly = true;
            txt_pos.ReadOnly = true;
        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_update_Click(object sender, EventArgs e)
        {
            using (var context = new HrDbContext()) // Replace with your actual context creation
            {
                string employeeName = DbFunctions.CapitalizeFirstLetterOfWords(txt_name.Text.Trim());

                int? parsedEmployeeId = null; // Use nullable int to represent no ID selected

                Employee existingEmployee = context.Employees.FirstOrDefault(emp => emp.Id == parsedEmployeeId);

                if (existingEmployee != null)
                {
                    // Employee already exists, update the properties
                    existingEmployee.Name = employeeName;
                    existingEmployee.Phone = int.Parse(txt_ph.Text);
                    existingEmployee.Address = txt_add.Text;
                    existingEmployee.Email = txt_email.Text;
                    existingEmployee.Job.Department = cb_dep.Text;
                    existingEmployee.Job.Position = txt_pos.Text;

                    context.SaveChanges();

                    MessageBox.Show("Data Saved Successfully (Updated existing employee).");
                }
            }


        }

        private void cb_isAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
