using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioWebGE240098.Models
{
    public class categoria
    {
        public List<SelectListItem> Categorias { get; set; }
        public int nIdCategoria;
        public string sNombreCategoria;
    }
}