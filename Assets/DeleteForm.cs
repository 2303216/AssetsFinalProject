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
    public partial class DeleteForm : Form
    {




        public DeleteForm()
        {
            InitializeComponent();
        }






        private void DeleteForm_Load(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string cs = StringConnector.CnnVal("EmployeesDB");

            using (var con = new MySqlConnection(cs))
            {



                try
                {





                    string DeleteFromDb = "DELETE FROM assets WHERE AssetID = " + IDdelete.Text;

                    con.Open();
                    MySqlCommand command = new MySqlCommand(DeleteFromDb, con);
                    if (command.ExecuteNonQuery() == 1)
                    {


                        MessageBox.Show("Asset Deleted");
                    }
                    else
                    {
                        MessageBox.Show("To Delete asset go to previos page and look for assetID ");
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Dashboard Dashboard = new Dashboard();
            Dashboard.Show();
            this.Hide();
        }




    }
}
