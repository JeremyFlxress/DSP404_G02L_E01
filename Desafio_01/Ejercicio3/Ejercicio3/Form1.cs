using System.Xml.Serialization;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        private List<Tarea> tareasPendientes = new List<Tarea>();
        private List<Tarea> tareasCompletadas = new List<Tarea>();

        public Form1()
        {
            InitializeComponent();
            
        }



        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreTarea.Text))
            {
                MessageBox.Show("El nombre de la tarea no puede estar vacío.");
                return;
            }

            var tarea = new Tarea
            {
                Nombre = txtNombreTarea.Text,
                FechaLimite = dtpFechaLimite.Value
            };
            tareasPendientes.Add(tarea);
            ActualizarListaTareas();
            txtNombreTarea.Clear();
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            // Verificar si hay una tarea seleccionada en la lista de tareas pendientes
            if (lstTareasPendientes.SelectedIndex >= 0)
            {
                tareasPendientes.RemoveAt(lstTareasPendientes.SelectedIndex);
                ActualizarListaTareas();
            }
            // Verificar si hay una tarea seleccionada en la lista de tareas completadas
            else if (lstTareasCompletadas.SelectedIndex >= 0)
            {
                tareasCompletadas.RemoveAt(lstTareasCompletadas.SelectedIndex);
                ActualizarListaTareasCompletadas();
            }
        }

        private void btnEditarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareasPendientes.SelectedIndex >= 0)
            {
                var tarea = tareasPendientes[lstTareasPendientes.SelectedIndex];
                tarea.Nombre = txtNombreTarea.Text;
                tarea.FechaLimite = dtpFechaLimite.Value;
                ActualizarListaTareas();
            }
            else if (lstTareasCompletadas.SelectedIndex >= 0)
            {
                var tarea = tareasCompletadas[lstTareasCompletadas.SelectedIndex];
                tarea.Nombre = txtNombreTarea.Text;
                tarea.FechaLimite = dtpFechaLimite.Value;
                ActualizarListaTareasCompletadas();
            }
        }

        private void btnCompletarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareasPendientes.SelectedIndex >= 0)
            {
                var tarea = tareasPendientes[lstTareasPendientes.SelectedIndex];
                tareasPendientes.Remove(tarea);
                tareasCompletadas.Add(tarea);
                ActualizarListaTareas();
                ActualizarListaTareasCompletadas();
            }
        }

        private void ActualizarListaTareas()
        {
            lstTareasPendientes.Items.Clear();
            foreach (var tarea in tareasPendientes.OrderBy(t => t.FechaLimite))
            {
                lstTareasPendientes.Items.Add($"{tarea.Nombre} - {tarea.FechaLimite.ToShortDateString()}");
            }
        }

        private void ActualizarListaTareasCompletadas()
        {
            lstTareasCompletadas.Items.Clear();
            foreach (var tarea in tareasCompletadas)
            {
                lstTareasCompletadas.Items.Add($"{tarea.Nombre} - {tarea.FechaLimite.ToShortDateString()}");
            }
        }

        

       

       

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            // Crear un archivo de texto con las tareas completadas
            try
            {
                using (var writer = new StreamWriter("tareasCompletadasOutput.txt"))
                {
                    foreach (var tarea in tareasCompletadas)
                    {
                        writer.WriteLine($"{tarea.Nombre} - {tarea.FechaLimite.ToShortDateString()}");
                    }
                }
                MessageBox.Show("Las tareas completadas se han guardado en tareasCompletadasOutput.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar las tareas completadas en el archivo de texto: {ex.Message}");
            }
        }
    }
    

    
    public class Tarea
    {
        public string Nombre { get; set; }
        public DateTime FechaLimite { get; set; }
    }
}


