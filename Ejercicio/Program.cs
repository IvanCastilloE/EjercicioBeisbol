using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();
            equipos.Add(new Equipo());
            equipos[0].Nombre = "Tigres del Norte";
            equipos[0].Entrenador = "El Babo";
            equipos[0].CiudadOrigen = "Monterrey";
            equipos[0].estadio = new Estadio("El Tomazoron Gaytan", "Mi casita ", 95000);
            equipos[0].Jugadores.Add(new Jugador("Snoop", "42"));
            equipos[0].Jugadores.Add(new Jugador("Eminem", "69"));
            equipos[0].Jugadores.Add(new Jugador("Kilo", "56"));
            equipos[0].Jugadores.Add(new Jugador("Liljay", "75"));
            equipos[0].Jugadores.Add(new Jugador("Ilo", "46"));
            equipos[0].Jugadores.Add(new Jugador("Milo", "47"));
            equipos[0].Jugadores.Add(new Jugador("Filo", "48"));
            equipos[0].Jugadores.Add(new Jugador("Marco", "85"));
            equipos[0].Jugadores.Add(new Jugador("Polo", "86"));

            equipos.Add(new Equipo());
            equipos[1].Nombre = "Los Chicos del Barrio";
            equipos[1].Entrenador = "El Jeringas";
            equipos[1].CiudadOrigen = "Cd. Obregon";
            equipos[1].estadio = new Estadio();
            equipos[1].estadio = null;
            equipos[1].Jugadores.Add(new Jugador("Miguelon", "01"));
            equipos[1].Jugadores.Add(new Jugador("Memo", "02"));
            equipos[1].Jugadores.Add(new Jugador("Cookie", "03"));
            equipos[1].Jugadores.Add(new Jugador("Guero", "04"));
            equipos[1].Jugadores.Add(new Jugador("Abiagail", "05"));
            equipos[1].Jugadores.Add(new Jugador("Abdul", "11"));
            equipos[1].Jugadores.Add(new Jugador("Elber", "86"));
            equipos[1].Jugadores.Add(new Jugador("Heman", "99"));
            equipos[1].Jugadores.Add(new Jugador("Jack", "76"));

            


            foreach (Equipo elemento in equipos)
            {
                Console.WriteLine("Equipo: " + elemento.Nombre);
                Console.WriteLine("Entrenador: " + elemento.Entrenador);
                Console.WriteLine("Ciudad de origen: " + elemento.CiudadOrigen);
                if(elemento.estadio != null)
                {
                    Console.WriteLine("Estadio: " + elemento.estadio.Nombre);
                }
                else{
                    Console.WriteLine("Estadio: N/A");
                }
                foreach(Jugador jugador in elemento.Jugadores)
                {
                    Console.WriteLine("Jugador: " + jugador.Nombre);
                    Console.WriteLine("Número: " + jugador.Número);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
