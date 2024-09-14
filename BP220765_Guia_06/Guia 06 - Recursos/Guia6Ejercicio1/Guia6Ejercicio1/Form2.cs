using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia6Ejercicio1
{
    public partial class Form2 : Form
    {
        public partial class Form2 : Form
        {
            // Declara dos listas basadas en objetos de ambas clases derivadas
            List<clsDoctor> doctores;
            List<clsVendedor> vendedores;

            // Prepara objeto para generar cuadro de diálogo de selección de archivo
            OpenFileDialog cuadroSeleccion = new OpenFileDialog();

            // Constructor del formulario
            public Form2()
            {
                
                doctores = new List<clsDoctor>();
                vendedores = new List<clsVendedor>();
                llenarcombobox();
            }

            // Métodos de la clase Form1

            // Método para generar las secuencias de días, meses y años en ComboBox
            private void llenarcombobox()
            {
                int c; // Contador usos varios

                // Primero días
                for (c = 1; c <= 31; c++)
                    cmbDia.Items.Add(c);
                cmbDia.Text = DateTime.Now.Day.ToString();

                // Luego meses
                for (c = 1; c <= 12; c++)
                    cmbMes.Items.Add(c);
                cmbMes.Text = DateTime.Now.Month.ToString();

                // Finalmente años
                for (c = 1950; c <= DateTime.Now.Year; c++)
                    cmbAnno.Items.Add(c);
                cmbAnno.Text = DateTime.Now.Year.ToString();
            }

            private void PrepararNuevoDoctor()
            {
                // Deja los controles listos para el próximo doctor a ingresar
                txtNom.Clear();
                picFotoDoc.ImageLocation = Application.StartupPath + "\\Desconocido.jpg";
                cmbDia.SelectedIndex = 0;
                cmbMes.SelectedIndex = 0;
                cmbAnno.SelectedIndex = 0;
                nudSueldo.Value = 1.00M;
                mtbCodDoctor.Clear();
                txtNom.Focus();
            }

            private void PrepararNuevoVendedor()
            {
                // Deja los controles listos para el próximo vendedor a ingresar
                txtNomV.Clear();
                picFotoVen.ImageLocation = Application.StartupPath + "\\Desconocido.jpg";
                dtpFechaNac.Value = DateTime.Now;
                dtpFechaC.Value = DateTime.Now;
                txtNomV.Focus();
            }

            public void MostrarLista_Doctores()
            {
                // Recorre la colección doctores para mostrar datos en el DataGridView
                int cm = 0;
                int i;
                // Se ajusta el título de la última columna de la grilla
                dataGridView1.Columns[4].HeaderText = "Codigo";
                dataGridView1.Rows.Clear();
                // Se llena la grilla con filas para los doctores registrados
                for (i = 0; i < doctores.Count; i++)
                    dataGridView1.Rows.Add();
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    if (cm >= doctores.Count) break; // Evita desbordamiento si hay más filas que doctores
                                                     // De cada objeto Doctor de la lista, extrae valores de sus campos privados
                    fila.Cells[0].Value = cm + 1;
                    fila.Cells[1].Value = doctores[cm].nombreempleado;
                    fila.Cells[2].Value = Image.FromFile(doctores[cm].URLfoto);
                    fila.Cells[3].Value = doctores[cm].fecha_nacimiento;
                    fila.Cells[4].Value = doctores[cm].codigodoctor;
                    cm++;
                }
            }

            public void MostrarLista_Vendedores()
            {
                // Recorre la colección vendedores para mostrar datos en el DataGridView
                int cm = 0;
                int i;
                // Ajusta el título de la última columna de la grilla
                dataGridView1.Columns[4].HeaderText = "Fecha Contrato";
                dataGridView1.Rows.Clear();
                // Se llena la grilla con filas para los vendedores registrados
                for (i = 0; i < vendedores.Count; i++)
                    dataGridView1.Rows.Add();
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    if (cm >= vendedores.Count) break; // Evita desbordamiento si hay más filas que vendedores
                    fila.Cells[0].Value = cm + 1;
                    fila.Cells[1].Value = vendedores[cm].nombreempleado;
                    fila.Cells[2].Value = Image.FromFile(vendedores[cm].URLfoto);
                    fila.Cells[3].Value = vendedores[cm].fecha_nacimiento;
                    fila.Cells[4].Value = vendedores[cm].FechaContrato;
                    cm++;
                }
            }
        }
    }
}
