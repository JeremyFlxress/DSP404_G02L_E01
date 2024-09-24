using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheTemperTrap.Models;

namespace TheTemperTrap.Controllers
{
    public class EmpleadoController : Controller
    {
        TheTemperTrapEntities contexto = new TheTemperTrapEntities();

        // GET: Empleado
        public ActionResult EmpleadoMenu()
        {
            List<Cliente> cliente = contexto.Cliente.ToList();
            List<Factura> fact = contexto.Factura.ToList();
            List<Pedido> pedido = contexto.Pedido.ToList();

            ViewBag.cliente = cliente;
            ViewBag.factura = fact;
            ViewBag.pedido = pedido;

            return View();
        }

        [HttpPost]
        public ActionResult ActualizarEstado(int id, string estado, string comentario)
        {
            // Buscar el pedido por ID
            Pedido pedido = contexto.Pedido.Find(id);

            if (pedido != null)
            {
                // Actualizar el estado del pedido y el comentario
                pedido.EstadoPedido = estado;
                pedido.Comentario = comentario; // Asegúrate de tener este campo en tu modelo Pedido
                contexto.SaveChanges(); // Guardar los cambios en la base de datos
            }

            return new HttpStatusCodeResult(200); // Retornar éxito
        }
    }
}