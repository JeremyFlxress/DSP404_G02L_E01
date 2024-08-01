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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero;
            int NegativoMayor = int.MinValue, NumerosPositivos = 0,  SumatoriaNegativos = 0, CantidadNegativos = 0, CantidadCeros = 0;
            
            
            if (txtCantNumeros.Text.Trim() == "")
            {
                MessageBox.Show("Introduzca un número", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                int NumeroCantidad = Convert.ToInt32(txtCantNumeros.Text);

                for (int i = 0; i < NumeroCantidad; i++)
                {
                    numero = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox((i + 1) + ". Por favor introduzca un número", "Ingresar Datos"));

                    if (!(numero >= -40 && numero <= 45))
                    {
                        MessageBox.Show("Por favor introduzca un número entre -40 hasta 45", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        i--; 
                    }
                    else
                    {
                        if (numero < 0 && (numero > NegativoMayor || NegativoMayor == int.MinValue))
                        {
                            NegativoMayor = numero;
                            txtNegativo.Text = Convert.ToString(NegativoMayor);
                        }
                        if (numero > 0)
                        {
                            NumerosPositivos++;
                            txtPositivo.Text = Convert.ToString(NumerosPositivos);
                        }
                        if (numero < 0)
                        {
                            SumatoriaNegativos += numero;
                            CantidadNegativos++;
                        }
                        if (numero == 0)
                        {
                            CantidadCeros++;
                        }
                    }
                }

                if (CantidadNegativos > 0)
                {
                    int PromedioNegativos = SumatoriaNegativos / CantidadNegativos;
                    txtPromedio.Text = PromedioNegativos.ToString();
                }
                else
                {
                    txtPromedio.Text = "0";
                }

                int total_numeros = NumerosPositivos + CantidadNegativos + CantidadCeros;

                if (total_numeros > 0)
                {
                    int PorcentajePositivos = (NumerosPositivos * 100) / total_numeros;
                    int PorcentajeNegativos = (CantidadNegativos * 100) / total_numeros;
                    int PorcentajeCeros = (CantidadCeros * 100) / total_numeros;

                    txtPorcentaje.Text = $"Positivos: {PorcentajePositivos}%, Negativos: {PorcentajeNegativos}%, Ceros: {PorcentajeCeros}%";
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPromedio.Clear();
            txtPositivo.Clear();
            txtNegativo.Clear();
            txtCantNumeros.Clear();
            txtPorcentaje.Clear();
            txtCantNumeros.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
