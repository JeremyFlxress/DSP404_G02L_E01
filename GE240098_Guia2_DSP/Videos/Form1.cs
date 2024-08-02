using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_2.Videos
{
    public partial class frmTablas : Form
    {
        public frmTablas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaraciónd e variables
            int numero;
            double suma, resta, multiplicacion, division;

            //Entrada de datos

            numero = Convert.ToInt32(txtNumero.Text);

            //Proceso
            //Dejamos en blanco los combobox
            cboSuma.Items.Clear();
            cboResta.Items.Clear();
            cboMulti.Items.Clear();
            cboDiv.Items.Clear();

            //Creamos nuestro bucle para poder mostrar la tabla del 1 al 12

            for (int i = 1; i <= 12; i++)
            {
                suma = numero + i;
                resta = numero - i;
                multiplicacion = numero * i;
                division = numero / i;

                //Agregar los resultados a los combobo
                cboSuma.Items.Add(numero + " + " + i + " = " + suma);
                cboResta.Items.Add(numero + " - " + i + " = " + resta);
                cboMulti.Items.Add(numero + " * " + i + " = " + multiplicacion);
                cboDiv.Items.Add(numero + " / " + i + " = " + division);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cboSuma.Items.Clear();
            cboResta.Items.Clear();
            cboMulti.Items.Clear();
            cboDiv.Items.Clear();
            txtNumero.Clear();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
