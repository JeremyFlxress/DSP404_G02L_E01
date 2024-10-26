using System;
using System.Web.Mvc;
using TurnoverTicket.Models;

namespace TurnoverTicket.Controllers
{
    public class CrearConciertoController : Controller
    {
        private Turnover_SA_CVEntities db = new Turnover_SA_CVEntities();

        // GET: CrearConcierto
        public ActionResult CrearConcierto()
        {
            return View(new CrearConciertoViewModel
            {
                Fecha = DateTime.Now.Date // Establecer la fecha actual por defecto
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
                        // Crear el concierto usando el modelo generado por EF
                        var concierto = new Conciertos
                        {
                            Nombre = model.Nombre,
                            Artista = model.Artista,
                            Fecha = model.Fecha,
                            Localizacion = model.Localizacion
                        };

                        db.Conciertos.Add(concierto);
                        db.SaveChanges();

                        // Crear las entradas VIP
                        var entradasVIP = new Entradas
                        {
                            IDConcierto = concierto.IDConcierto,
                            Localidad = "VIP",
                            CantidadDisponible = model.CantidadVIP,
                            Precio = model.PrecioVIP
                        };
                        db.Entradas.Add(entradasVIP);

                        // Crear las entradas General
                        var entradasGeneral = new Entradas
                        {
                            IDConcierto = concierto.IDConcierto,
                            Localidad = "General",
                            CantidadDisponible = model.CantidadGeneral,
                            Precio = model.PrecioGeneral
                        };
                        db.Entradas.Add(entradasGeneral);

                        // Crear las entradas Platea
                        var entradasPlatea = new Entradas
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