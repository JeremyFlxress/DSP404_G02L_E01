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
    public partial class frmCesar : Form
    {
        public frmCesar()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            //Verificamos que la llave contenga un numero y que este sea positivo
            if (IsNumeric(txtLlave.Text) && (Convert.ToInt16(txtLlave.Text) > 0))
            {
                txtResultado.Clear();
                int ascii;
                //para cada caracter en el objeto txtTexto
                foreach (int c in txtTexto.Text)
                {
                    //verficamos si el usuario desea encriptar o desencriptar el texto
                    if (rdbEncriptar.Checked == true)
                    {
                        /*convertimos el caracter extraido a su equivalente numero ASCII y le 
                       sumamos la llave*/
                        ascii = (int)c + Convert.ToInt16(txtLlave.Text);
                    }
                    else
                    {
                        /*convertimos el caracter extraido a su equivalente numero ASCCI y le 
                        restamos la llave*/
                        ascii = (int)c - Convert.ToInt16(txtLlave.Text);
                    }
                    txtResultado.Text += (char)ascii;
                }
                lblResultado.Text = "Texto encriptado:";
            }
            else
            {
                MessageBox.Show("El dato introducido en la llave es incorrecto", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtLlave.Focus();
                txtLlave.Clear();
                txtLlave.BackColor = Color.Red;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtLlave_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtLlave.BackColor = Color.White;
        }

        private void rdbEncriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEncriptar.Checked == true)
            {
                btnEncriptar.Text = "Encriptar";
            }
        }

        private void rdbDesencriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDesencriptar.Checked == true)
            {
                btnEncriptar.Text = "Desencriptar";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
            txtResultado.Clear();
            txtTexto.Focus();
        }
    }
}
