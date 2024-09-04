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

        private void Form1_Load(object sender, EventArgs e)
        {
            inicializarControles();
        }

        public int[,] matrix = new int[5,5];
        public int minimo = 0, maximo = 0;
        
        public void inicializarControles()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns.Clear();
        }
        private void LeerMatriz()
        {
             // Se asignan valores a las matriz

            minimo = Convert.ToInt32(nudFirst.Value);
            maximo = Convert.ToInt32(nudTwo.Value);

            Random MatrizRandom = new Random();


            //Se asignan los valores a la matriz
            for (int i = 0; i < matrix.GetLength(0); i ++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int randonNumber = MatrizRandom.Next(minimo, maximo + 1);
                    matrix[i, j] = randonNumber;
                }
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            LeerMatriz();
            mostrarMatriz();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            nudFirst.Value = 0;
            nudTwo.Value = 0;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mostrarMatriz()
        {

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = matrix.GetLength(1);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView1);

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row.Cells[j].Value = matrix[i,j];
                }

                dataGridView1.Rows.Add(row);
            }
        }

    }
}
