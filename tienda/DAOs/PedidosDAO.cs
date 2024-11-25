using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace tienda.DAOs
{
    internal class PedidosDAO
    {
        private string connectionString = "User Id=LIBRERIA_IMAGINA;Password=imagina123;Data Source=LIBRERIA_IMAGINA";

        private OracleConnection GetConnection()
        {
            return new OracleConnection(connectionString);
        }

        public DataTable LeerPedidos()
        {
            DataTable dt = new DataTable();
            using (var conn = GetConnection())
            {
                using (var cmd = new OracleCommand("LeerPedidos", conn))
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
