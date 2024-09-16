using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio_Guia_08.Models
{
    public class Conexion
    {
        private SqlConnection conexionSQL;
        public Conexion()
        {
            cadenaConexion = @"Data source=(local);Initial Catalog=Bolsa_Trabajo;Integrated Security=True";
        }
        public bool conectar() { ... }
        public void desconectar() { ... }
        public List<SelectListItem> getCategorias() { ... }
        public int nuevaOferta(...) { ... }
    }

}