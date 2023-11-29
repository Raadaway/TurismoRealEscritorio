using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Entidades
{
    public class ReporteReservas
    {
        public int idDepartamento { get; set; }
        public int cantArriendos { get; set; }
        public string estadoReserva { get; set; }
        public int totalGenerado { get; set; }
    }
}
