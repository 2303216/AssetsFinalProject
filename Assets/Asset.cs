using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Assets
{
    public class AssetHttpClient
    {
        private static string URL = @"https://services.nvd.nist.gov/rest/json/cves/2.0?cpeName=cpe:2.3:o:microsoft:windows_10:1607&cvssV3Severity=CRITICAL";

        public static async Task<string> GetAssetDataAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var response = await client.GetStringAsync(URL);
                    return response;
                }
            }
            catch (Exception ex)
            {
             
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
    }
}
