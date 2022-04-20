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
