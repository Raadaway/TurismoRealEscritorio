using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Entidades
{
    public class ReporteInventario
    {
        public int idArticulo { get; set; }
        public string descripcion { get; set; }
        public int idDepartamento { get; set; }
        public int cantidad { get; set; }
    }
}
