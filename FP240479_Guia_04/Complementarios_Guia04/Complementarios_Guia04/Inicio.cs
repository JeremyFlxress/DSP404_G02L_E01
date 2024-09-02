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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Ir_Click(object sender, EventArgs e)
        {
            string seleccion = comboBox1.SelectedItem?.ToString();

            switch (seleccion)
            {
                case "Ejercicio1":
                    Form1 form1 = new Form1();
                    form1.Show();
                    break;

                case "Ejercicio2":
                    Form2 formMatriz = new Form2();
                    formMatriz.Show();
                    break;

                case "Ejercicio3":
                    Form3 formNotas = new Form3();
                    formNotas.Show();
                    break;

                default:
                    MessageBox.Show("Por favor, selecciona un formulario válido.");
                    break;
            }
        }
    }
}
