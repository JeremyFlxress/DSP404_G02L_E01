using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01
{
    public partial class Form1 : Form
    {
        int[] matriz = new int[5];
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (i <= 5)
            {
                matriz[i] = Convert.ToInt16(txtNum.Text);
                lstDesorden.Items.Add(matriz[i]);
                i += 1;
                txtNum.Clear();
                txtNum.Select();
            }
            else
            {
                MessageBox.Show("No se puede ingresar mas datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            int j, k, count;
            double valor;
            int Tam = 5;
            for (j = 0; j < Tam; j++)
            {
                for (k = 0; k < (Tam - 1); k++)
                {
                    if (matriz[k] > matriz[k + 1])
                    {
                        valor = matriz[k];
                        matriz[k] = matriz[k + 1];
                        matriz[k + 1] = Convert.ToInt16(valor);
                    }
                }
            }
            lstOrdenada.Items.Clear();
            for (count = 0; count < Tam; count++)
            {
                lstOrdenada.Items.Add(matriz[count]);
            }
        }
    }
    }

