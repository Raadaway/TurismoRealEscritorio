using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Entidades
{
    public class CheckOut
    {
        public int IdCheckOut { get; set; }
        public string Hora { get; set; }
        public DateTime Fecha { get; set; }
        public int Multas { get; set; }
        public int PagoCliente { get; set; }
        public string FirmaCliente { get; set; }
        public int IdReserva { get; set; }
        public int FuncionarioRut { get; set; }
    }
}
