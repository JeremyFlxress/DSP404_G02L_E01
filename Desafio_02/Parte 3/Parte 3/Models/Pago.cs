using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parte_3.Models
{
    public class Pago : Controller
    {
		// GET: Pago
		public string NombreCompleto { get; set; }
		public string CorreoElectronico { get; set; }
		public string Telefono { get; set; }
		public string Direccion { get; set; }
		public decimal Total { get; set; } // Total a pagar
	}
}