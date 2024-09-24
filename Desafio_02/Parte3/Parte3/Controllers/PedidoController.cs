using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parte3.Models; // Asegúrate de que el espacio de nombres es correcto

namespace Parte3.Controllers
{
	public class PedidoController : Controller
	{
		private TheTemperTrapContext db = new TheTemperTrapContext();

		// GET: Pedido/Crear
		public ActionResult CrearPedido()
		{
			
			var productos = db.Productos.ToList();
			return View(productos);
		}


		
		[HttpPost]
		public ActionResult CrearPedido(Dictionary<int, int> cantidades) 
		{
			if (cantidades == null || !cantidades.Any())
			{
				ModelState.AddModelError("", "Debe seleccionar al menos un producto.");
				return RedirectToAction("CrearPedido");
			}

			// Crear un nuevo pedido
			var nuevoPedido = new Pedido
			{
				ClienteID = (int)Session["ClienteID"], 
				FechaPedido = DateTime.Now,
				EstadoPedido = "En proceso",
				TotalPagar = 0,
				Comentario = "" 
			};

			foreach (var item in cantidades)
			{
				int productoId = item.Key;
				int cantidad = item.Value;

				if (cantidad > 0)
				{
					var producto = db.Productos.Find(productoId);
					if (producto != null)
					{
						var detallePedido = new DetallePedido
						{
							ProductoID = productoId,
							Cantidad = cantidad
						};

						nuevoPedido.TotalPagar += producto.Precio_Unitario * cantidad;
						nuevoPedido.DetallePedidos.Add(detallePedido);
					}
				}
			}

			db.Pedidos.Add(nuevoPedido);
			db.SaveChanges();

			return RedirectToAction("VerPedido", new { id = nuevoPedido.IDPedido }); 
		}

		// GET: Pedido/Ver/5
		public ActionResult VerPedido(int id)
		{
			var pedido = db.Pedidos.Include("DetallePedidos").FirstOrDefault(p => p.IDPedido == id);
			if (pedido == null)
			{
				return HttpNotFound();
			}
			return View(pedido);
		}
		public ActionResult MisPedidos()
		{
			var clienteId = (int)Session["ClienteID"]; // Asegúrate de que el cliente esté autenticado
			var pedidos = db.Pedidos
							.Where(p => p.ClienteID == clienteId)
							.Include(p => p.DetallePedidos)
							.ToList();
			return View(pedidos);
		}
		public ActionResult Detalles(int id)
		{
			var pedido = db.Pedidos
						   .Include(p => p.DetallePedidos.Select(dp => dp.Producto))
						   .FirstOrDefault(p => p.IDPedido == id);

			if (pedido == null)
			{
				return HttpNotFound();
			}

			return View(pedido);
		}
		public ActionResult HistorialCompras()
		{
			var clienteId = (int)Session["ClienteID"];
			var historial = db.Pedidos
							  .Where(p => p.ClienteID == clienteId && p.EstadoPedido == "Entregado")
							  .ToList();
			return View(historial);
		}

	}
}
