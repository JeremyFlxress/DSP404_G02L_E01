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

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int dimension;
            if (int.TryParse(txtDimension.Text, out dimension) && dimension > 0)
            {
                int[,] matrix = new int[dimension, dimension];
                Random rand = new Random();

                // Generar la matriz original
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        matrix[i, j] = rand.Next(1, 100); // Generar números aleatorios entre 1 y 100
                    }
                }

                // Mostrar la matriz original
                txtOriginalMatriz.Clear();
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        txtOriginalMatriz.AppendText(matrix[i, j] + "\t");
                    }
                    txtOriginalMatriz.AppendText(Environment.NewLine);
                }

                // Calcular y mostrar la matriz traspuesta
                int[,] transposedMatrix = new int[dimension, dimension];
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        transposedMatrix[i, j] = matrix[j, i];
                    }
                }

                txtTranspuesta.Clear();
                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        txtTranspuesta.AppendText(transposedMatrix[i, j] + "\t");
                    }
                    txtTranspuesta.AppendText(Environment.NewLine);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una dimensión válida (número entero positivo).");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtTranspuesta.Clear();
            txtOriginalMatriz.Clear();
            txtDimension.Clear();
            txtDimension.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
