using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complementarios_Guia04
{
    public partial class Form2 : Form
    {
        private int[,] GenerarMatriz(int limiteInferior, int limiteSuperior)
        {
            Random rand = new Random();
            int[,] matriz = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = rand.Next(limiteInferior, limiteSuperior + 1);
                }
            }
            return matriz;
        }
        private void MostrarMatriz(int[,] matriz, DataGridView dataGridView)
        {
            dataGridView.ColumnCount = 5;
            dataGridView.RowCount = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridView[j, i].Value = matriz[i, j];
                }
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int limiteInferior = 1;
            int limiteSuperior = 100;

            // Generar la matriz.
            int[,] matriz = GenerarMatriz(limiteInferior, limiteSuperior);

            // Mostrar la matriz en el DataGridView.
            MostrarMatriz(matriz, dataGridView1);
        }
    }
}
