using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CajeroWeb.Models;

namespace CajeroWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string sNumeroTarjeta, string sNumeroPIN)
        {
            double sSaldo;
            string numero;
            Transaccion nuevaTransaccion = new Transaccion(sNumeroTarjeta);
            if (sNumeroTarjeta == "123456" && sNumeroPIN == "654321")
            {
                numero = nuevaTransaccion.getNumeroTarjeta();
                sSaldo = nuevaTransaccion.getSaldo();
                return Redirect("~/Menu/Menu?sNumeroTarjeta=" + sNumeroTarjeta + "&sSaldo=" + sSaldo);
            }
            else
            {
                //Si el numero de pin o de tarjeta no corresponde, entonces se
                // procede a mostrar a un mensaje de error
                ViewBag.Error = "Error en numero de tarjeta o PIN. Verifique";
                return View();
            }
        }
    }
}