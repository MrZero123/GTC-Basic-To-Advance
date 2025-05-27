using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicToAdvance_01
{
    public partial class Main : Form
    {
        #region Aimbot Method Dll
        [DllImport("IngameAimbot.dll")]
        private static extern void StartAimbot();

        [DllImport("IngameAimbot.dll")]
        private static extern void ToggleAimbotState();

        [DllImport("IngameAimbot.dll")]
        private static extern void SetAimbotEnabled(bool enabled);

        [DllImport("IngameAimbot.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsAimbotEnabled();

        [DllImport("IngameAimbot.dll")]
        private static extern IntPtr GetAimbotVersion();

        [DllImport("IngameAimbot.dll")]
        private static extern IntPtr CheckForUpdatesString();

        [DllImport("kernel32.dll")]
        private static extern IntPtr LoadLibrary(string dllToLoad);

        [DllImport("kernel32.dll")]
        private static extern IntPtr GetProcAddress(IntPtr hModule, string procedureName);

        [DllImport("IngameAimbot.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UpdateAvailable();

        private static string PtrToStringUtf8(IntPtr ptr)
        {
            if (ptr == IntPtr.Zero)
                return string.Empty;

            int len = 0;
            while (Marshal.ReadByte(ptr, len) != 0)
                len++;

            byte[] buffer = new byte[len];
            Marshal.Copy(ptr, buffer, 0, buffer.Length);
            return System.Text.Encoding.UTF8.GetString(buffer);
        }

        #endregion
        public Main()
        {
            InitializeComponent();
            Form1.KeyAuthApp.check();
            if(!Form1.KeyAuthApp.response.success)
            {
              Environment.Exit(0);
            }
            var ptr = GetProcAddress(LoadLibrary("IngameAimbot.dll"), "StartAimbot");
            if (ptr == IntPtr.Zero)
            {
               MessageBox.Show("Failed to find StartAimbot function in the DLL.");
          
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            StartAimbot();
            ToggleAimbotState();
            IsAimbotEnabled();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            SetAimbotEnabled(true);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SetAimbotEnabled(false);
        }
    }
}
