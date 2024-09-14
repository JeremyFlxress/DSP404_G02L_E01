using CajeroWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CajeroWeb.Controllers
{
    public class InternacionalesController : Controller
    {
        // GET: Internacionales
        public ActionResult Internacionales(string sNumeroTarjeta, double? sSaldo)
        {
            // Verificamos si sNumeroTarjeta está nulo o vacío
            if (string.IsNullOrEmpty(sNumeroTarjeta) || sSaldo == null)
            {
                // Devuelve un mensaje de error o redirige al menú inicial
                return Redirect("~/Home/Error");
            }

            ViewBag.sNumeroTarjeta = sNumeroTarjeta;
            ViewBag.sSaldo = sSaldo.Value;
            return View();
        }

        [HttpPost]
        public ActionResult Internacionales(string sNumeroTarjeta, double? sSaldo, double cantidad)
        {
            // Validamos si el saldo o el número de tarjeta son nulos
            if (string.IsNullOrEmpty(sNumeroTarjeta) || sSaldo == null)
            {
                return Redirect("~/Home/Error");
            }
            Transaccion nuevaTransaccion = new Transaccion(sNumeroTarjeta, sSaldo.Value);

            if (cantidad > 0)
            {
                nuevaTransaccion.transferenciaInternacional(cantidad);
            }
            sSaldo = nuevaTransaccion.getSaldo();
            ViewBag.sNumeroTarjeta = nuevaTransaccion.getNumeroTarjeta();
            ViewBag.sSaldo = nuevaTransaccion.getSaldo();

            return Redirect("~/Menu/Menu?sNumeroTarjeta=" + sNumeroTarjeta + "&sSaldo=" + sSaldo);
        }
    }
}