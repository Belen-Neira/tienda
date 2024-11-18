using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tienda.DAOs;

namespace tienda
{
    public partial class Libros : Form
    {
        private LibrosDAO librosDAO = new LibrosDAO();

        public Libros()
        {
            InitializeComponent();
            CargarLibros();
        }

        private void CargarLibros()
        {
            DataTable dt = librosDAO.LeerLibros();
            dataGridViewLibros.DataSource = dt;
        }

        private void btnInsertarLibro(object sender, EventArgs e)
        {
            librosDAO.InsertarLibro(txtNombre.Text, txtDescripcion.Text, txtAutor.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text));
            CargarLibros();
        }

        private void btnActualizarLibro(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            librosDAO.ActualizarLibro(id, txtNombre.Text, txtDescripcion.Text, txtAutor.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text));
            CargarLibros();
        }

        private void btnEliminarLibro(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            librosDAO.EliminarLibro(id);
            CargarLibros();
        }
    }
}
