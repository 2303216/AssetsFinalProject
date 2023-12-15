using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;


namespace Assets
{



    public class DataAccess
    {


        public List<Employee> GetPeople(string email)
        {
            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(StringConnector.CnnVal("EmployeesDB")))
            {

                var output = connection.Query<Employee>($"select * from people where email = '{ email }'").ToList();




                return output;
            }
        }
        public List<Asset> GetAsset(string email)
        {
            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(StringConnector.CnnVal("EmployeesDB")))
            {

                string sqlQuery = @"
            SELECT a.* 
            FROM people p
            INNER JOIN assets a ON p.EmployeeID = a.EmployeeID
            WHERE p.email = @Email";


                var output = connection.Query<Asset>(sqlQuery, new { Email = email }).ToList();

                return output;
            }
        }

        public void InsertAsset(string text1, string text2, string text3, string text4, string text8, string text5, string text6, int numericValue)
        {
            using (IDbConnection connection = new MySql.Data.MySqlClient.MySqlConnection(StringConnector.CnnVal("EmployeesDB")))
            {
                connection.Open();
                using (IDbCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO assets (SystemName, Model, Manufacturer, Type, IP, PurchaseDate, Notes, EmployeeID) " +
                                     "VALUES (@SystemName, @Model, @Manufacturer, @Type,  @IP, @PurchaseDate, @Notes, @EmployeeID)";

                    cmd.Parameters.Add(new MySqlParameter("@SystemName", text1));
                    cmd.Parameters.Add(new MySqlParameter("@Model", text2));
                    cmd.Parameters.Add(new MySqlParameter("@Manufacturer", text3));
                    cmd.Parameters.Add(new MySqlParameter("@Type", text4));
                    cmd.Parameters.Add(new MySqlParameter("@IP", text8));
                    cmd.Parameters.Add(new MySqlParameter("@PurchaseDate", text5));
                    cmd.Parameters.Add(new MySqlParameter("@Notes", text6));
                    cmd.Parameters.Add(new MySqlParameter("@EmployeeID", numericValue));

                    cmd.ExecuteNonQuery();
                }


            }
        }

    }
}