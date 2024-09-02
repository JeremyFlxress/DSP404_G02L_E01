using System.Drawing.Drawing2D;

namespace complementario2
{
    public partial class Form1 : Form
    {
        // Declaración de la matriz que se generará.
        private int[,] matriz;

        public Form1()
        {
            InitializeComponent();
            matriz = new int[5, 5]; // Inicializa la matriz 5x5.
        }

        // Método para generar una matriz de 5x5 con números aleatorios entre los límites dados.
        private int[,] GenerarMatriz(int limiteInferior, int limiteSuperior)
        {
            Random random = new Random();
            int[,] matriz = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = random.Next(limiteInferior, limiteSuperior + 1);
                }
            }

            return matriz;
        }

        // Método para mostrar la matriz en un DataGridView.
        private void MostrarMatriz(int[,] matriz, DataGridView dgv)
        {
            dgv.ColumnCount = 5;
            dgv.RowCount = 5;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dgv.Rows[i].Cells[j].Value = matriz[i, j];
                }
            }
        }
    

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int limiteInferior, limiteSuperior;

            // Verifica que los límites sean válidos.
            if (int.TryParse(txtLimiteInferior.Text, out limiteInferior) && int.TryParse(txtLimiteSuperior.Text, out limiteSuperior))
            {
                // Asegura que el límite inferior sea menor o igual al superior.
                if (limiteInferior <= limiteSuperior)
                {
                    matriz = GenerarMatriz(limiteInferior, limiteSuperior);
                    MessageBox.Show("Matriz generada.");
                }
                else
                {
                    MessageBox.Show("El límite inferior debe ser menor o igual al límite superior.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos para los límites.");
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            {
                MostrarMatriz(matriz, dgvMatriz);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
