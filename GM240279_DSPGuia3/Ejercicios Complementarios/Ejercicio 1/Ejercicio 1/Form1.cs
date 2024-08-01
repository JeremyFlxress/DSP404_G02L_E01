using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<string> nombres = new List<string>();

        private void ActualizarListBox()
        {
            // Limpiar la lista y agregar los nombres de la lista
            lstNombres.Items.Clear();
            foreach (string nombre in nombres)
            {
                lstNombres.Items.Add(nombre);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarListBox();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (!string.IsNullOrEmpty(nombre))
            {
                nombres.Add(nombre);

                txtNombre.Clear();

                ActualizarListBox();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lstNombres.SelectedIndex != -1)
            {
                int indice = lstNombres.SelectedIndex;
                nombres.RemoveAt(indice);
                ActualizarListBox();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un nombre para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstNombres.SelectedIndex != -1)
            {
                int indice = lstNombres.SelectedIndex;
                string nuevoNombre = txtNombre.Text.Trim();

                if (!string.IsNullOrEmpty(nuevoNombre))
                {
                    nombres[indice] = nuevoNombre;
                    txtNombre.Clear();
                    ActualizarListBox();
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un nombre válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un nombre para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
