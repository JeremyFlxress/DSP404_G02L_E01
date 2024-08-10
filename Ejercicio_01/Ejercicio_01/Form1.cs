using System;
using System.Windows.Forms;

namespace Ejercicio_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbCategorias.Items.Add("Entretenimiento");
            cbCategorias.Items.Add("Libros");
            cbCategorias.Items.Add("Lenguajes de Programacion");
            btnLogin.Click += button1_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbCategorias.SelectedItem != null)
            {
                string seleccionCategoria = cbCategorias.SelectedItem.ToString();

            
                Form selectedForm;

                switch (seleccionCategoria)
                {
                    case "Entretenimiento":
                        selectedForm = new Login(); 
                        break;

                    case "Libros":
                        selectedForm = new Libros(); 
                        break;

                    case "Lenguajes de Programacion":
                        selectedForm = new LenguajesProgra(); 
                        break;

                    default:
                        MessageBox.Show("Por favor, seleccione una categoría válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }
                selectedForm.Show();
                this.Hide();
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
