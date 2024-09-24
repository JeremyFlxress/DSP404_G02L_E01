using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parte3.Models
{
	public class Factura
	{
		[Key]
		public int FacturaID { get; set; }

		[Required]
		public int IDPedido { get; set; }

		[Required]
		public DateTime FechaTransaccion { get; set; }

		[Required]
		public decimal MontoTotal { get; set; }

		[StringLength(50)]
		public string TipoPago { get; set; }

		// Relaciones
		[ForeignKey("IDPedido")]
		public Pedido Pedido { get; set; }
	}
}
