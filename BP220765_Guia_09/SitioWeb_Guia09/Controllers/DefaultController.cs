using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SitioWeb_Guia09.Models;
using System.Data;
using System.EnterpriseServices.Internal;

namespace SitioWeb_Guia09.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            conexionDesconectada datos = new conexionDesconectada();
            datos.copiarBaseDatos();

            Category listcat = new Category();
            List<SelectListItem> itemscat = new List<SelectListItem>();

            Suppliers listsup = new Suppliers();
            List<SelectListItem> itemssupp = new List<SelectListItem>();

            List<Product> itemproducts = new List<Product>();
            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Categories"].Rows)
            {
                itemscat.Add(new SelectListItem
                {
                    Text = dr["CategoryName"].ToString(),
                    Value = dr["CategoryId"].ToString()
                });
            }
            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Suppliers"].Rows)
            {
                itemssupp.Add(new SelectListItem
                {
                    Text = dr["CompanyName"].ToString(),
                    Value = dr["SupplierID"].ToString()
                });
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
            conexionDesconectada datos = new conexionDesconectada();
            datos.copiarBaseDatos();

            Category listcat = new Category();
            List<SelectListItem> itemscat = new List<SelectListItem>();

            Suppliers listsup = new Suppliers();
            List<SelectListItem> itemssupp = new List<SelectListItem>();

            Product listprod = new Product();
            List<Product> itemproducts = new List<Product>();

            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Categories"].Rows)
            {
                itemscat.Add(new SelectListItem
                {
                    Text = dr["CategoryName"].ToString(),
                    Value = dr["CategoryId"].ToString()
                });
            }

            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Suppliers"].Rows)
            {
                itemssupp.Add(new SelectListItem
                {
                    Text = dr["CompanyName"].ToString(),
                    Value = dr["SupplierID"].ToString()
                });
            }

            //Cargamos un dataview ya que el nos permite hacer filtros
            //sobre la tabla seleccionada

            DataView vistaFiltro = new DataView(datos.DataSetPrincipal.Tables["Products"]);
            if (Categorias != "0")
            {
                vistaFiltro.RowFilter = "CategoryID = " + Categorias;
            }
            if (Proveedores != "0")
            {
                vistaFiltro.RowFilter = "SupplierID = " + Proveedores;
            }


            foreach (DataRowView dr in vistaFiltro)
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
            listprod.Productos = itemproducts;
            ViewBag.productos = listprod.Productos;
            listsup.proveedores = itemssupp;
            ViewBag.proveedores = listsup.proveedores;
            listcat.Categorias = itemscat;
            ViewBag.Categorias = listcat.Categorias;
            return View();
        }

        [HttpPost]
        public ActionResult IngresarDatos(string Categorias, string Proveedores, string ProductName,
            string QuantityPerUnit, string UnitPrice, string UnitsInStock, string UnitsOnOrder)
        {
            conexionDesconectada datos = new conexionDesconectada();
            datos.copiarBaseDatos();

            datos.insertarProducto(datos.DataSetPrincipal, Categorias,
            Proveedores, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder);

            Category listcat = new Category();
            List<SelectListItem> itemscat = new List<SelectListItem>();

            Suppliers listsup = new Suppliers();
            List<SelectListItem> itemssupp = new List<SelectListItem>();

            Product listprod = new Product();
            List<Product> itemproducts = new List<Product>();

            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Categories"].Rows)
            {
                itemscat.Add(new SelectListItem
                {
                    Text = dr["CategoryName"].ToString(),
                    Value = dr["CategoryId"].ToString()
                });
            }

            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Suppliers"].Rows)
            {
                itemssupp.Add(new SelectListItem
                {
                    Text = dr["CompanyName"].ToString(),
                    Value = dr["SupplierID"].ToString()
                });
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
            listprod.Productos = itemproducts;
            ViewBag.productos = listprod.Productos;
            listsup.proveedores = itemssupp;
            ViewBag.proveedores = listsup.proveedores;
            listcat.Categorias = itemscat;
            ViewBag.Categorias = listcat.Categorias;
            return View("Index");
        }
        [ActionName("Actualizar")]
        public ActionResult Actualizar(string ProductID, string Categorias, string Proveedores,
            string ProductName, string QuantityPerUnit, string UnitPrice, string UnitsInStock,
            string UnitsOnOrder)
        {
            conexionDesconectada datos = new conexionDesconectada();
            datos.copiarBaseDatos();

            datos.actualizarProducto(datos.DataSetPrincipal, int.Parse(ProductID), Categorias,
            Proveedores, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder);

            Category listcat = new Category();
            List<SelectListItem> itemscat = new List<SelectListItem>();

            Suppliers listsup = new Suppliers();
            List<SelectListItem> itemssupp = new List<SelectListItem>();

            Product listprod = new Product();
            List<Product> itemproducts = new List<Product>();

            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Categories"].Rows)
            {
                itemscat.Add(new SelectListItem
                {
                    Text = dr["CategoryName"].ToString(),
                    Value = dr["CategoryId"].ToString()
                });
            }

            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Suppliers"].Rows)
            {
                itemssupp.Add(new SelectListItem
                {
                    Text = dr["CompanyName"].ToString(),
                    Value = dr["SupplierID"].ToString()
                });
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
            listprod.Productos = itemproducts;
            ViewBag.productos = listprod.Productos;
            listsup.proveedores = itemssupp;
            ViewBag.proveedores = listsup.proveedores;
            listcat.Categorias = itemscat;
            ViewBag.Categorias = listcat.Categorias;
            return View("Index");
        }

        [HttpPost]
        public ActionResult Add()
        {
            conexionDesconectada datos = new conexionDesconectada();
            datos.copiarBaseDatos();

            Category listcat = new Category();
            List<SelectListItem> itemscat = new List<SelectListItem>();

            Suppliers listsup = new Suppliers();
            List<SelectListItem> itemssupp = new List<SelectListItem>();

            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Categories"].Rows)
            {
                itemscat.Add(new SelectListItem
                {
                    Text = dr["CategoryName"].ToString(),
                    Value = dr["CategoryId"].ToString()
                });
            }

            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Suppliers"].Rows)
            {
                itemssupp.Add(new SelectListItem
                {
                    Text = dr["CompanyName"].ToString(),
                    Value = dr["SupplierID"].ToString()
                });
            }

            listsup.proveedores = itemssupp;
            ViewBag.proveedores = listsup.proveedores;
            listcat.Categorias = itemscat;
            ViewBag.Categorias = listcat.Categorias;
            return View();
        }

        [ActionName("Edit")]
        public ActionResult Edit(string ProductID)
        {
            conexionDesconectada datos = new conexionDesconectada();
            datos.copiarBaseDatos();

            Category listcat = new Category();
            List<SelectListItem> itemscat = new List<SelectListItem>();

            Suppliers listsup = new Suppliers();
            List<SelectListItem> itemssupp = new List<SelectListItem>();

            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Categories"].Rows)
            {
                itemscat.Add(new SelectListItem
                {
                    Text = dr["CategoryName"].ToString(),
                    Value = dr["CategoryId"].ToString()
                });
            }

            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Suppliers"].Rows)
            {
                itemssupp.Add(new SelectListItem
                {
                    Text = dr["CompanyName"].ToString(),
                    Value = dr["SupplierID"].ToString()
                });
            }
            listsup.proveedores = itemssupp;
            ViewBag.proveedores = listsup.proveedores;
            listcat.Categorias = itemscat;
            ViewBag.Categorias = listcat.Categorias;
            return View(datos.mostrarDatos(int.Parse(ProductID), datos.DataSetPrincipal));
        }

        [ActionName("Eliminar")]
        public ActionResult Eliminar(string ProductID)
        {
            conexionDesconectada datos = new conexionDesconectada();
            datos.copiarBaseDatos();

            datos.eliminarProducto(datos.DataSetPrincipal, int.Parse(ProductID));

            Product listprod = new Product();
            List<Product> itemproducts = new List<Product>();

            Category listcat = new Category();
            List<SelectListItem> itemscat = new List<SelectListItem>();

            Suppliers listsup = new Suppliers();
            List<SelectListItem> itemssupp = new List<SelectListItem>();

            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Categories"].Rows)
            {
                itemscat.Add(new SelectListItem
                {
                    Text = dr["CategoryName"].ToString(),
                    Value = dr["CategoryId"].ToString()
                });
            }
            foreach (DataRow dr in datos.DataSetPrincipal.Tables["Suppliers"].Rows)
            {
                itemssupp.Add(new SelectListItem
                {
                    Text = dr["CompanyName"].ToString(),
                    Value = dr["SupplierID"].ToString()
                });
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
            listprod.Productos = itemproducts;
            ViewBag.productos = listprod.Productos;
            listsup.proveedores = itemssupp;
            ViewBag.proveedores = listsup.proveedores;
            listcat.Categorias = itemscat;
            ViewBag.Categorias = listcat.Categorias;
            return View("Index");
        }
    }
}