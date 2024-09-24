using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Parte3.Models
{
	public class DetallePedido
	{
		public int DetallePedidoID { get; set; }
		public int IDPedido { get; set; }
		public int ProductoID { get; set; }
		public int Cantidad { get; set; }

		public virtual Pedido Pedido { get; set; }
		public virtual Producto Producto { get; set; }
	}
}
