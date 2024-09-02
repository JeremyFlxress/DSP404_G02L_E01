namespace Complementario1
{
    public partial class Form1 : Form
    {
        // Declaración de la lista 
        private List<int> lista;

        public Form1()
        {
            InitializeComponent();
            lista = new List<int>(); 
        }

        // Método para crear la lista vacía.
        private void CrearListaVacia()
        {
            lista = new List<int>();
            MostrarLista(lista, listBoxElementos); 
        }

        // Método para mostrar los elementos en un ListBox.
        private void MostrarLista(List<int> lista, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (var item in lista)
            {
                listBox.Items.Add(item);
            }
        }

       
        private void InsertarElemento(List<int> lista, int valor)
        {
            lista.Add(valor);
            MostrarLista(lista, listBoxElementos); 
        }

        // Método para remover el primer elemento de la lista.
        private void RemoverElemento(List<int> lista)
        {
            if (lista.Count > 0)
            {
                lista.RemoveAt(0);
                MostrarLista(lista, listBoxElementos); 
            }
            else
            {
                MessageBox.Show("La lista está vacía.");
            }
        }

        // Evento del botón Salir.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento del botón Crear Lista Vacía.
        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearListaVacia();
            MessageBox.Show("Lista creada.");
        }

        // Evento del botón Remover Elemento.
        private void btnRemover_Click(object sender, EventArgs e)
        {
            RemoverElemento(lista);
            MessageBox.Show("Elemento removido.");
        }

        
        private void btnInsertar_Click_1(object sender, EventArgs e)
        {
            int valor;
            if (int.TryParse(txtValor.Text, out valor)) 
            {
                InsertarElemento(lista, valor);
                MessageBox.Show("Elemento insertado.");
                txtValor.Clear(); 
            }
            else
            {
                MessageBox.Show("Ingrese un valor numérico válido.");
            }
        }

        // Evento del botón Mostrar Lista.
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarLista(lista, listBoxElementos);
        }
    }
}