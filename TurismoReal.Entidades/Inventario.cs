using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Entidades
{
    public class Inventario
    {
        [DisplayName("Id del Articulo")]
        public int id_articulo { get; set; }

        [DisplayName("Id del Departamento")]
        public int id_departamento { get; set; }

        [DisplayName("Cantidad")]
        public int cantidad { get; set; }

        [DisplayName("Articulo")]
        public string nombre { get; set; }

        [DisplayName("Precio")]
        public int precio { get; set; }
    }
}
