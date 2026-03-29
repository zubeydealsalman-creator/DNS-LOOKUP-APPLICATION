using System;
using System.Net;
using System.Windows.Forms;
namespace dns_lookup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxDomain_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lookup_Click(object sender, EventArgs e)
        {

            info.Items.Clear();
            string input = textBoxDomain.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please enter a domain or IP.");
                return;
            }

            try
            {
                if (forward.Checked) // Forward lookup
                {
                    IPAddress[] addresses = Dns.GetHostAddresses(input);
                    foreach (var ip in addresses)
                    {
                        info.Items.Add(ip.ToString());
                    }
                }
                else if (reverse.Checked) // Reverse lookup
                {
                    IPHostEntry host = Dns.GetHostEntry(input);
                    info.Items.Add(host.HostName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void info_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    
