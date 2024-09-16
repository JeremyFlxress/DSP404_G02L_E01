using Ejercicio_Guia_08.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio_Guia_08.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Conexion obj = new Conexion();
            ViewBag.OpcionesCat = obj.getCategorias();
            ViewBag.Ofertas = obj.CargarDatos();
            return View();
        }
        [HttpPost]
        public ActionResult Index(string OpcionesCat) {  }
    }

}