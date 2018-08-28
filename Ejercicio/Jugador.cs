using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Jugador
    {
        public string Nombre;
        public string Número;
        public Jugador()
        {
            Nombre = "Nuevo Jugador";
            Número = "(00)";
        }
        public Jugador(string nombre, string número)
        {
            Nombre = nombre;
            Número = número;
        }
    }
}
