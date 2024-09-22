using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parte_2.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; } // Empleado o Cliente
    }
}