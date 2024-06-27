using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Trust_Machine_Test
{
    internal static class dbConnection
    {
        public static SqlConnection con;

        public static SqlConnection GetConnection()
        {
            con = new SqlConnection("Server = LAPTOP-9RQBBG2R\\SQLEXPRESS; Integrated Security = True; Database = trustdb;");
            return con;
        }
    }
}