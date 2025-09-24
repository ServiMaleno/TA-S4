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
    public partial class frmMostrarCanciones: Form
    {
        public frmMostrarCanciones()
        {
            InitializeComponent();
        }

        private void frmMostrarCanciones_Load(object sender, EventArgs e)
        {
            lboxCanciones.DisplayMember = "NombreCancion"; // Lo que va a mostrar
            lboxCanciones.ValueMember = "CodigoCancion"; // Ruta de acceso
            lboxCanciones.DataSource = Controlador.ListaCanciones; // origen de datos
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
