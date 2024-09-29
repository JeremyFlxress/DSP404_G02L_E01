using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitioWeb9_GE240098.Models
{
    public class Category
    {
        public List<SelectListItem> Categorias { get; set; }
        public string CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int Description { get; set; }
    }
}