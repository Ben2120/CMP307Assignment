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
using System.Linq.Expressions;
using System.DirectoryServices.ActiveDirectory;

namespace CMP307Assignment
{
    public partial class EditingEmployee : Form
    {
        string connectionString = @"Server = tolmount.abertay.ac.uk; Database = mssql2403393; User Id = mssql2403393; Password = gKL5hCw3Gs; Encrypt = True; TrustServerCertificate = True;";
        private readonly int selectedEmployeeID;

        public EditingEmployee(int selectedID)
        {
            InitializeComponent();

            selectedEmployeeID = selectedID;

            employeeID.Text = selectedEmployeeID.ToString();

            employeeID.ReadOnly = true;

            LoadDepartments();

            LoadEmployeeDetails();
        }

        private void EditingEmployee_Load(object sender, EventArgs e)
        {

        }

        private void LoadDepartments()
        {
            string query = @"SELECT DepartmentID, DepartmentName FROM ATS.DEPARTMENTS ORDER BY DepartmentName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable departments = new DataTable();

                    adapter.Fill(departments);

                    Departmentsbox.DataSource = departments;
                    Departmentsbox.DisplayMember = "DepartmentName";
                    Departmentsbox.ValueMember = "DepartmentID";
                }
            }
        }

        private void LoadEmployeeDetails()
        {
            string query = @"SELECT FirstName, LastName, Email, DepartmentID FROM ATS.EMPLOYEES WHERE EmployeeID = @EmployeeID";

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))

                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))

                    {
                        command.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = selectedEmployeeID;

                        using (SqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.Read())
                            {
                                firstname.Text = reader["FirstName"].ToString();

                                lastname.Text = reader["LastName"].ToString();

                                email.Text = reader["Email"].ToString();

                                Departmentsbox.SelectedValue = reader["DepartmentID"];
                            }

                            else
                            {
                                MessageBox.Show("The employee you habe searched for has not been found.");
                                updateinformation.Enabled = false;

                            }
                        }
                    }
                }
            }

            catch (SqlException ex)
            {
                MessageBox.Show("There was an error loading the employee information - " + ex.Message);
                updateinformation.Enabled = false;
            }
        }

        private void updateinformation_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstname.Text) || string.IsNullOrWhiteSpace(lastname.Text) || string.IsNullOrWhiteSpace(email.Text))
            {
                MessageBox.Show("Please make sure you have entered information into all fields.");
                return;
            }

            if (Departmentsbox.SelectedValue == null || Departmentsbox.SelectedValue is DataRowView)
            {
                MessageBox.Show("Please ensure a department has been selected for update.");
                return;
            }

            string query = @"UPDATE ATS.EMPLOYEES SET FirstName = @FirstName, LastName = @LastName, Email = @Email, DepartmentID = @DepartmentID WHERE EmployeeID = @EmployeeID";

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))

                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))

                    {
                        command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 50).Value = firstname.Text.Trim();

                        command.Parameters.Add("@LastName", SqlDbType.NVarChar, 50).Value = lastname.Text.Trim();

                        command.Parameters.Add("@Email", SqlDbType.NVarChar, 100).Value = email.Text.Trim();

                        command.Parameters.Add("@DepartmentID", SqlDbType.Int).Value = Convert.ToInt32(Departmentsbox.SelectedValue);

                        command.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = selectedEmployeeID;

                        int rowsaffected = command.ExecuteNonQuery();

                        if (rowsaffected > 0)
                        {
                            MessageBox.Show("The employee information you entered has been updated successfully.");

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }

                        else
                        {
                            MessageBox.Show("The employee could not be found.");
                        }
                    }
                }
            }

            catch (SqlException ex)

            {
                MessageBox.Show("There was a database error - " + ex.Message);
            }
        }

        //exit button below
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
