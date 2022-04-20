using JuegoDelGato.Forms;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDelGato.Logica
{
    //Esta clase administrará todo lo relacionado con el juego
    //Es estática porque solo habrá una partida, y por tanto no tendremos que crear instancias
    public static class Partida
    {
        //Aquí almacenamos las dos instancias de la clase Jugador.
        public static Jugador[] Jugadores { get; private set; }
        public static Tablero Tablero { get; private set; }

        //Estos tres elementos están relacionados con la información sobre el final de la ronda.
        private static int numeroTurno;
        private static bool hayGanador;
        public static bool RondaTerminada { get => hayGanador || numeroTurno >= 8; } //Si hay ganador o estamos en la ronda 8 la partida ha terminado

        public static Simbolo TurnoActual { get; private set; }
        //Para obtener el jugador actual tomamos como referencia el turno actual
        public static Jugador JugadorActual { get => Jugadores[0].Pinta == TurnoActual ? Jugadores[0] : Jugadores[1]; }
        public static Simbolo UltimoResultado { get; private set; }
        public static void IniciarPartida(string nombreJugador1, string nombreJugador2)
        {
            Jugadores = new[] { new Jugador(nombreJugador1, Simbolo.X), new Jugador(nombreJugador2, Simbolo.O) };
            IniciarRonda();
        }
        public static void IniciarRonda()
        {
            //Reiniciamos el tablero
            Tablero = new Tablero();
            //Obtenemos un simbolo aleatoria
            TurnoActual = new Random().NextDouble() > 0.5 ? Simbolo.X : Simbolo.O;
            //Reiniciamos las variables que sirven para saber cuándo termina la ronda
            numeroTurno = -1;
            hayGanador = false;
        }

        //En este método primero se chequea si hay tres en raya y después se cambia el turno. 
        public static Simbolo CasilleroSeleccionado(int casillero)
        {
            numeroTurno++;
            //El método devuelve esta variable
            Simbolo resultadoRonda;
            //Primero nos aseguramos de que el numero del casillero sea válido
            if (!(casillero >= 0 && casillero < 9)){}

            Tablero.simbolo[casillero] = TurnoActual;

            if (HayTresEnRaya())
            {
                //Si hay tres en raya guardamos el simbolo de ese turno como ganador
                UltimoResultado = TurnoActual;
                hayGanador = true;
                resultadoRonda = TurnoActual;
                JugadorActual.PartidaGanada();
            }
            //Si no hay tres en raya
            else
            {
                //Si la ronda ha terminado y no hay ganador (tres en raya), damos la ronda por empatada 
                if (RondaTerminada)
                {
                    UltimoResultado = Simbolo.Ninguna;
                }
                //Como no hay ganador devolvemos Pinta.Ninguna
                resultadoRonda = Simbolo.Ninguna;
            }
            TurnoActual = TurnoActual == Simbolo.X ? Simbolo.O : Simbolo.X;
            return resultadoRonda;
        }

        private static bool HayTresEnRaya()
        {
            //Para saber si hay tres en raya haremos lo siguiente:
            //Reducir las posibilidades de ganar del ultimo simbolo que fue puesto, ya que no hay otra forma de ganar

            bool[] casilleros = new bool[9];

            for (int i = 0; i < 9; i++)
            {
                casilleros[i] = Tablero.simbolo[i] == TurnoActual;
            }

            //Hay 8 posibilidades para ganar (3 filas, 3 columnas y 2 diagonales)
            //El centro (el que está en la posición 4 de nuestro array) tiene que estar seleccionado
            //Por tanto, si el centro no está seleccionado, podemos descartar la mitad de las posibilidades, ya que en la posicion 4 es donde van a estar Más tres en raya
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
            //Si ninguna de las condiciones se ha cumplido, podemos estar seguros de que no hay tres en raya
            return false;
        }
    }
}
