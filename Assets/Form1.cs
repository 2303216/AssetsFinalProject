using System;
using System.Windows.Forms;

namespace Assets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Get operating system information
            OperatingSystem os = Environment.OSVersion;

            // Display operating system details in the TextBoxes
            textBoxOSName.Text = os.Platform.ToString();
            textBoxOSVersion.Text = os.Version.ToString();
            textBoxOSManufacturer.Text = GetOSManufacturer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the AssetID and TextBox values
            string assetID = textBoxAssetID.Text;
            string osName = textBoxOSName.Text;
            string osVersion = textBoxOSVersion.Text;
            string osManufacturer = textBoxOSManufacturer.Text;

            // Save the data to the MySQL database
            DatabaseHelper.SaveToDatabase(assetID, osName, osVersion, osManufacturer);
        }

        private string GetOSManufacturer()
        {
            // You might need to implement platform-specific code to get the manufacturer
            // For simplicity, this example returns a placeholder value
            return "Unknown Manufacturer";
        }

        private void textBoxAssetID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard Dashboard = new Dashboard();


            Dashboard.Show();


            this.Hide();
        }
    }
}