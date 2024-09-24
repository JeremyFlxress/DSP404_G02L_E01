using System.ComponentModel.DataAnnotations;

namespace Parte3.Models
{
	public class Cliente
	{
		[Key]
		public int ClienteID { get; set; }

		[Required]
		[StringLength(50)]
		public string Nombre { get; set; }

		[Required]
		[StringLength(50)]
		public string Apellido { get; set; }

		[Required]
		[EmailAddress]
		public string Correo { get; set; }

		public string Telefono { get; set; }

		[Required]
		public string Contraseña { get; set; }

		public string Municipio { get; set; }
		public string Departamento { get; set; }
		public string Colonia { get; set; }
		public string NumeroCalle { get; set; }
	}
}