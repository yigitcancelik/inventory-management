using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DbConnection
    {
        private static DbConnection instance;

        public static DbConnection GetInstance()
        {
            if (instance == null)
                instance = new DbConnection();
            return instance;
        }

        private DbConnection() { }

        public SqlConnection GetConnection()
        {
            string connString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
            SqlConnection connection = new SqlConnection(connString);
            return connection;
        }
    }
}
