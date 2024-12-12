using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda.Clases
{
    public class Pedido
    {
        public int id_pedido { get; set; }
        public DateTime fecha_pedido { get; set; }
        public DateTime fecha_entrega_estimada { get; set; }
        public string estado_pedido { get; set; }
        public int monto_total { get; set; }
        public int cliente_id { get; set; }

    }
}
