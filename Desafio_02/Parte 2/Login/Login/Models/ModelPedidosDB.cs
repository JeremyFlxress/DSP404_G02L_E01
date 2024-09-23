using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Login.Models
{
    public class ModelPedidosDB : DbContext
    {
        public ModelPedidosDB() : base("The Temper Trap")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Empleado> Empleados { get; set; }
    }
}