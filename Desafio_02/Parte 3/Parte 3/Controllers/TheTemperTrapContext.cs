using System;
using System.Data.Entity;
using Parte_3.Models; 

namespace Parte_3.Data 
{
	public class TheTemperTrapContext : DbContext
	{
		public TheTemperTrapContext() : base("name=YourConnectionStringName")  
		{
		}

		public DbSet<Producto> Producto { get; set; } 
		
	
		public DbSet<DetallePedido> DetallePedido { get; set; }
		

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			 
			base.OnModelCreating(modelBuilder);
		}
	}
}
