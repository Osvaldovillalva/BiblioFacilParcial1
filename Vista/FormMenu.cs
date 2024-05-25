using Controladora;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormMenu : Form
    {
        private ControladoraMultas controladoraMultas;

        public FormMenu(ControladoraMultas controladora)
        {
            InitializeComponent();
            controladoraMultas = controladora;
            this.Load += new EventHandler(FormMenu_Load);
        }

        private void buttonLibros_Click(object sender, EventArgs e)
        {
            FormLibros formLibros = new FormLibros();

            formLibros.Show();

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            controladoraMultas.VerificarYActualizarEstadoSocios();
            controladoraMultas.VerificarYActualizarEstadoSociosMultados();
        }

        private void buttonSocios_Click(object sender, EventArgs e)
        {
            FormSocios formSocios = new FormSocios();

            formSocios.Show();
        }

        private void buttonPrestamos_Click(object sender, EventArgs e)
        {
            FormPrestamos formPrestamos = new FormPrestamos();

            formPrestamos.Show();
        }

        private void buttonReglas_Click(object sender, EventArgs e)
        {
            FormReglas formReglas = new FormReglas();

            // Mostrar el formulario
            formReglas.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormDevoluciones formDevoluciones = new FormDevoluciones();

            // Mostrar el formulario Devoluciones
            formDevoluciones.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegistros formRegistros = new FormRegistros();

            formRegistros.Show();
        }
    }
}
