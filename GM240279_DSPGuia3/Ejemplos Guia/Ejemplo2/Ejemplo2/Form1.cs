using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {

        string[,] matriz = new string[3, 3];
        public int fila1, colum1, fila2, colum2, fila3, colum3, countergen, i, p, z;

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double promedio = 0, contenedor = 0, cantidad;

            for (p = 0; p < 3; p++)
            {
                cantidad = double.Parse(matriz[p, 2]);
                contenedor += cantidad;
            }

            promedio = contenedor / 3;
            MessageBox.Show("El promedio de las edades es: " + promedio);
        }    

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgDatos.Rows.Clear();
            dgDatos.Columns.Clear();
            fila1 = 0;
            fila2 = 0;
            fila3 = 0;
        }

        private void lblMostrar_Click(object sender, EventArgs e)
        {
            //limpiando grilla
            dgDatos.Columns.Clear();
            //creando columnas
            dgDatos.ColumnCount = 3;
            dgDatos.Columns[0].Name = "Nombre";
            dgDatos.Columns[1].Name = "Apellido";
            dgDatos.Columns[2].Name = "Edad";
            dgDatos.Rows.Add();
            dgDatos.Rows.Add();
            //agregando datos a grilla
            //Mostrando nombres
            dgDatos.Rows[0].Cells[0].Value = matriz[0, 0];
            dgDatos.Rows[0].Cells[1].Value = matriz[0, 1];
            dgDatos.Rows[0].Cells[2].Value = matriz[0, 2];
            //Mostrando apellidos
            dgDatos.Rows[1].Cells[0].Value = matriz[1, 0];
            dgDatos.Rows[1].Cells[1].Value = matriz[1, 1];
            dgDatos.Rows[1].Cells[2].Value = matriz[1, 2];
            //Mostrando edades
            dgDatos.Rows[2].Cells[0].Value = matriz[2, 0];
            dgDatos.Rows[2].Cells[1].Value = matriz[2, 1];
            dgDatos.Rows[2].Cells[2].Value = matriz[2, 2];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            colum1 = 0;
            colum2 = 1;
            colum3 = 2;
            //verificamos el combobox1
            if (cbInformacion.SelectedIndex == 0)
            {
                if (txtInformacion.Text == "")
                    txtInformacion.BackColor = Color.Bisque;
                else
                {
                    if (fila1 < 3)
                    {
                        matriz[fila1, colum1] = txtInformacion.Text;
                        fila1 += 1;
                        MessageBox.Show("Nombre ingresado exitosamente", "", MessageBoxButtons.OK);
                        txtInformacion.Clear();
                    }
                    else
                        MessageBox.Show("No se pueden agregar mas nombres", "Alerta",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (cbInformacion.SelectedIndex == 1)
                    if (txtInformacion.Text == "")
                        txtInformacion.BackColor = Color.Bisque;
                    else
                    if (fila2 < 3)
                    {
                        matriz[fila2, colum2] = txtInformacion.Text;
                        fila2 += 1;
                        MessageBox.Show("Apellido ingresado exitosamente");
                        txtInformacion.Clear();
                    }
                    else
                        MessageBox.Show("No se pueden agregar mas apellidos");
                else
                    MessageBox.Show("Seleccione una opción");

            }
            if (IsNumeric(txtEdad.Text) == true)
                if (fila3 < 3)
                {
                    matriz[fila3, colum3] = txtEdad.Text;
                    fila3 += 1;
                    MessageBox.Show("Edad ingresada exitosamente");
                    txtEdad.Clear();
                    countergen += 1;
                }
                else
                    MessageBox.Show("No se pueden agregar mas edades");
            else
                txtEdad.BackColor = Color.Beige;
        }

        private void txtInformacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (Char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Números", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static bool IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
