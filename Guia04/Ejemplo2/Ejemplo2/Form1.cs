using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        // Definición de la variable contaventas
        private int contaventas = 0; // Inicialización a 0

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            // Mostrará la página 2 del tabControl1
            tabControl1.SelectedIndex = 1;
            // Bloquea el ingreso a los controles del contenedor GroupBox1 (Detalle de Venta)
            groupBox1.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void InicializarControles()
        {
            // Prepara el entorno de trabajo inicial al cargar el Form
            tabControl1.TabPages[0].Text = "Ventas efectuadas";
            tabControl1.TabPages[1].Text = "Estadísticas de venta";
            tabControl1.SelectedIndex = 0;

            // Configura el DataGridView
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns.Add("numeventa", "#");
            dataGridView1.Columns.Add("montoventa", "Monto ($)");
            dataGridView1.Columns.Add("fechaventa", "Fecha Venta");
            dataGridView1.Columns.Add("trime", "Trimestral(1-4)");

            // Configura el DateTimePicker
            dateTimePicker1.MaxDate = Convert.ToDateTime("31/12/2015");
            dateTimePicker1.MinDate = Convert.ToDateTime("01/01/2014");
            dateTimePicker1.Value = Convert.ToDateTime("01/01/2015");

            label3.Text = "Totales ventas promedio por trimestre";
            maskedTextBox1.Focus();
        }

        private void RegistrarVenta(decimal MontoVe, DateTime Fecha)
        {
            int trimestre;
            switch (Fecha.Month)
            {
                case 1:
                case 2:
                case 3:
                    trimestre = 1;
                    break;
                case 4:
                case 5:
                case 6:
                    trimestre = 2;
                    break;
                case 7:
                case 8:
                case 9:
                    trimestre = 3;
                    break;
                default:
                    trimestre = 4;
                    break;
            }

            dataGridView1.Rows.Add();
            dataGridView1.Rows[contaventas].Cells[0].Value = contaventas + 1;
            dataGridView1.Rows[contaventas].Cells[1].Value = MontoVe;
            dataGridView1.Rows[contaventas].Cells[2].Value = Fecha.ToShortDateString();
            dataGridView1.Rows[contaventas].Cells[3].Value = trimestre;
            contaventas++;
        }

        private void EvaluacionTrimestral()
        {
            decimal[] TotVentaTrim = new decimal[5];
            int c;
            int tri;

            for (c = 0; c < contaventas; c++)
            {
                tri = Convert.ToInt32(dataGridView1.Rows[c].Cells["trime"].Value);
                decimal x = Convert.ToDecimal(dataGridView1.Rows[c].Cells["montoventa"].Value);
                TotVentaTrim[tri] += x;
            }

            for (c = 1; c < 5; c++)
            {
                listBox1.Items.Add("Trimestre " + c + ": $" + TotVentaTrim[c]);
            }
        }

        private void ValidarDatos()
        {
            decimal montov;
            if (decimal.TryParse(maskedTextBox1.Text, out montov))
            {
                RegistrarVenta(montov, dateTimePicker1.Value);
                maskedTextBox1.Clear();
                maskedTextBox1.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un monto válido.", "Error de entrada");
                maskedTextBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EvaluacionTrimestral();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Valida que solo se ingrese número en el maskedTextBox
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Monto de venta incorrecto. Solo se permiten números.");
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ValidarDatos();
        }
    }
}



