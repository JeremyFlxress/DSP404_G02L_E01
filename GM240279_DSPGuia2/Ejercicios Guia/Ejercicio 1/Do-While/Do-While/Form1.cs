using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Do_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCantPersonas.Clear();
            txtPromedio.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int cantAlumnos, nota;
            Double promedio = 0;
            cantAlumnos = Convert.ToInt32(txtCantPersonas.Text);
            for (int i = 1; i <= cantAlumnos; i++)
            {
                do
                {
                    nota = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese la Nota del alumno " + i, " Notas"));
                } while (nota <= 0 || nota >= 20);
                promedio = promedio + nota;
            }
            txtPromedio.Text = Convert.ToString(promedio);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
