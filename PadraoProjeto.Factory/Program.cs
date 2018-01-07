using System.Data;
using System.Data.SqlClient;

namespace PadraoProjeto.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbConnection conn = new ConnectionFactory().GetConnection();

            IDbCommand comando = conn.CreateCommand();
            comando.CommandText = "select......";
        }
    }
}
