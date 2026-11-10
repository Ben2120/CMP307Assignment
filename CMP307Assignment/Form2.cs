//all libraries required for programme
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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditEmployee_Click(object sender, EventArgs e)
        {
            ViewEmployee View_Employeeform = new ViewEmployee();
            View_Employeeform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server = tolmount.abertay.ac.uk; Database = mssql2403393; User Id = mssql2403393; Password = gKL5hCw3Gs; Encrypt = True; TrustServerCertificate = True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Connection to database has failed - " + ex.Message);
            }

            string query = @"INSERT INTO ATS.EMPLOYEES (EmployeeID, FirstName, LastName, Email, DepartmentID) OUTPUT INSERTED.EmployeeID VALUES (@EmployeeID, @FirstName, @LastName, @Email, @DepartmentID)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))

                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeID", employeeID.Text);
                        command.Parameters.AddWithValue("@FirstName", firstname.Text);
                        command.Parameters.AddWithValue("@LastName", lastname.Text);
                        command.Parameters.AddWithValue("@Email", email.Text);
                        command.Parameters.Add("@DepartmentID", SqlDbType.Int).Value = Convert.ToInt32(Departmentsbox.SelectedValue);

                        connection.Open();

                        command.ExecuteNonQuery();

                        MessageBox.Show("Employee has been saved.\n");

                        if (Departmentsbox.SelectedIndex == -1)
                        {
                            MessageBox.Show("Please select a department in the box.");
                            return;
                        }

                    }
                }
            }

            catch (Exception ex)

            {
                MessageBox.Show("There was an error saving this employee - " + ex.Message);
            }
        }

        private void LoadDepartments()
        {
            string query = @"SELECT DepartmentID, DepartmentName FROM ATS.DEPARTMENTS ORDER BY DepartmentName";
            string connectionString = @"Server = tolmount.abertay.ac.uk; Database = mssql2403393; User Id = mssql2403393; Password = gKL5hCw3Gs; Encrypt = True; TrustServerCertificate = True;";

            try

            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable departments = new DataTable();

                        adapter.Fill(departments);

                        Departmentsbox.DataSource = departments;

                        Departmentsbox.DisplayMember = "DepartmentName";

                        Departmentsbox.ValueMember = "DepartmentID";

                        Departmentsbox.SelectedIndex = -1;

                        Departmentsbox.DropDownStyle = ComboBoxStyle.DropDownList;
                    }
                }
            }

            catch (SqlException ex)

            {
                MessageBox.Show("There was an error loading this employee" + ex.Message);
            }
        }    
    }
        
}
