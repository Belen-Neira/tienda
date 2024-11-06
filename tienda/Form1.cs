using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tienda
{
    public partial class Form1 : Form
    {
        string server = "Data Source = "
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IblNombre_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            lblNombre.Text = "Nombre";
            comboBox1.Items.Add(textBoxNombre.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
