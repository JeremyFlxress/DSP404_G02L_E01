using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Parte_3.Models
{
	public class DetallePedido
	{
		public int Id { get; set; }
		public int PedidoId { get; set; }
		public int ProductoId { get; set; }
		public int Cantidad { get; set; }
		
	}
}