using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Ejercicio_01
{
    public partial class Estadística : Form
    {
        public string categoria;

        public Estadística(string categoriaSeleccionada)
        {
            InitializeComponent();

            categoria = categoriaSeleccionada;
        }

        private void Estadística_Load(object sender, EventArgs e)
        {
            switch (categoria)
            {
                case "Entretenimiento":
                    chartEstadistica.Titles.Add("Entretenimiento");
                    string[] seriesEntretimiento = { "Game of Thrones", "Chernobyl", "The Marvelous Mrs. Maisel" };
                    int[] puntosEntretimiento = { 40, 34, 26};

                    for (int i = 0; i < seriesEntretimiento.Length; i++)
                    {
                        Series serie = chartEstadistica.Series.Add(seriesEntretimiento[i]);
                        serie.Label = puntosEntretimiento[i].ToString();
                        serie.Points.Add(puntosEntretimiento[i]);
                    }
                    break;

                case "Libros":
                    chartEstadistica.Titles.Add("Libros");
                    string[] seriesLibros = { "Harry Poter", "Goosebumps", "Perry Mason" };
                    int[] puntosLibros = { 40, 34, 26 };

                    for (int i = 0; i < seriesLibros.Length; i++)
                    {
                        Series serie = chartEstadistica.Series.Add(seriesLibros[i]);
                        serie.Label = puntosLibros[i].ToString();
                        serie.Points.Add(puntosLibros[i]);
                    }
                    break;

                case "Lenguajes de Programacion":
                    chartEstadistica.Titles.Add("Lenguajes de Programacion");
                    string[] seriesProgra = { "Python", "Java", "JavaScript" };
                    int[] puntosProgra = { 40, 34, 26 };

                    for (int i = 0; i < seriesProgra.Length; i++)
                    {
                        Series serie = chartEstadistica.Series.Add(seriesProgra[i]);
                        serie.Label = puntosProgra[i].ToString();
                        serie.Points.Add(puntosProgra[i]);
                    }
                    break;

                default:
                    MessageBox.Show("Por favor, seleccione una categoría válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Close();
        }

    }
}