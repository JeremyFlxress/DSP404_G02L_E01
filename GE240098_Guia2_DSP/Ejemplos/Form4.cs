using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_2.Ejemplos
{
    public partial class frmULAM : Form
    {
        public frmULAM()
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            lstLista.Items.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lstLista.Items.Clear();

            if(txtNumero.Text.Trim() == "")
            {
                MessageBox.Show("Introduzca un número", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int numero;

            numero = Convert.ToInt32(txtNumero.Text);

            if (numero < 0) 
            {
                MessageBox.Show("Numero no puede ser negativo", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numero > 0)
            {
                MessageBox.Show("El número que ingresaste es: " + numero, "Información",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                while (numero != 1)
                {
                    if(numero % 2 == 0)
                    {
                        numero /= 2;
                    }
                    else
                    {
                        numero = (numero * 3) + 1;
                    }

                    lstLista.Items.Add(numero);
                }
            }
        }
    }
}
