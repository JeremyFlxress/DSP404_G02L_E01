using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurnoverTicket.Models;
using System.Data.Entity;

namespace TurnoverTicket.Controllers
{
    public class ComprarConciertoController : Controller
    {
        private Turnover_SA_CVEntities1 db = new Turnover_SA_CVEntities1();

        private int ObtenerUsuarioActual()
        {
            if (Session["IDUsuario"] != null)
            {
                return Convert.ToInt32(Session["IDUsuario"]);
            }
            throw new UnauthorizedAccessException("Usuario no autenticado");
        }

        // GET: ComprarConcierto
        public ActionResult ComprarConcierto(string searchString, DateTime? searchDate)
        {
            var conciertos = db.Conciertos.AsQueryable();

            if (!String.IsNullOrEmpty(searchString))
            {
                conciertos = conciertos.Where(c => c.Nombre.Contains(searchString) || c.Artista.Contains(searchString));
            }

            if (searchDate.HasValue)
            {
                conciertos = conciertos.Where(c => DbFunctions.TruncateTime(c.Fecha) == DbFunctions.TruncateTime(searchDate.Value));
            }

            var conciertoList = conciertos
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

            return View(conciertoList);
        }

        public ActionResult DetalleConcierto(int id)
        {
            var concierto = db.Conciertos
                .Where(c => c.IDConcierto == id)
                .Select(c => new DetalleConciertoViewModel
                {
                    IDConcierto = c.IDConcierto,
                    Nombre = c.Nombre,
                    Artista = c.Artista,
                    Fecha = c.Fecha,
                    Localizacion = c.Localizacion,
                    Entradas = c.Entradas.Select(e => new EntradaViewModel
                    {
                        IDEntrada = e.IDEntrada,
                        Localidad = e.Localidad,
                        Precio = e.Precio,
                        CantidadDisponible = e.CantidadDisponible
                    }).ToList()
                }).FirstOrDefault();

            if (concierto == null)
            {
                return HttpNotFound();
            }

            return View(concierto);
        }

        [HttpPost]
        public ActionResult ConfirmarCompra(int IDConcierto, FormCollection form)
        {
            return RedirectToAction("Factura", new { idConcierto = IDConcierto });
        }

        public ActionResult Factura(int idConcierto, FormCollection form)
        {
            var concierto = db.Conciertos
                .Where(c => c.IDConcierto == idConcierto)
                .Select(c => new
                {
                    c.IDConcierto,
                    c.Nombre,
                    c.Artista,
                    c.Fecha,
                    c.Localizacion,
                    Entradas = c.Entradas.Select(e => new
                    {
                        e.IDEntrada,
                        e.Localidad,
                        e.Precio
                    }).ToList()
                })
                .FirstOrDefault();

            if (concierto == null)
            {
                return HttpNotFound();
            }

            var entradas = new List<EntradaViewModel>();
            foreach (var entrada in concierto.Entradas)
            {
                string cantidadComprarStr = form["CantidadComprar_" + entrada.IDEntrada];
                if (!string.IsNullOrEmpty(cantidadComprarStr) && int.TryParse(cantidadComprarStr, out int cantidadComprar))
                {
                    entradas.Add(new EntradaViewModel
                    {
                        IDEntrada = entrada.IDEntrada,
                        Localidad = entrada.Localidad,
                        Precio = entrada.Precio,
                        CantidadComprar = cantidadComprar
                    });
                }
            }

            var facturaViewModel = new FacturaViewModel
            {
                IDConcierto = concierto.IDConcierto,
                Nombre = concierto.Nombre,
                Artista = concierto.Artista,
                Fecha = concierto.Fecha,
                Localizacion = concierto.Localizacion,
                Entradas = entradas
            };

            return View(facturaViewModel);
        }

        [HttpPost]
        public ActionResult ConfirmarCompraFinal(int IDConcierto, FormCollection form)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    var nuevaVenta = new VentaEntrada
                    {
                        IDEmpleado = 1
                    };
                    db.VentaEntradas.Add(nuevaVenta);
                    db.SaveChanges();

                    decimal total = 0;
                    foreach (var key in form.AllKeys.Where(k => k.StartsWith("CantidadComprar_")))
                    {
                        int idEntrada = int.Parse(key.Split('_')[1]);
                        int cantidadComprar = int.Parse(form[key]);

                        var entrada = db.Entradas.Find(idEntrada);
                        if (entrada != null && cantidadComprar <= entrada.CantidadDisponible)
                        {
                            entrada.CantidadDisponible -= cantidadComprar;
                            db.SaveChanges();

                            total += cantidadComprar * entrada.Precio;

                            var detalleEntrada = new DetallesEntrada
                            {
                                IDVenta = nuevaVenta.IDVenta,
                                IDEntrada = idEntrada,
                                Cantidad = cantidadComprar
                            };
                            db.DetallesEntradas.Add(detalleEntrada);
                            db.SaveChanges();
                        }
                    }

                    var nuevaFactura = new Factura
                    {
                        IDEmpleado = 1,
                        IDUsuario = 1,
                        IDVenta = nuevaVenta.IDVenta,
                        FechaVenta = DateTime.Now,
                        Subtotal = total
                    };
                    db.Facturas.Add(nuevaFactura);
                    db.SaveChanges();

                    transaction.Commit();

                  
                    return RedirectToAction("ComprarConcierto");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine(ex.InnerException?.Message ?? ex.Message);
                    throw;
                }
            }
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
