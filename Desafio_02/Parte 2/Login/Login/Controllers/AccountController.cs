using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Login.Models;

public class AccountController : Controller
{
    // Pantalla de selección de rol
    public ActionResult SelectRole()
    {
        return View();
    }

    // Mostrar formulario de registro
    public ActionResult Register(string role)
    {
        ViewBag.Role = role;
        return View();
    }

    // Procesar formulario de registro
    [HttpPost]
    public ActionResult Register(UserRegisterViewModel model)
    {
        if (ModelState.IsValid)
        {
            using (var db = new ModelPedidosDB())
            {
                if (model.Role == "Cliente")
                {
                    var cliente = new Cliente
                    {
                        Nombre = model.Nombre,
                        Email = model.Email,
                        Password = model.Password
                    };
                    db.Clientes.Add(cliente);
                }
                else if (model.Role == "Empleado")
                {
                    var empleado = new Empleado
                    {
                        Nombre = model.Nombre,
                        Email = model.Email,
                        Password = model.Password,
                        Puesto = model.Puesto
                    };
                    db.Empleados.Add(empleado);
                }

                db.SaveChanges();
            }

            return RedirectToAction("Login");
        }

        return View(model);
    }

    // Mostrar formulario de login
    public ActionResult Login()
    {
        return View();
    }

    // Procesar formulario de login
    [HttpPost]
    public ActionResult Login(UserLoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            using (var db = new ModelPedidosDB())
            {
                if (model.Role == "Cliente")
                {
                    var cliente = db.Clientes.SingleOrDefault(c => c.Email == model.Email && c.Password == model.Password);

                    if (cliente != null)
                    {
                        Session["UserId"] = cliente.ClienteId;
                        Session["Role"] = "Cliente";
                        return RedirectToAction("Menu", "Pedidos");
                    }
                }
                else if (model.Role == "Empleado")
                {
                    var empleado = db.Empleados.SingleOrDefault(e => e.Email == model.Email && e.Password == model.Password);

                    if (empleado != null)
                    {
                        Session["UserId"] = empleado.EmpleadoId;
                        Session["Role"] = "Empleado";
                        return RedirectToAction("ManagePedidos", "Pedidos");
                    }
                }

                ModelState.AddModelError("", "Credenciales incorrectas");
            }
        }

        return View(model);
    }
}
