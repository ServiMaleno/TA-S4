using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA_S4.Controllers;
using TA_S4.Entities;

namespace TA_S4.Presentaciones
{
    public partial class frmListarCancionesDeUnAlbum: Form
    {
        public frmListarCancionesDeUnAlbum()
        {
            InitializeComponent();
        }

        private void ListarCancionesDeUnAlbum_Load(object sender, EventArgs e)
        {
            // Mostrar lsita de albumes
            lboxAlbumes.DisplayMember = "NombreAlbum"; //se muestra
            lboxAlbumes.ValueMember = "CodigoAlbum";// ruta de acceso
            lboxAlbumes.DataSource = Controlador.ListaAlbumes;
        }

        private void lboxAlbumes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Album album = (Album)lboxAlbumes.SelectedItem;
            lboxAlbumes.DisplayMember = "NombreAlbum"; // Lo que muestra
            lboxAlbumes.ValueMember = "CodigoAlbum"; // ruta de acceso
            lboxCanciones.DataSource = album.Canciones;// origen de datos
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
