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

namespace TA_S4.Presentaciones
{
    public partial class frmMostrarAlbumes : Form
    {
        public frmMostrarAlbumes()
        {
            InitializeComponent();
        }

        private void frmMostrarAlbumes_Load(object sender, EventArgs e)
        {
            lboxAlbumes.DisplayMember = "nombreAlbum"; //Mostrar el nombre del album
            lboxAlbumes.ValueMember = "codigoAlbum"; //Valor del album
            lboxAlbumes.DataSource = Controlador.listaAlbumes; //Lista de albumes
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
