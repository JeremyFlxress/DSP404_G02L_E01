using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_2
{
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNumero.BackColor = Color.White;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables
            long factorial = 1;
            int i;
            //Con la funcion IsNumeric verificamos que el TXTNumero contenga un dato númerico
            if (IsNumeric(txtNumero.Text))
            {
                //Se realiza un for desde el número ingresado hasta llegar a uno
                for (i = Convert.ToInt32(txtNumero.Text); i >= 1; i--)
                {
                    //Se multiplica el factorial por todos los numeros menores.
                    //Factorial = factorial*i
                    factorial *= i;
                }
                txtFactorial.Text = factorial.ToString();
            }
            else
            {
                txtNumero.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un número!", "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Clear();
                txtFactorial.Clear();
                txtNumero.Focus();
            }
        }
    }
}
