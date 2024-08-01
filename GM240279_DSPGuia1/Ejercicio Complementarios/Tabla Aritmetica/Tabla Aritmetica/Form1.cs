using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabla_Aritmetica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero;
            double suma, resta, mult, div;

            numero = Convert.ToInt32(textNumero.Text);

            cboSuma.Items.Clear();
            cboResta.Items.Clear ();
            cboMult.Items.Clear();
            cboDiv.Items.Clear();

            for (int i=1; i<=12; i = i + 1)
            {
                suma = numero + i;
                resta = numero - i;
                mult = numero * i;
                div = numero / i;

                cboSuma.Items.Add( numero + " + " + i + " = " + suma);
                cboResta.Items.Add(numero + " - " + i + " = " + resta);
                cboMult.Items.Add(numero + " * " + i + " = " + mult);
                cboDiv.Items.Add(numero + " / " + i + " = " + div);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cboSuma.Items.Clear();
            cboResta.Items.Clear();
            cboMult.Items.Clear();
            cboDiv.Items.Clear();
            textNumero.Clear();
        }
    }
}
