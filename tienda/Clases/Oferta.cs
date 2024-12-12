using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda.Clases
{
    public class Oferta
    {
        public int id {  get; set; }
        public int descuento { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public int libro_id { get; set; }

    }
}
