using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioWeb_GM240279.Models
{
    public class Category
    {
        public List<SelectListItem> Categorias { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}
