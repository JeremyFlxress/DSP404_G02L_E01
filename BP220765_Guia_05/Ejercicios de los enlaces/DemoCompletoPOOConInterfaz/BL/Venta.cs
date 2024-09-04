using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Venta
    {
        private string Cliente;
        private DateTime fecha;
        private List<Producto> productos;

        public Venta (string Cliente)
        {
            this.Cliente = Cliente;
            this.fecha = DateTime.Now;
            this.Productos = new List<Producto> ();
        }

        public List<Producto> Productos { get => productos; set => productos = value; }

        public void AgregarProducto (Producto producto)
        {
            Productos.Add (producto);
        }
        public decimal Total ()
        {
            decimal total = 0;
            foreach (Producto producto in Productos)
            {
                total += producto.Valor;
            }
            return total;
        }
    }
}






