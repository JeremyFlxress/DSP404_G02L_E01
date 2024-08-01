using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis_de_Resultado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Monedas();
        }

        private Dictionary<string, decimal> tasasDeCambio = new Dictionary<string, decimal>
        {
            {"USD", 1.0m},  // Dólar estadounidense
            {"EUR", 0.85m}, // Euro
            {"GBP", 0.75m}, // Libra esterlina
            {"JPY", 110.0m}, // Yen japonés
            {"AUD", 1.35m}  // Dólar australiano
        };

        private void Monedas()
        {
            cboInicio.Items.AddRange(new string[] { "USD", "EUR", "GBP", "JPY", "AUD" });
            cboFinal.Items.AddRange(new string[] { "USD", "EUR", "GBP", "JPY", "AUD" });

            cboInicio.SelectedIndex = 0;
            cboFinal.SelectedIndex = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtCantidad.Text, out decimal cantidad))
            {
                string PrimerMoneda = cboInicio.SelectedItem.ToString();
                string UltimaMoneda = cboFinal.SelectedItem.ToString();

                decimal tasaInicial = tasasDeCambio[PrimerMoneda];
                decimal tasaFinal = tasasDeCambio[UltimaMoneda];

                decimal resultado = (cantidad / tasaInicial) * tasaFinal;
                txtResult.Text = resultado.ToString("N2");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtResult.Clear();
            cboInicio.SelectedIndex = 0;
            cboFinal.SelectedIndex = 1;
            txtCantidad.Text = "0.0";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
