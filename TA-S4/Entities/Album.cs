using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA_S4.Entities;

namespace TA_S4.Entities
{
        public class Album
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public List<Cancion> Canciones { get; private set; }
        public string CodigoAlbum { get; internal set; }

        public Album(string codigo, string nombre)
            {
                Codigo = codigo;
                Nombre = nombre;
                Canciones = new List<Cancion>();
            }

            public bool AgregarCancion(Cancion c)
            {
                // No permitir canciones repetidas dentro del mismo álbum (por código)
                if (Canciones.Any(x => x.Codigo == c.Codigo)) return false;
                Canciones.Add(c);
                return true;
            }

            public override string ToString()
            {
                return $"{Codigo} - {Nombre} ({Canciones.Count} canciones)";
            }
        }
 }