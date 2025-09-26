using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TA_S4.Entities
{

        public class Cancion
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }

            // Duración en minutos (double) o en segundos según preferencia; aquí usamos minutos.
            public double DuracionMinutos { get; set; }
        public string CodigoCancion { get; internal set; }

        public Cancion(string codigo, string nombre, double duracionMinutos)
            {
                Codigo = codigo;
                Nombre = nombre;
                DuracionMinutos = duracionMinutos;
            }

            public override string ToString()
            {
                return $"{Codigo} - {Nombre} ({DuracionMinutos} min)";
            }
        }

}
