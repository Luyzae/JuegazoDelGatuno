using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDelGato.Logica
{
    public class Jugador
    {
        //Esta clase almacena la información del jugador (Nombre y partidas ganadas)
        //Se utiliza únicamente en la clase Partida.cs 

        //Constructor de la clase tomando como argumento el nombre del jugador
        public Jugador(string nombre, Simbolo pinta)
        {
            Nombre = nombre;
            PartidasGanadas = 0;
            Pinta = pinta;
        }

        //La hacemos privada ya que la modificaremos desde el método PartidaGanada()
        public string Nombre { get; private set; }
        public int PartidasGanadas { get; private set; } 
        public Simbolo Pinta { get; private set; }
        public object? Simbolo { get; internal set; }

        public void PartidaGanada()
        {
            PartidasGanadas++;
        }
    }
}
