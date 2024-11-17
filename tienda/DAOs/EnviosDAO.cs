using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace tienda.DAOs
{
    internal class EnviosDAO
    {
        private string connectionString = "User Id=username;Password=password;Data Source=your_datasource";

        private OracleConnection GetConnection()
        {
            return new OracleConnection(connectionString);
        }

        public DataTable LeerEnvios()
        {
            DataTable dt = new DataTable();
            using (var conn = GetConnection())
            {
                using (var cmd = new OracleCommand("LeerEnvios", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("cursor", OracleDbType.RefCursor).Direction = ParameterDirection.Output;

                    conn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            return dt;
        }
    }
}
