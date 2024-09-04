using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complementarios_Guia04
{
    public partial class Form3 : Form
    {
        private void CalcularEstadisticas(List<double> notas, ListBox listBox)
        {
            int deficientes = notas.Count(nota => nota < 5.0);
            int aprobados = notas.Count(nota => nota >= 6.0);
            double notaMin = notas.Min();
            double notaMax = notas.Max();
            double notaMedia = notas.Average();

            double porcentajeDeficientes = (double)deficientes / notas.Count * 100;

            listBox.Items.Clear();
            listBox.Items.Add($"Porcentaje de Deficientes: {porcentajeDeficientes}%");
            listBox.Items.Add($"Número de Aprobados: {aprobados}");
            listBox.Items.Add($"Nota Mínima: {notaMin}");
            listBox.Items.Add($"Nota Máxima: {notaMax}");
            listBox.Items.Add($"Nota Media: {notaMedia}");
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<double> notas = new List<double> { 7.5, 4.8, 6.3, 9.0, 2.5, 5.5, 8.7, 6.0, 3.2 };

            // Calcular y mostrar estadísticas en el ListBox.
            CalcularEstadisticas(notas, listBox1);
        }
    }
}
