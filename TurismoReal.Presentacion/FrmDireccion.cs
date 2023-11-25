using GMap.NET.MapProviders;
using GMap.NET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using MetroFramework;

namespace TurismoReal.Presentacion
{
    public partial class FrmDireccion : MetroFramework.Forms.MetroForm
    {
        public FrmDireccion()
        {
            InitializeComponent();
        }

        public FrmDireccion(string direccion, string latitud, string longitud) : this()
        {
            txtDireccion.Text = direccion;
            txtLatitud.Text = latitud;
            txtLongitud.Text = longitud;
        }

        private void FrmDireccion_Load(object sender, EventArgs e)
        {
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.MapProvider = GMapProviders.OpenStreetMap;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapControl1.ShowCenter = false;
            if (!string.IsNullOrEmpty(txtLatitud.Text) && !string.IsNullOrEmpty(txtLongitud.Text))
            {
                // Si hay valores en txtLatitud y txtLongitud, usarlos para establecer la posición
                double latitud = Convert.ToDouble(txtLatitud.Text);
                double longitud = Convert.ToDouble(txtLongitud.Text);
                gMapControl1.Position = new PointLatLng(latitud, longitud);

                gMapControl1.Zoom = 17;

                GMapMarker marker = new GMarkerGoogle(gMapControl1.Position, GMarkerGoogleType.green);
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                markersOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(markersOverlay);
            }
            else
            {
                // Si no hay valores en txtLatitud y txtLongitud, usar la posición por defecto
                gMapControl1.Position = new PointLatLng(-33.4489, -70.6693);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string direccion = txtDireccion.Text;

            GeoCoderStatusCode status = gMapControl1.SetPositionByKeywords(direccion);
            if (status == GeoCoderStatusCode.OK)
            {
                gMapControl1.Overlays.Clear();

                gMapControl1.Zoom = 17;

                GMapMarker marker = new GMarkerGoogle(gMapControl1.Position, GMarkerGoogleType.green);
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                markersOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(markersOverlay);

                txtLatitud.Text = gMapControl1.Position.Lat.ToString();
                txtLongitud.Text = gMapControl1.Position.Lng.ToString();
            }
            else
            {
                MessageBox.Show("No se pudo encontrar la ubicación para la dirección proporcionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (status != GeoCoderStatusCode.OK)
            {
                MetroMessageBox.Show(this, "Geocoder no pudo encontrar la dirección: '" + txtDireccion.Text + "', razón: " + status.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            FrmDepartamento frmDepa = Application.OpenForms.OfType<FrmDepartamento>().FirstOrDefault();

            if (frmDepa != null)
            {
                if ((txtDireccion.Text.Length > 0) && (txtLatitud.Text.Length > 0) && (txtLongitud.Text.Length > 0))
                {
                    frmDepa.AgregarDireLatLong(txtDireccion.Text, txtLatitud.Text, txtLongitud.Text);
                    this.Close();
                }
                else
                {
                    MetroMessageBox.Show(this.MdiParent, "No ha escrito ninguna dirección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
