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

using System.Drawing.Text;

namespace CMP307Assignment
{
    public partial class View_Asset : Form
    {
        string connectionString = @"Server = tolmount.abertay.ac.uk; Database = mssql2403393; User Id = mssql2403393; Password = gKL5hCw3Gs; Encrypt = True; TrustServerCertificate = True;";
        private int? selectedAssetID = null;

        public View_Asset()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void searchassetbutton(object sender, EventArgs e)
        {
            AssetInfo.Items.Clear();

            string searchingasset = assetName.Text.Trim();

            if (string.IsNullOrEmpty(searchingasset))
            {
                MessageBox.Show("Please make sure you have searched for an asset/system name.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT * FROM ATS.ASSETS WHERE LTRIM(RTRIM(SystemName)) LIKE '%' + @SystemName + '%'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@SystemName", SqlDbType.NVarChar).Value = searchingasset;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            selectedAssetID = Convert.ToInt32(reader["AssetID"]);

                            for (int i = 0; i < reader.FieldCount; i++)
                            {

                                AssetInfo.Items.Add(reader.GetName(i) + ": " + reader.GetValue(i).ToString());

                            }
                        }
                        else
                        {
                            MessageBox.Show("The asset you have searched for cannot be found.");
                        }
                    }
                }
            }
        }

        private void editasset_Click(object sender, EventArgs e)
        {
            if (selectedAssetID == null)
                
            {
                MessageBox.Show("Please make sure you have searched for an asset in the search bar.");
                return; 
            }

            EditAsset editassetform = new EditAsset(selectedAssetID.Value);
            editassetform.ShowDialog();
        }

        private void DeleteAsset_Click(object sender, EventArgs e)
        {
            if (assetName == null)
            {
                MessageBox.Show("Please make sure you have searched for an asset.");
                return;
            }

            DialogResult result = MessageBox.Show("Please confirm that you want to delete this asset from the database.", "Confirm Deletion of asset.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM ATS.ASSETS WHERE AssetID = @AssetID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add("@AssetID", SqlDbType.Int).Value = selectedAssetID.Value;

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The asset has been deleted.");

                            AssetInfo.Items.Clear();
                            assetName.Clear();
                            selectedAssetID = null;
                        }

                        else
                        {
                            MessageBox.Show("The asset which was searched for cannot be found.");
                        }
                    }
                }
            }
        }
    }
}
