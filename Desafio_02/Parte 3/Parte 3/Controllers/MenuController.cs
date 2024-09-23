using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parte_3.Controllers
{
	public class MenuController : Controller
	{
		private readonly MiDbContext _context; //deberia de llamar a la base de datos

		public MenuController(MiDbContext context) //deberia de llamar a la base de datos
		{
			_context = context; 
		}

		// GET: Menu
		public IActionResult Index() //deberia de llamar a la base de datos
		{
			var productos = _context.Productos.ToList(); 
			return View(productos); 
		}
	}
}