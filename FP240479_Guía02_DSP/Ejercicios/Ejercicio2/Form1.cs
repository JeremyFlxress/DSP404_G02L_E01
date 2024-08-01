using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class frmCesar : Form

    {
        public frmCesar()
        {
            InitializeComponent();
        }
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //verificamos que la lleva contenga un numero y que este sea positivo
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
                    lblresultado.Text = "Texto encriptado:";
            }
            else
            {
                MessageBox.Show("El dato introducido en la llave es incorrecto","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
               
                txtLlave.Focus();
                txtLlave.Clear();
                txtLlave.BackColor = Color.Red;
            }
        }

        private void txtLlave_TextChanged(object sender, EventArgs e)
        {
            txtLlave.BackColor = Color.White;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
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
            txtLlave.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
