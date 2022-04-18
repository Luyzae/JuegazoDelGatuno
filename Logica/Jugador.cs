using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDelGato.Logica
{
    public class Jugador
    {
        public Jugador(string nombre, Pinta pinta)
        {
            Nombre = nombre;
            PartidasGanadas = 0;
            Pinta = pinta;
        }
        public string Nombre { get; private set; }
        public int PartidasGanadas { get; private set; } 
        public Pinta Pinta { get; private set; }
        public void PartidaGanada()
        {
            PartidasGanadas++;
        }
    }
}
