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
    public partial class FormSocios : Form
    {
        private ControladoraSocios controladoraSocios; // Tu controladora de socios

        public FormSocios()
        {
            InitializeComponent();
            controladoraSocios = new ControladoraSocios(); // Inicializa la controladora
            dgvSocios.SelectionChanged += dgvSocios_SelectionChanged;
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            // Llama al método para cargar los datos en el DataGridView
            CargarDatosDataGridView();
        }

        private void CargarDatosDataGridView()
        {
            // Carga los socios desde la controladora
            var socios = controladoraSocios.ObtenerTodosLosSocios();

            // Asigna los socios como la fuente de datos del DataGridView
            dgvSocios.DataSource = socios;
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar el texto de todos los TextBox
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxDni.Clear();
            textBoxBuscar.Clear();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto ingresado en el TextBox de búsqueda
            string textoBusqueda = textBoxBuscar.Text;

            // Filtrar los socios en el DataGridView basados en el texto de búsqueda
            if (!string.IsNullOrEmpty(textoBusqueda))
            {
                // Filtrar los socios en el DataGridView basados en el texto de búsqueda
                List<Socio> sociosFiltrados = controladoraSocios.ObtenerSociosPorCoincidencia(textoBusqueda);

                // Actualizar el DataGridView con los socios filtrados
                dgvSocios.DataSource = sociosFiltrados;
            }
            else
            {
                // Si el texto de búsqueda está vacío, mostrar todos los socios en el DataGridView
                CargarDatosDataGridView();
            }
        }


        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            // Verificar si los TextBox de nombre, apellido y DNI no están vacíos
            if (!string.IsNullOrWhiteSpace(textBoxNombre.Text) &&
                !string.IsNullOrWhiteSpace(textBoxApellido.Text) &&
                !string.IsNullOrWhiteSpace(textBoxDni.Text))
            {
                // Verificar si el DNI es un número
                if (!int.TryParse(textBoxDni.Text, out int dni))
                {
                    MessageBox.Show("El DNI debe ser un número válido.", "DNI Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si el DNI no es un número
                }

                // Verificar si el DNI ya existe en la base de datos
                if (DniExiste(dni))
                {
                    MessageBox.Show("El DNI ingresado ya está asociado a otro socio.", "DNI Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si el DNI ya existe
                }

                // Crear un nuevo objeto Socio con los valores de los TextBox
                Socio nuevoSocio = new Socio
                {
                    Nombre = textBoxNombre.Text,
                    Apellido = textBoxApellido.Text,
                    Dni = dni,
                    Habilitado = true // Por defecto, establecer como habilitado
                };

                // Agregar el nuevo socio utilizando la controladora
                ControladoraSocios controladoraSocios = new ControladoraSocios();
                controladoraSocios.AgregarSocio(nuevoSocio);

                // Actualizar el DataGridView después de agregar el socio
                CargarDatosDataGridView();

                // Mostrar un mensaje indicando que el socio ha sido agregado correctamente
                MessageBox.Show("El socio ha sido agregado correctamente.", "Socio Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los TextBox después de agregar el socio
                textBoxNombre.Clear();
                textBoxApellido.Clear();
                textBoxDni.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool DniExiste(int dni)
        {
            // Verificar si el DNI existe en la base de datos
            ControladoraSocios controladoraSocios = new ControladoraSocios();
            var socios = controladoraSocios.ObtenerTodosLosSocios();
            return socios.Any(socio => socio.Dni == dni);
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (dgvSocios.SelectedRows.Count > 0)
            {
                // Obtener el ID del socio seleccionado en el DataGridView
                int socioId = Convert.ToInt32(dgvSocios.SelectedRows[0].Cells["SocioId"].Value);

                // Obtener el socio seleccionado de la base de datos utilizando su ID
                Socio socioSeleccionado = controladoraSocios.ObtenerSocioPorId(socioId);

                // Verificar si se encontró el socio en la base de datos
                if (socioSeleccionado != null)
                {
                    // Verificar si el socio está habilitado
                    if (!socioSeleccionado.Habilitado)
                    {
                        MessageBox.Show("El socio no está habilitado y no se puede borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Confirmar con el usuario si realmente desea borrar el socio
                    DialogResult result = MessageBox.Show("¿Estás seguro de que deseas borrar este socio?", "Confirmar Borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Llamar al método BorrarSocio de la controladora de socios
                        controladoraSocios.BorrarSocio(socioId);

                        // Actualizar los datos del DataGridView después de borrar el socio
                        CargarDatosDataGridView();

                        // Mostrar un mensaje indicando que el socio ha sido borrado correctamente
                        MessageBox.Show("El socio ha sido borrado correctamente.", "Socio Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un socio para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSocios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSocios.SelectedRows.Count > 0)
            {
                // Obtener el ID del socio seleccionado en el DataGridView
                int socioId = Convert.ToInt32(dgvSocios.SelectedRows[0].Cells["SocioId"].Value);

                // Obtener el socio seleccionado de la base de datos utilizando su ID
                Socio socioSeleccionado = controladoraSocios.ObtenerSocioPorId(socioId);

                // Verificar si se encontró el socio en la base de datos
                if (socioSeleccionado != null)
                {
                    // Mostrar los datos del socio seleccionado en los TextBox correspondientes
                    textBoxNombre.Text = socioSeleccionado.Nombre;
                    textBoxApellido.Text = socioSeleccionado.Apellido;
                    textBoxDni.Text = socioSeleccionado.Dni.ToString();
                }
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dgvSocios.SelectedRows.Count > 0)
            {
                // Obtener el ID del socio seleccionado en el DataGridView
                int socioId = Convert.ToInt32(dgvSocios.SelectedRows[0].Cells["SocioId"].Value);

                // Obtener el socio seleccionado de la base de datos utilizando su ID
                Socio socioSeleccionado = controladoraSocios.ObtenerSocioPorId(socioId);

                // Verificar si se encontró el socio en la base de datos
                if (socioSeleccionado != null)
                {
                    // Verificar si el socio está habilitado
                    if (!socioSeleccionado.Habilitado)
                    {
                        MessageBox.Show("El socio no está habilitado y no se puede modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Obtener los nuevos valores del nombre, apellido y DNI desde los TextBox
                    string nuevoNombre = textBoxNombre.Text;
                    string nuevoApellido = textBoxApellido.Text;
                    int nuevoDni;

                    // Verificar si el DNI ingresado es un número válido
                    if (!int.TryParse(textBoxDni.Text, out nuevoDni))
                    {
                        MessageBox.Show("El DNI ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Actualizar los datos del socio seleccionado
                    socioSeleccionado.Nombre = nuevoNombre;
                    socioSeleccionado.Apellido = nuevoApellido;
                    socioSeleccionado.Dni = nuevoDni;

                    // Guardar los cambios en la base de datos
                    controladoraSocios.ActualizarSocio(socioSeleccionado);

                    // Actualizar el DataGridView después de guardar los cambios
                    CargarDatosDataGridView();

                    // Mostrar un mensaje indicando que los cambios han sido guardados
                    MessageBox.Show("Los cambios han sido guardados correctamente.", "Cambios Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un socio para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
