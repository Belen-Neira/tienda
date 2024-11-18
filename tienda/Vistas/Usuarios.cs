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
using tienda.DAOs;

namespace tienda
{
    public partial class Usuarios : Form
    {
        private UsuariosDAO usuariosDAO = new UsuariosDAO();
        public Usuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void CargarUsuarios()
        {
            DataTable dt = usuariosDAO.LeerUsuarios();
            dataGridViewUsuarios.DataSource = dt;
        }

        private void btnInsertarUsuario(object sender, EventArgs e)
        {
            usuariosDAO.InsertarUsuario(txtPassword.Text, dtpLastLogin.Value, Convert.ToInt32(txtIsSuperuser.Text), txtRut.Text, txtNombre.Text, txtApellido.Text, txtUsername.Text, txtCorreo.Text, txtTelefono.Text, txtTipoUsuario.Text, Convert.ToInt32(txtIsActive.Text), Convert.ToInt32(txtIsStaff.Text));
            CargarUsuarios();
        }

        private void btnActualizarUsuario(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            usuariosDAO.ActualizarUsuario(id, txtPassword.Text, dtpLastLogin.Value, Convert.ToInt32(txtIsSuperuser.Text), txtRut.Text, txtNombre.Text, txtApellido.Text, txtUsername.Text, txtCorreo.Text, txtTelefono.Text, txtTipoUsuario.Text, Convert.ToInt32(txtIsActive.Text), Convert.ToInt32(txtIsStaff.Text));
            CargarUsuarios();
        }

        private void btnEliminarUsuario(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            usuariosDAO.EliminarUsuario(id);
            CargarUsuarios();
        }
    }
}
