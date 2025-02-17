using System;
using System.Net.Http;
using System.Threading.Tasks;

public class BlacklistAutomation
{
    // PHP API endpoint URL to add the user to the blacklist
    private static string apiUrl = "https://gtccheats.shop/Blacklist/add_to_blacklist.php"; // Replace with your actual URL

    // Method to automatically add the user to the blacklist
    public static async Task AddUserToBlacklist(string hwid, string ip, string reason)
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {
                // Build the URL with query parameters (sending HWID, IP, and reason)
                string url = $"{apiUrl}?hwid={hwid}&ip={ip}&reason={reason}";

                // Send the GET request to the PHP script
                HttpResponseMessage response = await client.GetAsync(url);

                // Ensure successful response
                response.EnsureSuccessStatusCode();

                // Read the response as a string (you can also log it if needed)
                string result = await response.Content.ReadAsStringAsync();

                Console.WriteLine(result); // Optional: print the result for debugging
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}