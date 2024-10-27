using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnoverTicket.Models
{
    public class FacturaCompra
    {
    }
    public class FacturaViewModel
    {
        public int IDConcierto { get; set; }
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public DateTime Fecha { get; set; }
        public string Localizacion { get; set; }
        public List<EntradaViewModel> Entradas { get; set; }

        public decimal Total
        {
            get
            {
                return Entradas.Sum(e => e.Precio * e.CantidadComprar);
            }
        }
    }

    public class EntradaViewModel1
    {
        public int IDEntrada { get; set; }
        public string Localidad { get; set; }
        public decimal Precio { get; set; }
        public int CantidadComprar { get; set; }
    }

}