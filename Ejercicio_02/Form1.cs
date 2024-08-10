using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaración de arreglos
        public static int[] numero_cuenta = { 10001, 10002, 10003, 10004, 10005 };
        public static int[] saldo_cuenta = { 400, 800, 1200, 1500, 2000 };

        //Metodo para ver si es un número o no
        public static Boolean IsNumeric(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string valor_usuario = txtCuenta.Text;

            if(!IsNumeric(valor_usuario) || valor_usuario == null)
            {
                MessageBox.Show("Digite un número de cuenta correcto", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCuenta.Clear();
                txtCuenta.Focus();
            }
            else 
            {
                int valor_cuenta = Convert.ToInt32(txtCuenta.Text);
                bool cuentaValida = false;

                for (int i = 0; i < numero_cuenta.Length; i++)
                {
                    //Validación de si el usuario digito el numero de cuenta correcto
                    if (numero_cuenta[i] == valor_cuenta)
                    {
                        cuentaValida = true;
                        MessageBox.Show("Número de cuenta de cuenta correcto", "Ingreso Exitosamente",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pnlInicio.Visible = false;
                        pnlCajero.Visible = true;
                        break;

                    }
                }

                if (!cuentaValida)
                {
                    MessageBox.Show("No existe ese número de cuenta. Digite uno correcto", "Información",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCuenta.Clear();
                    txtCuenta.Focus();
                }
            }
        }
    }
}
