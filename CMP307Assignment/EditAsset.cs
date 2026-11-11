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
using System.Web;

namespace CMP307Assignment
{   
    public partial class EditAsset : Form
    {
        //this is how the software communicates with the database.
        string connectionString = @"Server = tolmount.abertay.ac.uk; Database = mssql2403393; User Id = mssql2403393; Password = gKL5hCw3Gs; Encrypt = True; TrustServerCertificate = True;";
        private int selectedAssetID;

        public EditAsset()
        {
            InitializeComponent();
        }

        public EditAsset(int assetbeingupdated) : this()
        {
            selectedAssetID = assetbeingupdated;

            LoadAssetDetails();
        }

        private void SystemType_TextChanged(object sender, EventArgs e)
        {

        }

        //this is how the data from the asset which was just searched for gets loaded into this page.
        private void LoadAssetDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM ATS.ASSETS WHERE AssetID = @AssetID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@AssetID", SqlDbType.Int).Value = selectedAssetID;
    
                        
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                       {

                        //this ensures that the data which is being displayed is correct
                         if (reader.Read())

                            {
                                assetID.Text = reader["AssetID"].ToString();
                                systemname.Text = reader["SystemName"].ToString();
                                SystemModel.Text = reader["Model"].ToString();
                                SystemManufacturer.Text = reader["Manufacturer"].ToString();
                                SystemType.Text = reader["Type"].ToString();
                                systemIP.Text = reader["IPAddress"].ToString();
                                employeeID.Text = reader["EmployeeID"].ToString();
                                extranotes.Text = reader["Notes"].ToString();

                                if (reader["PurchaseDate"] != DBNull.Value)
                                    {
                                        purchasedate.Text = Convert.ToDateTime(reader["PurchaseDate"]).ToString("yyyy-MM-dd");
                                    }

                                else
                                {
                                    purchasedate.Text = "";
                                }

                            }

                            else

                            {
                                MessageBox.Show("The asset cannot be displayed.");
                            }
                       }
                }
            }
        }   

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //this is how the information gets updated in the database, if any changes are made. 
        private void editassetbutton_Click(object sender, EventArgs e)
        {

            if (string .IsNullOrWhiteSpace(systemname.Text))
            {
                MessageBox.Show("Please make sure you have inserted a system name.");
                return;
            }

            if (!DateTime.TryParse(purchasedate.Text, out DateTime purchaseDate))
            {
                MessageBox.Show("Please enter a purchase date which is valid.");
                return;
            }

            object EmployeeIDValue = DBNull.Value;

            if (!string.IsNullOrWhiteSpace(employeeID.Text))
            {
                if (!int.TryParse(employeeID.Text, out int employeeIDedit))
                {
                    MessageBox.Show("Please make sure you have entered a valid employee identification number.");
                    return;
                }

                EmployeeIDValue = employeeIDedit;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = @"UPDATE ATS.ASSETS SET SystemName = @SystemName, Model = @Model, Manufacturer = @Manufacturer, Type = @Type, IPAddress = @IPAddress, EmployeeID = @EmployeeID, PurchaseDate = @PurchaseDate, Notes = @Notes WHERE AssetID = @AssetID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AssetID", SqlDbType.Int).Value = selectedAssetID;
                    command.Parameters.AddWithValue("@SystemName", systemname.Text.Trim());
                    command.Parameters.AddWithValue("@Model", SystemModel.Text.Trim());
                    command.Parameters.AddWithValue("@Manufacturer", SystemManufacturer.Text.Trim());
                    command.Parameters.AddWithValue("@Type", SystemType.Text.Trim());
                    command.Parameters.AddWithValue("@IPAddress", systemIP.Text.Trim());
                    command.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = EmployeeIDValue;
                    command.Parameters.AddWithValue("@PurchaseDate", SqlDbType.Date).Value = purchaseDate;
                    command.Parameters.AddWithValue("@Notes", extranotes.Text.Trim());

                    try
                    {
                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The asset has been updated correctly.");

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }

                        else
                        {
                            MessageBox.Show("The asset could not be updated.");
                        }
                    }

                    catch (SqlException ex)
                    {
                        MessageBox.Show("There was a database error - " + ex.Message);
                    }
                }
            }
        }
    }
}
