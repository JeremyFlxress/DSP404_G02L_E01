using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnoverTicket.Models
{
    public class ComprarConcierto
    {
        
       
    public int IDConcierto { get; set; }
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public DateTime Fecha { get; set; }
        public string Localizacion { get; set; }
        public decimal PrecioDesde { get; set; }
    

}
}