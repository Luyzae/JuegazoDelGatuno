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
            // https://docs.microsoft.com/es-es/dotnet/api/system.string.trim?view=net-6.0
            if (InputNombre1.Text.Trim() != "" && InputNombre2.Text.Trim() != "") 
            {
                FormJuego formJuego = new FormJuego(InputNombre1.Text, InputNombre2.Text); 
                formJuego.Show();
                Hide();
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}