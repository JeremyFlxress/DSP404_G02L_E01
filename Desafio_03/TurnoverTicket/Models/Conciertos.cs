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
    
    public partial class Conciertos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Conciertos()
        {
            this.Entradas = new HashSet<Entradas>();
        }
    
        public int IDConcierto { get; set; }
        public string Localizacion { get; set; }
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public System.DateTime Fecha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entradas> Entradas { get; set; }
    }
}
