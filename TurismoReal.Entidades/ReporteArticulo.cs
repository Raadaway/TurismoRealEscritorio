using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Entidades
{
    public class ReporteArticulo
    {
        public int idArticulo { get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
        public int precio { get; set; }
    }
}
