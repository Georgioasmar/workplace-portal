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
using ClosedXML.Excel;

namespace Client
{
    public partial class depStats : Form
    {

        private DataTable dataTable;

        public depStats()
        {
            InitializeComponent();
        }

        private void depStats_Load(object sender, EventArgs e)
        {
            dataTable = new DataTable();

            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Department", typeof(string));
            dataTable.Columns.Add("Average Salary", typeof(decimal));
            dataTable.Columns.Add("Maximum Salary", typeof(decimal));
            dataTable.Columns.Add("Max Name", typeof(string));
            dataTable.Columns.Add("Maximum ID", typeof(int));

            string query = @"
        SELECT depID, depName FROM hrdbDepartment
    ";

            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        int depID = Convert.ToInt32(row["depID"]);

                        row["ID"] = depID; // Set the ID column to depID
                        row["Department"] = row["depName"]; // Set the Department column to depName

                        row["Average Salary"] = CalculateAverageSalary(connection, depID);

                        GetMaximumSalaryAndID(connection, depID, out decimal maxSalary, out int maxID);
                        row["Maximum Salary"] = maxSalary;
                        row["Maximum ID"] = maxID;

                        row["Max Name"] = GetEmployeeName(connection, maxID);
                    }
                }
            }

            dataGridView1.DataSource = dataTable;

            // Hide the "depID" and "depName" columns
            dataGridView1.Columns["depID"].Visible = false;
            dataGridView1.Columns["depName"].Visible = false;
        }



        //NEVER DO THIS, NEVER UPDATE THE SQL SERVER FOR CALCULATION/SIMPLIFICATION PURPOSES

        //private void statsUpdate()
        //{
        //    string connectionString = @"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;"; // Replace with your actual connection string

        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        // Calculate and update maxID, maxSalary, and averageSalary for each department
        //        string updateQuery = @"
        //        UPDATE hrdbDepartment
        //        SET maxID = (
        //            SELECT TOP 1 e.employeeID
        //            FROM hrdbEmployee e
        //            JOIN hrdbSalary s ON e.employeeID = s.employeeID
        //            WHERE e.empDepID = hrdbDepartment.depID
        //            ORDER BY s.basicSalary DESC
        //        ),
        //        maxSalary = (
        //            SELECT TOP 1 s.basicSalary
        //            FROM hrdbEmployee e
        //            JOIN hrdbSalary s ON e.employeeID = s.employeeID
        //            WHERE e.empDepID = hrdbDepartment.depID
        //            ORDER BY s.basicSalary DESC
        //        );

        //        UPDATE hrdbDepartment
        //        SET avgSalary = (
        //            SELECT AVG(s.basicSalary)
        //            FROM hrdbEmployee e
        //            JOIN hrdbSalary s ON e.employeeID = s.employeeID
        //            WHERE e.empDepID = hrdbDepartment.depID
        //        );";

        //        using (SqlCommand command = new SqlCommand(updateQuery, connection))
        //        {
        //            command.ExecuteNonQuery();
        //        }
        //    }

        //}

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            // Update the placeholder text based on TextBox content
            string searchBox_PlaceholderText = string.IsNullOrEmpty(searchBox.Text) ? "Search by Department" : string.Empty;

            // Clone the original DataTable's structure
            DataTable filteredDataTable = dataTable.Clone();

            // Iterate through the original DataTable and add rows to the filtered DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                string employeeName = row["Department"].ToString();
                if (employeeName.IndexOf(searchBox.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    filteredDataTable.ImportRow(row);
                }
            }

            // Bind the filtered DataTable to the DataGridView
            dataGridView1.DataSource = filteredDataTable;
        }

        private void button_toExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.DefaultExt = "xlsx";
                    saveFileDialog.AddExtension = true;
                    saveFileDialog.FileName = "Department Stats";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Data");

                            // Export column headers
                            for (int col = 1; col <= dataTable.Columns.Count; col++)
                            {
                                worksheet.Cell(1, col).Value = dataTable.Columns[col - 1].ColumnName;
                            }

                            // Export data rows
                            for (int row = 1; row <= dataTable.Rows.Count; row++)
                            {
                                for (int col = 1; col <= dataTable.Columns.Count; col++)
                                {
                                    worksheet.Cell(row + 1, col).Value = dataTable.Rows[row - 1][col - 1].ToString();

                                }
                            }

                            workbook.SaveAs(saveFileDialog.FileName);
                        }

                        MessageBox.Show("Data exported to Excel successfully!", "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butt_backSal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text == "Search by Department")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }
        }

        static decimal CalculateAverageSalary(SqlConnection connection, int depID)
        {
            string avgSalaryQuery = @"
        SELECT AVG(s.basicSalary)
        FROM hrdbEmployee e
        JOIN hrdbSalary s ON e.employeeID = s.employeeID
        WHERE e.empDepID = @depID";

            using (SqlCommand avgCommand = new SqlCommand(avgSalaryQuery, connection))
            {
                avgCommand.Parameters.AddWithValue("@depID", depID);
                object result = avgCommand.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    decimal averageSalary = Convert.ToDecimal(result);
                    return averageSalary;
                }
                return 0;
            }
        }

        static void GetMaximumSalaryAndID(SqlConnection connection, int depID, out decimal maxSalary, out int maxID)
        {
            string maxSalaryQuery = @"
        SELECT TOP 1 s.basicSalary, e.employeeID
        FROM hrdbEmployee e
        JOIN hrdbSalary s ON e.employeeID = s.employeeID
        WHERE e.empDepID = @depID
        ORDER BY s.basicSalary DESC";

            using (SqlCommand maxCommand = new SqlCommand(maxSalaryQuery, connection))
            {
                maxCommand.Parameters.AddWithValue("@depID", depID);
                using (SqlDataReader reader = maxCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        object salaryValue = reader["basicSalary"];
                        object idValue = reader["employeeID"];

                        if (salaryValue != null && salaryValue != DBNull.Value)
                        {
                            maxSalary = Convert.ToDecimal(salaryValue);
                        }
                        else
                        {
                            maxSalary = 0; // or some default value
                        }

                        if (idValue != null && idValue != DBNull.Value)
                        {
                            maxID = Convert.ToInt32(idValue);
                        }
                        else
                        {
                            maxID = 0; // or some default value
                        }
                    }
                    else
                    {
                        maxSalary = 0; // or some default value
                        maxID = 0;     // or some default value
                    }
                }
            }
        }


        static string GetEmployeeName(SqlConnection connection, int employeeID)
        {
            string nameQuery = "SELECT employeeName FROM hrdbEmployee WHERE employeeID = @employeeID";

            using (SqlCommand nameCommand = new SqlCommand(nameQuery, connection))
            {
                nameCommand.Parameters.AddWithValue("@employeeID", employeeID);
                object result = nameCommand.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
                return ""; // or some default value
            }
        }

    }
}
