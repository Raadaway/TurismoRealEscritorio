using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoReal.Datos;
using TurismoReal.Entidades;

namespace TurismoReal.Negocio
{
    public class NComuna
    {
        public List<Comuna> ListarComunas()
        {
            DDComuna dDComuna = new DDComuna();
            List<Comuna> lista =dDComuna.ListarComunas();

            return lista;
        }

    }
}
