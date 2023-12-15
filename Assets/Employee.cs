using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string firstname { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string departament { get; set; }



        public string FullInfo
        {

            get
            {
                return $"{ firstname } { surname } ({ email }) EmployeeID= { EmployeeID }";
            }


        }

        

    }
}
public class Asset
{
    public int AssetID { get; set; }
    public string SystemName { get; set; }
    public string Model { get; set; }
    public string Manufaturer { get; set; }
    public string Type { get; set; }
    public string IP { get; set; }
    public string PurchaseDate { get; set; }
    public string Notes { get; set; }
    public int EmplyeeID { get; set; }
    



    public string AssetInfo
    {

        get
        {
            return $"{ SystemName } { Model } { Manufaturer } { Type } AssetID= { AssetID }";
        }


    }



}
