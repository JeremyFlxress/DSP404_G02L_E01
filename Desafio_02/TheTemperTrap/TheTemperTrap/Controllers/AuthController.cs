using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheTemperTrap.Models;

namespace TheTemperTrap.Controllers
{
    public class AuthController : Controller
    {
        private TheTemperTrapEntities db = new TheTemperTrapEntities();

        // Acción para la pantalla de login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string correo, string contraseña)
        {
            try
            {
                var cliente = db.Cliente.SingleOrDefault(c => c.Correo == correo && c.Contraseña == contraseña);
                var empleado = db.Empleado.SingleOrDefault(e => e.Correo == correo && e.ContraseñaEmpleado == contraseña);

                if (cliente != null)
                {
                    Session["UserType"] = "Cliente";
                    Session["UserId"] = cliente.ClienteID;
                    return RedirectToAction("Productos", "Productos");
                }
                else if (empleado != null)
                {
                    Session["UserType"] = "Empleado";
                    Session["UserId"] = empleado.EmpleadoID;
                    return RedirectToAction("EmpleadoMenu", "Empleado");
                }
                else
                {
                    ViewBag.ErrorMessage = "Correo o contraseña incorrecta.";
                    return View();
                }
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "Ocurrió un error: " + ex.Message;
                return View();
            }
        }

        // Acción para seleccionar entre cliente o empleado
        public ActionResult SelectUserType()
        {
            return View();
        }
    }
}
