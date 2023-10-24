using System;
using System.Collections.Generic;
using System.Data;
using TurismoReal.Datos.WSportafolio;
using TurismoReal.Entidades;
using System.Linq;

namespace TurismoReal.Datos
{
    public class DDDepartamentoServicio
    {
        public bool AgregarDepaServicio(List<DepaServicioSimple> depaServicios)
        {
            try
            {
                WSPortafolioClient client = new WSPortafolioClient();
                var depaServiciosArray = new List<depaServicioSimple>();

                foreach (var servicio in depaServicios)
                {
                    depaServicioSimple servicioSimple = new depaServicioSimple
                    {
                        id_servicio = servicio.id_servicio,
                        id_depa = servicio.id_depa
                    };
                    depaServiciosArray.Add(servicioSimple);
                }

                bool resultado = client.agregarDepaServicio(depaServiciosArray.ToArray());

                if (!resultado)
                {
                    Console.WriteLine("Error al agregar servicios de departamento.");
                    return false;
                }

                return true; // Indica que la operación se realizó con éxito
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en capa de datos al agregar servicios: " + ex.Message);
                return false;
            }
        }

        /*public List<DepaServicioSimple> ListarDepaServicio()
        {
            try
            {
                WSPortafolioClient client = new WSPortafolioClient();

                // Llamamos al método del servicio web para obtener una lista de servicios
                depaServicioSimple[] lista = client.listarDepaServicio();

                // Convierte el array de servicios del servicio web a una lista
                List<DepaServicioSimple> listaServicios = lista.Select(s => new DepaServicioSimple
                {
                    id_servicio = s.id_servicio,
                    id_depa = s.id_depa,
                    nom_servicio = s.nom_servicio
                }).ToList();

                return listaServicios;
            }
            catch (Exception ex)
            {
                // Manejo de excepciones o registro de errores
                throw ex;
            }
        }*/
    }
}






