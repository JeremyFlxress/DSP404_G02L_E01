using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01
{
    public partial class Login : Form
    {
        private string categoria;

        public Login(string selecionCategoria)
        {
            InitializeComponent();
            categoria = selecionCategoria;

            ActualizarContenido();
        }

        private void ActualizarContenido()
        {
            switch (categoria)
            {
                case "Entretenimiento":
                    lblTitulo1.Text = "Game Of Thrones";
                    txtInformacion.Text = "Pruebas Entretenimiento";
                    break;
                case "Libros":
                    lblTitulo1.Text = "Harry Potter";
                    txtInformacion.Text = "Pruebas Libros";
                    break;
                case "Lenguajes de Programacion":
                    lblTitulo1.Text = "JavaScript";
                    txtInformacion.Text = "Pruebas Piton";
                    break;
                default:
                    break;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Close();
            form1.Close();
        }
    }
}
