using System;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            InicializarComboboxes();
        }

        private void InicializarComboboxes()
        {
            // Inicializar el combobox de mes
            cboMes.Items.AddRange(new string[]
            {
                "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
                "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            });

            // Inicializar el combobox de año
            for (int i = 1900; i <= DateTime.Now.Year; i++)
            {
                cboAnio.Items.Add(i.ToString());
            }

            // Inicializar el combobox de día vacío
            cboDia.Items.Clear();
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por confiar en nosotros", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void cboMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDias();
        }

        private void cboAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDias();
        }

        private void ActualizarDias()
        {
            if (!SeleccionValida()) return;

            if (!int.TryParse(cboAnio.SelectedItem?.ToString(), out int anio))
            {
                MessageBox.Show("El año seleccionado no es válido.");
                return;
            }

            int diasEnMes;

            switch (cboMes.SelectedIndex)
            {
                case 0: // Enero
                case 2: // Marzo
                case 4: // Mayo
                case 6: // Julio
                case 7: // Agosto
                case 9: // Octubre
                case 11: // Diciembre
                    diasEnMes = 31;
                    break;
                case 3: // Abril
                case 5: // Junio
                case 8: // Septiembre
                case 10: // Noviembre
                    diasEnMes = 30;
                    break;
                case 1: // Febrero
                    diasEnMes = DateTime.IsLeapYear(anio) ? 29 : 28;
                    break;
                default:
                    diasEnMes = 0;
                    break;
            }

            cboDia.Items.Clear();
            for (int i = 1; i <= diasEnMes; i++)
            {
                cboDia.Items.Add(i.ToString());
            }
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (!SeleccionValida() || cboDia.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una fecha válida.");
                return;
            }

            string mes = cboMes.SelectedItem?.ToString();
            if (!int.TryParse(cboDia.SelectedItem?.ToString(), out int dia))
            {
                MessageBox.Show("El día seleccionado no es válido.");
                return;
            }

            if (!int.TryParse(cboAnio.SelectedItem?.ToString(), out int anio))
            {
                MessageBox.Show("El año seleccionado no es válido.");
                return;
            }

            MessageBox.Show($"Fecha ingresada: {mes} {dia}, {anio}");
        }

        private bool SeleccionValida()
        {
            return cboMes.SelectedIndex != -1 && cboAnio.SelectedIndex != -1;
        }
    }
}
