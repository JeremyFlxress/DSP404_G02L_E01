using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Ejercicio_01
{
    public partial class Form1 : Form
    {
        public string CategoriaSeleccionada {  get; set; }

        public Form1()
        {
            InitializeComponent();

            cbCategorias.Items.Add("Entretenimiento");
            cbCategorias.Items.Add("Libros");
            cbCategorias.Items.Add("Lenguajes de Programacion");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoriaSeleccionada = cbCategorias.SelectedItem.ToString();
            if (cbCategorias.SelectedItem != null)
            {
                string[] nombres = { "Jeremy", "Edgar", "William", "Josue" };
                string[] contraseñas = { "Jeremy2344", "Edgar2402", "William4236", "Josue1234" };

                string seleccionCategoria = cbCategorias.SelectedItem.ToString();


                for (int i = 0; i < nombres.Length; i++)
                {
                    if (txtNombre.Text == nombres[i] && txtContraseña.Text == contraseñas[i])
                    {
                        Form selectedForm;
                        switch (seleccionCategoria)
                        {
                            case "Entretenimiento":
                                selectedForm = new Login(CategoriaSeleccionada);
                                break;

                            case "Libros":
                                selectedForm = new Libros(CategoriaSeleccionada);
                                break;

                            case "Lenguajes de Programacion":
                                selectedForm = new LenguajesProgra(CategoriaSeleccionada);
                                break;

                            default:
                                MessageBox.Show("Por favor, seleccione una categoría válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                        }
                        selectedForm.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una categoría antes de ingresar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }
    }
}
