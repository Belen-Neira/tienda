using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace tienda.DAOs
{
    internal class LibrosDAO
    {
        private string connectionString = "User Id=LIBRERIA_IMAGINA;Password=imagina123;Data Source=LIBRERIA_IMAGINA";

        private OracleConnection GetConnection()
        {
            return new OracleConnection(connectionString);
        }

        //MÉTODO INSERTAR LIBRO BD
        public void InsertarLibro(string nombreLibro, string descripcion, string autor, decimal precioUnitario, int cantidadDisponible)
        {
            using (var conn = GetConnection())
            {
                using (var cmd = new OracleCommand("InsertarLibro", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_NombreLibro", OracleDbType.NVarchar2).Value = nombreLibro;
                    cmd.Parameters.Add("p_Descripcion", OracleDbType.NClob).Value = descripcion;
                    cmd.Parameters.Add("p_Autor", OracleDbType.NVarchar2).Value = autor;
                    cmd.Parameters.Add("p_PrecioUnitario", OracleDbType.Decimal).Value = precioUnitario;
                    cmd.Parameters.Add("p_CantidadDisponible", OracleDbType.Int32).Value = cantidadDisponible;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //MÉTODO LEER LIBROS Y MANGAS EN LA VISTA
        public DataTable LeerLibros()
        {
            DataTable dt = new DataTable();
            using (var conn = GetConnection())
            {
                using (var cmd = new OracleCommand("LeerLibros", conn))
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

        //MÉTODO ACTUALIZAR LIBRO
        public void ActualizarLibro(int idLibro, string nombreLibro, string descripcion, string autor, decimal precioUnitario, int cantidadDisponible) 
        { 
            using (var conn = GetConnection()) 
            { 
                using (var cmd = new OracleCommand("ActualizarLibro", conn)) 
                { 
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_IDLibro", OracleDbType.Int32).Value = idLibro;
                    cmd.Parameters.Add("p_NombreLibro", OracleDbType.NVarchar2).Value = nombreLibro;
                    cmd.Parameters.Add("p_Descripcion", OracleDbType.NClob).Value = descripcion;
                    cmd.Parameters.Add("p_Autor", OracleDbType.NVarchar2).Value = autor;
                    cmd.Parameters.Add("p_PrecioUnitario", OracleDbType.Decimal).Value = precioUnitario;
                    cmd.Parameters.Add("p_CantidadDisponible", OracleDbType.Int32).Value = cantidadDisponible;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                } 
            } 
        }

        //MÉTODO ELIMINAR LIBRO
        public void EliminarLibro(int idLibro) 
        { 
            using (var conn = GetConnection()) 
            { 
                using (var cmd = new OracleCommand("EliminarLibro", conn)) 
                { 
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_IDLibro", OracleDbType.Int32).Value = idLibro;
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}

