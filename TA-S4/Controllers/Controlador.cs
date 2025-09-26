using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TA_S4.Entities;
namespace TA_S4.Controllers
{
    public class Controlador
    {
        private object txtAlbumCodigo;
        private object txtAlbumNombre;
        private object albums;

        //Definir lista de albumes y lista de canciones (Oliver)
        public static List<Album> ListaAlbumes { get; set; }
        public static List<Cancion> ListaCanciones { get; set; }

        //Definir el constructor (Oliver)
        public Controlador()
        {
            if (ListaAlbumes == null) ListaAlbumes = new List<Album>();
            if (ListaCanciones == null) ListaCanciones = new List<Cancion>();
        }

        //Registrar Album (Oliver)
        public void RegistrarAlbum(Album album)
        {
            ListaAlbumes.Add(album);
        }

        public bool AlbumExiste(String codigoAlbum)
        {
            return ListaAlbumes.Exists(delegate (Album value)
            {
                return value.CodigoAlbum == codigoAlbum;
            });
        }

        public bool CancionExiste(String codigoCancion)
        {
            return ListaCanciones.Exists(delegate (Cancion value)
            {
                return value.CodigoCancion == codigoCancion;
            });
        }

        private void btnAgregarAlbum_Click(object sender, EventArgs e)
        {
            btnAgregarAlbum_Click(sender, e, albums);
        }

        private void btnAgregarAlbum_Click(object sender, EventArgs e, object albums)
        {
            string codigo = txtAlbumCodigo.Text.Trim();
            string nombre = txtAlbumNombre.Text.Trim();

            if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese código y nombre del álbum.");
                return;
            }

            if (albums.Any(a => a.Codigo == codigo))
            {
                MessageBox.Show("Ya existe un álbum con ese código.");
                return;
            }

            Album aNuevo = new Album(codigo, nombre);
            object nuevoAlbum = albums.Add(aNuevo);
            ActualizarListaAlbums();
            MessageBox.Show("Álbum agregado correctamente.");
            object value = txtAlbumCodigo.Clear();
            txtAlbumNombre.Clear();
        }

        private void btnMostrarAlbums_Click(object sender, EventArgs e)
        {
            lbAlbums.Items.Clear();
            foreach (var a in albums)
            {
                lbAlbums.Items.Add(a.ToString());
            }
        }

        private void btnAgregarCancion_Click(object sender, EventArgs e)
        {
            if (cmbAlbumSeleccionado.Items.Count == 0)
            {
                MessageBox.Show("No hay álbumes para seleccionar. Primero registre un álbum.");
                return;
            }

            string albumSeleccionado = cmbAlbumSeleccionado.SelectedItem as string;
            if (string.IsNullOrEmpty(albumSeleccionado))
            {
                MessageBox.Show("Seleccione un álbum.");
                return;
            }

            string codigoCancion = txtCancionCodigo.Text.Trim();
            string nombreCancion = txtCancionNombre.Text.Trim();
            string duracionTxt = txtCancionDuracion.Text.Trim();

            if (string.IsNullOrEmpty(codigoCancion) || string.IsNullOrEmpty(nombreCancion) || string.IsNullOrEmpty(duracionTxt))
            {
                MessageBox.Show("Complete los datos de la canción.");
                return;
            }

            if (!double.TryParse(duracionTxt, out double duracion))
            {
                MessageBox.Show("Duración inválida. Ingrese número (minutos). Ej: 3.5");
                return;
            }

            // obtener album por codigo (en cmb almacenamos "codigo - nombre")
            string codigoAlbum = albumSeleccionado.Split('-')[0].Trim();
            Album album = albums.FirstOrDefault(a => a.Codigo == codigoAlbum);
            if (album == null)
            {
                MessageBox.Show("Álbum no encontrado.");
                return;
            }

            Cancion c = new Cancion(codigoCancion, nombreCancion, duracion);
            bool agregado = album.AgregarCancion(c);
            if (!agregado)
            {
                MessageBox.Show("La canción ya existe en este álbum (mismo código).");
                return;
            }

            MessageBox.Show("Canción agregada al álbum.");
            txtCancionCodigo.Clear();
            txtCancionNombre.Clear();
            txtCancionDuracion.Clear();
            ActualizarListaAlbums();
            ActualizarTodasLasCancionesListBox();
        }

        private void btnMostrarTodasCanciones_Click(object sender, EventArgs e)
        {
            lbCanciones.Items.Clear();
            var todas = ObtenerTodasLasCanciones();
            foreach (var c in todas)
            {
                lbCanciones.Items.Add(c.ToString());
            }
        }

        private void btnListarCancionesAlbum_Click(object sender, EventArgs e)
        {
            if (lbAlbums.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un álbum de la lista de álbumes.");
                return;
            }

            // Formato en lbAlbums: "codigo - nombre (n canciones)"
            string seleccionado = lbAlbums.SelectedItem.ToString();
            string codigo = seleccionado.Split('-')[0].Trim();
            Album album = albums.FirstOrDefault(a => a.Codigo == codigo);
            if (album == null)
            {
                MessageBox.Show("Álbum no encontrado.");
                return;
            }

            if (album.Canciones.Count == 0)
            {
                MessageBox.Show("El álbum no tiene canciones registradas.");
                return;
            }

            lbCanciones.Items.Clear();
            foreach (var c in album.Canciones)
            {
                lbCanciones.Items.Add(c.ToString());
            }
        }

        // Listar canciones del album (Darwin)
        public List<Cancion> ListarCancionesDeAlbum(String codigoAlbum)
        {
            Album albumEncontrado = ListaAlbumes.Find(delegate (Album value)
            {
                return value.Codigo == codigoAlbum;
            });
            if (albumEncontrado != null) return albumEncontrado.Canciones;
            else return null;

        }
        // Obtener album con más canciones (Darwin)
        public Album AlbumConMasCanciones()
        {
            Album temp = new Album();
            foreach (Album album in ListaAlbumes)
            {
                if (album.Canciones.Count > temp.Canciones.Count) temp = album;
            }
            return temp;
        }
        //Obtener cancion con mayor duracion (Franco)
        public Cancion CancionConMayorDuracion()
        {
            Cancion temp = new Cancion();
            temp.DuracionMinutos = -1;
            foreach (Album album in ListaAlbumes)
            {
                foreach (Cancion cancion in album.Canciones)
                {
                    if (cancion.DuracionMinutos > temp.DuracionMinutos) temp = cancion;
                }
            }
            return temp;
        }

        //Obtener cancion con menor duracion (Franco)
        public Cancion CancionConMenorDuracion()
        {
            Cancion temp = new Cancion();
            temp.DuracionMinutos = 101;
            foreach (Album album in ListaAlbumes)
            {
                foreach (Cancion cancion in album.Canciones)
                {
                    if (cancion.DuracionMinutos < temp.DuracionMinutos) temp = cancion;
                }
            }
            return temp;
        }


    }
}
