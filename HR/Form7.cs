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

namespace HR
{
    public partial class Form7 : Form

    {

        private DataTable dataTable;

        public Form7()
        {

            InitializeComponent();

            //LoadDataAndSetColumns();

            //// Bind the DataTable to the DataGridView
            //dataGridView1.DataSource = dataTable;

            //// Dynamically distribute excess width among columns
            //DistributeExcessWidth();

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            searchBox.ForeColor = Color.Gray;

            // Connection string to your SQL Server database
            //string connectionString = "Your_Connection_String";

            // SQL query to retrieve data
            string query = "SELECT s.employeeID, employeeName, basicSalary, Transportation, employeeAddress, employeePhone FROM hrdbSalary AS s INNER JOIN hrdbEmployee AS e ON s.employeeID = e.employeeID;"; // Replace with your actual table name

            // Create a DataTable to hold the data
            dataTable = new DataTable();

            // Load data into the DataTable
            using (SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-G192168O\SQLINSTANCE;Initial Catalog=HRDB;User ID=sa;Integrated Security=True;"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

            // Rename the columns
            dataTable.Columns["employeeID"].ColumnName = "ID";
            dataTable.Columns["employeeName"].ColumnName = "Employee Name";
            dataTable.Columns["basicSalary"].ColumnName = "Basic Salary";
            dataTable.Columns["employeeAddress"].ColumnName = "Address";
            // Transportation column remains unchanged

            // Bind the DataTable to the DataGridView
            dataGridView1.DataSource = dataTable;


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
                    saveFileDialog.FileName = "Employee Data";

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

        private void button_salaryEditor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void butt_backSal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

            // Update the placeholder text based on TextBox content
            string searchBox_PlaceholderText = string.IsNullOrEmpty(searchBox.Text) ? "Search by Name" : string.Empty;

            // Clone the original DataTable's structure
            DataTable filteredDataTable = dataTable.Clone();

            // Iterate through the original DataTable and add rows to the filtered DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                string employeeName = row["Employee Name"].ToString();
                if (employeeName.IndexOf(searchBox.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    filteredDataTable.ImportRow(row);
                }
            }

            // Bind the filtered DataTable to the DataGridView
            dataGridView1.DataSource = filteredDataTable;
        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if(searchBox.Text == "Search by Name")
            {
                searchBox.Text = "";
                searchBox.ForeColor = Color.Black;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void LoadDataAndSetColumns()
        //{
        //    // Your code to load data and set up DataTable goes here
        //    // ...

        //    // Set up DataGridView properties
        //    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        //    dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        //    // Loop through the columns and set properties
        //    foreach (DataGridViewColumn column in dataGridView1.Columns)
        //    {
        //        column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

        //        if (column.Name == "ID")
        //        {
        //            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        //        }
        //    }
        //}

        //private void DistributeExcessWidth()
        //{
        //    int totalWidth = dataGridView1.ClientSize.Width;
        //    int numNonIDColumns = dataGridView1.Columns.Count - 1; // Exclude ID column
        //    int widthToDistribute = (totalWidth - dataGridView1.Columns["employeeID"].Width) / numNonIDColumns;

        //    foreach (DataGridViewColumn column in dataGridView1.Columns)
        //    {
        //        if (column.Name != "employeeID")
        //        {
        //            column.Width = widthToDistribute;
        //        }
        //    }

        //    // Allow the last column to fill remaining space
        //    dataGridView1.Columns[dataGridView1.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        //}

    }
}
