using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDelGato.Logica
{
    //Esta clase almacena la información del jugador (Nombre y partidas ganadas)
    //Se utiliza únicamente en la clase Partida.cs 
    public class Jugador
    {
        //Constructor de la clase tomando como argumento el nombre del jugador
        public Jugador(string nombre, Simbolo simbolo)
        {
            Nombre = nombre;
            PartidasGanadas = 0;
            Simbolo = simbolo;
        }
        public string Nombre { get; private set; }
        //La unica razon para editar esta propiedad sera cuando el jugador gane una partida
        // Por eso la hacemos privada ya que la modificaremos desde el método PartidaGanada()
        public int PartidasGanadas { get; private set; } 
        public Simbolo Simbolo { get; private set; }

        public void PartidaGanada()
        {
            PartidasGanadas++;
        }
    }
}
