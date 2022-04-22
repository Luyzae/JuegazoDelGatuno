using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDelGato.Logica
{
    // Aqui se almacena la informacion del tablero
    public class Tablero
    {
        public Tablero()
        {
            simbolo = new[]
            {
                Simbolo.Ninguna,
                Simbolo.Ninguna,
                Simbolo.Ninguna,
                Simbolo.Ninguna,
                Simbolo.Ninguna,
                Simbolo.Ninguna,
                Simbolo.Ninguna,
                Simbolo.Ninguna,
                Simbolo.Ninguna,
            };
        }
        public Simbolo[] simbolo { get; private set; }
    }
}
