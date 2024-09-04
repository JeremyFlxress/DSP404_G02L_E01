using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_POO_Interfaz
{
    internal class Venta
    {
        private string cliente;
        private DateTime fecha;
        private List<Productos> productos;

        public Venta(string cliente) { 
            this.cliente = cliente;
            this.fecha = DateTime.Now;
            this.productos = new List<Productos>();
        }

        public void AgregarProducto(Productos producto)
        {
            productos.Add(producto);
        }

        public decimal Total()
        {
            decimal total = 0;
            foreach (Productos producto in productos) {
                total += producto.Valor;
            }
            return total;
        }
    }
}
