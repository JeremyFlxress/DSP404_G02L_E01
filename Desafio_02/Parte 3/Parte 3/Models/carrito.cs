using Parte_3.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parte_3.Models
{
    public class carrito : Controller
    {
		// GET: carrito
		public class Carrito
		{
			public List<Producto> Productos { get; set; } = new List<Producto>();
		}
    }
}