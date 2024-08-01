using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        private int[,] matrizOriginal;
        private int[,] matrizTranspuesta;

        public Form1()
        {
            InitializeComponent();
        }

        private int[,] GenerarMatrizAleatoria(int dimension)
        {
            Random random = new Random();
            int[,] matriz = new int[dimension, dimension];

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    matriz[i, j] = random.Next(1, 100);
                }
            }

            return matriz;
        }

        private int[,] CalcularMatrizTranspuesta(int[,] matriz)
        {
            int dimension = matriz.GetLength(0);
            int[,] transpuesta = new int[dimension, dimension];

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    transpuesta[j, i] = matriz[i, j];
                }
            }

            return transpuesta;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMatriz.Text, out int dimension))
            {
                if (dimension > 0)
                {
                    matrizOriginal = GenerarMatrizAleatoria(dimension);
                    matrizTranspuesta = CalcularMatrizTranspuesta(matrizOriginal);
                    MostrarMatricesEnDataGridView(matrizOriginal, dgMatriz);
                    MostrarMatricesEnDataGridView(matrizTranspuesta, dgTranspuesta);
                }
                else
                {
                    MessageBox.Show("La dimensión de la matriz debe ser mayor que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese una dimensión válida para la matriz.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void MostrarMatricesEnDataGridView(int[,] matriz, DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            int dimension = matriz.GetLength(0);
            for (int i = 0; i < dimension; i++)
            {
                dataGridView.Columns.Add($"col{i}", $"Col{i + 1}");
            }

            for (int i = 0; i < dimension; i++)
            {
                DataGridViewRow row = new DataGridViewRow();

                for (int j = 0; j < dimension; j++)
                {
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = matriz[i, j] });
                }

                dataGridView.Rows.Add(row);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
