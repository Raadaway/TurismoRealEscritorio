using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoReal.Negocio;
using TurismoReal.Presentacion.WSportafolio;

namespace TurismoReal.Presentacion
{
    public partial class FrmFuncionario : MetroFramework.Forms.MetroForm
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }
        private void Listar()
        {
            try
            {
                DataTable dataTable = NFuncionario.Listar();

                if (dataTable != null)
                {
                    DGVListar.DataSource = dataTable;
                    this.Formato();
                    this.Limpiar();
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
                MetroFramework.MetroMessageBox.Show(this.MdiParent, ex.Message + ex.StackTrace);
            }
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
                        dataView.RowFilter = $"Nombre LIKE '%{filtroTexto}%' OR Convert(RUT, 'System.String') LIKE '%{filtroTexto}%'";
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
                Listar();
            }
        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                TxtBuscar_TextChanged((object)sender, e);
            }
        }

        private void BtnRefrescar_Click(object sender, EventArgs e)
        {
            TxtBuscar.Text = ""; // Borra el contenido del TextBox
            Listar(); // Recarga la lista completa
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtRut.Clear();
            TxtDv.Clear();
            TxtNombre.Clear();
            TxtApellidoP.Clear();
            TxtApellidoM.Clear();
            TxtTelefono.Clear();
            TxtCorreo.Clear();
            TxtUsuario.Clear();
            TxtContrasena.Clear();
            BtnAgregar.Visible = true;
            BtnModificar.Visible = false;

            DGVListar.Columns[0].Visible = false;
            BtnEliminar.Visible = false;
        }

        private void Formato()
        {
            // Verifica si hay suficientes columnas antes de intentar configurarlas
            if (DGVListar.Columns.Count > 9)
            {
                DGVListar.Columns[0].Visible = false;
                DGVListar.Columns[1].Visible = true;
                DGVListar.Columns[2].Width = 100;
                DGVListar.Columns[3].Width = 100;
                DGVListar.Columns[4].Width = 100;
                DGVListar.Columns[5].Width = 100;
                DGVListar.Columns[6].Width = 100;
                DGVListar.Columns[7].Width = 100;
                DGVListar.Columns[8].Visible = false;
                DGVListar.Columns[9].Width = 100;
            }
        }

        private void MensajeOk(string mensaje)
        {
            MetroFramework.MetroMessageBox.Show(this.MdiParent, mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MetroFramework.MetroMessageBox.Show(this.MdiParent, mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string rut = TxtRut.Text;
                string dv = TxtDv.Text;
                string nombre = TxtNombre.Text;
                string apellidoPaterno = TxtApellidoP.Text;
                string apellidoMaterno = TxtApellidoM.Text;
                string correo = TxtCorreo.Text;
                string usuario = TxtUsuario.Text;
                string contrasena = TxtContrasena.Text;
                string telefono = TxtTelefono.Text;

                if (!ValidarRut(rut, dv))
                {
                    return; // Salir del método si el RUT no es válido
                }

                if (!ValidarNombre(nombre))
                {
                    return; // Salir del método si el nombre no es válido
                }

                if (!ValidarApellidoP(apellidoPaterno))
                {
                    return; // Salir del método si el apellido paterno no es válido
                }

                if (!ValidarApellidoM(apellidoMaterno))
                {
                    return; // Salir del método si el apellido materno no es válido
                }

                if (!ValidarCorreoElectronico(correo))
                {
                    return; // Salir del método si el apellido materno no es válido
                }

                if (string.IsNullOrEmpty(usuario))
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ingrese un nombre de usuario válido.", "Error de nombre de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(contrasena))
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ingrese una contraseña válida.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidarTelefono(telefono))
                {
                    return; // Salir del método si el apellido materno no es válido
                }

                // Llamar al método de negocio para agregar un funcionario
                bool resultado = NFuncionario.Insertar(int.Parse(rut), dv, nombre, apellidoPaterno, apellidoMaterno, correo, usuario, contrasena, telefono);

                // Verificar el resultado y mostrar el cuadro de mensaje correspondiente
                if (resultado)
                {
                    // Operación exitosa
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Funcionario agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Error
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Error al agregar funcionario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string rut = TxtRut.Text;
                string dv = TxtDv.Text;
                string nombre = TxtNombre.Text;
                string apellidoPaterno = TxtApellidoP.Text;
                string apellidoMaterno = TxtApellidoM.Text;
                string correo = TxtCorreo.Text;
                string usuario = TxtUsuario.Text;
                string contrasena = TxtContrasena.Text;
                string telefono = TxtTelefono.Text;

                if (!ValidarRut(rut, dv))
                {
                    return; // Salir del método si el RUT no es válido
                }

                if (!ValidarNombre(nombre))
                {
                    return; // Salir del método si el nombre no es válido
                }

                if (!ValidarApellidoP(apellidoPaterno))
                {
                    return; // Salir del método si el apellido paterno no es válido
                }

                if (!ValidarApellidoM(apellidoMaterno))
                {
                    return; // Salir del método si el apellido materno no es válido
                }

                if (!ValidarCorreoElectronico(correo))
                {
                    return; // Salir del método si el apellido materno no es válido
                }

                if (string.IsNullOrEmpty(usuario))
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ingrese un nombre de usuario válido.", "Error de nombre de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(contrasena))
                {
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ingrese una contraseña válida.", "Error de contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!ValidarTelefono(telefono))
                {
                    return; // Salir del método si el apellido materno no es válido
                }

                // Llama al método de negocio para actualizar el cliente
                bool resultado = NFuncionario.ModificarFuncionario(int.Parse(rut), dv, nombre, apellidoPaterno, apellidoMaterno, correo, usuario, contrasena, telefono);

                // Verifica el resultado y muestra un mensaje correspondiente
                if (resultado)
                {
                    // Operación exitosa
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Funcionario actualizado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Error
                    MetroFramework.MetroMessageBox.Show(this.MdiParent, "Error al actualizar funcionario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVListar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BtnModificar.Visible = true;
                BtnAgregar.Visible = false;
                TxtRut.Text = Convert.ToString(DGVListar.CurrentRow.Cells["RUT"].Value);
                TxtDv.Text = Convert.ToString(DGVListar.CurrentRow.Cells["DV"].Value);
                TxtNombre.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Nombre"].Value);
                TxtApellidoP.Text = Convert.ToString(DGVListar.CurrentRow.Cells["ApellidoPaterno"].Value);
                TxtApellidoM.Text = Convert.ToString(DGVListar.CurrentRow.Cells["ApellidoMaterno"].Value);
                TxtTelefono.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Telefono"].Value);
                TxtCorreo.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Correo"].Value);
                TxtUsuario.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Usuario"].Value);
                TxtContrasena.Text = Convert.ToString(DGVListar.CurrentRow.Cells["Contrasena"].Value);
                TabGeneral.SelectedIndex = 1;
            }
            catch (Exception)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Seleccione desde la celda nombre");
            }
        }

        private void CbSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (CbSeleccionar.Checked)
            {
                DGVListar.Columns[0].Visible = true;
                BtnEliminar.Visible = true;
            }
            else
            {
                DGVListar.Columns[0].Visible = false;
                BtnEliminar.Visible = false;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MetroFramework.MetroMessageBox.Show(this.MdiParent, "¿Desea eliminar el funcionario?", "Turismo Real", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    

                    foreach (DataGridViewRow row in DGVListar.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);

                            // Llamar al método de negocio para eliminar al administrador
                            bool resultado = NFuncionario.EliminarFuncionario(codigo);

                            if (resultado)
                            {
                                this.MensajeOk("Se eliminó el registro " + codigo);
                                CbSeleccionar.Checked = false;
                            }
                            else
                            {
                                this.MensajeError("Error al eliminar el registro " + codigo);
                            }
                        }
                    }

                    // Actualizar la lista después de la eliminación
                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void DGVListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DGVListar.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell CbEliminar = (DataGridViewCheckBoxCell)DGVListar.Rows[e.RowIndex].Cells["Seleccionar"];
                CbEliminar.Value = !Convert.ToBoolean(CbEliminar.Value);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            TabGeneral.SelectedIndex = 0;
        }

        private void SoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ignorar la tecla presionada
            }
        }

        private bool ValidarRut(string rut, string dv)
        {
            if (string.IsNullOrEmpty(rut))
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ingrese un nombre válido.", "Error de nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que el RUT tenga el formato correcto
            if (!Regex.IsMatch(rut, @"^[0-9]{1,8}$"))
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "El RUT debe contener solo números y tener como máximo 8 dígitos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que el dígito verificador sea válido
            if (!EsRutValido(rut, dv))
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "El RUT ingresado no es válido.", "Error de RUT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool EsRutValido(string rut, string dv)
        {
            try
            {
                int rutNumerico = int.Parse(rut);
                int dvCalculado = CalcularDigitoVerificador(rutNumerico);

                return dv == dvCalculado.ToString();
            }
            catch
            {
                return false;
            }
        }

        private int CalcularDigitoVerificador(int rut)
        {
            int suma = 0;
            int multiplicador = 2;

            while (rut > 0)
            {
                int digito = rut % 10;
                suma += digito * multiplicador;
                rut /= 10;
                multiplicador = (multiplicador < 7) ? multiplicador + 1 : 2;
            }

            int resto = suma % 11;
            int dvCalculado = 11 - resto;

            return (dvCalculado == 11) ? 0 : dvCalculado;
        }

        private bool ValidarNombre(string nombre)
        {
            // Validar que el nombre no esté vacío
            if (string.IsNullOrEmpty(nombre))
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ingrese un nombre válido.", "Error de nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que la primera letra sea mayúscula
            if (!char.IsUpper(nombre[0]))
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "La primera letra del nombre debe ser mayúscula.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Regex regex = new Regex(@"^[a-zA-ZñÑáéíóúÁÉÍÓÚüÜ]+$");

            if (!regex.IsMatch(nombre))
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "El nombre debe contener solo caracteres válidos", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidarApellidoP(string apPaterno)
        {
            // Validar que el nombre no esté vacío
            if (string.IsNullOrEmpty(apPaterno))
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ingrese un apellido paterno válido.", "Error de apellido paterno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que la primera letra sea mayúscula
            if (!char.IsUpper(apPaterno[0]))
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "La primera letra del apellido paterno debe ser mayúscula.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Regex regex = new Regex(@"^[a-zA-ZñÑáéíóúÁÉÍÓÚüÜ]+$");

            if (!regex.IsMatch(apPaterno))
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "El apellido paterno debe contener solo caracteres válidos", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidarApellidoM(string apMaterno)
        {
            // Validar que el nombre no esté vacío
            if (string.IsNullOrEmpty(apMaterno))
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ingrese un apellido materno válido.", "Error de apellido materno", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que la primera letra sea mayúscula
            if (!char.IsUpper(apMaterno[0]))
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "La primera letra del apellido materno debe ser mayúscula.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            Regex regex = new Regex(@"^[a-zA-ZñÑáéíóúÁÉÍÓÚüÜ]+$");

            if (!regex.IsMatch(apMaterno))
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "El apellido materno debe contener solo caracteres válidos", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidarCorreoElectronico(string correo)
        {
            if (string.IsNullOrEmpty(correo))
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ingrese un correo electrónico válido.", "Error de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(correo, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "El correo electrónico no es válido.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar la cadena con la expresión regular
            return true;
        }

        private bool ValidarTelefono(string telefono)
        {
            if (string.IsNullOrEmpty(telefono))
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "Ingrese un número telefónico válido.", "Error de número telefónico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Regex.IsMatch(telefono, @"^[0-9]{9}$"))
            {
                MetroFramework.MetroMessageBox.Show(this.MdiParent, "El número telefónico debe contener solo números y tener 9 dígitos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar la cadena con la expresión regular
            return true;
        }
    }
}

