using Controladora;
using Entidades;
using Modelo;
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
    public partial class FormReglas : Form
    {

        private ControladoraReglas controladoraReglas;
        public FormReglas()
        {
            InitializeComponent();

            controladoraReglas = new ControladoraReglas();
            dgvReglas.SelectionChanged += DgvReglas_SelectionChanged;

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvReglas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormReglas_Load(object sender, EventArgs e)
        {
            CargarDatosDataGridView();
        }
        private void CargarDatosDataGridView()
        {
            // Carga las reglas desde la controladora
            var reglas = controladoraReglas.ObtenerTodasLasReglas();

            // Asigna las reglas como la fuente de datos del DataGridView
            dgvReglas.DataSource = reglas;
        }

        private void textBoxDiasPrestamo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMaximoPrestamo_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            // Verificar que los campos no estén vacíos y contengan valores numéricos
            if (!string.IsNullOrEmpty(textBoxDiasPrestamo.Text) &&
                !string.IsNullOrEmpty(textBoxMaximoPrestamo.Text) &&
                !string.IsNullOrEmpty(textBoxDiasMulta.Text) && // Nuevo campo de días de multa
                int.TryParse(textBoxDiasPrestamo.Text, out int dias) &&
                int.TryParse(textBoxMaximoPrestamo.Text, out int maximo) &&
                int.TryParse(textBoxDiasMulta.Text, out int diasMulta)) // Nuevo campo de días de multa
            {
                // Confirmar la modificación con un cuadro de diálogo
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas realizar los cambios?",
                                                       "Confirmar cambios", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Obtener los nuevos valores de días de préstamo, máximo de libros por usuario y días de multa
                    int nuevosDiasPrestamo = int.Parse(textBoxDiasPrestamo.Text);
                    int nuevoMaximoPrestamo = int.Parse(textBoxMaximoPrestamo.Text);
                    int nuevosDiasMulta = int.Parse(textBoxDiasMulta.Text); // Nuevo campo de días de multa

                    // Llamar al método de la controladora de reglas para modificar las reglas
                    controladoraReglas.ModificarReglas(nuevosDiasPrestamo, nuevoMaximoPrestamo, nuevosDiasMulta);

                    // Mostrar un mensaje de éxito

                }
            }
            else
            {
                // Mostrar un mensaje de error si los campos están vacíos o no contienen valores numéricos
                MessageBox.Show("Por favor, ingresa valores numéricos válidos en los campos de días de préstamo, máximo de libros por usuario y días de multa.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CargarDatosDataGridView();
        }

        private void DgvReglas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReglas.SelectedRows.Count > 0)
            {
                // Obtiene la primera fila seleccionada
                DataGridViewRow filaSeleccionada = dgvReglas.SelectedRows[0];

                // Obtiene los valores de las celdas correspondientes a las columnas DiasPrestamo y MaxLibrosPorUsuario
                object valorDiasPrestamo = filaSeleccionada.Cells["DiasPrestamo"].Value;
                object valorMaximoPrestamo = filaSeleccionada.Cells["MaxLibrosPorUsuario"].Value;

                object valorDiasMulta = filaSeleccionada.Cells["DiasMulta"].Value;

                // Asigna los valores obtenidos a los TextBox correspondientes
                textBoxDiasPrestamo.Text = valorDiasPrestamo?.ToString();
                textBoxMaximoPrestamo.Text = valorMaximoPrestamo?.ToString();
                textBoxDiasMulta.Text= valorDiasMulta?.ToString();
            }
            else
            {
                // Si no hay filas seleccionadas, limpia los TextBox
                textBoxDiasPrestamo.Clear();
                textBoxMaximoPrestamo.Clear();
                textBoxDiasMulta.Clear();
            }
        }

        private void textBoxDiasMulta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
