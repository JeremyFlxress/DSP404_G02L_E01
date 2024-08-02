using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        private int i;

        public Form1()
        {
            InitializeComponent();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            int[] matriz = new int[5];
            if (i <= 5)
            {//agregamos los numeros en cada posicion del arreglo
                matriz[i] = Convert.ToInt16(txtNum.Text);
                lstdesorden.Items.Add(matriz[i]);//agregamos los numeros a la lista
                i += 1;
                txtNum.Clear();//limpiar txtnum
                txtNum.Select();//colocar cursos en txtnum
            }
            else
            {
                MessageBox.Show("No se puede ingresar mas datos", "Advertencia", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
        }

        private void btOrdenar_Click(object sender, EventArgs e)
        {
            int j, k, count;
            int[] matriz = new int[5];


            double valor;
            int Tam = 5;
            //---ordenamos el arreglo por le metodo de la burbuja 
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
            //recorremos el arreglo e ingresamos los valores a la lista
            lstOrdenada.Items.Clear();
            for (count = 0; count < Tam; count++)
            {
                lstOrdenada.Items.Add(matriz[count]);
            }
        }
    }
}
