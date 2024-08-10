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
        public static double[] saldo_cuenta = { 400, 800, 1200, 1500, 2000 };
        public static string nombre_usuario;
        public static int valor_cuenta;
        public static int indice_valor_cuenta = -1;

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
                    indice_valor_cuenta = i;


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
    
        /**
         * Botón para consultar saldo de la cuenta
         */
        private void btnConsultarSaldo_Click(object sender, EventArgs e)
        {
            if (indice_valor_cuenta >= 0)
            {
                double saldo = saldo_cuenta[indice_valor_cuenta];

                MessageBox.Show("El saldo actual de la cuenta es: $" + saldo, "Saldo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /**
        * Botón para retirar saldo de la cuenta
         */
        private void btnRetirarFondos_Click(object sender, EventArgs e)
        {
            if (indice_valor_cuenta >= 0)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Digite el saldo a retirar", "Retirar saldo");

                // Verificar si el usuario ha cancelado o dejado el campo vacío
                if (string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("Operación cancelada.", "Cancelación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                double saldo_retirar;
                if (double.TryParse(input, out saldo_retirar))
                {
                    if (saldo_retirar <= saldo_cuenta[indice_valor_cuenta])
                    {
                        saldo_cuenta[indice_valor_cuenta] -= saldo_retirar;
                        MessageBox.Show("Retiro exitoso. El saldo restante es: $" + saldo_cuenta[indice_valor_cuenta], "Retiro",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Fondos insuficientes. El saldo actual es: $" + saldo_cuenta[indice_valor_cuenta], "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, introduzca un número válido.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /**
         * Boton de salir que da un mensaje de despedida
         */
        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muchas Gracias, vuelva pronto", "¡Gracias!",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Close();
        }


        /**
         * Boton de consignar, es decir, depositar dinero a la cuenta
         */
        private void btnConsignar_Click(object sender, EventArgs e)
        {
            if (indice_valor_cuenta >= 0)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Digite el saldo a consignar", "Consignar saldo");

                // Verificar si el usuario ha cancelado o dejado el campo vacío
                if (string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("Operación cancelada.", "Cancelación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                double saldo_consignar;

                if (double.TryParse(input, out saldo_consignar) && saldo_consignar > 0)
                {
                    saldo_cuenta[indice_valor_cuenta] += saldo_consignar;
                    MessageBox.Show("Consignación exitosa. El saldo actual es: $" + saldo_cuenta[indice_valor_cuenta], "Consignación",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Por favor, introduzca un número válido y mayor a 0.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /**
         * Botón de transferir saldo a otra cuenta
         */
        private void btnTransferir_Click(object sender, EventArgs e)
        {
            // Solicitar el número de cuenta a la que se va a transferir
            string input_numero_cuenta = Microsoft.VisualBasic.Interaction.InputBox("Digite el número de la cuenta a la que va a transferir", "Transferir saldo");

            // Verificar si el usuario ha cancelado o dejado el campo vacío
            if (string.IsNullOrEmpty(input_numero_cuenta))
            {
                MessageBox.Show("Operación cancelada.", "Cancelación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int input_numero_cuenta_convertido;
            if (!int.TryParse(input_numero_cuenta, out input_numero_cuenta_convertido))
            {
                MessageBox.Show("Número de cuenta inválido. Por favor, introduzca un número de cuenta válido.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si la cuenta de destino existe
            int cuenta_destino_indice = Array.IndexOf(numero_cuenta, input_numero_cuenta_convertido);
            if (cuenta_destino_indice == -1)
            {
                MessageBox.Show("No se encontró ninguna cuenta con ese número.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Solicitar la cantidad a transferir
            string input_saldo_transferir = Microsoft.VisualBasic.Interaction.InputBox("Digite la cantidad en dólares que desea transferir a la cuenta", "Transferir Saldo");

            // Verificar si el usuario ha cancelado o dejado el campo vacío
            if (string.IsNullOrEmpty(input_saldo_transferir))
            {
                MessageBox.Show("Operación cancelada.", "Cancelación",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double saldo_transferir;

            if (!double.TryParse(input_saldo_transferir, out saldo_transferir) || saldo_transferir <= 0)
            {
                MessageBox.Show("Por favor, introduzca un monto válido y mayor a 0.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si hay suficientes fondos en la cuenta de origen
            if (saldo_transferir > saldo_cuenta[indice_valor_cuenta])
            {
                MessageBox.Show("Fondos insuficientes. El saldo actual es: $" + saldo_cuenta[indice_valor_cuenta], "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Realizar la transferencia
            saldo_cuenta[indice_valor_cuenta] -= saldo_transferir; // Restar de la cuenta de origen
            saldo_cuenta[cuenta_destino_indice] += saldo_transferir; // Sumar a la cuenta destino

            MessageBox.Show("Transferencia exitosa. El saldo actual de su cuenta es: $" + saldo_cuenta[indice_valor_cuenta], "Transferencia",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}