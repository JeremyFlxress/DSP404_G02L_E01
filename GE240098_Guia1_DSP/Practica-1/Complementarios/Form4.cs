using System;
using System.Windows.Forms;
using System.Linq;

namespace Practica_1
{
    public partial class Form4 : Form
    {
        // Declaración de variables
        private double menorNegativo = double.MaxValue; // Inicializado con el máximo valor posible
        private double mayorNegativo = double.MinValue; // Inicializado con el mínimo valor posible
        private double promedioPositivo = 0;
        private double totalPromedio = 0;
        private double sumaTotal = 0;

        public Form4()
        {
            InitializeComponent();
        }

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
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

            // Limpiar variables antes de realizar cálculos
            menorNegativo = double.MaxValue;
            mayorNegativo = double.MinValue;
            promedioPositivo = 0;
            sumaTotal = 0;

            // Verificar cuál RadioButton está seleccionado
            if (rdbMasMenos.Checked)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < 0)
                    {
                        if (numbers[i] > mayorNegativo)
                        {
                            mayorNegativo = numbers[i];
                        }
                        if (numbers[i] < menorNegativo)
                        {
                            menorNegativo = numbers[i];
                        }
                    }
                    else if (numbers[i] > 0)
                    {
                        promedioPositivo += numbers[i];
                    }
                }

                // Calcular promedio de positivos solo si hay números positivos
                int countPositivos = numbers.Count(n => n > 0);
                if (countPositivos > 0)
                {
                    promedioPositivo /= countPositivos;
                }

                lstResult.Items.Clear();
                lstResult.Items.Add($"El número mayor de los negativos es: {mayorNegativo}.");
                lstResult.Items.Add($"El número menor de los negativos es: {menorNegativo}.");
                lstResult.Items.Add($"El promedio de los positivos es: {promedioPositivo}.");
            }
            else if (rdbProm.Checked)
            {
                // Calcular suma total de todos los números
                for (int i = 0; i < numbers.Length; i++)
                {
                    sumaTotal += numbers[i];
                }

                // Calcular promedio de todos los números
                totalPromedio = sumaTotal / numbers.Length;

                lstResult.Items.Clear();
                lstResult.Items.Add($"El promedio de todos los números es: {totalPromedio}");
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muchas gracias por confiar en nosotros", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
