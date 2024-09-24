using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Parte3.Models
{
	public class Pedido
	{
		public int IDPedido { get; set; }
		public int ClienteID { get; set; }
		public int? EmpleadoID { get; set; }
		public DateTime FechaPedido { get; set; }
		public string EstadoPedido { get; set; }
		public decimal TotalPagar { get; set; }
		public string Comentario { get; set; }

		public virtual Cliente Cliente { get; set; }
		public virtual Empleado Empleado { get; set; }
		public virtual ICollection<DetallePedido> DetallePedidos { get; set; } = new List<DetallePedido>();
	}
}
