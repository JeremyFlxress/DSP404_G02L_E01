namespace Parte3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        Correo = c.String(nullable: false),
                        Telefono = c.String(),
                        Contraseña = c.String(nullable: false),
                        Municipio = c.String(),
                        Departamento = c.String(),
                        Colonia = c.String(),
                        NumeroCalle = c.String(),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.DetallePedidoes",
                c => new
                    {
                        DetallePedidoID = c.Int(nullable: false, identity: true),
                        IDPedido = c.Int(nullable: false),
                        ProductoID = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DetallePedidoID)
                .ForeignKey("dbo.Pedidoes", t => t.IDPedido, cascadeDelete: true)
                .ForeignKey("dbo.Productoes", t => t.ProductoID, cascadeDelete: true)
                .Index(t => t.IDPedido)
                .Index(t => t.ProductoID);
            
            CreateTable(
                "dbo.Pedidoes",
                c => new
                    {
                        IDPedido = c.Int(nullable: false, identity: true),
                        ClienteID = c.Int(nullable: false),
                        EmpleadoID = c.Int(),
                        FechaPedido = c.DateTime(nullable: false),
                        EstadoPedido = c.String(maxLength: 50),
                        TotalPagar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Comentario = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.IDPedido)
                .ForeignKey("dbo.Clientes", t => t.ClienteID, cascadeDelete: true)
                .ForeignKey("dbo.Empleadoes", t => t.EmpleadoID)
                .Index(t => t.ClienteID)
                .Index(t => t.EmpleadoID);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        EmpleadoID = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50),
                        Apellido = c.String(nullable: false, maxLength: 50),
                        Correo = c.String(nullable: false),
                        Celular = c.String(),
                        FechaNacimiento = c.DateTime(),
                        FechaContratacion = c.DateTime(nullable: false),
                        ContraseñaEmpleado = c.String(nullable: false),
                        Municipio = c.String(),
                        Departamento = c.String(),
                        Colonia = c.String(),
                        NumeroCalle = c.String(),
                    })
                .PrimaryKey(t => t.EmpleadoID);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        ProductoID = c.Int(nullable: false, identity: true),
                        Nombre_Producto = c.String(nullable: false, maxLength: 100),
                        Descripcion_del_Producto = c.String(maxLength: 255),
                        Precio_Unitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ProductoID);
            
            CreateTable(
                "dbo.Facturas",
                c => new
                    {
                        FacturaID = c.Int(nullable: false, identity: true),
                        IDPedido = c.Int(nullable: false),
                        FechaTransaccion = c.DateTime(nullable: false),
                        MontoTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TipoPago = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.FacturaID)
                .ForeignKey("dbo.Pedidoes", t => t.IDPedido, cascadeDelete: true)
                .Index(t => t.IDPedido);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Facturas", "IDPedido", "dbo.Pedidoes");
            DropForeignKey("dbo.DetallePedidoes", "ProductoID", "dbo.Productoes");
            DropForeignKey("dbo.DetallePedidoes", "IDPedido", "dbo.Pedidoes");
            DropForeignKey("dbo.Pedidoes", "EmpleadoID", "dbo.Empleadoes");
            DropForeignKey("dbo.Pedidoes", "ClienteID", "dbo.Clientes");
            DropIndex("dbo.Facturas", new[] { "IDPedido" });
            DropIndex("dbo.Pedidoes", new[] { "EmpleadoID" });
            DropIndex("dbo.Pedidoes", new[] { "ClienteID" });
            DropIndex("dbo.DetallePedidoes", new[] { "ProductoID" });
            DropIndex("dbo.DetallePedidoes", new[] { "IDPedido" });
            DropTable("dbo.Facturas");
            DropTable("dbo.Productoes");
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Pedidoes");
            DropTable("dbo.DetallePedidoes");
            DropTable("dbo.Clientes");
        }
    }
}
