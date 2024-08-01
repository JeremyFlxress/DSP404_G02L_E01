using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complementarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstFibonacci.ReadOnly = true;
        }
        private string GenerarFibonacci(int maxNumber)
        {
            StringBuilder secuencia = new StringBuilder();
            int a = 0;
            int b = 1;
            secuencia.Append(a + Environment.NewLine); 

            while (b <= maxNumber)
            {
                secuencia.Append(b + Environment.NewLine); 
                int temp = a;
                a = b;
                b = temp + b;
            }

            return secuencia.ToString();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lstFibonacci.Clear(); 

            if (int.TryParse(txtNum.Text, out int maxNumber) && maxNumber >= 0)
            {
                string secuencia = GenerarFibonacci(maxNumber);
                lstFibonacci.Text = secuencia;
            }
            else
            {
                txtNum.BackColor = System.Drawing.Color.Red;
                MessageBox.Show("Por favor, debe de ingresar un número entero positivo.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum.Clear();
                txtNum.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstFibonacci.Clear();
            txtNum.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

