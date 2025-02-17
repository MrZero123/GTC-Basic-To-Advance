using Guna.UI2.WinForms;
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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Form1.KeyAuthApp.check();
            if(!Form1.KeyAuthApp.response.success)
            {
              Environment.Exit(0);
            }
        }
        private void logoutfunction()
        {
            Form1.KeyAuthApp.logout();
            if (Form1.KeyAuthApp.response.success)
            {
                Form1 main = new Form1();
                main.Show();
                this.Hide();
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = info.Show();
            if (result == DialogResult.Yes)
            {
                logoutfunction();
            }
            else if (result == DialogResult.No)
            {
          
            }      
        }
    }
}
