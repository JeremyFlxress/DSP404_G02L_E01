//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TurnoverTicket.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistorialCompra
    {
        public int IDHistorial { get; set; }
        public Nullable<int> IDFactura { get; set; }
        public Nullable<System.DateTime> FechaCompra { get; set; }
        public int CantidadEntradas { get; set; }
    
        public virtual Factura Factura { get; set; }
    }
}