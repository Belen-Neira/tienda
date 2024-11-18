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
    public partial class Ofertas : Form
    {
        private OfertasDAO ofertasDAO = new OfertasDAO();
        public Ofertas()
        {
            InitializeComponent();
            CargarOfertas();
        }

        private void CargarOfertas()
        {
            DataTable dt = ofertasDAO.LeerOfertas();
            dataGridViewOfertas.DataSource = dt;
        }

        private void btnInsertarOferta(object sender, EventArgs e)
        {
            ofertasDAO.InsertarOferta(Convert.ToDecimal(txtDescuento.Text), dtpFechaInicio.Value, dtpFechaFin.Value, Convert.ToInt32(txtLibroID.Text));
            CargarOfertas();
        }

        private void btnActualizarOferta(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            ofertasDAO.ActualizarOferta(id, Convert.ToDecimal(txtDescuento.Text), dtpFechaInicio.Value, dtpFechaFin.Value, Convert.ToInt32(txtLibroID.Text));
            CargarOfertas();
        }

        private void btnEliminarOferta(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            ofertasDAO.EliminarOferta(id);
            CargarOfertas();
        }
    }
}
