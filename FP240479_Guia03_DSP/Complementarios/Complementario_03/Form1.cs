using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complementario_03
{
    public partial class Form1 : Form
    {
        private const int NumAlumnos = 6;
        private const int NumAsignaturas = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int?[,] grades = GenerateRandomGrades(NumAlumnos, NumAsignaturas);
            DisplayGrades(grades, dataGridViewGrades);
        }

        private int?[,] GenerateRandomGrades(int numAlumnos, int numAsignaturas)
        {
            Random rand = new Random();
            int?[,] grades = new int?[numAlumnos, numAsignaturas];

            for (int i = 0; i < numAlumnos; i++)
            {
                int subjects = rand.Next(2, numAsignaturas + 1); 
                for (int j = 0; j < subjects; j++)
                {
                    grades[i, j] = rand.Next(0, 10); 
                }
            }

            return grades;
        }

        private void DisplayGrades(int?[,] grades, DataGridView dataGridView)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();

            int numAlumnos = grades.GetLength(0);
            int numAsignaturas = grades.GetLength(1);

            dataGridView.ColumnCount = numAsignaturas + 1; 
            for (int i = 0; i < numAsignaturas; i++)
            {
                dataGridView.Columns[i].Name = $"Asignatura {i + 1}";
            }
            dataGridView.Columns[numAsignaturas].Name = "Media";

            for (int i = 0; i < numAlumnos; i++)
            {
                double sum = 0;
                int count = 0;
                string[] row = new string[numAsignaturas + 1];

                for (int j = 0; j < numAsignaturas; j++)
                {
                    if (grades[i, j].HasValue)
                    {
                        row[j] = grades[i, j].Value.ToString();
                        sum += grades[i, j].Value;
                        count++;
                    }
                    else
                    {
                        row[j] = "-";
                    }
                }

                double average = count > 0 ? sum / count : 0;
                row[numAsignaturas] = average.ToString("F2");

                dataGridView.Rows.Add(row);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
