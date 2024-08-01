using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complementario2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double[] numeros = new double[4];
                numeros[0] = Convert.ToDouble(txtNum1.Text);
                numeros[1] = Convert.ToDouble(txtNum2.Text);
                numeros[2] = Convert.ToDouble(txtNum3.Text);
                numeros[3] = Convert.ToDouble(txtNum4.Text);


                double promedio = numeros.Average();

                double sumatoriaDesviacion = numeros.Sum(x => Math.Pow(x - promedio, 2));
                double desviacionTipica = Math.Sqrt(sumatoriaDesviacion / numeros.Length);
                lblPromedio.Text = "Promedio: " + promedio.ToString("F2");
                lblDesviacionTipica.Text = "Desviación Típica: " + desviacionTipica.ToString("F3");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números válidos en todos los campos.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lblDesviacionTipica.Clear();
            lblPromedio.Clear();
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum3.Clear();
            txtNum4.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
