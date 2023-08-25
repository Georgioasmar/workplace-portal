using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;

namespace Client
{
    public partial class Form1 : Form
    {
        public static bool loggedAdmin { get; set; }
        public static string loggedUser { get; set; }
        public static string loggedID { get; set; }

        public static Employee loggedemp { get; set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void txt_log_Click(object sender, EventArgs eventArgs)
        {
            try
            {
                if (txt_us.Text == "" || txt_pas.Text == "")
                {
                    MessageBox.Show("Please provide UserName and Password");
                    return;
                }

                using (var context = new Business.HrDbContext()) // Replace with your actual context creation
                {
                    string username = txt_us.Text;
                    string password = txt_pas.Text;

                    var employee = context.Employees.FirstOrDefault(e => e.Acc.User == username && e.Acc.Pass == password);

                    if (employee != null)
                    {
                        //loggedAdmin = employee.Acc.isAdmin;
                        loggedemp = employee;
                        //loggedUser = employee.Acc.User;

                        if (loggedUser != "admin")
                        {
                            string loggedID = context.Employees
                                .Where(emp => emp.Acc.User == loggedUser)
                                .Select(emp => emp.Id.ToString())
                                .FirstOrDefault();

                            if (!string.IsNullOrEmpty(loggedID))
                            {
                                // Use the loggedID
                            }

                            if (employee.Acc.resetNext)
                            {
                                Form6 f6 = new Form6(employee.Id);

                            }
                        }

                        //loggedemp.Acc.isAdmin = employee.Acc.isAdmin;
                        //loggedUser = employee.Acc.User;

                        this.Hide();
                        Form3 f3 = new Form3();
                        f3.Show();

                        if (loggedUser != "admin")
                        {
                            // Call your DbFunctions.checkPassReset method
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username/password");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_us_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the Enter key from inserting a new line
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_pas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the Enter key from inserting a new line
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txt_us_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }


