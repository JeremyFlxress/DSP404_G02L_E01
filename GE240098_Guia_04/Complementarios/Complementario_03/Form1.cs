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
        public Form1()
        {
            InitializeComponent();
        }

        private void InicializorControles()
        {
            nudCantidadNotas.Focus();

            nudCantidadNotas.Minimum = 0;
            nudCantidadNotas.Maximum = 10;
            nudCantidadNotas.Increment = 1;

            lstResultados.Items.Clear();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializorControles();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            nudCantidadNotas.Value = 0;
            lstResultados.Items.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            leerDatos();
            CalcularSumaNotas();
            lstResultados.Items.Add("Porcentaje de estudiantes Deficientes: " 
                + estudiantesDeficientes().ToString() + "%");
            lstResultados.Items.Add("Cantidad de estudiantes Aprobados: " + numeroAprobados().ToString());
            lstResultados.Items.Add("La nota más baja es: " + notaBaja().ToString());
            lstResultados.Items.Add("La nota más alta es: " + notaAlta().ToString());
            lstResultados.Items.Add("El promedio de notas es: " + Promedio().ToString());
        }

        //Boton para salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        int cant = 0;
        int[] cantidadAlumnos;
        decimal promedio = 0;
        decimal sumaNotas;

        private void leerDatos()
        {
            // Lee la cantidad de notas que se van a ingresar
            cant = Convert.ToInt32(nudCantidadNotas.Value);
            cantidadAlumnos = new int[cant];

            for (int i = 0; i < cant; i++)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Digite la nota del alumno (0 - 10): ");
                int nota;
                // Validar la entrada del usuario y asegurar que esté en el rango de 0 a 10
                while (!int.TryParse(input, out nota) || nota < 0 || nota > 10)
                {
                    MessageBox.Show("Por favor, ingrese un número válido entre 0 y 10.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    input = Microsoft.VisualBasic.Interaction.InputBox("Digite la nota del alumno (0 - 10): ");
                }
                // Asignar la nota validada al arreglo
                cantidadAlumnos[i] = nota;
            }
        }


        private void CalcularSumaNotas()
        {
            sumaNotas = 0;
            foreach (int nota in cantidadAlumnos)
            {
                sumaNotas += nota; 
            }
        }
        private decimal Promedio()
        {
            return sumaNotas / (decimal)cant; // Devuelve el promedio calculado
        }

        private decimal notaAlta()
        {
            decimal notaMayor = 0;
            
            foreach (int nota in cantidadAlumnos)
            {
                if (nota > notaMayor)
                {
                    notaMayor = nota;
                }
            }
                return notaMayor;
        }
        private decimal notaBaja()
        {
            decimal notaMenor = 10;
            foreach(int nota in cantidadAlumnos)
            {
                if (nota < notaMenor)
                {
                    notaMenor = nota;
                }
            }
            return notaMenor;
        }
        private Decimal estudiantesDeficientes()
        {
            int estudiantesConBajaNota = 0;

            foreach (int nota in cantidadAlumnos)
            {
                if (nota < 5)
                {
                    estudiantesConBajaNota++;
                }
            }
            //Calculando el porcentaje de los estudiantes deficientes
            decimal porcentaje = Math.Round(((decimal)estudiantesConBajaNota / cant ) * 100); 
            return porcentaje;
        }
        private int numeroAprobados()
        {
            int estudiantesConBuenaNota = 0;

            foreach (int nota in cantidadAlumnos)
            {
                if (nota >= 6)
                {
                    estudiantesConBuenaNota++;
                }
            }
            return estudiantesConBuenaNota;
        }

    }
}
