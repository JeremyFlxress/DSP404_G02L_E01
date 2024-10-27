using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurnoverTicket.Models;
using System.Data.Entity;


namespace TurnoverTicket.Controllers
{
    public class ListaConciertosController : Controller
    {
        // GET: ListaConciertos
        private Turnover_SA_CVEntities db = new Turnover_SA_CVEntities();

        // GET: ListaConciertos
        public ActionResult ListaConciertos()
        {
            var conciertos = db.Conciertos
                .Include(c => c.Entradas)
                .ToList();
            return View(conciertos);
        }

        // GET: ListaConciertos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            var concierto = db.Conciertos.Find(id);
            if (concierto == null)
            {
                return HttpNotFound();
            }

            // Obtener las entradas asociadas al concierto
            var entradasVIP = db.Entradas.FirstOrDefault(e => e.IDConcierto == id && e.Localidad == "VIP");
            var entradasGeneral = db.Entradas.FirstOrDefault(e => e.IDConcierto == id && e.Localidad == "General");
            var entradasPlatea = db.Entradas.FirstOrDefault(e => e.IDConcierto == id && e.Localidad == "Platea");

            var viewModel = new CrearConciertoViewModel
            {
                IDConcierto = concierto.IDConcierto,
                Nombre = concierto.Nombre,
                Artista = concierto.Artista,
                Fecha = concierto.Fecha,
                Localizacion = concierto.Localizacion,
                CantidadVIP = entradasVIP?.CantidadDisponible ?? 0,
                PrecioVIP = entradasVIP?.Precio ?? 0,
                CantidadGeneral = entradasGeneral?.CantidadDisponible ?? 0,
                PrecioGeneral = entradasGeneral?.Precio ?? 0,
                CantidadPlatea = entradasPlatea?.CantidadDisponible ?? 0,
                PrecioPlatea = entradasPlatea?.Precio ?? 0
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CrearConciertoViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        var concierto = db.Conciertos.Find(model.IDConcierto);
                        if (concierto != null)
                        {
                            // Actualizar datos del concierto
                            concierto.Nombre = model.Nombre;
                            concierto.Artista = model.Artista;
                            concierto.Fecha = model.Fecha;
                            concierto.Localizacion = model.Localizacion;

                            // Actualizar entradas
                            UpdateEntradas(model.IDConcierto, "VIP", model.CantidadVIP, model.PrecioVIP);
                            UpdateEntradas(model.IDConcierto, "General", model.CantidadGeneral, model.PrecioGeneral);
                            UpdateEntradas(model.IDConcierto, "Platea", model.CantidadPlatea, model.PrecioPlatea);

                            db.SaveChanges();
                            transaction.Commit();
                            TempData["Success"] = "El concierto se ha actualizado exitosamente.";
                            return RedirectToAction("ListaConciertos");
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        ModelState.AddModelError("", "Error al actualizar el concierto: " + ex.Message);
                    }
                }
            }
            return View(model);
        }

        private void UpdateEntradas(int conciertoId, string localidad, int cantidad, decimal precio)
        {
            var entrada = db.Entradas.FirstOrDefault(e => e.IDConcierto == conciertoId && e.Localidad == localidad);
            if (entrada != null)
            {
                entrada.CantidadDisponible = cantidad;
                entrada.Precio = precio;
            }
        }

        // GET: ListaConciertos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            var concierto = db.Conciertos.Find(id);
            if (concierto == null)
            {
                return HttpNotFound();
            }

            return View(concierto);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    // Primero eliminar las entradas asociadas
                    var entradas = db.Entradas.Where(e => e.IDConcierto == id);
                    db.Entradas.RemoveRange(entradas);

                    // Luego eliminar el concierto
                    var concierto = db.Conciertos.Find(id);
                    db.Conciertos.Remove(concierto);

                    db.SaveChanges();
                    transaction.Commit();
                    TempData["Success"] = "El concierto se ha eliminado exitosamente.";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    TempData["Error"] = "Error al eliminar el concierto: " + ex.Message;
                }
            }
            return RedirectToAction("ListaConciertos");
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