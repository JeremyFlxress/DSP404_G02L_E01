using System;
using System.ComponentModel.DataAnnotations;

namespace Parte3.Models
{
	public class Empleado
	{
		[Key]
		public int EmpleadoID { get; set; }

		[Required]
		[StringLength(50)]
		public string Nombre { get; set; }

		[Required]
		[StringLength(50)]
		public string Apellido { get; set; }

		[Required]
		[EmailAddress]
		public string Correo { get; set; }

		public string Celular { get; set; }
		public DateTime? FechaNacimiento { get; set; }

		[Required]
		public DateTime FechaContratacion { get; set; }

		[Required]
		public string ContraseñaEmpleado { get; set; }

		public string Municipio { get; set; }
		public string Departamento { get; set; }
		public string Colonia { get; set; }
		public string NumeroCalle { get; set; }
	}
}
