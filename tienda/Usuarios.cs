using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace tienda
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
    }

    //MÉTODO CREAR USUARIO
    private void btnCrear_Usuario(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["OracleConnection"].ConnectionString;
        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO USUARIOS (ID, Nombre, Descripcion, Precio, Cantidad) VALUES (:id, :nombre, :descripcion, :precio, :cantidad)";
            using (OracleCommand cmd = new OracleCommand(query, connection))
            {
                cmd.Parameters.Add(new OracleParameter("id", txtID.Text));
                cmd.Parameters.Add(new OracleParameter("nombre", txtNombre.Text));
                cmd.Parameters.Add(new OracleParameter("descripcion", txtDescripcion.Text));
                cmd.Parameters.Add(new OracleParameter("precio", txtPrecio.Text));
                cmd.Parameters.Add(new OracleParameter("cantidad", txtCantidad.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario creado exitosamente");
                CargarDatos();
            }
        }
    }

    //MÉTODO MOSTRAR USUARIOS
    private void CargarUsuarios()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["OracleConnection"].ConnectionString;
        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM USUARIOS";
            OracleDataAdapter adapter = new OracleDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridViewProductos.DataSource = dataTable;
        }
    }

    //MÉTODO ACTUALIZAR USUARIO
    private void btnActualizar_Usuario(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["OracleConnection"].ConnectionString;
        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            connection.Open();
            string query = "UPDATE USUARIOS SET Nombre = :nombre, Descripcion = :descripcion, Precio = :precio, Cantidad = :cantidad WHERE ID = :id";
            using (OracleCommand cmd = new OracleCommand(query, connection))
            {
                cmd.Parameters.Add(new OracleParameter("nombre", txtNombre.Text));
                cmd.Parameters.Add(new OracleParameter("descripcion", txtDescripcion.Text));
                cmd.Parameters.Add(new OracleParameter("precio", txtPrecio.Text));
                cmd.Parameters.Add(new OracleParameter("cantidad", txtCantidad.Text));
                cmd.Parameters.Add(new OracleParameter("id", txtID.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario actualizado exitosamente");
                CargarDatos();
            }
        }
    }


    //MÉTODO ELIMINAR USUARIO
    private void btnEliminar_Usuario(object sender, EventArgs e)
    {
        string connectionString = ConfigurationManager.ConnectionStrings["OracleConnection"].ConnectionString;
        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            connection.Open();
            string query = "DELETE FROM USUARIOS WHERE ID = :id";
            using (OracleCommand cmd = new OracleCommand(query, connection))
            {
                cmd.Parameters.Add(new OracleParameter("id", txtID.Text));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario eliminado exitosamente");
                CargarUsuarios();
            }
        }
    }


}
