namespace Parte3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarProducto : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Pedidoes", "ClienteID", "dbo.Clientes");
            DropForeignKey("dbo.Pedidoes", "EmpleadoID", "dbo.Empleadoes");
            DropForeignKey("dbo.DetallePedidoes", "IDPedido", "dbo.Pedidoes");
            DropForeignKey("dbo.Facturas", "IDPedido", "dbo.Pedidoes");
            DropIndex("dbo.Pedidoes", new[] { "ClienteID" });
            DropIndex("dbo.Pedidoes", new[] { "EmpleadoID" });
            DropPrimaryKey("dbo.Pedidoes");
            AddColumn("dbo.Pedidoes", "PedidoID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Pedidoes", "Fecha", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pedidoes", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddPrimaryKey("dbo.Pedidoes", "PedidoID");
            AddForeignKey("dbo.DetallePedidoes", "IDPedido", "dbo.Pedidoes", "PedidoID", cascadeDelete: true);
            AddForeignKey("dbo.Facturas", "IDPedido", "dbo.Pedidoes", "PedidoID", cascadeDelete: true);
            DropColumn("dbo.Pedidoes", "IDPedido");
            DropColumn("dbo.Pedidoes", "ClienteID");
            DropColumn("dbo.Pedidoes", "EmpleadoID");
            DropColumn("dbo.Pedidoes", "FechaPedido");
            DropColumn("dbo.Pedidoes", "EstadoPedido");
            DropColumn("dbo.Pedidoes", "TotalPagar");
            DropColumn("dbo.Pedidoes", "Comentario");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pedidoes", "Comentario", c => c.String(maxLength: 255));
            AddColumn("dbo.Pedidoes", "TotalPagar", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Pedidoes", "EstadoPedido", c => c.String(maxLength: 50));
            AddColumn("dbo.Pedidoes", "FechaPedido", c => c.DateTime(nullable: false));
            AddColumn("dbo.Pedidoes", "EmpleadoID", c => c.Int());
            AddColumn("dbo.Pedidoes", "ClienteID", c => c.Int(nullable: false));
            AddColumn("dbo.Pedidoes", "IDPedido", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Facturas", "IDPedido", "dbo.Pedidoes");
            DropForeignKey("dbo.DetallePedidoes", "IDPedido", "dbo.Pedidoes");
            DropPrimaryKey("dbo.Pedidoes");
            DropColumn("dbo.Pedidoes", "Total");
            DropColumn("dbo.Pedidoes", "Fecha");
            DropColumn("dbo.Pedidoes", "PedidoID");
            AddPrimaryKey("dbo.Pedidoes", "IDPedido");
            CreateIndex("dbo.Pedidoes", "EmpleadoID");
            CreateIndex("dbo.Pedidoes", "ClienteID");
            AddForeignKey("dbo.Facturas", "IDPedido", "dbo.Pedidoes", "IDPedido", cascadeDelete: true);
            AddForeignKey("dbo.DetallePedidoes", "IDPedido", "dbo.Pedidoes", "IDPedido", cascadeDelete: true);
            AddForeignKey("dbo.Pedidoes", "EmpleadoID", "dbo.Empleadoes", "EmpleadoID");
            AddForeignKey("dbo.Pedidoes", "ClienteID", "dbo.Clientes", "ClienteID", cascadeDelete: true);
        }
    }
}
