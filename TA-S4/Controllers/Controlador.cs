using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA_S4.Entities;
namespace TA_S4.Controllers
{
    public class Controlador
    {
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
       
        public void RegistrarCancionEnAlbum(String codigoAlbum, Cancion cancion)
        {
            Album albumEncontrado = ListaAlbumes.Find(delegate (Album value)
            {
                return value.CodigoAlbum == codigoAlbum;
            });

            if (albumEncontrado != null)
            {
                albumEncontrado.Canciones.Add(cancion);
            }
            if (ListaCanciones.Exists(delegate (Cancion value)
            {
                return value.CodigoCancion == cancion.CodigoCancion;
                // SI existe el codigo de cancion se retorna la cancion, pero al negar seria Falso, entonces sale del IF sin hacer nada
                // Si no existe el codigo de cancion retorna falso, pero con la negacion seria VERDADERO, entonces ingresa al IF
            }))
            {
                ListaCanciones.Add(cancion);
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


    }    
}
