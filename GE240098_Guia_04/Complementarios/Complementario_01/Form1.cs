using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complemetario_01
{
    public partial class Form1 : Form
    {
        public class ListaSimulada
        {
            // a) Crear lista vacía
            public void CrearListaVacia(ref int[] vector)
            {
                vector = new int[0]; 
            }

            // b) Mostrar listado de elementos en el ListBox
            public void MostrarElementos(int[] vector, ListBox listBox)
            {
                listBox.Items.Clear(); 

                foreach (int elemento in vector)
                {
                    listBox.Items.Add(elemento);
                }
            }

            // c) Insertar elemento en la lista
            public void InsertarElemento(ref int[] vector, int valor)
            {
                int nuevoTamaño = vector.Length + 1;
                Array.Resize(ref vector, nuevoTamaño); 
                vector[nuevoTamaño - 1] = valor; 
            }

            // d) Remover el primer elemento
            public void RemoverElemento(ref int[] vector)
            {
                if (vector.Length == 0) return; 

                for (int i = 0; i < vector.Length - 1; i++)
                {
                    vector[i] = vector[i + 1]; 
                }

                Array.Resize(ref vector, vector.Length - 1);
            }
        }
        public Form1()
        {

            InitializeComponent();
            listaSimulada = new ListaSimulada();
        }

        private int[] vector;
        private ListaSimulada listaSimulada;

        private void btnCrearLista_Click(object sender, EventArgs e)
        {
            listaSimulada.CrearListaVacia(ref vector);
            MessageBox.Show("Lista vacía creada.", "Informacion", MessageBoxButtons.OK);
        }

        private void btnMostrarElementos_Click(object sender, EventArgs e)
        {
            listaSimulada.MostrarElementos(vector, listBox1);
        }

        private void btnInsertarElemento_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValor.Text, out int valor))
            {
                listaSimulada.InsertarElemento(ref vector, valor);
                MessageBox.Show($"Elemento {valor} insertado.");
                txtValor.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnRemoverElemento_Click(object sender, EventArgs e)
        {
            listaSimulada.RemoverElemento(ref vector);
            MessageBox.Show("Primer elemento eliminado.", "Eliminacion", MessageBoxButtons.OK);
        }
    }
}
