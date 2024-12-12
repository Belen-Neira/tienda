using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda.Clases
{
    public class Envio
    {
        public int id_envio { get; set; }
        public DateTime fecha_envio { get; set; }
        public int direccion_id { get; set; }
        public int repartidor_id { get; set; }
        public int pedido_id { get; set; }

    }
}
