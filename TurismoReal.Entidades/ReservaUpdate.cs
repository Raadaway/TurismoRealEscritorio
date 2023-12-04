using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Entidades
{
    public class ReservaUpdate
    {
        public int idUpdate { get; set; }
        public int montoTotal { get; set; }
        public int montoAbonado { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }
        public int idReserva { get; set; }
        public string descripcion { get; set; }
    }
}
