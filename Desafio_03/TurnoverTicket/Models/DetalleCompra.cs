using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnoverTicket.Models
{
    public class DetalleCompra
    {
    }
    public class DetalleConciertoViewModel
    {
        public int IDConcierto { get; set; }
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public DateTime Fecha { get; set; }
        public string Localizacion { get; set; }
        public List<EntradaViewModel> Entradas { get; set; }
    }

    public class EntradaViewModel
    {
        public int IDEntrada { get; set; }
        public string Localidad { get; set; }
        public decimal Precio { get; set; }
        public int CantidadDisponible { get; set; }
        public decimal CantidadComprar { get; internal set; }
    }
}