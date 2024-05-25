using Controladora;
using System.Diagnostics.Eventing.Reader;

namespace Vista
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            textBoxContraseña.Clear();
            textBoxUsuario.Clear();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "admin" && textBoxContraseña.Text == "123")
            {
                ControladoraMultas controladoraMultas = new ControladoraMultas();
                controladoraMultas.VerificarYActualizarEstadoSociosMultados();
                MostrarFormMenu(controladoraMultas);

            }
            else
            {
                MessageBox.Show("Los datos son incorrectos");

                textBoxContraseña.Clear();
                textBoxUsuario.Clear();
            }





        }
        private void MostrarFormMenu(ControladoraMultas controladoraMultas)
        {
            FormMenu formMenu = new FormMenu(controladoraMultas);
            formMenu.FormClosed += (s, args) => this.Close(); // Cierra la aplicación cuando se cierre el formulario del menú
            formMenu.Show();
            this.Hide(); // Oculta el formulario de inicio de sesión después de mostrar el menú
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
