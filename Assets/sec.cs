using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets
{
    public partial class sec : Form
    {
        private static string baseUrl = "https://services.nvd.nist.gov/rest/json/cves/2.0";
        private static string criticalCveUrl = "?cvssV3Severity=CRITICAL";
        

        public sec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string windowsVersion = GetWindowsVersion();
            MessageBox.Show($"Detected Windows version: {windowsVersion}");

            string url = ConstructUrl(windowsVersion);

            if (url != null)
            {
                MakeHttpRequestAndShowResultAsync(url);
            }
            else
            {
             
                MakeHttpRequestAndShowResultAsync(defaultUrl);
            }
        }

        private string GetWindowsVersion()
        {
            return Environment.OSVersion.Version.ToString();
        }

        private string ConstructUrl(string windowsVersion)
        {
            if (windowsVersion.StartsWith("10"))
            {
                return $"{baseUrl}?cpeName=cpe:2.3:o:microsoft:windows_10:1607{criticalCveUrl}";
            }
            else if (windowsVersion.StartsWith("11"))
            {
                return $"{baseUrl}?cpeName=cpe:2.3:o:microsoft:windows_11:1607{criticalCveUrl}";
            }
            else
            {
                return null; // Unsupported or unknown Windows version
            }
        }
        
        private async void MakeHttpRequestAndShowResultAsync(string url)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content
                        string content = await response.Content.ReadAsStringAsync();

                        // Display only a portion of the response content in a MessageBox
                        DisplayPartialContent(content);
                    }
                    else
                    {
                        MessageBox.Show($"..");
                        MakeHttpRequestAndShowResultAsync(defaultUrl);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"....");
                    MakeHttpRequestAndShowResultAsync(defaultUrl);
                }
            }
        }

        private void DisplayPartialContent(string content)
        {
            // Display the first 500 characters of the response content
            string partialContent = content.Length > 1500 ? content.Substring(0, 1500) + "..." : content;
            MessageBox.Show(partialContent, "HTTP Request Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private static string defaultUrl = "https://services.nvd.nist.gov/rest/json/cves/2.0?cpeName=cpe:2.3:o:microsoft:windows_10:1607&cvssV3Severity=CRITICAL";
    }
}
