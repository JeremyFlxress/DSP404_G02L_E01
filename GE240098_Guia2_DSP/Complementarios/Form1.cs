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
    public partial class frmFibonacci : Form
    {
        public frmFibonacci()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            lstResult.Items.Clear();
            lstResult.Items.Add("Resultado:");
            txtNumero.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Limpiamos el ListBox antes de agregar los nuevos resultados
            lstResult.Items.Clear();

            // Verificamos que el número ingresado sea válido
            if (int.TryParse(txtNumero.Text.Trim(), out int numero) && numero >= 0)
            {
                // Variables para los números de la serie
                int a = 0, b = 1, c;

                // Agregar los primeros números de la serie
                if (numero >= 0)
                {
                    lstResult.Items.Add(a);
                }

                if (numero >= 1)
                {
                    lstResult.Items.Add(b);
                }

                // Generar la serie de Fibonacci
                while (true)
                {
                    c = a + b;
                    if (c > numero)
                        break;
                    lstResult.Items.Add(c);
                    a = b;
                    b = c;
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un número válido!", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Clear();
                txtNumero.Focus();
            }
        }
    }
}