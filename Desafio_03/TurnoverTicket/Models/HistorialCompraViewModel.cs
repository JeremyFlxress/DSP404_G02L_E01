using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnoverTicket.Models
{
    public class HistorialComprasViewModel
    {
        public int IDHistorial { get; set; }
        public int IDFactura { get; set; }
        public DateTime FechaCompra { get; set; }
        public int CantidadEntradas { get; set; }
    }

    public class DetalleCompraViewModel
    {
        public string NombreConcierto { get; set; }
        public string Artista { get; set; }
        public DateTime FechaConcierto { get; set; }
        public string Localidad { get; set; }
        public int CantidadEntradas { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal SubtotalDetalle { get; set; }
    }




}