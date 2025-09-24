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
    public partial class frmRegistroAlbum : Form
    {
        Controlador objcontrolador = new Controlador();
        public frmRegistroAlbum()
        {
            InitializeComponent();
        }

        private void btnRegistrarAlbum_Click(object sender, EventArgs e)
        {
            //Validar campos vacios (Oliver)
            if(tbCodigoAlbum.Text != "" && tbNombreAlbum.Text != "")
            {
                if (!objcontrolador.AlbumExiste(tbCodigoAlbum.Text))
                {
                    //Ingresa si no existe el album (Oliver)
                    Album album = new Album() 
                    { 
                        CodigoAlbum = tbCodigoAlbum.Text,
                        NombreAlbum = tbNombreAlbum.Text,
                    };

                    //Registrar el album (Oliver)
                    MessageBox.Show("Album registrado con éxito", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    objcontrolador.RegistrarAlbum(album);
                }
                //Si ya existe el album (Oliver)
                else
                {
                    MessageBox.Show("El código ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            //Si algún campo está vacío (Oliver)
            else
            {
                MessageBox.Show("Debe completar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            // Limpiar los campos
            tbCodigoAlbum.Clear();
            tbNombreAlbum.Clear();
            tbCodigoAlbum.Focus();
        }

        private void btnMostrarAlbum_Click(object sender, EventArgs e)
        {
            frmMostrarAlbumes frmMostrarAlbumes = new frmMostrarAlbumes();
            frmMostrarAlbumes.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
