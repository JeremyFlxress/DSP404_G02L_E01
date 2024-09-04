using BL;

namespace GUI
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
                MessageBox.Show("Debe asignar un cliente");
                clienteTextBox.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(idTextBox.Text))
            {
                MessageBox.Show("Debe ingresar un ID");
                idTextBox.Focus();
                return;
            }

            if (!int.TryParse(idTextBox.Text, out int id) || id <= 0)
            {
                MessageBox.Show("Debe ingresar un ID numérico entero mayor a cero");
                idTextBox.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(DescripcionTextBox.Text))
            {
                MessageBox.Show("Debe ingresar una descripción");
                DescripcionTextBox.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(PrecioTextBox1.Text) || !decimal.TryParse(PrecioTextBox1.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Debe ingresar un precio ");
                PrecioTextBox1.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(CantidadTextBox2.Text) || !float.TryParse(CantidadTextBox2.Text, out float cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Debe ingresar una cantidad ");
                CantidadTextBox2.Focus();
                return;
            }


            Producto producto = new Producto
            {
                Id = id,
                Descripcion = DescripcionTextBox.Text,
                Precio = precio,
                Cantidad = cantidad
            };

            venta.AgregarProducto(producto);
            MessageBox.Show("Producto agregado correctamente.");

            dtg.DataSource = null;
            dtg.DataSource = venta.Productos;
            idTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            PrecioTextBox1.Text = string.Empty;
            CantidadTextBox2.Text = string.Empty;
            idTextBox.Focus();



        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            // Validar el nombre del cliente
            if (string.IsNullOrWhiteSpace(clienteTextBox.Text))
            {
                MessageBox.Show("Debe ingresar un cliente");
                clienteTextBox.Focus();
                return;
            }

            // Asignar la venta al cliente
            venta = new Venta(clienteTextBox.Text);
            dtg.DataSource = venta.Productos;
            MessageBox.Show("Cliente asignado correctamente.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            DialogResult rta = MessageBox.Show(this, string.Format("Su cuenta es : {0:C2}\n"
                 + "¿Desea paagar?",
                 venta.Total()), "Pagar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (rta == DialogResult.No)
            {
                venta = null;
                clienteTextBox.Text = string.Empty;
                clienteTextBox.Focus();
                dtg.DataSource = null;
    }
            

    }
}
}


