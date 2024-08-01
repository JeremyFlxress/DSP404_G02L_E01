using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int NUM_ALUMNOS = 6;
        private const int NUM_ASIGNATURAS = 5;

        private double[,] notasAlumnos = new double[NUM_ALUMNOS, NUM_ASIGNATURAS];

        private void Form1_Load(object sender, EventArgs e)
        {
            dgrNotas.ColumnCount = NUM_ASIGNATURAS + 1;
            dgrNotas.Columns[0].HeaderText = "Alumno";

            for (int i = 0; i < NUM_ASIGNATURAS; i++)
            {
                dgrNotas.Columns[i + 1].HeaderText = $"Asignatura {i + 1}";
            }

            for (int i = 0; i < NUM_ALUMNOS; i++)
            {
                dgrNotas.Rows.Add($"Alumno {i + 1}");
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            GenerarNotasAleatorias();
            MostrarNotasEnDataGridView();
        }

        private void GenerarNotasAleatorias()
        {
            Random random = new Random();

            for (int i = 0; i < NUM_ALUMNOS; i++)
            {
                int numAsignaturas = random.Next(2, 6);

                for (int j = 0; j < numAsignaturas; j++)
                {
                    notasAlumnos[i, j] = random.Next(1, 11);
                }
            }
        }

        private void MostrarNotasEnDataGridView()
        {
            dgrNotas.Rows.Clear();

            for (int i = 0; i < NUM_ALUMNOS; i++)
            {
                double sumaNotas = 0;
                int numAsignaturas = 0;
                dgrNotas.Rows.Add($"Alumno {i + 1}");

                for (int j = 0; j < NUM_ASIGNATURAS; j++)
                {
                    double nota = notasAlumnos[i, j];
                    dgrNotas.Rows[i].Cells[j + 1].Value = nota;

                    if (nota > 0)
                    {
                        sumaNotas += nota;
                        numAsignaturas++;
                    }
                }

                if (numAsignaturas > 0)
                {
                    double media = sumaNotas / numAsignaturas;
                    dgrNotas.Rows[i].Cells[NUM_ASIGNATURAS].Value = media.ToString("0.00");
                }
            }
        }
    }
}
