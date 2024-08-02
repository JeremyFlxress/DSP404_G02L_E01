namespace Discusion4
{
    public partial class Form1 : Form
    {
        // Diccionario para almacenar las tasas de cambio relativas al USD
        private readonly Dictionary<string, double> exchangeRates = new Dictionary<string, double>
    {
      { "USD", 1.0 },
      { "EUR", 0.85 },
      { "JPY", 110.0 },
      { "GBP", 0.75 },
      { "AUD", 1.35 }
    };

        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();
            btnCalcular.Click += new EventHandler(btnCalcular_Click);
        }

        private void InitializeComboBoxes()
        {
            cmbInicial.Items.AddRange(exchangeRates.Keys.ToArray());
            cmbFinal.Items.AddRange(exchangeRates.Keys.ToArray());

            cmbInicial.SelectedIndex = 0;
            cmbFinal.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Implementar la lógica de conversión aquí
            if (double.TryParse(txtValor.Text, out double valor) && valor >= 0)
            {
                string divisaInicial = cmbInicial.SelectedItem.ToString();
                string divisaFinal = cmbFinal.SelectedItem.ToString();

                // Obtener las tasas de cambio desde el diccionario
                double tasaInicial = exchangeRates[divisaInicial];
                double tasaFinal = exchangeRates[divisaFinal];

                // **Implementar la lógica de conversión aquí**
                double valorConvertido = valor * (tasaFinal / tasaInicial);

                // Mostrar el resultado
                lblResultado1.Text = $"{valor} {divisaInicial} = {valorConvertido:F2} {divisaFinal}";
            }
            else
            {

            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor.Clear();
            lblResultado1.Text = string.Empty;
            txtValor.BackColor = Color.White;
            cmbInicial.SelectedIndex = 0;
            cmbFinal.SelectedIndex = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
