using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_04
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtNombre.Focus();

            txtMontoHospedaje.Enabled = false;
            txtMontoServicio.Enabled = false;
            txtMontoTotal.Enabled = false;
            txtInteres.Enabled = false;
            nudPagar.Enabled = false;
            radioButton1.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        const float pago_turista = 50, pago_delegado = 70;
        float interes = 0.18f;

        private float calculo_hospedaje(int dias) //Funcion recibe parametros y retorna valor
        {
            float calculo = 0f;
            if (radioButton1.Checked)
            {
                calculo = Convert.ToInt32(txtDias.Text) * pago_turista;
            }
            else
            {
                calculo = Convert.ToInt32(txtDias.Text) * pago_delegado;
            }

            return calculo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que se ingrese un número entero en txtDias
            if (!int.TryParse(txtDias.Text, out int dias))
            {
                MessageBox.Show("Digite un número entero", "ERROR", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }

            float monto_hospedaje = 0f;
            int montos = 0;
            decimal total = 0;

            // Se utiliza el valor de dias parseado
            monto_hospedaje = calculo_hospedaje(dias);
            txtMontoHospedaje.Text = monto_hospedaje.ToString();

            montos = calculoServicio();
            txtMontoServicio.Text = montos.ToString();

            float montoTotal = monto_hospedaje + montos;
            txtMontoTotal.Text = montoTotal.ToString();

            // Calcular el interés basado en montoTotal
            float interesMonto = montoTotal * interes;
            txtInteres.Text = interesMonto.ToString();

            // Calcular el total final con el interés
            total = Convert.ToDecimal(montoTotal) + Convert.ToDecimal(interesMonto);
            txtMontoTotal.Text = total.ToString(); 

            // Ajustar el valor máximo permitido para nudPagar
            nudPagar.Maximum = 2 * total;
            nudPagar.Value = total;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtNombre.Focus();
            txtDias.Text = " ";
            txtMontoHospedaje.Text = "";
            txtMontoServicio.Text = "";
            txtMontoTotal.Text = "";
            txtInteres.Text = "";
            nudPagar.Value = 0;
            radioButton1.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int calculoServicio()//Funcion NO recibe parametros y retorna valor
        {
            int acum = 0;
            /**
             * Usar CheckBox sin tanto if. 
             * Para ello se recorre la colección ControlCollection de la propiedad Controls, 
             * Después se verifica si el control es un CheckBox y de serlo, verificar su valor. 
             * Cuando damos click en el boton calcular se invoca esta función
             * y se recorren todos los controles del formulario,y si un control es un CheckBox, 
             * Entonces se verifica su valor y si es verdadero acumulamos el valor del servicio
             */

            foreach (Control control in this.groupBox2.Controls)
            {
                CheckBox checkbox = control as CheckBox;
                if (checkbox.Checked)
                {
                    acum += 20;
                }//Fin del primer if dentro de foreach
            }
            return acum;
        }
    }
}
