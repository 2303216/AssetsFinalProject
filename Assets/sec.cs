using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assets
{
    public partial class sec : Form
    {
        private static string URL = @"https://services.nvd.nist.gov/rest/json/cves/2.0?cpeName=cpe:2.3:o:microsoft:windows_10:1607&cvssV3Severity=CRITICAL";

        public sec()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await MakeHttpRequestAndShowResultAsync();
        }

        private async Task MakeHttpRequestAndShowResultAsync()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(URL);

                    if (response.IsSuccessStatusCode)
                    {
                        // Read the response content
                        string content = await response.Content.ReadAsStringAsync();

                        // Display only a portion of the response content in a MessageBox
                        DisplayPartialContent(content);
                    }
                    else
                    {
                        MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayPartialContent(string content)
        {
            // Display the first 500 characters of the response content
            string partialContent = content.Length > 1500 ? content.Substring(0, 1500) + "..." : content;
            MessageBox.Show(partialContent, "HTTP Request Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

