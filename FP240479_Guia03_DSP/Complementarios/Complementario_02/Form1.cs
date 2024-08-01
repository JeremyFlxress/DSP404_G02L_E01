using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complementario_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dimension = (int)numericUpDownDimension.Value;
            int[,] matrix = GenerateRandomMatrix(dimension);
            DisplayMatrix(matrix, dataGridView1);
            int[,] transposedMatrix = TransposeMatrix(matrix);
            DisplayMatrix(transposedMatrix, dataGridView2);
        }

        private int[,] GenerateRandomMatrix(int dimension)
        {
            Random rand = new Random();
            int[,] matrix = new int[dimension, dimension];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    matrix[i,j] = rand.Next(100); // Esto significa que seran numeros aleatorios entre 0 y 99
                }
            }
            return matrix;
        }

        private void DisplayMatrix(int[,] matrix, DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            int dimension = matrix.GetLength(0);
            dataGridView.ColumnCount = dimension;
            for (int i = 0; i < dimension; i++)
            {
                dataGridView.Rows.Add();
                for (int j = 0; j < dimension; j++)
                {
                    dataGridView.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private int[,] TransposeMatrix(int[,] matrix)
        {
            int dimension = matrix.GetLength(0);
            int[,] transposedMatrix = new int[dimension, dimension];
            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    transposedMatrix[j, i] = matrix[i, j];
                }
            }
            return transposedMatrix;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
