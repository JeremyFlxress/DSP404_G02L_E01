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

        private void Form1_Load(object sender, EventArgs e)
        {
            //Cuando se ejecute el programa siempre aparezca el panel de Incio
            pnlInicio.Visible = true;
            pnlCajero.Visible = false;
            txtNombreUsuario.Select();
        }

        //Declaración de arreglos
        public static int[] numero_cuenta = { 10001, 10002, 10003, 10004, 10005 };
        public static int[] saldo_cuenta = { 400, 800, 1200, 1500, 2000 };
        public static string nombre_usuario;

        //Metodo para ver si es un número o no
        public static Boolean IsNumeric(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string valor_usuario = txtCuenta.Text;
            nombre_usuario = txtNombreUsuario.Text;
            bool nombre_valido = nombre_usuario.Length >= 3;

            if (!nombre_valido)
            {
                MessageBox.Show("Digite un nombre correcto", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreUsuario.Clear();
                txtNombreUsuario.Focus();
                return;
            }
            else
            {
                txtCuenta.Focus();
            }

            if (!IsNumeric(valor_usuario) || valor_usuario == null)
            {
                MessageBox.Show("Digite un número de cuenta correcto", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCuenta.Clear();
                txtCuenta.Focus();
                return;
            }

            int valor_cuenta = Convert.ToInt32(txtCuenta.Text);
            bool cuentaValida = false;

            for (int i = 0; i < numero_cuenta.Length; i++)
            {
                // Validación de si el usuario digitó el número de cuenta correcto
                if (numero_cuenta[i] == valor_cuenta && nombre_valido)
                {
                    cuentaValida = true;
                    MessageBox.Show("Número de cuenta correcto", "Ingreso Exitosamente",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pnlInicio.Visible = false;
                    pnlCajero.Visible = true;

                    lblBienvenida.Text = "¡Bienvenido/a " + nombre_usuario.ToUpper() + "!";

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            pnlCajero.Visible = false;
            pnlInicio.Visible = true;
            //Limpiar los textboxs
            txtNombreUsuario.Clear();
            txtCuenta.Clear();

            txtNombreUsuario.Focus();
        }

        private void pnlCajero_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblBienvenida_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
