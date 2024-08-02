using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_2.Videos
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Declarar variables
            int cantAlumnos, nota;
            double promedio = 0;

            //Entrada de datos
            cantAlumnos = Convert.ToInt32(txtCantAlumnos.Text);

            //Proceso de datos
            //Implementar un bucle for para pedir las notas de los alumnos
            for (int i = 1; i <= cantAlumnos; i++)
            {
                //Leer la nota del alumno n

                do
                {
                    nota = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese nota del alumno " + i, "Registro de notas"));
                }
                while (nota < 0 || nota > 20);

                promedio += nota;
                
            }
            //Salida de la información 
            txtPromedio.Text = Convert.ToString(promedio / cantAlumnos);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPromedio.Clear();
            txtCantAlumnos.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
