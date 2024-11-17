using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace tienda
{
    internal class Conexion
    {
    }

    public class OracleDB
    {
        private String connectionString = "User Id=username;Password=password;Data Source=your_datasource";

        public OracleConnection GetConnection()
        {
            return new OracleConnection(connectionString);
        }
    }
}
