using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioWebdeFP240479_New.Models
{
    public class Categorias
    {
        public List<SelectListItem> categorias { get; set; }
        public int nIdCategoria;
        public string sNombreCategoria;
    }
}