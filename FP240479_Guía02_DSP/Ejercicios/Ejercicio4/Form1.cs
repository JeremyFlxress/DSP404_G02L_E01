using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class FormULAM : Form
    {
        public FormULAM()
        {
            InitializeComponent();
            
        }
        public static bool IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        private string CalcularULAM(int number)
        {
            StringBuilder secuencia = new StringBuilder();
            while (number != 1)
            {
                secuencia.Append(number + " ");
                if (number % 2 == 0)
                {
                    number /= 2;
                }
                else
                {
                    number = 3 * number + 1;
                }
            }
            secuencia.Append("1"); // Añadir el último valor que es siempre 1
            return secuencia.ToString();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int number;
            if (IsNumeric(txtNumero.Text))
            {
                number = Convert.ToInt32(txtNumero.Text);
                string secuencia = CalcularULAM(number);
                lstLista.Text = secuencia;
            }
            else
            {
                txtNumero.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un número!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Clear();
                lstLista.Clear();
                txtNumero.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstLista.Clear();
            txtNumero.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormULAM_Load(object sender, EventArgs e)
        {

        }
    }
}








