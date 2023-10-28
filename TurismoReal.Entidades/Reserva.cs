using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Entidades
{
    public class Reserva
    {
        public int id_reserva { get; set; }
        public DateTime inicio_reserva { get; set; }
        public DateTime termino_reserva { get; set; }
        public int cant_personas { get; set; }
        public int monto_total { get; set; }
        public int monto_abonado { get; set; }
        public int departamento_id_departamento { get; set; }
        public int cliente_rut { get; set; }
        public int estado_res_id_estado { get; set; }
    }
}
