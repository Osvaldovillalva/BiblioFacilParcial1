using Controladora;
using Entidades;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Vista
{
    public partial class FormDevoluciones : Form
    {
        private ControladoraPrestamos controladoraPrestamos;

        private ControladoraLibros controladoraLibros;
        private ControladoraReglas controladoraReglas;  
        private ControladoraSocios controladoraSocios;
        private ControladoraMultas controladoraMultas;

        public FormDevoluciones()
        {
            InitializeComponent();
            controladoraPrestamos = new ControladoraPrestamos();

            controladoraLibros = new ControladoraLibros();
            controladoraSocios = new ControladoraSocios();
            controladoraReglas = new ControladoraReglas();
            controladoraMultas = new ControladoraMultas();// Inicializar la variable miembro correctamente
        }


        private void FormDevoluciones_Load(object sender, EventArgs e)
        {


            CargarDatosDataGridView();
        }





        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarDatosDataGridView()
        {
            // Obtener los datos de la tabla Prestamos
            List<Prestamo> prestamos = controladoraPrestamos.ObtenerTodosLosPrestamos();

            // Asignar el DataSource del DataGridView al listado de préstamos
            dgvPrestamos.DataSource = prestamos;

            // Ocultar las columnas de IdSocio y IdLibro
            dgvPrestamos.Columns["Libro"].Visible = false;
            dgvPrestamos.Columns["Socio"].Visible = false;
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = textBoxBuscar.Text.Trim();

            if (!string.IsNullOrWhiteSpace(textoBusqueda))
            {
                // Realizar la búsqueda en la base de datos
                List<Prestamo> resultadosBusqueda = controladoraPrestamos.BuscarPrestamos(textoBusqueda);

                // Asignar el DataSource del DataGridView a los resultados de la búsqueda
                dgvPrestamos.DataSource = resultadosBusqueda;
            }
            else
            {
                // Si el texto de búsqueda está vacío, cargar todos los préstamos en el DataGridView
                CargarDatosDataGridView();
            }

            // Ocultar las columnas de IdSocio y IdLibro
            dgvPrestamos.Columns["LibroId"].Visible = false;
            dgvPrestamos.Columns["SocioId"].Visible = false;
        }

        private void buttonGenerarDevolucion_Click(object sender, EventArgs e)
        {
            if (dgvPrestamos.SelectedRows.Count > 0)
            {
                int prestamoId = Convert.ToInt32(dgvPrestamos.SelectedRows[0].Cells["PrestamoId"].Value);
                Prestamo prestamo = controladoraPrestamos.ObtenerPrestamoPorId(prestamoId);

                // Verificar si el préstamo ya ha sido devuelto
                if (!prestamo.EnPrestamo)
                {
                    MessageBox.Show("El préstamo ya ha sido devuelto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Confirmar con el usuario si desea realizar la devolución
                DialogResult result = MessageBox.Show("¿Está seguro de realizar la devolución?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return; // Salir del método si el usuario elige "No"
                }

                // Cambiar el estado del préstamo
                controladoraPrestamos.CambiarEstadoPrestamo(prestamoId);

                // Obtener el ID del libro asociado al préstamo
                int libroId = controladoraPrestamos.ObtenerIdLibroDePrestamo(prestamoId);

                // Cambiar el estado de disponibilidad del libro
                controladoraLibros.CambiarEstadoDisponibilidadLibro(libroId);

                // Decrementar la cantidad de libros prestados del socio
                controladoraPrestamos.DecrementarCantidadLibrosPrestados(prestamoId);

                // Calcular la fecha de devolución
                DateTime fechaDevolucion = DateTime.Now;
                if (prestamo.FechaDevolucion < fechaDevolucion)
                {
                    // Si la devolución es tardía, generar una multa
                    Multa multa = new Multa
                    {
                        SocioId = prestamo.SocioId,
                        FechaInicio = prestamo.FechaDevolucion,
                        FechaFinalizacion = controladoraReglas.CalcularFechaMultaFinalizacion(controladoraReglas.ObtenerDiasMulta()),
                        Pagada = false // La multa se marca como no pagada inicialmente
                    };

                    // Guardar la multa en la base de datos
                    controladoraMultas.AgregarMulta(multa);

                    // Mostrar mensaje de multa
                    MessageBox.Show("¡El socio ha sido multado por devolución tardía!", "Multa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // Guardar los cambios en la tabla Libros y Prestamos
                controladoraLibros.SaveChanges();
                controladoraPrestamos.SaveChanges();

                // Mostrar mensaje de éxito
                MessageBox.Show("¡Devolución realizada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recargar el DataGridView para reflejar los cambios
                CargarDatosDataGridView();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un préstamo de la lista.");
            }
        }




    }

}
