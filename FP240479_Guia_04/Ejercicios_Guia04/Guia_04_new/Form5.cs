using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_04_new
{
    public partial class Form5 : Form
    {
        const float Pago_turista = 50, Pago_Delegado = 70;
        float interes = 0.18f;
        private float calculo_hospedaje(int dias) 
        {
            float calculo = 0f;
            if (radioButton1.Checked)
            {
                calculo = Convert.ToInt32(txtdias.Text) * Pago_turista;
            }
            else
            {
                calculo = Convert.ToInt32(txtdias.Text) * Pago_Delegado;
            }

            return calculo;
        }
        private int calculo_servicio()
        {
            int acum = 0;
            foreach (Control contr in this.groupBox2.Controls)
            {
                CheckBox checkbox = contr as CheckBox;
                if (checkbox.Checked)
                    acum += 20;
            }
            return acum;
        }
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float montoh = 0f;
            int montos = 0;
            decimal total = 0;
            montoh = calculo_hospedaje(Convert.ToInt32(txtdias.Text));
            txtmontoh.Text = Convert.ToString(montoh);
            montos = calculo_servicio();
            txtmontos.Text = Convert.ToString(montos);
            txtmontot.Text = Convert.ToString(montoh + montos);
            txtinteres.Text = ((float.Parse(txtmontot.Text) * interes)).ToString();

            total = Convert.ToDecimal(txtmontot.Text) + Convert.ToDecimal(txtinteres.Text);
            nUDpagar.Maximum = 2 * total;
            nUDpagar.Value = total;

            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("El campo 'Apellidos y Nombres' es obligatorio.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnombre.Focus();
                return;
            }

            int diasHospedaje;
            if (!int.TryParse(txtdias.Text, out diasHospedaje) || diasHospedaje <= 0)
            {
                MessageBox.Show("El campo 'Días de Hospedaje' debe contener un número entero positivo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdias.Focus();
                return;
            }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnombre.Text = "";
            txtnombre.Focus();
            txtdias.Text = " ";
            txtmontoh.Text = "";
            txtmontos.Text = "";
            txtmontot.Text = "";
            txtinteres.Text = "";
            nUDpagar.Value = 0;
            radioButton1.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txtnombre.Focus();

            txtmontoh.Enabled = false;
            txtmontos.Enabled = false;
            txtmontot.Enabled = false;
            txtinteres.Enabled = false;
            nUDpagar.Enabled = false;
            radioButton1.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
    }
}
