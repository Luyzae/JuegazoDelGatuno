using JuegoDelGato.Forms;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDelGato.Logica
{
    public static class Partida
    {
        public static Jugador[] Jugadores { get; private set; }
        public static Tablero Tablero { get; private set; }

        private static int numeroTurno;
        private static bool hayGanador;
        public static bool RondaTerminada { get => hayGanador || numeroTurno >= 8; }

        public static Pinta TurnoActual { get; private set; }
        public static Jugador JugadorActual { get => Jugadores[0].Pinta == TurnoActual ? Jugadores[0] : Jugadores[1]; }
        public static Pinta UltimoResultado { get; private set; }
        public static void IniciarPartida(string nombreJugador1, string nombreJugador2)
        {
            Jugadores = new []{ new Jugador(nombreJugador1, Pinta.X), new Jugador(nombreJugador2, Pinta.O) };
            IniciarRonda();
        }
        public static void IniciarRonda()
        {
            Tablero = new Tablero();
            TurnoActual = new Random().NextDouble() > 0.5 ? Pinta.X : Pinta.O;
            numeroTurno = 0;
            hayGanador = false;
        }

        public static Pinta CasilleroSeleccionado(int casillero)
        {
            Pinta resultadoRonda;
            if (casillero >= 0 && casillero < 9){}
            
            Tablero.pintas[casillero] = TurnoActual;
            if (HayTresEnRaya())
            {
                UltimoResultado = TurnoActual;
                hayGanador = true;
                resultadoRonda = TurnoActual;
                JugadorActual.PartidaGanada();
            }
            else
            {
                if (RondaTerminada)
                {
                    UltimoResultado = Pinta.Vacio;
                    hayGanador = false;
                }
                resultadoRonda = Pinta.Vacio;
            }
            TurnoActual = TurnoActual == Pinta.X ? Pinta.O : Pinta.X;
            return resultadoRonda;
        }

        private static bool HayTresEnRaya()
        {

            bool[] casilleros = new bool[9];

            for (int i = 0; i < 9; i++)
            {
                casilleros[i] = Tablero.pintas[i] == TurnoActual;
            }
            //Vamos a tener en cuenta que hay 8 posibilidades para ganar (3 filas, 3 columnas y 2 diagonales)
            //El 4 es el centro (el que está en la posición 4 de nuestro array) tiene que estar seleccionado
            //Por tanto, si el centro no está seleccionado, podemos descartar la mitad de las posibilidades

            if (!casilleros[4])
            {
                if ((casilleros[0] && casilleros[1] && casilleros[2]) || (casilleros[0] && casilleros[3] && casilleros[6]) || (casilleros[6] && casilleros[7] && casilleros[8]) || (casilleros[2] && casilleros[5] && casilleros[8]))
                {
                    return true;
                }
            }
            //Si entre las posibilidades que pasan por el centro ninguna se cumple, vamos a probar el resto
            else
            {
                if ((casilleros[0] && casilleros[8]) || (casilleros[1] && casilleros[7]) || (casilleros[2] && casilleros[6]) || (casilleros[3] && casilleros[5]))
                {
                    return true;
                }
            }
            //Si ninguna de las condiciones, no hay tres en raya
            return false;
        }
    }
}
