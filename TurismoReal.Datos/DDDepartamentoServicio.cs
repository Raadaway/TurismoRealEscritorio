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

        public List<DepaServicioSimple> ListarDepaServicio()
        {
            WSportafolio.WSPortafolioClient client = null;
            List<DepaServicioSimple> lista = new List<DepaServicioSimple>();

            try
            {
                client = new WSportafolio.WSPortafolioClient();
                var depServWebService = client.listarDepaServicio();

                if (depServWebService != null)
                {
                    foreach (var DepServWS in depServWebService)
                    {
                        DepaServicioSimple DepServ = new DepaServicioSimple
                        {
                            id_servicio = DepServWS.id_servicio,
                            id_depa = DepServWS.id_depa,
                            nom_servicio = DepServWS.nom_servicio
                        };

                        lista.Add(DepServ);
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones o registro de errores
                throw ex;
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }

            return lista;
        }
    }
}






