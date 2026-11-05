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

        }

        private void RetrievingSystemInfo()
        {

            //getting the system name from the machine
            systemname.Text = Environment.MachineName;

            //getting the manufacturer and model
            try

            {
                using (ManagementObjectSearcher Searcher = new ManagementObjectSearcher "SELECT System Manufacturer, System Model FROM Win32_ComputerSystem"))
                {
                    {
                        foreach (ManagementObject computer in searcher.Get())
                        {
                            systemmanufacturer.Text = Convert.ToString(computer["Manufacturer"]);
                            systemmodel.Text =Convert.ToString(computer["Model"]);

                            break;
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to retrieve system details: " + ex.Message);
            }

            //get the ip address from the computer system
            try
            {
                var ipAddress = Dns.GetHostAddresses(Dns.GetHostName()).FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork && !IPAddress.IsLoopback(ip));
                systemIP.Text = ipAddress?.ToString() ?? "";
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                "Unable to retrieve IP address: " + ex.Message);
            }
        }
    }
}
