using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ejercicio_Guia_08.Models
{
    public class categorias
    {
        public List<SelectListItem> Categorias { get; set; }
        public int nIdCategoria;
        public string sNombreCategoria;
    }
}