using System;
using System.Collections.Generic;
using System.Data;
using TurismoReal.Datos.WSportafolio;
using TurismoReal.Entidades;

namespace TurismoReal.Datos
{
    public class DDMantenimiento
    {
        public DataTable ListarMantenimiento()
        {
            WSPortafolioClient client = null;
            DataTable dataTable = new DataTable();

            try
            {
                client = new WSPortafolioClient();

                // Llamamos al método del servicio web para obtener una lista de mantenimientos
                TurismoReal.Datos.WSportafolio.mantenimiento[] lista = client.listarMantenimiento();

                // Verificar si hay registros antes de continuar
                if (lista != null && lista.Length > 0)
                {
                    // Configurar las columnas del DataTable
                    dataTable.Columns.Add("IdMantenimiento", typeof(int));
                    dataTable.Columns.Add("DescMantenimiento", typeof(string));
                    dataTable.Columns.Add("FechaInicio", typeof(DateTime));
                    dataTable.Columns.Add("FechaTermino", typeof(DateTime));
                    dataTable.Columns.Add("IdDepartamento", typeof(int));

                    foreach (var mant in lista)
                    {
                        // Crear una nueva fila en el DataTable
                        DataRow row = dataTable.NewRow();

                        // Asignar los valores del mantenimiento a las columnas correspondientes
                        row["IdMantenimiento"] = mant.id_mantenimiento;
                        row["DescMantenimiento"] = mant.desc_mantenimiento;
                        row["FechaInicio"] = mant.fecha_inicio;
                        row["FechaTermino"] = mant.fecha_termino;
                        row["IdDepartamento"] = mant.id_departamento;

                        // Agregar la fila al DataTable
                        dataTable.Rows.Add(row);
                    }
                }

                return dataTable;
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
        }

        public bool AgregarMantenimiento(Mantenimiento mant)
        {
            WSPortafolioClient client = null;
            bool result = false;

            try
            {
                client = new WSPortafolioClient();

                // Llamamos al método del servicio web para agregar un mantenimiento
                result = client.agregarMantenimiento(
                    mant.DescMantenimiento,
                    mant.FechaInicio.ToString("yyyy-MM-dd"), // Asegúrate de ajustar el formato según tu servicio web
                    mant.FechaTermino.ToString("yyyy-MM-dd"),
                    mant.IdDepartamento
                );
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

            return result;
        }

        public bool ModificarMantenimiento(int idMantenimiento, Mantenimiento mant)
        {
            WSPortafolioClient client = null;
            bool result = false;

            try
            {
                client = new WSPortafolioClient();

                // Llamamos al método del servicio web para modificar un mantenimiento
                result = client.modificarMantenimiento(
                    idMantenimiento,
                    mant.DescMantenimiento,
                    mant.FechaInicio.ToString("yyyy-MM-dd"), // Asegúrate de ajustar el formato según tu servicio web
                    mant.FechaTermino.ToString("yyyy-MM-dd")
                );
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

            return result;
        }

        public bool EliminarMantenimiento(int idMantenimiento)
        {
            WSPortafolioClient client = null;
            bool result = false;

            try
            {
                client = new WSPortafolioClient();

                // Llamamos al método del servicio web para eliminar un mantenimiento
                result = client.eliminarMantenimiento(idMantenimiento);
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

            return result;
        }

    }
}
