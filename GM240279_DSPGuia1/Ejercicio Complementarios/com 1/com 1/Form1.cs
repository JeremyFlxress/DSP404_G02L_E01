using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            // Obtener los valores ingresados
            decimal[] numbers = new decimal[10];
            try
            {
                numbers[0] = Convert.ToDecimal(txtNumber1.Text);
                numbers[1] = Convert.ToDecimal(txtNumber2.Text);
                numbers[2] = Convert.ToDecimal(txtNumber3.Text);
                numbers[3] = Convert.ToDecimal(txtNumber4.Text);
                numbers[4] = Convert.ToDecimal(txtNumber5.Text);
                numbers[5] = Convert.ToDecimal(txtNumber6.Text);
                numbers[6] = Convert.ToDecimal(txtNumber7.Text);
                numbers[7] = Convert.ToDecimal(txtNumber8.Text);
                numbers[8] = Convert.ToDecimal(txtNumber9.Text);
                numbers[9] = Convert.ToDecimal(txtNumber10.Text);
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese solo números decimales válidos.");
                return;
            }

            // Calcular los valores requeridos
            var negativeNumbers = numbers.Where(n => n < 0).ToArray();
            var positiveNumbers = numbers.Where(n => n > 0).ToArray();
            var averagePositive = positiveNumbers.Average();
            var meanAll = numbers.Average();

            // Mostrar los resultados
            lblAveragePositive.Text = "Promedio de positivos:"  + Math.Round(averagePositive, 2);
            lblMeanAll.Text = "Media de todos:" + meanAll;
        }

        private void txtNumber3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAveragePositive_Click(object sender, EventArgs e)
        {

        }

        private void lblMaxNegative_Click(object sender, EventArgs e)
        {

        }

        private void lblMinNegative_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumber10_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber9_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber4_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMeanAll_Click(object sender, EventArgs e)
        {

        }

        private void txtNumber2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
