using System;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;
using Parte_2.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace Parte_2.Controllers
{
    public class AccountController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string NombreUsuario, string Contraseña)
        {
            string connString = ConfigurationManager.ConnectionStrings["RestauranteDB"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connString))
            {
                string query = "SELECT Rol FROM Usuarios WHERE NombreUsuario = @usuario AND Contraseña = @contraseña";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@usuario", NombreUsuario);
                cmd.Parameters.AddWithValue("@contraseña", Contraseña);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string rol = reader["Rol"].ToString();
                    FormsAuthentication.SetAuthCookie(NombreUsuario, false);

                    if (rol == "Empleado")
                    {
                        return RedirectToAction("PedidosEmpleado", "Pedidos");
                    }
                    else if (rol == "Cliente")
                    {
                        return RedirectToAction("MenuCliente", "Menu");
                    }
                }
                else
                {
                    ViewBag.ErrorMessage = "Usuario o contraseña incorrectos.";
                    return View();
                }
            }

            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }
    }
}
