namespace Discusion01
{
    public partial class Form1 : Form
    {
        // Declaración de la variable nombres
        private List<string> nombres;

        public Form1()
        {
            InitializeComponent();

            // Inicialización de la lista nombres
            nombres = new List<string>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // La lista ya está inicializada en el constructor
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            if (!string.IsNullOrEmpty(nombre) && !nombres.Contains(nombre))
            {
                nombres.Add(nombre);
                lstNombres.Items.Add(nombre);
                txtNombre.Clear();
            }
            else
            {
                MessageBox.Show("El nombre está vacío o ya existe en la lista.");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lstNombres.SelectedItem != null)
            {
                string nombre = lstNombres.SelectedItem.ToString();
                nombres.Remove(nombre);
                lstNombres.Items.Remove(nombre);
            }
            else
            {
                MessageBox.Show("Selecciona un nombre para borrar.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstNombres.SelectedItem != null)
            {
                string nombreNuevo = txtNombre.Text.Trim();
                if (!string.IsNullOrEmpty(nombreNuevo) && !nombres.Contains(nombreNuevo))
                {
                    string nombreAntiguo = lstNombres.SelectedItem.ToString();
                    int index = nombres.IndexOf(nombreAntiguo);
                    nombres[index] = nombreNuevo;

                    lstNombres.Items[lstNombres.SelectedIndex] = nombreNuevo;
                    txtNombre.Clear();
                }
                else
                {
                    MessageBox.Show("El nombre está vacío o ya existe en la lista.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un nombre para modificar.");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

