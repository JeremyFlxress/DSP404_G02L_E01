using System.Linq;
using System.Web.Mvc;
using Parte3.Models; // Asegúrate de que la ruta sea correcta

namespace Parte3.Controllers
{
	public class ClienteController : Controller
	{
		private readonly TheTemperTrapContext db = new TheTemperTrapContext();

		// GET: Cliente
		public ActionResult Registro()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Registro(Cliente cliente)
		{
			if (ModelState.IsValid)
			{
				db.Clientes.Add(cliente);
				db.SaveChanges();
				return RedirectToAction("Index", "Home"); // Redirigir a la página principal después del registro
			}
			return View(cliente);
		}

		public ActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(string correo, string contraseña)
		{
			var cliente = db.Clientes.FirstOrDefault(c => c.Correo == correo && c.Contraseña == contraseña);
			if (cliente != null)
			{
				// Autenticación exitosa, podrías almacenar el cliente en la sesión
				Session["ClienteID"] = cliente.ClienteID;
				return RedirectToAction("Index", "Home"); // Redirigir a la página principal
			}

			ModelState.AddModelError("", "Correo o contraseña incorrectos.");
			return View();
		}

		public ActionResult Logout()
		{
			Session.Clear(); // Limpiar la sesión
			return RedirectToAction("Index", "Home"); // Redirigir a la página principal
		}
	}
}
