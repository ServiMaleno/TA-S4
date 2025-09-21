using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_S4.Entities
{
    public class Album
    {
        public string codigoAlbum { get; set; }
        public string nombreAlbum { get; set; }

        public List<Cancion> canciones { get; set; }

        public Album() { canciones = new List<Cancion>(); }
    }
}
