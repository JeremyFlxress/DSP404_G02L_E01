using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parte_3.Controllers
{
    public class CarritoController : Controller
    {
		// GET: Carrito
		private Carrito _carrito;

		public CarritoController()
		{
			
			_carrito = new Carrito();
		}

		public IActionResult AgregarAlCarrito(int id)
		{
			// Aquí deberías buscar el producto por ID en la base de datos
			
			return RedirectToAction("Index", "Menu");
		}

		public IActionResult VerCarrito()
		{
			return View(_carrito);
		}
	}
}