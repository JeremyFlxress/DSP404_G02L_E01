using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CajeroWeb.Models;

namespace CajeroWeb.Controllers
{
    public class InternacionalesController : Controller
    {
        // GET: Internacionales
        public ActionResult Internacionales(string sNumeroTarjeta, double sSaldo)
        {
            ViewBag.sNumeroTarjeta = sNumeroTarjeta;
            ViewBag.sSaldo = sSaldo;
            return View();
        }

        [HttpPost]
        public ActionResult Internacionales(string sNumeroTarjeta, double sSaldo, double cantidad)
        {
            // Crea una nueva instancia de la transacción
            transaccion nuevaTransaccion = new transaccion(sNumeroTarjeta, sSaldo);

            // Verifica si la cantidad es mayor que cero
            if (cantidad > 0)
            {
                // Realiza la transferencia internacional
                nuevaTransaccion.transferenciaInternacional(cantidad);
            }

            // Actualiza el saldo
            sSaldo = nuevaTransaccion.getSaldo();
            ViewBag.sNumeroTarjeta = nuevaTransaccion.getNumTarjeta();
            ViewBag.sSaldo = nuevaTransaccion.getSaldo();

            // Redirige al menú principal con los nuevos valores
            return Redirect("~/Menu/Menu?sNumeroTarjeta=" + sNumeroTarjeta + "&sSaldo=" + sSaldo);
        }
    }
}