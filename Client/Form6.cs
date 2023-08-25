using System;
using System.Linq;
using System.Windows.Forms;
using Business;

namespace Client
{
    public partial class Form6 : Form
    {
        private int ID;

        public Form6(int loggedID)
        {
            ID = loggedID;
            InitializeComponent();
        }

        private void txt_log_Click(object sender, EventArgs e)
        {
            if (txt_newPass.Text == txt_reenter.Text)
            {
                using (var context = new HrDbContext()) // Replace with your actual context creation
                {
                    var employeeLogin = context.Employees.FirstOrDefault(emp => emp.Id == ID);

                    if (employeeLogin != null)
                    {
                        employeeLogin.Acc.Pass = txt_newPass.Text;
                        employeeLogin.Acc.resetNext = false;

                        try
                        {
                            context.SaveChanges();
                            MessageBox.Show("Password updated successfully.");
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Employee not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please reenter the same password.");
            }
        }
    }
}
