using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Assets
{
    public static class DatabaseHelper
    {
        // Use the connection string from the configuration file
        private static readonly string ConnectionString = StringConnector.CnnVal("EmployeesDB");

        public static void SaveToDatabase(string assetID, string osName, string osVersion, string osManufacturer)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();

                    // Insert data into the database
                    string query = "INSERT INTO SystemInfoTable (AssetID, OSName, OSVersion, OSManufacturer) " +
                                   "VALUES (@AssetID, @OSName, @OSVersion, @OSManufacturer)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@AssetID", assetID);
                        cmd.Parameters.AddWithValue("@OSName", osName);
                        cmd.Parameters.AddWithValue("@OSVersion", osVersion);
                        cmd.Parameters.AddWithValue("@OSManufacturer", osManufacturer);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Data saved to the database successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}