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
using System.Text.RegularExpressions;

namespace HR
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;");
        private void txt_search_Click(object sender, EventArgs e)
        {
            DbFunctions.RetrieveEmployeeSalary(txt_empID.Text , ref salName, ref txt_Bsly, ref txt_trans);
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            salName.Enabled = false;


            con.Open();
            string query = "SELECT employeeID FROM hrdbSalary";
            using (SqlCommand command = new SqlCommand(query, con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int employeeID = reader.GetInt32(0);
                        txt_empID.Items.Add(employeeID);
                    }
                }

            }
            con.Close();
        }

        private void txt_update_Click(object sender, EventArgs e)
        {
            if (txt_Bsly.Text == "" || txt_trans.Text == "")
            {
                MessageBox.Show("Please fill all the entities !");
                return;
            }
            con.Open();
            SqlCommand cmd = new SqlCommand("update hrdbSalary set basicSalary = '" + RemoveNonNumerical(txt_Bsly.Text) + "', Transportation = '" + RemoveNonNumerical(txt_trans.Text) + "'  where employeeID = '" + txt_empID.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Saved Successfully.");
            con.Close();
        }

        private void bsx_txt(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only digits are allowed !");
            }
        }

        private void trans_txt(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only digits are allowed !");
            }
        }

        private void BackF4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void txt_empID_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbFunctions.RetrieveEmployeeSalary(txt_empID.Text, ref salName, ref txt_Bsly, ref txt_trans);
        }

        static string RemoveNonNumerical(string input)
        {
            // Use a regular expression to match non-numeric characters
            string cleaned = Regex.Replace(input, @"[^0-9]", "");
            return cleaned;
        }
    }
}

