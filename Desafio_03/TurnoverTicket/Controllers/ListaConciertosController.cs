using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TurnoverTicket.Controllers
{
    public class ListaConciertosController : Controller
    {
        // GET: ListaConciertos
        public ActionResult ListaConciertos()
        {
            return View();
        }
    }
}