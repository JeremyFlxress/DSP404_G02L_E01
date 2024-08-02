using System.Drawing.Drawing2D;

namespace Discusion02
{
    public partial class Form1 : Form
    {
        private int[,] matrizOriginal;
        private int[,] matrizTranspuesta;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Este método se llama cuando se carga el formulario.
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int dimension;
            if (int.TryParse(txtDimension.Text, out dimension) && dimension > 0)
            {
                matrizOriginal = new int[dimension, dimension];
                Random rnd = new Random();

                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        matrizOriginal[i, j] = rnd.Next(100); // Genera números aleatorios entre 0 y 99
                    }
                }

                MostrarMatriz(dgvMatriz, matrizOriginal);
            }
            else
            {
                MessageBox.Show("Introduce una dimensión válida.");
            }
        }

        private void btnTranspuesta_Click(object sender, EventArgs e)
        {
            if (matrizOriginal != null)
            {
                int dimension = matrizOriginal.GetLength(0);
                matrizTranspuesta = new int[dimension, dimension];

                for (int i = 0; i < dimension; i++)
                {
                    for (int j = 0; j < dimension; j++)
                    {
                        matrizTranspuesta[j, i] = matrizOriginal[i, j];
                    }
                }

                MostrarMatriz(dgvMatriz, matrizTranspuesta);
            }
            else
            {
                MessageBox.Show("Primero genera una matriz.");
            }
        }

        // Método para mostrar la matriz en un DataGridView
        private void MostrarMatriz(DataGridView dgv, int[,] matriz)
        {
            dgv.ColumnCount = matriz.GetLength(1);
            dgv.RowCount = matriz.GetLength(0);

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    dgv[j, i].Value = matriz[i, j];
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}