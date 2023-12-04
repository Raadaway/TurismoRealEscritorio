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
            BtnModificar.Visible = false;
        }

        // Constructor que acepta el ID del departamento como argumento
        public FrmServicio(int idDepa) : this()
        {
            this.idDepartamento = idDepa; // Almacena el ID del departamento
            TabGeneral.SelectedIndex = 1;
            TxtIdDepartamento.Text = idDepa.ToString();
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
                        dataView.RowFilter = $"nom_servicio LIKE '%{filtroTexto}%' OR Convert(id_depa, 'System.String') LIKE '%{filtroTexto}%'";
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
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Error al aplicar el filtro: " + ex.Message);
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

                // Contar la cantidad de servicios seleccionados
                int serviciosSeleccionados = 0;

                if (CheckBoxPiscina.Checked)
                {
                    depaServicios.Add(new DepaServicioSimple { id_servicio = 1, id_depa = idDepartamento });
                    serviciosSeleccionados++;
                }

                if (CheckBoxAire.Checked)
                {
                    depaServicios.Add(new DepaServicioSimple { id_servicio = 2, id_depa = idDepartamento });
                    serviciosSeleccionados++;
                }

                if (CheckBoxParking.Checked)
                {
                    depaServicios.Add(new DepaServicioSimple { id_servicio = 3, id_depa = idDepartamento });
                    serviciosSeleccionados++;
                }

                if (CheckBoxLavadora.Checked)
                {
                    depaServicios.Add(new DepaServicioSimple { id_servicio = 4, id_depa = idDepartamento });
                    serviciosSeleccionados++;
                }

                if (CheckBoxWifi.Checked)
                {
                    depaServicios.Add(new DepaServicioSimple { id_servicio = 5, id_depa = idDepartamento });
                    serviciosSeleccionados++;
                }

                // Validar que se hayan seleccionado 2 o menos servicios
                if (serviciosSeleccionados > 2)
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent,"Debe seleccionar 2 o menos servicios.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si la validación falla
                }

                // Llamar al método de la capa de negocio para agregar los servicios
                bool resultado = NDepartamentoServicio.AgregarDepaServicio(depaServicios);

                if (resultado)
                {
                    // La operación se realizó con éxito
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Servicios agregados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Manejo de errores
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Error al agregar servicios de departamento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "ID de departamento no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            TxtBuscar.Text = ""; // Borra el contenido del TextBox
            ListarServicios(); // Recarga la lista completa
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }
    }
}
