using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using MySql.Data.MySqlClient;




namespace Assets
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string cs = StringConnector.CnnVal("EmployeesDB");

            using (var con = new MySqlConnection(cs))
            {
                try
                {
                    {
                        con.Open();
                        string stm = "SELECT email, password FROM people WHERE email = @email and password = @password";
                        var cmd = new MySqlCommand(stm, con);
                        cmd.Parameters.AddWithValue("@email", LoginBox.Text);
                        cmd.Parameters.AddWithValue("@password", PasswordBox.Text);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                // Successful login
                                MessageBox.Show("Login successful!");

                                // Create an instance of Dashboard and show it
                                Dashboard dashboardForm = new Dashboard();
                                dashboardForm.Show();

                                // Optionally, you can hide the loginForm if needed
                                this.Hide();
                            }
                            else
                            {
                                // Failed login
                                MessageBox.Show("Wrong Email or password. Please try again");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                con.Close();
            }
        }

        // Update the PasswordChar property when the user types in the PasswordBox
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            // Set the PasswordChar property to '*' to mask the entered characters
            PasswordBox.PasswordChar = '*';
        }
    }
}
