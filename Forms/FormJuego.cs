using JuegoDelGato.Logica;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDelGato.Forms
{
    public partial class FormJuego : Form
    {
        public FormJuego(string nombre1, string nombre2)
        {
            InitializeComponent();
            casilleros = new Button[]
            {
                Casillero1,
                Casillero2,
                Casillero3,
                Casillero4,
                Casillero5,
                Casillero6,
                Casillero7,
                Casillero8,
                Casillero9,
            };
            Partida.IniciarPartida(nombre1, nombre2);
            LabelResultado.Hide();
            ActualizarTurno();
        }
        void Reiniciar()
        {
            Partida.IniciarRonda();
            foreach (var casillero in casilleros)
            {
                casillero.Text = "-";
                casillero.Enabled = true;
            }
            LabelResultado.Hide();
            ActualizarTurno();
        }

        Button[] casilleros;
        void ActualizarTurno()
        {
            LabelTurno.Text = $"Turno de {Partida.JugadorActual.Nombre}";
        }

        void ActualizarCasillero(int casillero)
        {
            Pinta nuevaPintaCasillero = Partida.Tablero.pintas[casillero];
            string texto;
            if (nuevaPintaCasillero == Pinta.O)
            {
                texto = "O";
            }
            else if (nuevaPintaCasillero == Pinta.X)
            {
                texto = "X";
            }
            else
            {
                texto = "-";
            }
            casilleros[casillero].Text = texto;
            casilleros[casillero].Enabled = false;
        }

        void ActualizarEstadisticasJugadores(bool reinicio = false)
        {
            Jugador jugador1 = Partida.Jugadores[0];
            Jugador jugador2 = Partida.Jugadores[1];
            string textoEstadisticas = "{0} = {1} ({2} ganadas)";
            LabelJugador1.Text = string.Format(textoEstadisticas, jugador1.Nombre, jugador1.Pinta,  reinicio ? 0 : jugador1.PartidasGanadas);
            LabelJugador2.Text = string.Format(textoEstadisticas, jugador2.Nombre, jugador2.Pinta, reinicio ? 0 : jugador2.PartidasGanadas);
        }

        void ActualizarResultado()
        {
            LabelResultado.Text = Partida.UltimoResultado ==  ? "Empate"  : $"Gana {Partida.JugadorActual.Nombre}";
        }

        private void ClickEnCasillero(int numeroCasillero)
        {
            Partida.CasilleroSeleccionado(numeroCasillero);
            ActualizarCasillero(numeroCasillero);
            if (Partida.RondaTerminada)
            {
                LabelResultado.Show();
                foreach (var casillero in casilleros)
                {
                    casillero.Enabled = false;
                }
                ActualizarResultado();
                ActualizarEstadisticasJugadores();
            }
            ActualizarTurno();
        }
        private void Casillero1_Click(object sender, EventArgs e)
        {
            ClickEnCasillero(0);
        }

        private void Casillero2_Click(object sender, EventArgs e)
        {
            ClickEnCasillero(1);
        }

        private void Casillero3_Click(object sender, EventArgs e)
        {
            ClickEnCasillero(2);
        }

        private void Casillero4_Click(object sender, EventArgs e)
        {
            ClickEnCasillero(3);
        }

        private void Casillero5_Click(object sender, EventArgs e)
        {
            ClickEnCasillero(4);
        }

        private void Casillero6_Click(object sender, EventArgs e)
        {
            ClickEnCasillero(5);
        }

        private void Casillero7_Click(object sender, EventArgs e)
        {
            ClickEnCasillero(6);
        }

        private void Casillero8_Click(object sender, EventArgs e)
        {
            ClickEnCasillero(7);
        }

        private void Casillero9_Click(object sender, EventArgs e)
        {
            ClickEnCasillero(8);
        }

        private void BotonNuevoJuego_Click(object sender, EventArgs e)
        {
            Partida.IniciarRonda();
            Reiniciar();
        }

        private void BotonReiniciarContador_Click(object sender, EventArgs e)
        {
            ActualizarEstadisticasJugadores(true);
        }

        private void FormJuego_Load(object sender, EventArgs e)
        {

        }
    }
}
