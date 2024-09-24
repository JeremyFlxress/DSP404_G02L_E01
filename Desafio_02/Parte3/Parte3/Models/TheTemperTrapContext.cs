using System.Data.Entity;

namespace Parte3.Models
{
	public class TheTemperTrapContext : DbContext
	{
		public TheTemperTrapContext() : base("name=TheTemperTrapDB") { }

		public DbSet<Producto> Productos { get; set; }
		public DbSet<Cliente> Clientes { get; set; }
		public DbSet<Empleado> Empleados { get; set; }
		public DbSet<Pedido> Pedidos { get; set; }
		public DbSet<DetallePedido> DetallePedidos { get; set; }
		public DbSet<Factura> Facturas { get; set; }
	}
}