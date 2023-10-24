using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TurismoReal.Datos;
using TurismoReal.Entidades;

namespace TurismoReal.Negocio
{
    public class NDepartamentoServicio
    {
        public static bool AgregarDepaServicio(List<DepaServicioSimple> depaServicios)
        {
            try
            {
                DDDepartamentoServicio datosDepaServicio = new DDDepartamentoServicio();
                return datosDepaServicio.AgregarDepaServicio(depaServicios);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa de negocios al agregar servicios de departamentos: " + ex.Message);
                return false;
            }
        }
    }
}
