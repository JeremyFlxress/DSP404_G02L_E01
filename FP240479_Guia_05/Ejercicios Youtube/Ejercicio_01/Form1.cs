using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Ejercicio_01
{
    public partial class Form1 : Form
    {
        private Venta venta;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (venta == null)
            {
                MessageBox.Show("Debe asignar un cliente", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCliente.Focus();
                return;
            }

            //Validaciones para el ID
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un ID", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }

            int id = 0;
            if (!int.TryParse(txtID.Text, out id))
            {
                MessageBox.Show("Debe ingresar un ID entero", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }

            if(id <= 0)
            {
                MessageBox.Show("Debe ingresar un ID mayor a cero", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtID.Focus();
                return;
            }
            //Fin validaciones txtID

            //Validaciones para la descripcion
            if (txtDescripcion.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una Descripción", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDescripcion.Focus();
                return;
            }
            //Fin  validaciones para la descripción

            //Validaciones para el precio
            if (txtPrecio.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar un precio", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPrecio.Focus();
                return;
            }

            decimal precio = 0;
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("Debe ingresar un precio numérico", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPrecio.Focus();
                return;
            }

            if (precio <= 0)
            {
                MessageBox.Show("Debe ingresar un precio mayor a cero", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPrecio.Focus();
                return;
            }
            //Fin validaciones precio

            //Validaciones para la cantidad
            if (txtCantidad.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una cantidad", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCantidad.Focus();
                return;
            }

            float cantidad = 0;
            if (!float.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("Debe ingresar una cantidad numérica", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCantidad.Focus();
                return;
            }

            if (cantidad <= 0)
            {
                MessageBox.Show("Debe ingresar una cantidad mayor a cero", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCantidad.Focus();
                return;
            }
            //Fin validaciones cantidad

            Producto producto = new Producto();
            producto.ID = id;
            producto.Descripcion = txtDescripcion.Text;
            producto.Precio = precio;
            producto.Cantidad = cantidad;

            venta.AgregarProducto(producto);

            detalleDataGridView.DataSource = null;
            detalleDataGridView.DataSource = venta.Productos;

            //Limpiar los TextBox
            txtCantidad.Clear();
            txtDescripcion.Clear();
            txtID.Clear();
            txtPrecio.Clear();

            txtID.Focus();
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            string cliente = txtCliente.Text;
            if(cliente == string.Empty)
            {
                MessageBox.Show("Debe ingresar un cliente", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCliente.Focus();
                return;
            }

            venta = new Venta(cliente);
            detalleDataGridView.DataSource = venta.Productos;
        }

        private void btnPagar_Click(object sender, EventArgs e)
        { 
            DialogResult rta = MessageBox.Show(this, string.Format(
                "El total de la cuenta es: {0:C2}\n" + "¿Desea pagar?", 
                venta.Total()), 
                "Total",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if(rta == DialogResult.No)
            {
                return;
            }
            venta = null;
            txtCliente.Clear();
            txtCliente.Focus();
            detalleDataGridView.DataSource = null;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
