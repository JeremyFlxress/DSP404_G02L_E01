using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace Parte_3.Controllers
{
	
		public class Producto
		{
			public int Id { get; set; }

			[Required]
			public string Nombre { get; set; }

			[Required]
			[Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que cero.")]
			public decimal Precio { get; set; }

			public string Descripción { get; set; }
		}
	}
