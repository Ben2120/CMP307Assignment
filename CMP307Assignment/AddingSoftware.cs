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
    public partial class AddingSoftware : Form
    {
        public AddingSoftware()
        {
            InitializeComponent();
        }

        private void AddingSoftware_Load(object sender, EventArgs e)
        {
            //RetrievingSystemInfo();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {

        }

        /*private void RetrievingSystemInfo()
        {

            //getting the system name from the machine
            OperatingSystemName.Text = Environment.OSName;
            .

            //getting the manufacturer and model
            //Used the same method as taught in CMP201
            using (ManagementObjectSearcher Searcher = new ManagementObjectSearcher("SELECT OSName, Version, OSManufacturer FROM Win32_ComputerSystem"))

            {
                //this section reads the hardware details from the system it is running on 
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

            //this ensures the user is aware if the software could not read the IP address from the system
            catch (Exception ex)
            {
                MessageBox.Show(
                "We were unable to get your IP address - " + ex.Message);
            }
        }*/
    }
}
