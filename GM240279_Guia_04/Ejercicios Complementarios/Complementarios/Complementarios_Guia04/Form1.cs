using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        private int[] lista;
        public Form1()
        {
            InitializeComponent();

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            CrearLista(ref lista);
            MessageBox.Show("Lista creada exitosamente.");
        }
        private void CrearLista(ref int[] lista)
        {
            lista = new int[0];  // Crea un arreglo de tamaño 0.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarLista(lista, listBox1);
        }
        private void MostrarLista(int[] lista, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (int item in lista)
            {
                listBox.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nuevoElemento;
            if (int.TryParse(textBox1.Text, out nuevoElemento))
            {
                InsertarElemento(ref lista, nuevoElemento);
                MessageBox.Show("Elemento insertado exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido.");
            }
        }
        private void InsertarElemento(ref int[] lista, int valor)
        {
            Array.Resize(ref lista, lista.Length + 1);
            lista[lista.Length - 1] = valor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lista.Length > 0)
            {
                RemoverElemento(ref lista);
                MessageBox.Show("Primer elemento removido exitosamente.");
            }
            else
            {
                MessageBox.Show("La lista está vacía.");
            }
        }
        private void RemoverElemento(ref int[] lista)
        {
            if (lista.Length > 0)
            {
                for (int i = 1; i < lista.Length; i++)
                {
                    lista[i - 1] = lista[i];
                }
                Array.Resize(ref lista, lista.Length - 1);
            }
        }
    }
}
