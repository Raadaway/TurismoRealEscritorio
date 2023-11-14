using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoReal.Negocio;
using TurismoReal.Presentacion.WSportafolio;
using TurismoReal.Entidades;

namespace TurismoReal.Presentacion
{
    public partial class FrmServicio : MetroFramework.Forms.MetroForm
    {

        private int idDepartamento; // Campo para almacenar el ID del departamento

        public FrmServicio()
        {
            InitializeComponent();
        }

        // Constructor que acepta el ID del departamento como argumento
        public FrmServicio(int idDepartamento) : this()
        {
            this.idDepartamento = idDepartamento; // Almacena el ID del departamento
            TabGeneral.SelectedIndex = 1;
            SetIdDepartamento(idDepartamento);
            TxtIdDepartamento.ReadOnly = true;
        }

        private void ListarServicios()
        {
            try
            {
                List<DepaServicioSimple> lista = NDepartamentoServicio.ListarDepaServicio();

                if (lista != null)
                {
                    DGVListar.DataSource = lista;
                    LblTotal.Text = "Total de registros: " + Convert.ToString(DGVListar.Rows.Count);
                }
                else
                {
                    DGVListar.DataSource = null; // Limpiar el control DataGridView
                    LblTotal.Text = "No hay registros para mostrar";
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message + ex.StackTrace);
            }
        }

        private void FrmServicio_Load(object sender, EventArgs e)
        {
            ListarServicios();
        }

        public void SetIdDepartamento(int idDepartamento)
        {
            TxtIdDepartamento.Text = idDepartamento.ToString();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtroTexto = TxtBuscar.Text;

            if (DGVListar.DataSource != null)
            {
                DataTable dataTable = (DataTable)DGVListar.DataSource;
                DataView dataView = dataTable.DefaultView;

                try
                {
                    if (!string.IsNullOrEmpty(filtroTexto))
                    {
                        dataView.RowFilter = $"Convert(Id Departamento, 'System.String') LIKE '%{filtroTexto}%' OR Articulo LIKE '%{filtroTexto}%'";
                    }
                    else
                    {
                        dataView.RowFilter = string.Empty;
                    }

                    DGVListar.DataSource = dataView.ToTable();
                    LblTotal.Text = "Total de registros: " + Convert.ToString(dataView.Count);
                }
                catch (Exception ex)
                {
                    // Manejar la excepción (por ejemplo, mostrar un mensaje al usuario o restaurar la vista original)
                    MetroFramework.MetroMessageBox.Show(this, "Error al aplicar el filtro: " + ex.Message);
                }
            }
            else
            {
                ListarServicios();
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtIdDepartamento.Text, out int idDepartamento))
            {
                // Crear una lista de DepaServicioSimple para almacenar los servicios seleccionados
                var depaServicios = new List<DepaServicioSimple>();

                if (CheckBoxPiscina.Checked)
                {
                    depaServicios.Add(new DepaServicioSimple { id_servicio = 1, id_depa = idDepartamento });
                }

                if (CheckBoxAire.Checked)
                {
                    depaServicios.Add(new DepaServicioSimple { id_servicio = 2, id_depa = idDepartamento });
                }

                if (CheckBoxParking.Checked)
                {
                    depaServicios.Add(new DepaServicioSimple { id_servicio = 3, id_depa = idDepartamento });
                }

                if (CheckBoxLavadora.Checked)
                {
                    depaServicios.Add(new DepaServicioSimple { id_servicio = 4, id_depa = idDepartamento });
                }

                if (CheckBoxWifi.Checked)
                {
                    depaServicios.Add(new DepaServicioSimple { id_servicio = 5, id_depa = idDepartamento });
                }

                // Llamar al método de la capa de negocio para agregar los servicios
                bool resultado = NDepartamentoServicio.AgregarDepaServicio(depaServicios);

                if (resultado)
                {
                    // La operación se realizó con éxito
                    MessageBox.Show("Servicios agregados correctamente.");
                }
                else
                {
                    // Manejo de errores
                    MessageBox.Show("Error al agregar servicios de departamento.");
                }
            }
            else
            {
                MessageBox.Show("ID de departamento no válido.");
            }
        }
    }
}
