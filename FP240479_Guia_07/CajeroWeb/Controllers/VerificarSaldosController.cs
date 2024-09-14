using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CajeroWeb.Models;

namespace CajeroWeb.Controllers
{
    public class VerificarSaldosController : Controller
    {
        // GET: VerificarSaldos
        public ActionResult VerSaldo(string sNumeroTarjeta, decimal sSaldo)
        {
            
            ViewBag.sNumeroTarjeta = sNumeroTarjeta;
            ViewBag.sSaldo = sSaldo;
            return View();
        }
    }
}