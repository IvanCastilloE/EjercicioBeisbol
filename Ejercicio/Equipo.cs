using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string CiudadOrigen { get; set; }
        public string Entrenador {get; set;}
        public List<Jugador> Jugadores { get; set; }
        public Equipo()
        {
            Nombre = "Nuevo Equipo";
            CiudadOrigen = "Ciudad";
            Entrenador = "Nuevo Entrenador";
            Jugadores = new List<Jugador>();

        }
    }
}
