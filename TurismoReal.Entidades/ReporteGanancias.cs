using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Entidades
{
    public class ReporteGanancias
    {
        public int idReserva { get; set; }
        public DateTime inicioReserva { get; set; }
        public DateTime terminoReserva { get; set; }
        public int ganancias { get; set; }
        public int idDepartamento { get; set; }
        public string estadoReserva { get; set; }
    }
}
