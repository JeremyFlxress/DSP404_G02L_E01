using System;
using System.Web.Mvc;
using TurnoverTicket.Models;

namespace TurnoverTicket.Controllers
{
    public class CrearConciertoController : Controller
    {
        private Turnover_SA_CVEntities1 db = new Turnover_SA_CVEntities1();

        // GET: CrearConcierto
        public ActionResult CrearConcierto()
        {
            return View(new CrearConciertoViewModel
            {
                Fecha = DateTime.Now.Date 
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearConcierto(CrearConciertoViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var concierto = new Concierto
                        {
                            Nombre = model.Nombre,
                            Artista = model.Artista,
                            Fecha = model.Fecha,
                            Localizacion = model.Localizacion
                        };

                        db.Conciertos.Add(concierto);
                        db.SaveChanges();

                        // aca es donde se crean todas las entradas
                        var entradasVIP = new Entrada
                        {
                            IDConcierto = concierto.IDConcierto,
                            Localidad = "VIP",
                            CantidadDisponible = model.CantidadVIP,
                            Precio = model.PrecioVIP
                        };
                        db.Entradas.Add(entradasVIP);

                      
                        var entradasGeneral = new Entrada
                        {
                            IDConcierto = concierto.IDConcierto,
                            Localidad = "General",
                            CantidadDisponible = model.CantidadGeneral,
                            Precio = model.PrecioGeneral
                        };
                        db.Entradas.Add(entradasGeneral);

                       
                        var entradasPlatea = new Entrada
                        {
                            IDConcierto = concierto.IDConcierto,
                            Localidad = "Platea",
                            CantidadDisponible = model.CantidadPlatea,
                            Precio = model.PrecioPlatea
                        };
                        db.Entradas.Add(entradasPlatea);

                        db.SaveChanges();
                        transaction.Commit();

                        TempData["Success"] = "El concierto se ha creado exitosamente.";
                        return RedirectToAction("ListaConciertos", "ListaConciertos");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        ModelState.AddModelError("", "Error al crear el concierto: " + ex.Message);
                    }
                }
            }

            return View(model);
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