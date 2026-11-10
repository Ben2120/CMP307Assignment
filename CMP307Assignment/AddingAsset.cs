using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMP307Assignment
{
    public partial class AddingAsset : Form
    {
        public AddingAsset()
        {
            InitializeComponent();
        }

        private void AddingAsset_Load(object sender, EventArgs e)
        {
           RetrievingSystemInfo();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebutton_Click(object sender, EventArgs e)
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
            //this is ensuring that the data which has been entered into the boxes is stored into the database correctly
            string query = @"INSERT INTO ATS.ASSETS (SystemName, Model, Manufacturer, IPAddress, Type, EmployeeID, PurchaseDate, Notes) OUTPUT INSERTED.AssetID VALUES (@SystemName, @Model, @Manufacturer, @IPAddress, @Type, @EmployeeID, @PurchaseDate, @Notes)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))

                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SystemName", systemname.Text);
                        command.Parameters.AddWithValue("@Model", systemmodel.Text);
                        command.Parameters.AddWithValue("@Manufacturer", systemmanufacturer.Text);
                        command.Parameters.AddWithValue("@IPAddress", systemIP.Text);
                        command.Parameters.AddWithValue("@Type", systemtype.Text);
                        command.Parameters.AddWithValue("@EmployeeID", employeeID.Text);
                        command.Parameters.AddWithValue("@PurchaseDate", purchaseDate.Text);
                        command.Parameters.AddWithValue("@Notes", extranotes.Text);

                        connection.Open();

                        int newAssetID = Convert.ToInt32(command.ExecuteScalar());

                        assetID.Text = newAssetID.ToString();

                        MessageBox.Show("Asset has been saved to the database and has been assigned ID - " + newAssetID);

                    }
                }
            }

            catch (Exception ex)

            {
                MessageBox.Show("There was an error saving the asset - " + ex.Message);
            }
        }


        private void RetrievingSystemInfo()
        {

            //getting the system name from the machine
            systemname.Text = Environment.MachineName;


            //getting the manufacturer and model
            //Used the same method as taught in CMP201
            using (ManagementObjectSearcher Searcher = new ManagementObjectSearcher("SELECT Manufacturer, Model, SystemType FROM Win32_ComputerSystem"))
           
            {
                foreach (ManagementObject computer in Searcher.Get())
                {
                    systemmanufacturer.Text = Convert.ToString(computer["Manufacturer"]);

                    systemmodel.Text = Convert.ToString(computer["Model"]);

                    systemtype.Text = Convert.ToString(computer["SystemType"]);

                    break;
                }
            }

            //get the ip address from the computer system
            try
            {
                var ipAddress = Dns.GetHostAddresses
                    (Dns.GetHostName()).FirstOrDefault
                    (ip => ip.AddressFamily == AddressFamily.InterNetwork && !IPAddress.IsLoopback(ip));
                
                systemIP.Text = ipAddress?.ToString() ?? "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                "We were unable to get your IP address - " + ex.Message);
            }
        }
    }
}
