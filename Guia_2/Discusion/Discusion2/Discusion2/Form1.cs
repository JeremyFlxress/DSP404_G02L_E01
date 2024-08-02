namespace Discusion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Leer los 4 números del usuario
            double[] numeros = new double[4];
            try
            {
                numeros[0] = double.Parse(txtNumero1.Text);
                numeros[1] = double.Parse(txtNumero2.Text);
                numeros[2] = double.Parse(txtNumero3.Text);
                numeros[3] = double.Parse(txtNumero4.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese 4 números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcular el promedio
            double promedio = numeros.Average();

            // Calcular la desviación típica
            double sumatoria = numeros.Sum(x => Math.Pow(x - promedio, 2));
            double desviacionTipica = Math.Sqrt(sumatoria / numeros.Length);

            // Mostrar resultados
            txtPromedio.Text = promedio.ToString();
            txtDesviacionTipica.Text = desviacionTipica.ToString();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            txtNumero3.Clear();
            txtNumero4.Clear();
            txtPromedio.Clear();
            txtDesviacionTipica.Clear();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
