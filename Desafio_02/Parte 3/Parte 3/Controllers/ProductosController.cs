using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 
using System.Data.Entity;
using Parte_3.Data;
using Parte_3.Models;

namespace Parte_3.Controllers
{
	public class ProductosController : Controller
	{
		private TheTemperTrapContext db = new TheTemperTrapContext();

		// GET: 
		
		public ActionResult Create()
		{
			return View(); 
		}

		
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Nombre,Descripcion,Precio")] Producto producto)
		{
			if (ModelState.IsValid)
			{
				db.Producto.Add(producto); 
				db.SaveChanges(); 
				return RedirectToAction("Productos"); 
			}

			return View(producto); 
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}