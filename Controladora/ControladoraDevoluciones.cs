﻿using Entidades;
using Microsoft.EntityFrameworkCore;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{

    
    public class ControladoraDevoluciones
    {
        private Context contexto;

        public ControladoraDevoluciones()
        {
            contexto = new Context();
        }

        public List<Devolucion> ObtenerTodasLasDevoluciones()
        {
            // Utiliza el DbContext para obtener todas las devoluciones
            return contexto.Devoluciones.Include(d => d.Prestamo).ToList();
        }

    }
}
