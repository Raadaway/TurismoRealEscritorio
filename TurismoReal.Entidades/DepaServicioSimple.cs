using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Entidades
{
    public class DepaServicioSimple
    {
        [DisplayName("Id Servicio")]
        public int id_servicio { get; set; }

        [DisplayName("Id Departamento")]
        public int id_depa { get; set; }

        [DisplayName("Servicio")]
        public string nom_servicio { get; set; }
    }
}
