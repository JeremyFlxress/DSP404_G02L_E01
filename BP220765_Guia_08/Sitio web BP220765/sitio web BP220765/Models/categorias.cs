using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SitioWebBP220765.Models
{
    public class categorias
    {
        public List<SelectListItem> Categorias { get; set; }
        public int nIdCategoria;
        public string sNombreCategoria;
    }
}