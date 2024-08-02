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
    public partial class frmDesviacion : Form
    {
        public frmDesviacion()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum3.Clear();
            txtNum4.Clear();
            txtPromedio.Clear();
            txtDesviacion.Clear();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validar entradas
            if (int.TryParse(txtNum1.Text, out int num1) &&
                int.TryParse(txtNum2.Text, out int num2) &&
                int.TryParse(txtNum3.Text, out int num3) &&
                int.TryParse(txtNum4.Text, out int num4))
            {
                // Calcular promedio
                double promedio = (num1 + num2 + num3 + num4) / 4.0;
                txtPromedio.Text = promedio.ToString();

                // Calcular desviación típica
                double sumatoria = Math.Pow(num1 - promedio, 2) +
                                   Math.Pow(num2 - promedio, 2) +
                                   Math.Pow(num3 - promedio, 2) +
                                   Math.Pow(num4 - promedio, 2);

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
    }
}
