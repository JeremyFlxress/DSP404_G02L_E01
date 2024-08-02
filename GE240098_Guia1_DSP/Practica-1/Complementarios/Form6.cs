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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public static Boolean IsNumeric(string valor)
        {
            double result;
            return double.TryParse(valor, out result);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Arreglo para almacenar los números como strings
            string[] numberString = { txtNum1.Text, txtNum2.Text, txtNum3.Text, txtNum4.Text,
                              txtNum5.Text, txtNum6.Text, txtNum7.Text, txtNum8.Text,
                              txtNum9.Text, txtNum10.Text };

            // Vector para almacenar los números como doubles
            double[] numbers = new double[numberString.Length];

            // Convertir los strings a doubles y almacenarlos en el vector 'numbers'
            for (int i = 0; i < numberString.Length; i++)
            {
                if (IsNumeric(numberString[i]))
                {
                    numbers[i] = Convert.ToDouble(numberString[i]);
                }
                else
                {
                    MessageBox.Show($"El valor en la posición {i + 1} no es un número válido.", "Error de entrada",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Limpiar listas y resultados anteriores
            lstPositivos.Items.Clear();
            lstMenor.Items.Clear();
            lstQuestions.Items.Clear();

            // Clasifica los números en positivos y negativos
            List<double> positivos = new List<double>();
            List<double> negativos = new List<double>();

            foreach (double num in numbers)
            {
                if (num > 0)
                {
                    positivos.Add(num);
                    lstPositivos.Items.Add(num);
                }
                else if (num < 0)
                {
                    negativos.Add(num);
                    lstMenor.Items.Add(num);
                }
            }

            // Calcula y muestra el menor de los negativos
            if (negativos.Count > 0)
            {
                double menorNegativo = negativos.Min();
                lstQuestions.Items.Add($"El menor de los negativos: {menorNegativo}");
            }
            else
            {
                lstQuestions.Items.Add("No hay números negativos.");
            }

            // Calcula y muestra el promedio de los positivos
            if (positivos.Count > 0)
            {
                double promedioPositivos = positivos.Average();
                lstQuestions.Items.Add($"Promedio de los números positivos: {promedioPositivos}");
            }
            else
            {
                lstQuestions.Items.Add("No hay números positivos.");
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Gracias por su confianza!", "GRACIAS",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
