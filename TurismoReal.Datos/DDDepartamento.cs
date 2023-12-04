using System;
using System.Collections.Generic;
using System.Data;
using TurismoReal.Datos.WSportafolio;
using TurismoReal.Entidades;
using System.Linq;

namespace TurismoReal.Datos
{
    public class DDDepartamento
    {
        public DataTable Listar()
        {
            WSPortafolioClient client = null;
            DataTable dataTable = new DataTable();

            try
            {
                client = new WSPortafolioClient();

                // Llama al método del servicio web para obtener una lista de departamentos
                departamentoDetalle[] lista = client.listarDepartamento();

                if (lista != null && lista.Length > 0)
                {
                    // Configura las columnas del DataTable
                    dataTable.Columns.Add("ID", typeof(int));
                    dataTable.Columns.Add("Direccion", typeof(string));
                    dataTable.Columns.Add("Descripcion", typeof(string));
                    dataTable.Columns.Add("Precio", typeof(int));
                    dataTable.Columns.Add("Latitud", typeof(float));
                    dataTable.Columns.Add("Longitud", typeof(float));
                    dataTable.Columns.Add("Capacidad", typeof(int));
                    dataTable.Columns.Add("Habitaciones", typeof(int));
                    dataTable.Columns.Add("Comuna", typeof(string));
                    dataTable.Columns.Add("Estado", typeof(string));

                    foreach (var dep in lista)
                    {
                        if (dep.desc_estado != "Desuso")
                        {
                            DataRow row = dataTable.NewRow();
                            row["ID"] = dep.id_depa;
                            row["Direccion"] = dep.direccion;
                            row["Descripcion"] = dep.descripcion;
                            row["Precio"] = dep.precio;
                            row["Latitud"] = dep.latitud;
                            row["Longitud"] = dep.longitud;
                            row["Capacidad"] = dep.cap_personas;
                            row["Habitaciones"] = dep.habitaciones;
                            row["Comuna"] = dep.nom_comuna;
                            row["Estado"] = dep.desc_estado;
                            dataTable.Rows.Add(row);
                        }
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
                // Asegúrate de cerrar el cliente para liberar recursos
                if (client != null)
                {
                    client.Close();
                }
            }

            return dataTable;
        }

        public int ObtenerSiguienteIdDepa()
        {
            WSPortafolioClient cliente = null;
            int idDepa = -1;
            try
            {
                cliente = new WSPortafolioClient();
                int idDepaWS = cliente.obtenerSiguienteIdDepa();
                if (idDepaWS >= 1)
                {
                    idDepa = idDepaWS;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cliente != null)
                {
                    cliente.Close();
                }
            }
            return idDepa;
        }

        public bool AgregarDepartamento(string direccion, string descripcion, int precio, float latitud, float longitud, int capacidad_persona, int cantidad_img, int habitaciones, int id_comuna)
        {
            bool ward = false;
            WSPortafolioClient client = null;

            try
            {
                client = new WSPortafolioClient();
                ward = client.agregarDepartamento(direccion, descripcion, precio, latitud, longitud, capacidad_persona, cantidad_img, habitaciones, id_comuna);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar departamento: " + ex.Message);
            }
            finally
            {
                if (client != null)
                {
                    client.Close();
                }
            }
            return ward;
        }




        public bool ModificarDepartamento(int id_departamento, string direccion, string descripcion, int precio, float latitud, float longitud, int capacidadPersona, int cantidadImagenes, int habitaciones, int idComuna)
        {
            try
            {
                WSPortafolioClient client = new WSPortafolioClient();
                bool resultado = client.modificarDepartamento(id_departamento, direccion, descripcion, precio, latitud, longitud, capacidadPersona, cantidadImagenes, habitaciones, idComuna);
                client.Close();
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al modificar departamento a través del servicio web: " + ex.Message);
                return false;
            }
        }

        public bool EliminarDepartamento(int id_departamento)
        {
            try
            {
                WSPortafolioClient client = new WSPortafolioClient();
                bool resultado = client.eliminarDepartamento(id_departamento);
                client.Close();
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar departamento: " + ex.Message);
                return false;
            }
        }
    }
}









