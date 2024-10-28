﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TurnoverTicket.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Turnover_SA_CVEntities1 : DbContext
    {
        public Turnover_SA_CVEntities1()
            : base("name=Turnover_SA_CVEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Concierto> Conciertos { get; set; }
        public virtual DbSet<DetallesEntrada> DetallesEntradas { get; set; }
        public virtual DbSet<Empleado> Empleadoes { get; set; }
        public virtual DbSet<Entrada> Entradas { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<HistorialCompra> HistorialCompras { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<VentaEntrada> VentaEntradas { get; set; }
        public object Factura { get; internal set; }
        public object Empleado { get; internal set; }

        public virtual int ST_ActualizarConcierto(Nullable<int> iDConcierto, string localizacion, string nombre, Nullable<System.DateTime> fecha)
        {
            var iDConciertoParameter = iDConcierto.HasValue ?
                new ObjectParameter("IDConcierto", iDConcierto) :
                new ObjectParameter("IDConcierto", typeof(int));
    
            var localizacionParameter = localizacion != null ?
                new ObjectParameter("Localizacion", localizacion) :
                new ObjectParameter("Localizacion", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ST_ActualizarConcierto", iDConciertoParameter, localizacionParameter, nombreParameter, fechaParameter);
        }
    
        public virtual int ST_ActualizarEntrada(Nullable<int> iDEntrada, Nullable<int> cantidadDisponible, Nullable<decimal> precio)
        {
            var iDEntradaParameter = iDEntrada.HasValue ?
                new ObjectParameter("IDEntrada", iDEntrada) :
                new ObjectParameter("IDEntrada", typeof(int));
    
            var cantidadDisponibleParameter = cantidadDisponible.HasValue ?
                new ObjectParameter("CantidadDisponible", cantidadDisponible) :
                new ObjectParameter("CantidadDisponible", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ST_ActualizarEntrada", iDEntradaParameter, cantidadDisponibleParameter, precioParameter);
        }
    
        public virtual int ST_ActualizarUsuario(Nullable<int> iDUsuario, string telefono)
        {
            var iDUsuarioParameter = iDUsuario.HasValue ?
                new ObjectParameter("IDUsuario", iDUsuario) :
                new ObjectParameter("IDUsuario", typeof(int));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ST_ActualizarUsuario", iDUsuarioParameter, telefonoParameter);
        }
    
        public virtual int ST_CrearConcierto(string localizacion, string nombre, Nullable<System.DateTime> fecha)
        {
            var localizacionParameter = localizacion != null ?
                new ObjectParameter("Localizacion", localizacion) :
                new ObjectParameter("Localizacion", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ST_CrearConcierto", localizacionParameter, nombreParameter, fechaParameter);
        }
    
        public virtual int ST_CrearEntrada(Nullable<int> iDConcierto, string localidad, Nullable<int> cantidadDisponible, Nullable<decimal> precio)
        {
            var iDConciertoParameter = iDConcierto.HasValue ?
                new ObjectParameter("IDConcierto", iDConcierto) :
                new ObjectParameter("IDConcierto", typeof(int));
    
            var localidadParameter = localidad != null ?
                new ObjectParameter("Localidad", localidad) :
                new ObjectParameter("Localidad", typeof(string));
    
            var cantidadDisponibleParameter = cantidadDisponible.HasValue ?
                new ObjectParameter("CantidadDisponible", cantidadDisponible) :
                new ObjectParameter("CantidadDisponible", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ST_CrearEntrada", iDConciertoParameter, localidadParameter, cantidadDisponibleParameter, precioParameter);
        }
    
        public virtual int ST_CrearUsuario(string nombres, string apellidos, string correo, string contraseña, string telefono)
        {
            var nombresParameter = nombres != null ?
                new ObjectParameter("Nombres", nombres) :
                new ObjectParameter("Nombres", typeof(string));
    
            var apellidosParameter = apellidos != null ?
                new ObjectParameter("Apellidos", apellidos) :
                new ObjectParameter("Apellidos", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var contraseñaParameter = contraseña != null ?
                new ObjectParameter("Contraseña", contraseña) :
                new ObjectParameter("Contraseña", typeof(string));
    
            var telefonoParameter = telefono != null ?
                new ObjectParameter("Telefono", telefono) :
                new ObjectParameter("Telefono", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ST_CrearUsuario", nombresParameter, apellidosParameter, correoParameter, contraseñaParameter, telefonoParameter);
        }
    
        public virtual int ST_EliminarConcierto(Nullable<int> iDConcierto)
        {
            var iDConciertoParameter = iDConcierto.HasValue ?
                new ObjectParameter("IDConcierto", iDConcierto) :
                new ObjectParameter("IDConcierto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ST_EliminarConcierto", iDConciertoParameter);
        }
    
        public virtual int ST_EliminarEntrada(Nullable<int> iDEntrada)
        {
            var iDEntradaParameter = iDEntrada.HasValue ?
                new ObjectParameter("IDEntrada", iDEntrada) :
                new ObjectParameter("IDEntrada", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ST_EliminarEntrada", iDEntradaParameter);
        }
    
        public virtual int ST_EliminarUsuario(Nullable<int> iDUsuario)
        {
            var iDUsuarioParameter = iDUsuario.HasValue ?
                new ObjectParameter("IDUsuario", iDUsuario) :
                new ObjectParameter("IDUsuario", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ST_EliminarUsuario", iDUsuarioParameter);
        }
    
        public virtual ObjectResult<ST_LeerConciertos_Result> ST_LeerConciertos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ST_LeerConciertos_Result>("ST_LeerConciertos");
        }
    
        public virtual ObjectResult<ST_LeerEntradas_Result> ST_LeerEntradas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ST_LeerEntradas_Result>("ST_LeerEntradas");
        }
    
        public virtual ObjectResult<ST_LeerUsuarios_Result> ST_LeerUsuarios()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ST_LeerUsuarios_Result>("ST_LeerUsuarios");
        }
    }
}