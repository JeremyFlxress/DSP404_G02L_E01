using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_2.Ejercicios
{
    public partial class frmConversorMonedas : Form
    {
        // Diccionario para almacenar las tasas de cambio
        private Dictionary<string, decimal> tasasDeCambio = new Dictionary<string, decimal>
        {
            {"USD", 1.0m},  // Dólar estadounidense
            {"EUR", 0.85m}, // Euro
            {"GBP", 0.75m}, // Libra esterlina
            {"JPY", 110.0m}, // Yen japonés
            {"AUD", 1.35m}  // Dólar australiano
        };

        public frmConversorMonedas()
        {
            InitializeComponent();
            CargarMonedas();
        }

        private void CargarMonedas()
        {
            cboInicial.Items.AddRange(new string[] { "USD", "EUR", "GBP", "JPY", "AUD" });
            cboFinal.Items.AddRange(new string[] { "USD", "EUR", "GBP", "JPY", "AUD" });

            cboInicial.SelectedIndex = 0;
            cboFinal.SelectedIndex = 1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtResult.Clear();
            cboInicial.SelectedIndex = 0;
            cboFinal.SelectedIndex = 1;
            txtCantidad.Text = "0.0";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCantidad.Text, out decimal cantidad))
            {
                string monedaInicial = cboInicial.SelectedItem.ToString();
                string monedaFinal = cboFinal.SelectedItem.ToString();

                decimal tasaInicial = tasasDeCambio[monedaInicial];
                decimal tasaFinal = tasasDeCambio[monedaFinal];

                decimal resultado = (cantidad / tasaInicial) * tasaFinal;
                txtResult.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.");
            }
        }
    }
}
