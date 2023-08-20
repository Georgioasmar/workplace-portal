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

namespace HR
{
    public partial class Form1 : Form
    {
        public static bool loggedAdmin { get; set; }
        public static string loggedUser { get; set; }
        public static string loggedID { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        private void txt_log_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_us.Text == "" || txt_pas.Text == "")
                {
                    MessageBox.Show("Please provide UserName and Password");
                    return;
                }
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;");
                SqlCommand cmd = new SqlCommand("Select * from hrdblogin where username = @Username And password = @Password", con);
                cmd.Parameters.AddWithValue("@username", txt_us.Text);
                cmd.Parameters.AddWithValue("@password", txt_pas.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;

                if (count > 0)
                {
                    loggedAdmin = DbFunctions.GetAdminStatusForUser(txt_us.Text);
                    loggedUser = txt_us.Text.ToLower();
                    if (loggedUser != "admin")
                    {
                        string query = "SELECT ID FROM hrdblogin WHERE Username = @username";
                        using (SqlCommand command = new SqlCommand(query, con))
                        {
                            command.Parameters.AddWithValue("@username", loggedUser);
                            con.Open();
                            object result = command.ExecuteScalar();
                            con.Close();
                            if (result != null && result != DBNull.Value)
                            {
                                loggedID = result.ToString();

                            }
                        }


                    }



                    this.Hide();
                    Form3 f3 = new Form3();
                    f3.Show();
                    if (loggedUser != "admin")
                    {
                        DbFunctions.checkPassReset(con, loggedID);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username/password");
                    return;
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


