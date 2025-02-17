using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicToAdvance_01
{
    public partial class CheckBlacklist : Form
    {
        public CheckBlacklist()
        {
            InitializeComponent();
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            string hwid = guna2TextBox1.Text; // TextBox for HWID input
            string ip = guna2TextBox2.Text;     // TextBox for IP input

            // Check if HWID and IP are provided
            if (string.IsNullOrEmpty(hwid) || string.IsNullOrEmpty(ip))
            {
                MessageBox.Show("Please enter both HWID and IP.");
                return;
            }

            // Call the CheckIfBlacklisted method
            string result = await BlacklistChecker.CheckIfBlacklisted(hwid, ip);

            // Display the result in the Label
            if (result == "blacklisted")
            {
                label1.Text = "The user is blacklisted.";
            }
            else if (result == "not_blacklisted")
            {
                label1.Text = "The user is not blacklisted.";
            }
            else
            {
                label1.Text = "An error occurred while checking the blacklist status.";
            }
        }
    }
}
