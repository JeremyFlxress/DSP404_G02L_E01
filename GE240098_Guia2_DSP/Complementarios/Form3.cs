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
    public partial class frmClaificacionNumeros : Form
    {
        public frmClaificacionNumeros()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Se limpian todos los txtbox
            txtPromedio.Clear();
            txtPositivo.Clear();
            txtNegativo.Clear();
            txtCantNumeros.Clear();
            txtPorcentaje.Clear();
            txtCantNumeros.Focus();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables

            int numero;
            int mayor_negativo = int.MinValue,
                numeros_positivos = 0,
                sumatoria_negativos = 0,
                cantidad_negativos = 0,
                cantidad_ceros = 0;
            if (txtCantNumeros.Text.Trim() == "")
            {
                MessageBox.Show("Introduzca un número", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                int cant_numeros = Convert.ToInt32(txtCantNumeros.Text);

                for (int i = 0; i < cant_numeros; i++)
                {
                    numero = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox((i + 1) + 
                        ". Introduzca un número", "Ingresar Datos"));

                    if (!(numero >= -40 && numero <= 45))
                    {
                        MessageBox.Show("Introduzca un número entre -40 hasta 45", "Advertencia",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        i--; // Para no contar este número inválido en el total
                    }
                    else
                    {
                        if (numero < 0 && (numero > mayor_negativo || mayor_negativo == int.MinValue))
                        {
                            mayor_negativo = numero;
                            txtNegativo.Text = Convert.ToString(mayor_negativo);
                        }
                        if (numero > 0)
                        {
                            numeros_positivos++;
                            txtPositivo.Text = Convert.ToString(numeros_positivos);
                        }
                        if (numero < 0)
                        {
                            sumatoria_negativos += numero;
                            cantidad_negativos++;
                        }
                        if (numero == 0)
                        {
                            cantidad_ceros++;
                        }
                    }
                }

                if (cantidad_negativos > 0)
                {
                    int promedio_negativos = sumatoria_negativos / cantidad_negativos;
                    txtPromedio.Text = promedio_negativos.ToString();
                }
                else
                {
                    txtPromedio.Text = "0";
                }

                int total_numeros = numeros_positivos + cantidad_negativos + cantidad_ceros;

                if (total_numeros > 0)
                {
                    int porcentaje_positivos = (numeros_positivos * 100) / total_numeros;
                    int porcentaje_negativos = (cantidad_negativos * 100) / total_numeros;
                    int porcentaje_ceros = (cantidad_ceros * 100) / total_numeros;

                    txtPorcentaje.Text = $"Positivos: {porcentaje_positivos}%, Negativos: {porcentaje_negativos}%, Ceros: {porcentaje_ceros}%";
                }
            }
        }
    }
}
