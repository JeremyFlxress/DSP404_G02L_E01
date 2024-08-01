using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complementario4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private decimal ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
        {
            var exchangeRates = new System.Collections.Generic.Dictionary<string, decimal>
            {
                { "USD", 1.0m },
                { "EUR", 0.85m },
                { "GBP", 0.75m },
                { "JPY", 110.0m },
                { "AUD", 1.35m }
            };
            decimal amountInUSD = amount / exchangeRates[fromCurrency];
            decimal convertedAmount = amountInUSD * exchangeRates[toCurrency];

            return convertedAmount;
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal amount = 0;
            if (!decimal.TryParse(textBoxAmount.Text, out amount))
            {
                MessageBox.Show("Por favor, ingrese un valor válido.");
                return;
            }
            string fromCurrency = comboBoxFrom.SelectedItem.ToString();
            string toCurrency = comboBoxTo.SelectedItem.ToString();
            decimal result = ConvertCurrency(amount, fromCurrency, toCurrency);

            
            textResult.Text = $"Resultado: {result.ToString("0.00")} {toCurrency}";
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textResult.Clear();
            textBoxAmount.Clear();
        }
    }
}

