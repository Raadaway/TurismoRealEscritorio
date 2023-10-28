using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Entidades
{
    public class Reserva
    {
        [DisplayName("ID reserva")]
        public int id_reserva { get; set; }

        [DisplayName("Fecha Inicio")]
        public DateTime inicio_reserva { get; set; }

        [DisplayName("Fecha Termino")]
        public DateTime termino_reserva { get; set; }

        [DisplayName("Cantidad de personas")]
        public int cant_personas { get; set; }

        [DisplayName("Total a pagar")]
        public int monto_total { get; set; }

        [DisplayName("Total abonado")]
        public int monto_abonado { get; set; }

        [DisplayName("ID departamento")]
        public int departamento_id_departamento { get; set; }

        [DisplayName("Rut cliente")]
        public int cliente_rut { get; set; }

        [DisplayName("Estado Reserva")]
        public String estado_reserva { get; set; }
    }
}
