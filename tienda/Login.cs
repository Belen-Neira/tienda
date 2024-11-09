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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        //CONEXIÓN A LA BASE DE DATOS ORACLE
       /* OracleConnection conexion = new OracleConnection("DATA SOURCE = ** ; PASSWORD = ** ; USER ID = **");
        private void btnLogin_Click(object sender, EventArgs e)
        {
        
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECT * FROM LIBRERIA_IMAGINA.USUARIO WHERE NOMBRE = :nombre AND PASSWORD = :pass", conexion);

            comando.Parameters.AddWithValue(":nombre", txtNombre.Text);
            comando.Parameters.AddWithValue(":pass", lblPass.Text);

            OracleDataReader lector = comando.ExecuteReader();

            if(lector.Read())
            {
                //SUJETO A CAMBIOS SE LLAMA A LA SIGUIENTE VISTA QUE PASA DEL LOGIN
                Form1 formulario = new Form1();
                conexion.Close();
                formulario.Show();
            }
            else
            {
                MessageBox.Show("No es posible acceder");
            }
        }*/

        private void Login_Load(object sender, EventArgs e)
        { 
        

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            
        }

        private void lblPass_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
