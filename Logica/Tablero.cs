using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDelGato.Logica
{
    public class Tablero
    {
        public Tablero()
        {
            pintas = new[]
            {
                Pinta.Vacio,
                Pinta.Vacio,
                Pinta.Vacio,
                Pinta.Vacio,
                Pinta.Vacio,
                Pinta.Vacio,
                Pinta.Vacio,
                Pinta.Vacio,
                Pinta.Vacio,
            };
        }
        public Pinta[] pintas { get; private set; }
    }
}
