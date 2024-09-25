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
            // Obtener las listas de facturas, clientes y pedidos desde la base de datos
            List<Cliente> clientes = contexto.Cliente.ToList();
            List<Factura> facturas = contexto.Factura.ToList();
            List<Pedido> pedidos = contexto.Pedido.ToList();

            // Pasar las listas a la vista mediante ViewBag
            ViewBag.cliente = clientes;
            ViewBag.factura = facturas;
            ViewBag.pedido = pedidos;

            // Retornar la vista
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