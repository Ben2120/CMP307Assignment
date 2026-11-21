using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMP307Assignment
{
    public partial class AddingSoftware : Form
    {
        public AddingSoftware()
        {
            InitializeComponent();
        }

        private void AddingSoftware_Load(object sender, EventArgs e)
        {
           RetrievingSystemInfo();
        }

        private void exitbutton_Click(object sender, EventArgs e)
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
            string query = @"INSERT INTO ATS.SOFTWARE (OSName, OSVersion, OSManufacturer) OUTPUT INSERTED.AssetID VALUES (@OperatingSystemName, @OperatingSystemVersion, @OperatingSystemManufacturer)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))

                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OSName", OperatingSystemName.Text);
                        command.Parameters.AddWithValue("@OSVersion", OperatingSystemVersion.Text);
                        command.Parameters.AddWithValue("@OSManufacturer", OperatingSystemManufacturer.Text);

                        connection.Open();

                        int newsoftwareID = Convert.ToInt32(command.ExecuteScalar());

                        softwareID.Text = newsoftwareID.ToString();

                        MessageBox.Show("Software has been saved to the database and has been assigned ID - " + newsoftwareID);

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
            //OperatingSystemName.Text = Environment.OSName;

            //getting the manufacturer and model
            //Used the same method as taught in CMP201
            using (ManagementObjectSearcher Searcher = new ManagementObjectSearcher("SELECT OSName, Version, OSManufacturer FROM Win32_ComputerSystem"))

            {
                //this section reads the hardware details from the system it is running on 
                foreach (ManagementObject computer in Searcher.Get())
                {
                    OperatingSystemName.Text = Convert.ToString(computer["OSName"]);

                    OperatingSystemManufacturer.Text = Convert.ToString(computer["OSManufacturer"]);

                    OperatingSystemVersion.Text = Convert.ToString(computer["Version"]);

                    break;
                }
            }
        }
    }
}
