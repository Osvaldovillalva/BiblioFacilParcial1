using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Modelo;

namespace Controladora
{
    public class ControladoraReglas
    {
        private Context contexto;


        public ControladoraReglas()
        {
            contexto = new Context(); // Inicializa el contexto de la base de datos
        }




        public List<Regla> ObtenerTodasLasReglas()
        {
            using (var contexto = new Context()) // Asume que tienes acceso al contexto
            {
                return contexto.Reglas.ToList();
            }
        }
        public void ModificarReglas(int nuevosDiasPrestamo, int nuevoMaximoPrestamo, int nuevoDiasMulta)
        {
            // Obtener la regla existente (asumiendo que solo hay una regla en la base de datos)
            Regla reglaExistente = contexto.Reglas.FirstOrDefault();

            if (reglaExistente != null)
            {
                // Actualizar los valores de la regla existente
                reglaExistente.DiasPrestamo = nuevosDiasPrestamo;
                reglaExistente.MaxLibrosPorUsuario = nuevoMaximoPrestamo;
                reglaExistente.DiasMulta = nuevoDiasMulta;

                // Guardar los cambios en la base de datos
                contexto.SaveChanges();
            }
        }

        public DateTime CalcularFechaDevolucion(DateTime fechaPrestamo)
        {
            // Obtener la regla existente (asumiendo que solo hay una regla en la base de datos)
            Regla reglaExistente = contexto.Reglas.FirstOrDefault();

            if (reglaExistente != null)
            {
                // Calcular la fecha de devolución sumando los días de préstamo a la fecha de préstamo
                return fechaPrestamo.AddDays(reglaExistente.DiasPrestamo);
            }
            else
            {
                // En caso de que no exista ninguna regla, lanzar una excepción o manejar el error de manera adecuada
                throw new InvalidOperationException("No se encontraron reglas en la base de datos.");
            }
        }
        public int ObtenerMaxLibrosPrestados()
        {
            // Obtener el valor de la columna MaxLibrosPorUsuario de la tabla Reglas
            Regla reglas = contexto.Reglas.FirstOrDefault(); // Suponiendo que solo hay un registro en la tabla
            if (reglas != null)
            {
                return reglas.MaxLibrosPorUsuario;
            }
            else
            {
                // Manejar el caso en que no se encuentre ninguna regla en la tabla
                // Puedes lanzar una excepción, devolver un valor predeterminado o manejarlo de alguna otra manera
                throw new InvalidOperationException("No se encontraron reglas en la base de datos.");
            }
        }

        public DateTime CalcularFechaMultaFinalizacion(int diasMulta)
        {
            // Obtener la fecha actual
            DateTime fechaActual = DateTime.Now;

            // Calcular la fecha de finalización sumando los días de multa a la fecha actual
            DateTime fechaFinalizacion = fechaActual.AddDays(diasMulta);

            return fechaFinalizacion;
        }
        public int ObtenerDiasMulta()
        {
            // Suponiendo que tienes una instancia de DbContext llamada 'contexto' que te permite acceder a tus datos
            Regla regla = contexto.Reglas.FirstOrDefault();

            if (regla != null)
            {
                return regla.DiasMulta;
            }
            else
            {
                // Manejar el caso en que no se encuentre ninguna regla en la tabla
                // En este caso, podrías lanzar una excepción, devolver un valor predeterminado o manejarlo de alguna otra manera
                throw new InvalidOperationException("No se encontraron reglas en la base de datos.");
            }
        }

    }
}
