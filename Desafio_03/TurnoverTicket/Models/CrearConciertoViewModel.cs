using System;
using System.ComponentModel.DataAnnotations;

namespace TurnoverTicket.Models
{
    public class CrearConciertoViewModel
    {
        // Propiedades del Concierto
        [Required(ErrorMessage = "El nombre del concierto es requerido")]
        [Display(Name = "Nombre del concierto")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El nombre del artista es requerido")]
        [Display(Name = "Nombre del artista")]
        [StringLength(100)]
        public string Artista { get; set; }

        [Required(ErrorMessage = "La fecha del concierto es requerida")]
        [Display(Name = "Fecha del concierto")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "La localización es requerida")]
        [Display(Name = "Localización")]
        [StringLength(100)]
        public string Localizacion { get; set; }

        // Propiedades para Entradas VIP
        [Required(ErrorMessage = "La cantidad de entradas VIP es requerida")]
        [Display(Name = "Número de entradas VIP")]
        [Range(0, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor o igual a 0")]
        public int CantidadVIP { get; set; }

        [Required(ErrorMessage = "El precio de entradas VIP es requerido")]
        [Display(Name = "Precio entradas VIP")]
        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 0")]
        [DataType(DataType.Currency)]
        public decimal PrecioVIP { get; set; }

        // Propiedades para Entradas General
        [Required(ErrorMessage = "La cantidad de entradas General es requerida")]
        [Display(Name = "Número de entradas General")]
        [Range(0, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor o igual a 0")]
        public int CantidadGeneral { get; set; }

        [Required(ErrorMessage = "El precio de entradas General es requerido")]
        [Display(Name = "Precio entradas General")]
        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 0")]
        [DataType(DataType.Currency)]
        public decimal PrecioGeneral { get; set; }

        // Propiedades para Entradas Platea
        [Required(ErrorMessage = "La cantidad de entradas Platea es requerida")]
        [Display(Name = "Número de entradas Platea")]
        [Range(0, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor o igual a 0")]
        public int CantidadPlatea { get; set; }

        [Required(ErrorMessage = "El precio de entradas Platea es requerido")]
        [Display(Name = "Precio entradas Platea")]
        [Range(0, double.MaxValue, ErrorMessage = "El precio debe ser mayor o igual a 0")]
        [DataType(DataType.Currency)]
        public decimal PrecioPlatea { get; set; }
    }
}