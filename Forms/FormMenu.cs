using JuegoDelGato.Forms; 

namespace JuegoDelGato
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        private void BotonJugar_Click(object sender, EventArgs e)
        {
            // El juego solo empezara si los casilleros de nombres tienen algo introduccido, para eso usamos "Trim()"
            // https://docs.microsoft.com/es-es/dotnet/api/system.string.trim?view=net-6.0
            if (Nombre1.Text.Trim() != "" && Nombre2.Text.Trim() != "") 
            {
                FormJuego formJuego = new FormJuego(Nombre1.Text, Nombre2.Text);
                formJuego.ActualizarEstadisticasJugadores();
                formJuego.Show();
                Hide();
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}