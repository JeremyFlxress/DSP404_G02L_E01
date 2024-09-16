using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitioWebBP220765.Models
{
    public class Localidad
    {
        public List<SelectListItem> Localidades { get; set; }
        public int nIdMunicipio;
        public string sNombreMunicipio;
        public int nIdPais;
    }
}
