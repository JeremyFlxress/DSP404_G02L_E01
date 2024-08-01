using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complementario3
{
    public partial class Form1 : Form
    {
        private int mayorNegativo = int.MinValue;
        private int cantidadPositivos = 0;
        private int sumaNegativos = 0;
        private int cantidadNegativos = 0;
        private int cantidadCeros = 0;
        private int totalNumeros = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Obtener el número ingresado por el usuario desde el TextBox
            if (int.TryParse(txtNum.Text, out int numero))
            {
                // Verificar si el número está dentro del rango permitido
                if (numero >= -40 && numero <= 45)
                {
                    // Actualizar estadísticas generales
                    totalNumeros++;

                    // Determinar tipo de número (positivo, negativo o cero)
                    if (numero > 0)
                    {
                        cantidadPositivos++;
                    }
                    else if (numero < 0)
                    {
                        cantidadNegativos++;
                        sumaNegativos += numero;

                        // Actualizar el mayor número negativo
                        if (numero > mayorNegativo)
                        {
                            mayorNegativo = numero;
                        }
                    }
                    else
                    {
                        cantidadCeros++;
                    }

                    // Mostrar estadísticas actuales en los Labels correspondientes
                    lblMayorNegativo.Text = $"Mayor número negativo: {mayorNegativo}";
                    lblCantidadPositivos.Text = $"Cantidad de números positivos: {cantidadPositivos}";
                    lblPromedioNegativos.Text = $"Promedio de negativos: {(double)sumaNegativos / cantidadNegativos:F2}";
                    lblPorcentajePositivos.Text = $"Porcentaje de positivos: {(double)cantidadPositivos / totalNumeros * 100:F2}%";
                    lblPorcentajeNegativos.Text = $"Porcentaje de negativos: {(double)cantidadNegativos / totalNumeros * 100:F2}%";
                    lblPorcentajeCeros.Text = $"Porcentaje de ceros: {(double)cantidadCeros / totalNumeros * 100:F2}%";
                }
                else
                {
                    MessageBox.Show("Número fuera del rango permitido (-40 a 45). Inténtelo de nuevo.");
                }
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número válido.");
            }

            // Limpiar el TextBox después de cada ingreso
            txtNum.Clear();
            txtNum.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblMayorNegativo.Clear();
            lblCantidadPositivos.Clear();
            lblPromedioNegativos.Clear();
            lblPorcentajePositivos.Clear();
            lblPorcentajeNegativos.Clear();
            lblPorcentajeCeros.Clear();
            txtNum.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
