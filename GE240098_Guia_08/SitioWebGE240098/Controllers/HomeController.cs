﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using SitioWebGE240098.Models;

namespace SitioWebGE240098.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //Dropdown categorias
            categoria ct = new categoria();
            Conexion obj = new Conexion();
            ct.Categorias = obj.getCategorias();
            ViewBag.OpcionesCat = ct.Categorias;
            //Dropdown empresa
            Empresa emp = new Empresa();
            emp.Empresas = obj.getEmpresas();
            ViewBag.OpcionesEmp = emp.Empresas;
            //Dropdown localidad
            Localidad loc = new Localidad();
            loc.Localidades = obj.getLocalidades();
            ViewBag.OpcionesLoc = loc.Localidades;
            //Ofertas
            ViewBag.Ofertas = obj.CargarDatos();
            return View();
        }

        [HttpPost]
        public ActionResult Index(string OpcionesCat, string OpcionesLoc, string OpcionesEmp)
        {
            int dcat, dloc, demp;
            dcat = Convert.ToInt16(OpcionesCat);
            dloc = Convert.ToInt16(OpcionesLoc);
            demp = Convert.ToInt16(OpcionesEmp);
            //Dropdown categorias
            categoria ct = new categoria();
            Conexion obj = new Conexion();
            ct.Categorias = obj.getCategorias();
            ViewBag.OpcionesCat = ct.Categorias;
            //Dropdown empresa
            Empresa emp = new Empresa();
            emp.Empresas = obj.getEmpresas();
            ViewBag.OpcionesEmp = emp.Empresas;
            //Dropdown localidad
            Localidad loc = new Localidad();
            loc.Localidades = obj.getLocalidades();
            ViewBag.OpcionesLoc = loc.Localidades;
            //Ofertas
            ViewBag.Ofertas = obj.CargarDatos(dcat, dloc, demp);
            return View();
        }
        [HttpPost]
        public ActionResult Nuevo()
        {
            List<SelectListItem> tcontrato = new List<SelectListItem>();
            tcontrato.Add(new SelectListItem { Text = "Permanente", Value = "1" });
            tcontrato.Add(new SelectListItem { Text = "Por Proyecto", Value = "2" });
            ViewBag.TipoC = tcontrato;
            List<SelectListItem> tjornada = new List<SelectListItem>();
            tjornada.Add(new SelectListItem { Text = "Tiempo Completo", Value = "1" });
            tjornada.Add(new SelectListItem { Text = "Por Horas", Value = "2" });
            ViewBag.TipoJ = tjornada;
            List<SelectListItem> tlocalidad = new List<SelectListItem>();
            tlocalidad.Add(new SelectListItem { Text = "Area", Value = "1" });
            tlocalidad.Add(new SelectListItem { Text = "Proximidad", Value = "2" });
            ViewBag.TipoL = tlocalidad;
            //Dropdown categorias
            categoria ct = new categoria();
            Conexion obj = new Conexion();
            ct.Categorias = obj.getCategorias();
            ViewBag.OpcionesCat = ct.Categorias;
            //Dropdown empresa
            Empresa emp = new Empresa();
            emp.Empresas = obj.getEmpresas();
            ViewBag.OpcionesEmp = emp.Empresas;
            //Dropdown localidad
            Localidad loc = new Localidad();
            loc.Localidades = obj.getLocalidades();
            ViewBag.OpcionesLoc = loc.Localidades;
            return View();
        }
        [HttpPost]
        public ActionResult Ingresardatos(string OpcionesCat, string OpcionesLoc, string OpcionesEmp,
            string sTituloOferta, string TipoJ, string TipoC, string fSalario, string TipoL,
            string dFechaPublicacion, string dFechaContratacion, string sDescripcion,
            string nVacantes)
        {
            Conexion obj = new Conexion();
            obj.conectar();
            obj.nuevaOferta(int.Parse(OpcionesEmp), sTituloOferta, int.Parse(TipoC), int.Parse(TipoJ),
           double.Parse(fSalario), int.Parse(OpcionesLoc), int.Parse(TipoL), int.Parse(OpcionesCat),
           dFechaPublicacion, sDescripcion, dFechaContratacion, int.Parse(nVacantes));
            obj.desconectar();
            int dcat, dloc, demp;
            dcat = Convert.ToInt16(OpcionesCat);
            dloc = Convert.ToInt16(OpcionesLoc);
            demp = Convert.ToInt16(OpcionesEmp);
            //Dropdown categorias
            categoria ct = new categoria();
            ct.Categorias = obj.getCategorias();
            ViewBag.OpcionesCat = ct.Categorias;
            //Dropdown empresa
            Empresa emp = new Empresa();
            emp.Empresas = obj.getEmpresas();
            ViewBag.OpcionesEmp = emp.Empresas;
            //Dropdown localidad
            Localidad loc = new Localidad();
            loc.Localidades = obj.getLocalidades();
            ViewBag.OpcionesLoc = loc.Localidades;
            //Ofertas
            Datos data = new Datos();
            data.DatosOfertas = obj.CargarDatos(dcat, dloc, demp);
            ViewBag.Ofertas = data.DatosOfertas;
            return View("Index");
        }
        [ActionName("Editar")]
        public ActionResult Editar(string nIdOferta)
        {
            List<SelectListItem> tcontrato = new List<SelectListItem>();
            tcontrato.Add(new SelectListItem { Text = "Permanente", Value = "1" });
            tcontrato.Add(new SelectListItem { Text = "Por Proyecto", Value = "2" });
            ViewBag.TipoC = tcontrato;
            List<SelectListItem> tjornada = new List<SelectListItem>();
            tjornada.Add(new SelectListItem { Text = "Tiempo Completo", Value = "1" });
            tjornada.Add(new SelectListItem { Text = "Por Horas", Value = "2" });
            ViewBag.TipoJ = tjornada;
            List<SelectListItem> tlocalidad = new List<SelectListItem>();
            tlocalidad.Add(new SelectListItem { Text = "Area", Value = "1" });
            tlocalidad.Add(new SelectListItem { Text = "Proximidad", Value = "2" });
            ViewBag.TipoL = tlocalidad;

            //Dropdown categorias
            categoria ct = new categoria();
            Conexion obj = new Conexion();
            ct.Categorias = obj.getCategorias();
            ViewBag.OpcionesCat = ct.Categorias;
            //Dropdown empresa
            Empresa emp = new Empresa();
            emp.Empresas = obj.getEmpresas();
            ViewBag.OpcionesEmp = emp.Empresas;
            //Dropdown localidad
            Localidad loc = new Localidad();
            loc.Localidades = obj.getLocalidades();
            ViewBag.OpcionesLoc = loc.Localidades;
            return View(obj.mostraroferta(int.Parse(nIdOferta)));
        }

        [ActionName("Actualizar")]
        public ActionResult Update(string nIdOferta, string OpcionesCat, string OpcionesLoc,
        string OpcionesEmp, string sTituloOferta, string TipoJ, string TipoC, string fSalario,
        string TipoL, string dFechaPublicacion, string dFechaContratacion,
        string sDescripcion, string nVacantes)
        {
            Conexion obj = new Conexion();
            obj.conectar();
            obj.actualizarOferta(int.Parse(nIdOferta), int.Parse(OpcionesEmp), sTituloOferta,
            int.Parse(TipoJ), int.Parse(TipoC), double.Parse(fSalario), int.Parse(OpcionesLoc), int.Parse(TipoL),
            int.Parse(OpcionesCat), sDescripcion, dFechaContratacion, int.Parse(nVacantes));
            obj.desconectar();
            int dcat, dloc, demp;
            dcat = Convert.ToInt16(OpcionesCat);
            dloc = Convert.ToInt16(OpcionesLoc);
            demp = Convert.ToInt16(OpcionesEmp);
            //Dropdown categorias
            categoria ct = new categoria();
            ct.Categorias = obj.getCategorias();
            ViewBag.OpcionesCat = ct.Categorias;
            //Dropdown empresa
            Empresa emp = new Empresa();
            emp.Empresas = obj.getEmpresas();
            ViewBag.OpcionesEmp = emp.Empresas;
            //Dropdown localidad
            Localidad loc = new Localidad();
            loc.Localidades = obj.getLocalidades();
            ViewBag.OpcionesLoc = loc.Localidades;
            //Ofertas
            Datos data = new Datos();
            data.DatosOfertas = obj.CargarDatos(dcat, dloc, demp);
            ViewBag.Ofertas = data.DatosOfertas;
            return View("Index");
        }

        [ActionName("Eliminar")]
        public ActionResult Delete(string nIdOferta)
        {
            Conexion obj = new Conexion();
            obj.conectar();
            obj.EliminarDatos(int.Parse(nIdOferta));
            obj.desconectar();

            //Dropdown categorias
            categoria ct = new categoria();
            ct.Categorias = obj.getCategorias();
            ViewBag.OpcionesCat = ct.Categorias;
            //Dropdown empresa
            Empresa emp = new Empresa();
            emp.Empresas = obj.getEmpresas();
            ViewBag.OpcionesEmp = emp.Empresas;
            //Dropdown localidad
            Localidad loc = new Localidad();
            loc.Localidades = obj.getLocalidades();
            ViewBag.OpcionesLoc = loc.Localidades;
            //Ofertas
            Datos data = new Datos();
            data.DatosOfertas = obj.CargarDatos();
            ViewBag.Ofertas = data.DatosOfertas;
            return View("Index");
        }
    }
}