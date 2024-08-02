namespace Discusion03
{
    using System;
    using System.Windows.Forms;

    public partial class Form1 : Form
    {
        private int[,] notas; // Matriz para almacenar las notas de los alumnos

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarNotas(); // Inicializa las notas de los alumnos
            MostrarNotas();     // Muestra las notas en el DataGridView
        }

        private void InicializarNotas()
        {
            notas = new int[6, 5]; // Crea una matriz de 6 filas (alumnos) y 5 columnas (asignaturas)
            Random rnd = new Random();

            for (int i = 0; i < 6; i++)
            {
                int numAsignaturas = rnd.Next(2, 6); // Genera un número aleatorio de asignaturas entre 2 y 5

                for (int j = 0; j < numAsignaturas; j++)
                {
                    notas[i, j] = rnd.Next(1, 11); // Asigna una nota aleatoria entre 1 y 10
                }

                for (int j = numAsignaturas; j < 5; j++)
                {
                    notas[i, j] = -1; // Indica que el alumno no cursa esta asignatura con -1
                }
            }
        }

        private void MostrarNotas()
        {
            dgvNotas.Columns.Clear();
            dgvNotas.ColumnCount = 6; // Configura 6 columnas: 1 para "Alumno" y 5 para "Asignaturas"

            dgvNotas.Columns[0].Name = "Alumno";
            for (int j = 1; j <= 5; j++)
            {
                dgvNotas.Columns[j].Name = $"Asignatura {j}";
            }

            dgvNotas.Rows.Clear();
            for (int i = 0; i < 6; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvNotas);
                row.Cells[0].Value = $"Alumno {i + 1}";

                for (int j = 0; j < 5; j++)
                {
                    row.Cells[j + 1].Value = notas[i, j] != -1 ? (object)notas[i, j] : ""; // Muestra la nota si no es -1
                }
                dgvNotas.Rows.Add(row);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dgvMedia.Columns.Clear();
            dgvMedia.ColumnCount = 2; // Configura 2 columnas: 1 para "Alumno" y 1 para "Media"

            dgvMedia.Columns[0].Name = "Alumno";
            dgvMedia.Columns[1].Name = "Media";

            dgvMedia.Rows.Clear();
            for (int i = 0; i < 6; i++)
            {
                int suma = 0;
                int count = 0;

                for (int j = 0; j < 5; j++)
                {
                    if (notas[i, j] != -1) // Solo sumar las notas de las asignaturas que el alumno cursa
                    {
                        suma += notas[i, j];
                        count++;
                    }
                }

                double media = count > 0 ? (double)suma / count : 0;

                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvMedia);
                row.Cells[0].Value = $"Alumno {i + 1}";
                row.Cells[1].Value = media;
                dgvMedia.Rows.Add(row);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }
    }
}







