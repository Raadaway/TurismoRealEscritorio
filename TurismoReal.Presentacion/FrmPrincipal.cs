using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoReal.Presentacion
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        private int childFormNumber = 0;
        private String TipoUsuario;
        private int Rut;

        public FrmPrincipal(string tipoUsuario, int rut)
        {
            InitializeComponent();
            TipoUsuario = tipoUsuario;
            Rut = rut;

            if (tipoUsuario == "funcionario")
            {
                metroTile1.Visible = false;
                metroTile2.Visible = false;
                metroTile4.Visible = false;
            }
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void administradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdministrador frm = new FrmAdministrador();
            frm.MdiParent = this;
            frm.Show();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario frm = new FrmFuncionario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartamento frm = new FrmDepartamento();
            frm.MdiParent = this;
            frm.Show();
        }


        private void reservaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TipoUsuario == "funcionario")
            {
                FrmReservas frm = new FrmReservas(Rut);
                frm.MdiParent = this;
                frm.Show();
            }
            else
            {
                FrmReservas frm = new FrmReservas();
                frm.MdiParent = this;
                frm.Show();
            }
            
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCheckIn frm = new FrmCheckIn();
            frm.MdiParent = this;
            frm.Show();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCheckOut frm = new FrmCheckOut();
            frm.MdiParent = this;
            frm.Show();
        }

        private void transporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransporte frm = new FrmTransporte();
            frm.MdiParent = this;
            frm.Show();
        }

        private void tourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTour frm = new FrmTour();
            frm.MdiParent = this;
            frm.Show();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArticulo frm = new FrmArticulo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Abre el formulario de inicio de sesión (FrmLogin)
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmServicio frm = new FrmServicio();
            frm.MdiParent = this;
            frm.Show();
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInventario frm = new FrmInventario();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimiento frm = new FrmMantenimiento();
            frm.MdiParent = this;
            frm.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(metroTile1, 0, metroTile1.Height);
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            metroContextMenu2.Show(metroTile2, 0, metroTile2.Height);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            metroContextMenu3.Show(metroTile3, 0, metroTile3.Height);
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            metroContextMenu4.Show(metroTile4, 0, metroTile4.Height);
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            FrmReportes frm = new FrmReportes();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
