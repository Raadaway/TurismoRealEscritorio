using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Entidades
{
    public class Transporte
    {
            public int IdTransporte { get; set; }
            public string NombreEmpresa { get; set; }
            public string Horario { get; set; }
            public string Patente { get; set; }
            public int TarifaAdicional { get; set; }
            public int RutChofer { get; set; }
    }
}
