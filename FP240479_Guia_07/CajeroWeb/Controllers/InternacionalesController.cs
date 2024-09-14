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
    
            transaccion nuevaTransaccion = new transaccion(sNumeroTarjeta, sSaldo);

            if (cantidad > 0)
            {
                nuevaTransaccion.transferenciaInternacional(cantidad);  // Se aplica la transferencia internacional.
            }

            sSaldo = nuevaTransaccion.getSaldo();  // Se actualiza el saldo.

         
            return Redirect("~/Menu/Menu?sNumeroTarjeta=" + sNumeroTarjeta + "&sSaldo=" + sSaldo);
        }
    }
}