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
        public string NombreConcierto { get; set; }
        public int IDEntrada { get; set; }
        public string Localidad { get; set; }
        public decimal Precio { get; set; }
        public int CantidadDisponible { get; set; }
        public int CantidadComprar { get; set; } // Cambié a 'int' porque debería ser un número entero.

        public DateTime FechaConcierto { get; set; }
        public string Artista { get; set; }
    
        public int CantidadEntradas { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal SubtotalDetalle { get; set; }
    }

}