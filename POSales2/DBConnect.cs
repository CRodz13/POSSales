using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSales2
{
    internal class DBConnect
    {
        private string con;
        public string myConnection()
        {
            con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\CRod\Documents\DBPOSale.mdf;Integrated Security=True;Connect Timeout=30";
            return con;
        }
    }
}
