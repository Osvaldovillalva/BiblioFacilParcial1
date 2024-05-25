using Controladora;
using Entidades;
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
    public partial class FormRegistros : Form
    {
        private ControladoraDevoluciones controladoraDevoluciones;
        private ControladoraMultas controladoraMultas;
        public FormRegistros()
        {
            InitializeComponent();
            controladoraDevoluciones =new ControladoraDevoluciones();
            controladoraMultas = new ControladoraMultas();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRegistros_Load(object sender, EventArgs e)
        {
            CargarDatosDataGridView();
        }


        private void CargarDatosDataGridView()
        {
            // Obtener los datos de la tabla Devoluciones
            List<Devolucion> devoluciones = controladoraDevoluciones.ObtenerTodasLasDevoluciones();

            // Asignar el DataSource del DataGridView al listado de devoluciones
            dgvDevoluciones.DataSource = devoluciones;

            // Ocultar las columnas de IdPrestamo si no es necesario mostrarlo


            List<Multa> multas = controladoraMultas.ObtenerTodasLasMultas();
            dgvMultas.DataSource = multas;

        }





    }
}
