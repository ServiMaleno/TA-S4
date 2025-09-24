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
    public partial class frmRegistroCancion: Form
    {
        Controlador objcontrolador = new Controlador();
        public frmRegistroCancion()
        {
            InitializeComponent();
        }

        private void frmRegistroCancion_Load(object sender, EventArgs e)
        {
            // Mostrar lista de albumes
            lboxAlbumes.DisplayMember = "NombreAlbum"; // lo que mostrará
            lboxAlbumes.ValueMember = "CodigoAlbum"; // ruta de acceso
            lboxAlbumes.DataSource = Controlador.ListaAlbumes; // origen de datos
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //validacion

            if (tbCodigoCancion.Text != "" && tbNombreCancion.Text != "" && tbDuracion.Text != "")
            {
                if (!objcontrolador.CancionExiste(tbCodigoCancion.Text))
                {
                    Cancion cancion = new Cancion();
                    cancion.CodigoCancion = tbCodigoCancion.Text;
                    cancion.NombreCancion = tbNombreCancion.Text;
                    cancion.Duracion = float.Parse(tbDuracion.Text);

                    foreach (Album album in lboxAlbumes.SelectedItems)
                        objcontrolador.RegistrarCancionEnAlbum(album.CodigoAlbum, cancion);
                }
                else
                    MessageBox.Show("El código ya existe");
            }

            else
                    MessageBox.Show("Insertar todos los campos");
            //Limpiar todos los campos
            tbCodigoCancion.Clear();
            tbNombreCancion.Clear();
            tbDuracion.Clear();
            lboxAlbumes.SelectedIndex = -1; // con este -1 indica que no hay seleccion de elementos
            // Colocar le cursor
            tbCodigoCancion.Focus();

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmMostrarCanciones frm = new frmMostrarCanciones();
            frm.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
