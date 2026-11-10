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

namespace CMP307Assignment
{
    public partial class ViewEmployee : Form
    {

        string connectionString = @"Server = tolmount.abertay.ac.uk; Database = mssql2403393; User Id = mssql2403393; Password = gKL5hCw3Gs; Encrypt = True; TrustServerCertificate = True;";
        private int? selectedEmployeeID = null;

        public ViewEmployee()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchemployee_Click(object sender, EventArgs e)
        {
            EmployeeInfo.Items.Clear();
            selectedEmployeeID = null;
            DeleteEmployee.Enabled = false;

            if (!int.TryParse(employeeIDtextbox.Text.Trim(), out int searchemployeeID))
            {
                MessageBox.Show("Please enter a valid Employee ID.");
                return;
            }

            string query = @"SELECT * FROM ATS.EMPLOYEES WHERE EmployeeID = @EmployeeID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = searchemployeeID;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                selectedEmployeeID = searchemployeeID;

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    string columnName = reader.GetName(i);

                                    string value = reader.IsDBNull(i) ? "Not provided" : reader.GetValue(i).ToString();

                                    EmployeeInfo.Items.Add(
                                        columnName + ": " + value);
                                }

                                DeleteEmployee.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("The employee was not found.");
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("There was a database error - " + ex.Message);
            }

        }

        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeID == null)
            {
                MessageBox.Show("Please search for an employee first.");
                return;
            }

            int employeeID = selectedEmployeeID.Value;

            DialogResult result = MessageBox.Show(
                "If you delete this employee, any of the assets assigned to this employee will be left with no one responsible. Please ensure you edit the assets which will be effected?.",
                "Confirm Employee Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // Step 1: Unassign all assets belonging to the employee
                            string updateQuery = @"UPDATE ATS.ASSETS SET EmployeeID = NULL WHERE EmployeeID = @EmployeeID";

                            using (SqlCommand updateCmd =
                                new SqlCommand(updateQuery, conn, transaction))
                            {
                                updateCmd.Parameters.Add("@EmployeeID", SqlDbType.Int)
                                    .Value = employeeID;

                                updateCmd.ExecuteNonQuery();
                            }

                            // Step 2: Delete the employee
                            string deleteQuery = @"DELETE FROM ATS.EMPLOYEES WHERE EmployeeID = @EmployeeID";

                            int rowsAffected;

                            using (SqlCommand deleteCmd =
                                new SqlCommand(deleteQuery, conn, transaction))
                            {
                                deleteCmd.Parameters.Add("@EmployeeID", SqlDbType.Int)
                                    .Value = employeeID;

                                rowsAffected = deleteCmd.ExecuteNonQuery();
                            }

                            if (rowsAffected == 0)
                            {
                                transaction.Rollback();
                                MessageBox.Show("The employee you searched for cannot be found. Please enter a valid employee identification number.");
                                return;
                            }

                            //Ensures the form gets cleared after the employee has been deleted.
                            transaction.Commit();

                            MessageBox.Show("This employee has been deleted.");

                            EmployeeInfo.Items.Clear();
                            employeeIDtextbox.Clear();
                            selectedEmployeeID = null;
                            DeleteEmployee.Enabled = false;
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
        }

        private void editasset_Click(object sender, EventArgs e)
        {
            //This ensures the user has to search for an employee before it shows the next form.
            if (selectedEmployeeID == null)
            {
                MessageBox.Show("Please make sure you have searched for a valid employee identifcation number.");
                return;
            }    
            
            EditingEmployee editingEmployee = new EditingEmployee(selectedEmployeeID.Value);
            editingEmployee.ShowDialog();

            //This clears the interface and search bar for preparation to move to edit employee form.
            EmployeeInfo.Items.Clear();
            selectedEmployeeID = null;
            DeleteEmployee.Enabled = false; 
        }
    }
}
