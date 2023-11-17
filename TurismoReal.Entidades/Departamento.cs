using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoReal.Entidades
{
    public class Departamento
    {
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
        public int Capacidad_persona { get; set; }
        public int Cantidad_img { get; set; }
        public int habitaciones { get; set; }
        public int Id_comuna { get; set; }
    }
}
