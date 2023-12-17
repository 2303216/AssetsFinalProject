using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assets
{

    public partial class Dashboard : Form



    {


        List<Asset> asset1 = new List<Asset>();

        List<Employee> people = new List<Employee>();


        public Dashboard()
        {
            InitializeComponent();



            AssetBox.DataSource = asset1;
            AssetBox.DisplayMember = "AssetInfo";



            peoplelist.DataSource = people;
            peoplelist.DisplayMember = "FullInfo";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            people = db.GetPeople(EmailTXT.Text);
            asset1 = db.GetAsset(EmailTXT.Text);

            AssetBox.DataSource = asset1;
            AssetBox.DisplayMember = "AssetInfo";




            peoplelist.DataSource = people;
            peoplelist.DisplayMember = "FullInfo";



        }

        private void AssetBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddAssetButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            if (int.TryParse(textBox7.Text, out int numericValue))
            {
                // Validate textBox8 format using a regular expression
                string ipAddressPattern = @"^\d{1,3}(\.\d{1,3}){3}$";
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox8.Text, ipAddressPattern))
                {
                    // Validate textBox5 format as a date
                    string dateFormat = @"^\d{1,2}/\d{1,2}/\d{4}$";
                    if (System.Text.RegularExpressions.Regex.IsMatch(textBox5.Text, dateFormat))
                    {
                        db.InsertAsset(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox8.Text, textBox5.Text, textBox6.Text, numericValue);

                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox8.Text = "";
                        textBox5.Text = "";
                        textBox6.Text = "";
                        textBox7.Text = "";
                        MessageBox.Show("Asset Added");
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid date format (e.g., MM/DD/YYYY).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox5.Clear();
                        textBox5.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid IP address format (e.g., x.x.x.x).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox8.Clear();
                    textBox8.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric value for EmployeeID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox7.Clear();
                textBox7.Focus();
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }






        private void GoDelete_Click(object sender, EventArgs e)
        {

            DeleteForm deleteForm = new DeleteForm();


            deleteForm.Show();


            this.Hide();
        }

        private void GoEdit_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.Show();
            this.Hide();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            sec secForm = new sec();


            secForm.Show();


            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vulnerability vulnerabilityForm = new Vulnerability();


            vulnerabilityForm.Show();


            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {







            HardwareInfo hardwareInfo = new HardwareInfo();

             string systemName = hardwareInfo.GetSystemName();
            string systemModel = hardwareInfo.GetSystemModel();
            string systemManufacturer = hardwareInfo.GetSystemManufacturer();
            string systemType = hardwareInfo.GetSystemType();
            string ipAddress = hardwareInfo.GetLocalIPAddress();

            textBox1.Text = systemName;
            textBox2.Text = systemModel;
            textBox3.Text = systemManufacturer;
            textBox4.Text = systemType;
            textBox8.Text = ipAddress;



        }
    }

}

    
