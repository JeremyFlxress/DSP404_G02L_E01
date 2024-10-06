using System;
using System.Collections.Generic;
using System.Data;
using System.Web.Mvc;
using SitioWeb_GM240279.Models;

namespace SitioWeb_GM240279.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Index()
        {
            conexionDesconetada datos = new conexionDesconetada();
            datos.copiarBaseDatos();

            Category listcat = new Category();
            List<SelectListItem> itemscat = new List<SelectListItem>();

            Suppliers listsup = new Suppliers();
            List<SelectListItem> itemssupp = new List<SelectListItem>();

            List<Product> itemproducts = new List<Product>();

            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Categories"].Rows)
            {
                itemscat.Add(new SelectListItem { Text = dr["CategoryName"].ToString(), Value = dr["CategoryId"].ToString() });
            }

            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Suppliers"].Rows)
            {
                itemssupp.Add(new SelectListItem { Text = dr["CompanyName"].ToString(), Value = dr["SupplierID"].ToString() });
            }

            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Products"].Rows)
            {
                itemproducts.Add(new Product
                {
                    ProductID = dr["ProductID"].ToString(),
                    ProductName = dr["ProductName"].ToString(),
                    SupplierID = dr["SupplierID"].ToString(),
                    CategoryID = dr["CategoryID"].ToString(),
                    QuantityPerUnit = dr["QuantityPerUnit"].ToString(),
                    UnitPrice = dr["UnitPrice"].ToString(),
                    UnitsInStock = dr["UnitsInStock"].ToString(),
                    UnitsOnOrder = dr["UnitsOnOrder"].ToString()
                });
            }

            ViewBag.productos = itemproducts;
            listsup.proveedores = itemssupp;
            ViewBag.proveedores = listsup.proveedores;
            listcat.Categorias = itemscat;
            ViewBag.Categorias = listcat.Categorias;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Categorias, string Proveedores)
        {
            // Similar lógica que en el método Index GET pero aplicando filtros
        }

        [HttpPost]
        public ActionResult Ingresardatos(string Categorias, string Proveedores, string ProductName, string QuantityPerUnit, string UnitPrice, string UnitsInStock, string UnitsOnOrder)
        {
            // Inserción de datos de un nuevo producto
        }

        public ActionResult Edit(string ProductID)
        {
            // Método para cargar la vista de edición
        }

        public ActionResult Actualizar(string ProductID, string Categorias, string Proveedores, string ProductName, string QuantityPerUnit, string UnitPrice, string UnitsInStock, string UnitsOnOrder)
        {
            // Método para actualizar los datos del producto
        }

        public ActionResult Eliminar(string ProductID)
        {
            // Método para eliminar un producto
        }
    }
}
