using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace login.Controllers
{
	public class LoginController : Controller
	{

		public ActionResult Login()
		{
			return View();
		}

		// Acción para la página de selección de usuario
		public ActionResult SeleccionUsuario()
		{
			return View();
		}

		// Acción para el login de cliente
		public ActionResult Cliente()
		{
			return View();
		}

		// Acción para el registro de cliente
		public ActionResult RegistroCliente()
		{
			return View();
		}
	}
}