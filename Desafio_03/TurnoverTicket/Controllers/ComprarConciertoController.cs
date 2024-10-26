using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurnoverTicket.Models;

namespace TurnoverTicket.Controllers
{
    public class ComprarConciertoController : Controller
    {
        private Turnover_SA_CVEntities db = new Turnover_SA_CVEntities();

        // GET: ComprarConcierto
        public ActionResult ComprarConcierto()
        {
            var conciertos = db.Conciertos
                .Where(c => c.Fecha >= DateTime.Now)  
                .OrderBy(c => c.Fecha)
                .Select(c => new
                {
                    Concierto = c,
                    PrecioMinimo = c.Entradas.Min(e => e.Precio)
                })
                .ToList()
                .Select(x => new ComprarConcierto
                {
                    IDConcierto = x.Concierto.IDConcierto,
                    Nombre = x.Concierto.Nombre,
                    Artista = x.Concierto.Artista,
                    Fecha = x.Concierto.Fecha,
                    Localizacion = x.Concierto.Localizacion,
                    PrecioDesde = x.PrecioMinimo
                })
                .ToList();

            return View(conciertos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}