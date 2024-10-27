using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurnoverTicket.Models;

namespace TurnoverTicket.Controllers
{
	public class LoginController : Controller
	{
		private Turnover_SA_CVEntities _db = new Turnover_SA_CVEntities();

		// Acción GET para mostrar el formulario de login del cliente.
		public ActionResult Cliente()
		{
			return View();  // Renderiza la vista Cliente.cshtml
		}

		// Acción POST para procesar el login del cliente.
		[HttpPost]
		public ActionResult Cliente(string correo, string password)
		{
			var usuario = _db.Usuarios.FirstOrDefault(u => u.Correo == correo && u.Contraseña == password);

			if (usuario != null)
			{
				// Redirige a ComprarConcierto si el usuario es válido.
				return RedirectToAction("ComprarConcierto", "ComprarConcierto");
			}

			// Si el login falla, mostrar un mensaje de error.
			ViewBag.Error = "Correo o contraseña incorrectos, porfavor registrate.";
			return View();
		}

		// Acción GET para mostrar el formulario de registro de cliente.
		public ActionResult RegistroCliente()
		{
			return View();  // Renderiza la vista RegistroCliente.cshtml
		}

		// Acción POST para registrar un nuevo cliente.
		[HttpPost]
		public ActionResult RegistroCliente(string nombre, string apellido, string telefono, string correo, string password)
		{
			if (ModelState.IsValid)
			{
				// Verifica si el correo ya existe
				var existeCorreo = _db.Usuarios.Any(u => u.Correo == correo);
				if (existeCorreo)
				{
					ViewBag.Error = "Este correo ya está registrado.";
					return View();
				}

				var nuevoCliente = new Usuarios
				{
					Nombres = nombre,
					Apellidos = apellido,
					Telefono = telefono,
					Correo = correo,
					Contraseña = password
				};

				_db.Usuarios.Add(nuevoCliente);
				_db.SaveChanges();

				// Redirigir al login tras un registro exitoso.
				return RedirectToAction("Cliente", "Login");
			}

			// Si hay un error, recargar la vista con el mensaje.
			ViewBag.Error = "Ocurrió un error al registrar al cliente.";
			return View();
		}

		// Acción GET para mostrar la vista del empleado.
		public ActionResult Empleado()
		{
			return View();  // Renderiza la vista Empleado.cshtml
		}

		// Acción POST para procesar el login del empleado.
		[HttpPost]
		public ActionResult Empleado(string correo, string password)
		{
			var empleado = _db.Empleado.FirstOrDefault(e => e.Correo == correo && e.Contraseña == password);

			if (empleado != null)
			{
				// Redirige a ComprarConcierto si el empleado es válido.
				return RedirectToAction("ListaConciertos", "ListaConciertos");
			}

			// Si el login falla, mostrar un mensaje de error.
			ViewBag.Error = "Correo o contraseña incorrectos.";
			return View();
		}

		public ActionResult Login()
		{
			return View();
		}
	}
}
