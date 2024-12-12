using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace tienda
{
    public class Conexion
    {
        private static Conexion con = null;

        public Conexion()
        {
        }

        public OracleConnection CrearConexion()
        {
            OracleConnection orc = new OracleConnection();
            try
            {
                orc.ConnectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED(SERVICE_NAME=xe)));User Id=TSUKI;Password=TSUKI;";

            }
            catch (Exception ex)
            {
                orc = null;
                throw ex;
            }
            return orc;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }   
}
