using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tienda.Clases
{
    public class Libro
    {
        public int id_libro {  get; set; }
        public string nombre_libro { get; set; }
        public string descripcion {  get; set; }
        public string autor {  get; set; }
        public string editorial {  get; set; }
        public int precio_unitario {  get; set; }
        public int cantidad_disponible {  get; set; }
        public string thumbnail { get; set; }
        public string portada {  get; set; }
        public DateTime fecha_publicacion { get; set; }
        public string categoria {  get; set; }
        public string isbn { get; set; }
        public string slug { get; set; }

    }
}
