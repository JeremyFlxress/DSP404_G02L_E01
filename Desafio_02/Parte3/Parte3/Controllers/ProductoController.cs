using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Parte3.Models; // Asegúrate de tener los modelos en esta ruta

namespace Parte3.Controllers
{
	public class ProductoController : Controller
	{
		// Instancia del contexto de base de datos
		private TheTemperTrapContext db = new TheTemperTrapContext();

		// GET: Producto
		public ActionResult Index()
		{
			try
			{
				var productos = db.Productos.ToList(); // Obtener todos los productos de la base de datos
				return View(productos); // Pasar la lista de productos a la vista
			}
			catch (Exception ex)
			{
				ViewBag.ErrorMessage = ex.Message; // Captura el error y lo muestra en la vista
				return View(new List<Producto>()); // Devolver una lista vacía en caso de error
			}

		}
		public ActionResult Productos()
		{
			var productos = db.Productos.ToList(); // Asegúrate de que 'db' es tu contexto de base de datos
			return View(productos); // Asegúrate de que estás devolviendo el tipo correcto
		}
	}
}