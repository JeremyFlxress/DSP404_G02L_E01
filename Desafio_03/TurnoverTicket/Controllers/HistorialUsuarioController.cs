using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TurnoverTicket.Models;
using System.Data.Entity;

namespace TurnoverTicket.Controllers
{
    public class HistorialUsuarioController : Controller
    {
        private Turnover_SA_CVEntities1 db = new Turnover_SA_CVEntities1();

        private int ObtenerUsuarioActual()
        {
            if (Session["IDUsuario"] != null)
            {
                return Convert.ToInt32(Session["IDUsuario"]);
            }
            // Si no hay usuario en sesión, redirigir al login
            throw new UnauthorizedAccessException("Usuario no autenticado");
        }

        // GET: HistorialUsuario
        public ActionResult HistorialUsuario()
        {
            try
            {
                int usuarioActual = ObtenerUsuarioActual();
                Console.WriteLine("Usuario Actual: " + usuarioActual); // Verificar el ID del usuario

                var facturas = db.Facturas
                    .Include(f => f.VentaEntrada)
                    .Include(f => f.VentaEntrada.DetallesEntradas)
                    .Include(f => f.VentaEntrada.DetallesEntradas.Select(d => d.Entrada))
                    .Include(f => f.VentaEntrada.DetallesEntradas.Select(d => d.Entrada.Concierto))
                    .Where(f => f.IDUsuario == usuarioActual) // Filtrar por usuario actual
                    .OrderByDescending(f => f.FechaVenta)
                    .Select(f => new FacturaViewModel
                    {
                        IDConcierto = f.VentaEntrada.DetallesEntradas.FirstOrDefault().Entrada.Concierto.IDConcierto,
                        Nombre = f.VentaEntrada.DetallesEntradas.FirstOrDefault().Entrada.Concierto.Nombre,
                        Artista = f.VentaEntrada.DetallesEntradas.FirstOrDefault().Entrada.Concierto.Artista,
                        Fecha = f.VentaEntrada.DetallesEntradas.FirstOrDefault().Entrada.Concierto.Fecha,
                        Localizacion = f.VentaEntrada.DetallesEntradas.FirstOrDefault().Entrada.Concierto.Localizacion,
                        Entradas = f.VentaEntrada.DetallesEntradas.Select(d => new EntradaViewModel
                        {
                            IDEntrada = d.IDEntrada,
                            Localidad = d.Entrada.Localidad,
                            Precio = d.Entrada.Precio,
                            CantidadComprar = d.Cantidad
                        }).ToList()
                    })
                    .ToList();

                // Verificar el contenido de facturas
                Console.WriteLine("Facturas: " + facturas.Count); // Verificar la cantidad de facturas obtenidas

                if (!facturas.Any())
                {
                    ViewBag.Error = "No se encontraron facturas para el usuario actual.";
                }

                // Enviar las facturas a la vista HistorialUsuario
                return View(facturas);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error al cargar las facturas: " + ex.Message;
                return View(new List<FacturaViewModel>());
            }
        }
    }
}