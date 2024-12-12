using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda.Clases
{
    public class Usuario
    {
        public int id { get; set; }
        public string password { get; set; }
        public string last_login { get; set; }
        public int is_superuser { get; set; }
        public string rut {  get; set; }
        public string nombre { get; set; }
        public string apellido {  get; set; }
        public string username { get; set; }
        public string correo { get; set; }
        public int telefono { get; set; }
        public string tipo_usuario {  get; set; }
        public int is_active { get; set; }
        public int is_staff {  get; set; }
        public int direccion_id { get; set; }

    }
}
