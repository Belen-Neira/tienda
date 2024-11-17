using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace tienda.DAOs
{
    internal class OfertasDAO
    {
        private string connectionString = "User Id=username;Password=password;Data Source=your_datasource";

        private OracleConnection GetConnection()
        {
            return new OracleConnection(connectionString);
        }

        //MÉTODO INSERTAR OFERTA
        public void InsertarOferta(decimal descuento, DateTime fechaInicio, DateTime fechaFin, int libroID)
        {
            using (var conn = GetConnection())
            {
                using (var cmd = new OracleCommand("InsertarOferta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_Descuento", OracleDbType.Decimal).Value = descuento;
                    cmd.Parameters.Add("p_FechaInicio", OracleDbType.TimeStamp).Value = fechaInicio;
                    cmd.Parameters.Add("p_FechaFin", OracleDbType.TimeStamp).Value = fechaFin;
                    cmd.Parameters.Add("p_LibroID", OracleDbType.Int32).Value = libroID;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //MÉTODO LEER OFERTAS
        public DataTable LeerOfertas()
        {
            DataTable dt = new DataTable();
            using (var conn = GetConnection())
            {
                using (var cmd = new OracleCommand("LeerOfertas", conn))
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

        //MÉTODO ACTUALIZAR OFERTA
        public void ActualizarOferta(int id, decimal descuento, DateTime fechaInicio, DateTime fechaFin, int libroID)
        {
            using (var conn = GetConnection())
            {
                using (var cmd = new OracleCommand("ActualizarOferta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_ID", OracleDbType.Int32).Value = id;
                    cmd.Parameters.Add("p_Descuento", OracleDbType.Decimal).Value = descuento;
                    cmd.Parameters.Add("p_FechaInicio", OracleDbType.TimeStamp).Value = fechaInicio;
                    cmd.Parameters.Add("p_FechaFin", OracleDbType.TimeStamp).Value = fechaFin;
                    cmd.Parameters.Add("p_LibroID", OracleDbType.Int32).Value = libroID;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //MÉTODO ELIMINAR OFERTA
        public void EliminarOferta(int id)
        {
            using (var conn = GetConnection())
            {
                using (var cmd = new OracleCommand("EliminarOferta", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_ID", OracleDbType.Int32).Value = id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
