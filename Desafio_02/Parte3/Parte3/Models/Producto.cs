using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Parte3.Models
{
	public class Producto
	{
		[Key]
		public int ProductoID { get; set; }

		[Required]
		[StringLength(100)]
		public string Nombre_Producto { get; set; }

		[StringLength(255)]
		public string Descripcion_del_Producto { get; set; }

		[Required]
		public decimal Precio_Unitario { get; set; }
	}
}