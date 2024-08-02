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
        private double[,] matrizNotas = new double[6, 5];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            // Generar notas aleatorias
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    // Generar un número aleatorio entre 1 y 10
                    matrizNotas[i, j] = rand.Next(1, 11);
                }
            }

            // Limpiar el DataGridView
            dgNotas.Columns.Clear();
            dgNotas.Rows.Clear();

            // Crear columnas para el DataGridView
            dgNotas.ColumnCount = 7; // Cambiar a 7 para incluir la columna de promedio
            dgNotas.Columns[0].Name = "Alumno";
            for (int i = 1; i <= 5; i++)
            {
                dgNotas.Columns[i].Name = $"Materia {i}";
            }
            dgNotas.Columns[6].Name = "Promedio"; // Agregar la columna de promedio

            // Mostrar las notas y calcular el promedio
            for (int i = 0; i < 6; i++)
            {
                double sumaNotas = 0;
                int contadorAsignaturas = 0;
                string[] row = new string[7];
                row[0] = $"Alumno {i + 1}";

                for (int j = 0; j < 5; j++)
                {
                    if (j < 2 + rand.Next(4)) // Cada alumno tiene entre 2 y 5 materias
                    {
                        row[j + 1] = matrizNotas[i, j].ToString();
                        sumaNotas += matrizNotas[i, j];
                        contadorAsignaturas++;
                    }
                    else
                    {
                        row[j + 1] = "";
                    }
                }

                // Calcular el promedio solo si hay asignaturas
                if (contadorAsignaturas > 0)
                {
                    double promedio = sumaNotas / contadorAsignaturas;
                    row[6] = promedio.ToString("F2"); // Mostrar con dos decimales
                }
                else
                {
                    row[6] = "N/A";
                }

                dgNotas.Rows.Add(row);
            }
        }   

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
