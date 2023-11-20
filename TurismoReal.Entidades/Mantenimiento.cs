using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Entidades
{
    public class Mantenimiento
    {
        public int IdMantenimiento { get; set; }
        public string DescMantenimiento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public int IdDepartamento { get; set; }
    }
}
