using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace PadraoProjeto.Factory
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection conn = new SqlConnection();
           // conn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionStringName"].ConnectionString;
            conn.Open();

            return conn;
        }
    }
}
