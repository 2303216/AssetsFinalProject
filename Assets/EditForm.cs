using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Assets
{







    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = StringConnector.CnnVal("EmployeesDB");

            // Construct the SQL update query with parameters
            string update = "UPDATE assets SET SystemName = @SystemName, Model = @Model, Manufacturer = @Manufacturer, Type = @Type, IP = @IP, PurchaseDate = @PurchaseDate, Notes = @Notes WHERE AssetID = @AssetID";

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                try
                {
                    MySqlCommand command = new MySqlCommand(update, con);

                    // Assign parameter values from user input




                    command.Parameters.AddWithValue("@SystemName", SnBox.Text);
                    command.Parameters.AddWithValue("@Model", MoBox.Text);
                    command.Parameters.AddWithValue("@Manufacturer", MaBox.Text);
                    command.Parameters.AddWithValue("@Type", tBox.Text);
                    command.Parameters.AddWithValue("@IP", IpBox.Text);
                    command.Parameters.AddWithValue("@PurchaseDate", PdBox.Text);
                    command.Parameters.AddWithValue("@Notes", NoBox.Text);

                    // Use the provided AssetID for updating the corresponding record
                    command.Parameters.AddWithValue("@AssetID", int.Parse(IDBox.Text));

                    // Execute the SQL query
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Updated");
                    }
                    else
                    {
                        MessageBox.Show("Not updated");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void btnFind_Click_1(object sender, EventArgs e)
        {
            string cs = StringConnector.CnnVal("EmployeesDB");

            // Retrieve existing data for the given AssetID
            string selectQuery = "SELECT * FROM assets WHERE AssetID = @AssetID";

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                try
                {
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, con);
                    selectCommand.Parameters.AddWithValue("@AssetID", int.Parse(IDBox.Text));






                    using (MySqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Prefill text boxes with existing data
                            SnBox.Text = reader["SystemName"].ToString();
                            MoBox.Text = reader["Model"].ToString();
                            MaBox.Text = reader["Manufacturer"].ToString();
                            tBox.Text = reader["Type"].ToString();
                            IpBox.Text = reader["IP"].ToString();
                            PdBox.Text = reader["PurchaseDate"].ToString();
                            NoBox.Text = reader["Notes"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Record not found");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            Dashboard Dashboard = new Dashboard();


            Dashboard.Show();


            this.Hide();
        }

        private void IDBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}