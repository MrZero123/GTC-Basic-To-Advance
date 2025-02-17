using System;
using System.Net.Http;
using System.Threading.Tasks;

public class BlacklistChecker
{
    // PHP API endpoint URL
    private static string apiUrl = "https://gtccheats.shop/Blacklist/black.php"; // Change this to your PHP server URL

    // Method to check if user is blacklisted
    public static async Task<string> CheckIfBlacklisted(string hwid, string ip)
    {
        try
        {
            using (HttpClient client = new HttpClient())
            {
                // Build the URL with query parameters
                string url = $"{apiUrl}?hwid={hwid}&ip={ip}";

                // Send the GET request to the PHP script
                HttpResponseMessage response = await client.GetAsync(url);

                // Ensure successful response
                response.EnsureSuccessStatusCode();

                // Read the response as a string
                string result = await response.Content.ReadAsStringAsync();

                // Return the result (blacklisted or not_blacklisted)
                return result;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            return null;
        }
    }
}
