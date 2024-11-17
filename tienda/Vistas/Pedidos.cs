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
    public partial class Pedidos : Form
    {
        private PedidosDAO pedidosDAO = new PedidosDAO();
        public Pedidos()
        {
            InitializeComponent();
            CargarPedidos();
        }

        private void CargarPedidos()
        {
            DataTable dt = pedidosDAO.LeerPedidos();
            dataGridViewPedidos.DataSource = dt;
        }
    }
}
