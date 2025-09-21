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
        public static List<Album> listaAlbumes { get; set; }
        public static List<Cancion> listaCanciones { get; set; }

        //Definir el constructor (Oliver)
        public Controlador()
        {
            if(listaAlbumes == null) listaAlbumes = new List<Album>();
            if(listaCanciones == null) listaCanciones = new List<Cancion>();
        }

        //Registrar Album (Oliver)
        public void RegistrarAlbum(Album album)
        {
            listaAlbumes.Add(album);
        }

        public bool AlbumExiste(String codigoAlbum)
        {
            return listaAlbumes.Exists(delegate (Album value)
            {
                return value.codigoAlbum == codigoAlbum;
            });
        }

        public bool CancionExiste(String codigoCancion)
        {
            return listaCanciones.Exists(delegate (Cancion value)
            {
                return value.codigoCancion == codigoCancion;
            });
        }
    }
}
