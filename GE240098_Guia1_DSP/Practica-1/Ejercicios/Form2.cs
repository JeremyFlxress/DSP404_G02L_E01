using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private double TasaI;
        // Valida que el dato recibido es un numero

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
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

        private void rbdInteres1_CheckedChanged(object sender, EventArgs e)
        {
            TasaI = 0.12;
        }

        private void rdbInteres2_CheckedChanged(object sender, EventArgs e)
        {
            TasaI = 0.235;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            string NombreEmpresa;
            double MontoInic = 0, MontoFin = 0;
            int Tiempo;

            NombreEmpresa = txtEmpresa.Text;
            NombreEmpresa = NombreEmpresa.Trim(); // Quita el espacio-blanco al inicio-final

            if (NombreEmpresa.Length == 0)
            {
                //Si no hay caracteres en nombre empresa
                MessageBox.Show("Debe indicar el nombre de la empresa", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtMonto.Focus(); // Metodo que indica que control txtEmpresa recbira el cursor
                return; //Sale el procedimiento btnAnalisis
            }
            if (!(IsNumeric(txtMonto.Text)))
            {
                MessageBox.Show("Valor Monto Incorrecto", "ERROR", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonto.Focus(); // Metodo que indica que control txtEmpresa recbira el cursor
                return; 
            }
            else
            {
                MontoInic = Convert.ToDouble(txtMonto.Text);
                if (!(MontoInic > 0))
                {
                    MessageBox.Show("Valor del Monto no puede ser negativo", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMonto.Focus(); // Metodo que indica que control txtEmpresa recbira el cursor
                    return;
                }
            }

            Tiempo = Convert.ToInt32(txtTiempo.Text);
            // Si selecciono Tasa Interes 3, valida que sea correcta
            txtTasaInterEX.Text = txtTasaInterEX.Text.Trim();

            if (rdbInteres3.Checked == true)
            {
                if (txtTasaInterEX.Text.Length > 0)
                {
                    if (!(IsNumeric(txtTasaInterEX.Text) == true))
                    {
                        MessageBox.Show("Tasa Interes incorrecto", "ERROR", 
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Aun no ha indicado una tasa de Interes", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTasaInterEX.Focus();
                    return;
                }
            }

            //Hace el cálculo esperado
            MontoFin = (1 + TasaI);
            MontoFin = MontoInic * (Math.Pow(Convert.ToDouble(MontoFin), Tiempo));
            TasaI *= 100;

            //Muestra la respuesta (Monto a Pagar)
            lstResul.Items.Clear();
            lstResul.Items.Add("Empresa: " + txtEmpresa.Text);
            lstResul.Items.Add("Monto: $" + MontoInic + ", Tasa anual: "+ TasaI);
            lstResul.Items.Add("Monto a Pagar: " + Math.Round(MontoFin));
        }
    }
}
