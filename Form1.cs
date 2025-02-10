using KeyAuth;
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
    public partial class Form1 : Form
    {
        public static api KeyAuthApp = new api(
    name: "Course Basic To Advance", // App name
    ownerid: "tLfYsHY39n", // Account ID
    version: "1.0" // Application version. Used for automatic downloads see video here https://www.youtube.com/watch?v=kW195PLCBKs
                   //path: @"Your_Path_Here" // (OPTIONAL) see tutorial here https://www.youtube.com/watch?v=I9rxt821gMk&t=1s
);

        public Form1()
        {
            InitializeComponent();
            KeyAuthApp.init();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(guna2TextBox1.Text, guna2TextBox2.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
                error.Show("Status: " + KeyAuthApp.response.message);
        }
    }
}
