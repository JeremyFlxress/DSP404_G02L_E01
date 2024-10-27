using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return RedirectToAction("Factura", new { idConcierto = IDConcierto, form });
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
            using (var dbContext = new Turnover_SA_CVEntities())
            {
                DbContextTransaction transaction = null;
                try
                {
                    // Aseguramos que la conexión está abierta
                    if (dbContext.Database.Connection.State != System.Data.ConnectionState.Open)
                    {
                        dbContext.Database.Connection.Open();
                    }

                    // Iniciamos la transacción después de asegurar la conexión
                    transaction = dbContext.Database.BeginTransaction();

                    var nuevaVenta = new VentaEntradas
                    {
                        IDEmpleado = 1, // ID del empleado de prueba
                        FechaVenta = DateTime.Now
                    };
                    dbContext.VentaEntradas.Add(nuevaVenta);
                    dbContext.SaveChanges(); // Guardamos para obtener el ID de la venta

                    decimal total = 0;

                    foreach (var key in form.AllKeys.Where(k => k.StartsWith("CantidadComprar_")))
                    {
                        int idEntrada = int.Parse(key.Split('_')[1]);
                        int cantidadComprar = int.Parse(form[key]);

                        var entrada = dbContext.Entradas.Find(idEntrada);
                        if (entrada != null && cantidadComprar <= entrada.CantidadDisponible)
                        {
                            entrada.CantidadDisponible -= cantidadComprar;
                            total += cantidadComprar * entrada.Precio;

                            var detalleEntrada = new DetallesEntradas
                            {
                                IDVenta = nuevaVenta.IDVenta,
                                IDEntrada = idEntrada,
                                Cantidad = cantidadComprar
                            };
                            dbContext.DetallesEntradas.Add(detalleEntrada);
                        }
                        else
                        {
                            if (transaction != null)
                            {
                                transaction.Rollback();
                            }
                            throw new InvalidOperationException("La cantidad solicitada es mayor a la disponible.");
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
                    dbContext.Factura.Add(nuevaFactura);

                    dbContext.SaveChanges();
                    transaction.Commit();

                    return RedirectToAction("ComprarConcierto");
                }
                catch (Exception ex)
                {
                    if (transaction != null)
                    {
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (InvalidOperationException)
                        {
                            // Log error de rollback si es necesario
                        }
                    }
                    // Log del error original
                    Console.WriteLine(ex.Message);
                    throw;
                }
                finally
                {
                    if (transaction != null)
                    {
                        transaction.Dispose();
                    }
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
