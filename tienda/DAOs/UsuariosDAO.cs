using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace tienda.DAOs
{
    internal class UsuariosDAO
    {
        private string connectionString = "User Id=username;Password=password;Data Source=your_datasource";

        private OracleConnection GetConnection()
        {
            return new OracleConnection(connectionString);
        }

        //MÉTODO INSERTAR USUARIO
        public void InsertarUsuario(string password, DateTime lastLogin, int isSuperuser, string rut, string nombre, string apellido, string username, string correo, string telefono, string tipoUsuario, int isActive, int isStaff, int direccionID)
        {
            using (var conn = GetConnection())
            {
                using (var cmd = new OracleCommand("InsertarUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_Password", OracleDbType.NVarchar2).Value = password;
                    cmd.Parameters.Add("p_LastLogin", OracleDbType.TimeStamp).Value = lastLogin;
                    cmd.Parameters.Add("p_IsSuperuser", OracleDbType.Int32).Value = isSuperuser;
                    cmd.Parameters.Add("p_Rut", OracleDbType.NVarchar2).Value = rut;
                    cmd.Parameters.Add("p_Nombre", OracleDbType.NVarchar2).Value = nombre;
                    cmd.Parameters.Add("p_Apellido", OracleDbType.NVarchar2).Value = apellido;
                    cmd.Parameters.Add("p_Username", OracleDbType.NVarchar2).Value = username;
                    cmd.Parameters.Add("p_Correo", OracleDbType.NVarchar2).Value = correo;
                    cmd.Parameters.Add("p_Telefono", OracleDbType.NVarchar2).Value = telefono;
                    cmd.Parameters.Add("p_TipoUsuario", OracleDbType.NVarchar2).Value = tipoUsuario;
                    cmd.Parameters.Add("p_IsActive", OracleDbType.Int32).Value = isActive;
                    cmd.Parameters.Add("p_IsStaff", OracleDbType.Int32).Value = isStaff;
                    cmd.Parameters.Add("p_DireccionID", OracleDbType.Int32).Value = direccionID;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //MÉTODO LEER USUARIOS
        public DataTable LeerUsuarios()
        {
            DataTable dt = new DataTable();
            using (var conn = GetConnection())
            {
                using (var cmd = new OracleCommand("LeerUsuarios", conn))
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

        //MÉTODO ACTUALIZAR USUARIO
        public void ActualizarUsuario(int id, string password, DateTime lastLogin, int isSuperuser, string rut, string nombre, string apellido, string username, string correo, string telefono, string tipoUsuario, int isActive, int isStaff, int direccionID)
        {
            using (var conn = GetConnection())
            {
                using (var cmd = new OracleCommand("ActualizarUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_ID", OracleDbType.Int32).Value = id;
                    cmd.Parameters.Add("p_Password", OracleDbType.NVarchar2).Value = password;
                    cmd.Parameters.Add("p_LastLogin", OracleDbType.TimeStamp).Value = lastLogin;
                    cmd.Parameters.Add("p_IsSuperuser", OracleDbType.Int32).Value = isSuperuser;
                    cmd.Parameters.Add("p_Rut", OracleDbType.NVarchar2).Value = rut;
                    cmd.Parameters.Add("p_Nombre", OracleDbType.NVarchar2).Value = nombre;
                    cmd.Parameters.Add("p_Apellido", OracleDbType.NVarchar2).Value = apellido;
                    cmd.Parameters.Add("p_Username", OracleDbType.NVarchar2).Value = username;
                    cmd.Parameters.Add("p_Correo", OracleDbType.NVarchar2).Value = correo;
                    cmd.Parameters.Add("p_Telefono", OracleDbType.NVarchar2).Value = telefono;
                    cmd.Parameters.Add("p_TipoUsuario", OracleDbType.NVarchar2).Value = tipoUsuario;
                    cmd.Parameters.Add("p_IsActive", OracleDbType.Int32).Value = isActive;
                    cmd.Parameters.Add("p_IsStaff", OracleDbType.Int32).Value = isStaff;
                    cmd.Parameters.Add("p_DireccionID", OracleDbType.Int32).Value = direccionID;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //MÉTODO ELIMINAR USUARIO
        public void EliminarUsuario(int id)
        {
            using (var conn = GetConnection())
            {
                using (var cmd = new OracleCommand("EliminarUsuario", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("p_ID", OracleDbType.Int32).Value = id;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //MÉTODO VALIDAR USUARIO LOGIN
        public bool VerificarUsuario(string username, string password)
        {
            using (var conn = GetConnection())
            {
                using (var cmd = new OracleCommand("SELECT COUNT(*) FROM TSUKI.USUARIO WHERE USERNAME = :username AND PASSWORD = :password", conn))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(":username", OracleDbType.NVarchar2).Value = username;
                    cmd.Parameters.Add(":password", OracleDbType.NVarchar2).Value = password;

                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }
    }
}
