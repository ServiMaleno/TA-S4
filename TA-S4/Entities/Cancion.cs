using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_S4.Entities
{
    public class Cancion
    {
        //Constructor
        public Cancion() { } 
        // Propiedades de los atributos
        public string CodigoCancion { get; set; }
        public string NombreCancion { get; set; }
        public float Duracion { get; set; }
    }
}
