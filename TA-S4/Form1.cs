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
using TA_S4.Presentaciones;

namespace TA_S4
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void registroDeAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroAlbum frmRegistroAlbum = new frmRegistroAlbum();
            frmRegistroAlbum.Show();
        }

        private void registroDeCanciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroCancion frm = new frmRegistroCancion();
            frm.ShowDialog();
        }

        private void listarLasCancionesDeUnÁlbumToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            frmListarCancionesDeUnAlbum frm = new frmListarCancionesDeUnAlbum();
            frm.ShowDialog();
        }

        private void obtenerElÁlbumConMásCancionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controlador objcontrolador = new Controlador();
            Album album = objcontrolador.AlbumConMasCanciones();
            MessageBox.Show("El álbum con más canciones es: " + album.NombreAlbum);
        }
    }
}
