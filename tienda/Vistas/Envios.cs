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
    public partial class Envios : Form
    {
        private EnviosDAO enviosDAO = new EnviosDAO();
        public Envios()
        {
            InitializeComponent();
            CargarEnvios();
        }

        private void CargarEnvios()
        {
            DataTable dt = enviosDAO.LeerEnvios();
            dataGridViewEnvios.DataSource = dt;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
