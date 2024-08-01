using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        private Double TasaI;
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NomEmpre;
            double MontoInic = 0, MontoFin = 0;
            int Tiempo;
            NomEmpre = txtEmpresa.Text;
            NomEmpre = NomEmpre.Trim();
            if (NomEmpre.Length == 0)
            {

                MessageBox.Show("Debe indicar Nombre de la empresa", "ERROR",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMonto.Focus();
                return;
            }
            if (!(IsNumeric(txtMonto.Text)))
            {
                MessageBox.Show("Valor Monto incorrecto", "ERROR", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                txtMonto.Focus(); 
                return;
            }
            else
            {
                MontoInic = Convert.ToDouble(txtMonto.Text);
                if (!(MontoInic > 0))
                {
                    MessageBox.Show("Valor Monto no puede ser negativo", "ERROR",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMonto.Focus(); 
                    return;
                }
            }
            Tiempo = Convert.ToInt32(txtTiempo.Text);
            
            txtTasaInterEX.Text = txtTasaInterEX.Text.Trim();
            if (rdbInteres3.Checked == true)
            {
                if (txtTasaInterEX.Text.Length > 0)
                {
                    if (!(IsNumeric(txtTasaInterEX.Text) == true))
                    {
                        MessageBox.Show("Tasa interes incorrecto", "ERROR", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                        txtTasaInterEX.Text = "0";
                        txtTasaInterEX.Focus();
                        return;
                    }
                    else
                    {
                        TasaI = Convert.ToDouble(txtTasaInterEX.Text) / 100;
                    }
                }

                else
                {
                    MessageBox.Show("Aun no ha indicado una tasa interes", "ERROR",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTasaInterEX.Focus();
                    return;
                }
            }
            
            MontoFin = (1 + TasaI);
            MontoFin = MontoInic * (Math.Pow(Convert.ToDouble(MontoFin), Tiempo));
            TasaI *= 100;
            
            lstResul.Items.Clear();
            lstResul.Items.Add("Empresa: " + txtEmpresa.Text);
            lstResul.Items.Add("Monto: $" + MontoInic + ", Tasa anual: " + TasaI);
            lstResul.Items.Add("Monto a pagar: $" + MontoFin);
        }

        private void rdbInteres3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInteres3.Checked == true)
            {
                txtTasaInterEX.Enabled = true;
                txtTasaInterEX.Focus();
            }
            else
            {
                txtTasaInterEX.Text = "0";
                txtTasaInterEX.Enabled = false;
            }
        }

        private void rdbInteres1_CheckedChanged(object sender, EventArgs e)
        {
            Double TasaI = 0.12;
        }

        private void rdbInteres2_CheckedChanged(object sender, EventArgs e)
        {
            Double TasaI = 0.235;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
