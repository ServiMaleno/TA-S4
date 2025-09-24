using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_S4.Entities
{
    public class Album
    {
        // Propiedades automáticas  de atributos
        public string CodigoAlbum { get; set; }
        public string NombreAlbum { get; set; }

        public List<Cancion> Canciones { get; set; }

        // definimos el constructor y creamos la lista de heroes
        public Album() { Canciones = new List<Cancion>(); }
    }
}
