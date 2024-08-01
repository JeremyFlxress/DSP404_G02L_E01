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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNum4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValorA.Clear();
            txtValorC.Clear();
            txtValorB.Clear();
            txtValorD.Clear();
            txtPromedio.Clear();
            txtDesviacion.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValorA.Text, out int a) && int.TryParse(txtValorB.Text, out int b) && int.TryParse(txtValorC.Text, out int c) && int.TryParse(txtValorD.Text, out int d)){
                double promedio = (a + b + c + d) / 4.0;
                txtPromedio.Text = promedio.ToString();

                double sumatoria = Math.Pow(a - promedio, 2) + Math.Pow(b - promedio, 2) + Math.Pow(c - promedio, 2) + Math.Pow(d - promedio, 2);

                double desviacion = sumatoria / 4;

                desviacion = Math.Sqrt(desviacion);

                txtDesviacion.Text = desviacion.ToString();
            }
            else
            {
                MessageBox.Show("Debe ingresar números válidos en todos los campos.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
