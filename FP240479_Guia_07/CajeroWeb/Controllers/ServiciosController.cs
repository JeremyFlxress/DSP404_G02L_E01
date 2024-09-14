using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CajeroWeb.Models;

namespace CajeroWeb.Controllers
{
    public class ServiciosController : Controller
    {
        // GET: Servicios
        public ActionResult Servicio(string sNumeroTarjeta, double sSaldo)
        {
            ViewBag.sNumeroTarjeta = sNumeroTarjeta;
            ViewBag.sSaldo = sSaldo;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string sNumeroTarjeta, double sSaldo, string servicio, double monto)
        {
            transaccion nuevaTransaccion = new transaccion(sNumeroTarjeta, sSaldo);

            if (monto > 0 && monto <= sSaldo)
            {
                nuevaTransaccion.pagarServicio(monto);  

                ViewBag.Servicio = servicio;
                ViewBag.Monto = monto;
                ViewBag.Saldo = nuevaTransaccion.getSaldo();
                ViewBag.NumeroTarjeta = nuevaTransaccion.getNumTarjeta();
            }
            else
            {
                ViewBag.Error = "Saldo insuficiente o monto inválido.";
                ViewBag.Saldo = sSaldo; 
            }

            return View();
        }
    }
}