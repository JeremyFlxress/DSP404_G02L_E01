using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheTemperTrap.Models;

namespace TheTemperTrap.Controllers
{
    public class ClienteController : Controller
    {
        private TheTemperTrapEntities db = new TheTemperTrapEntities(); // Tu contexto de Entity Framework

        // Acción para registrar nuevo cliente
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Cliente model)
        {
            if (ModelState.IsValid)
            {
                db.Cliente.Add(model);
                db.SaveChanges();
                return RedirectToAction("Login", "Auth");
            }

            return View(model);
        }

        // Acción para mostrar el menú del cliente
        public ActionResult ClienteMenu()
        {
            return View();
        }
    }
}
