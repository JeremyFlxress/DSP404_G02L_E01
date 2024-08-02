using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Declaración de matriz
        string[,] matriz = new string[3, 3];
        // Variables para movernos dentro de las posiciones de la matriz
        public int fila1 = 0, colum1, fila2 = 0, colum2, fila3 = 0, colum3, countergen, i;

        private void btPromedio_Click(object sender, EventArgs e)
        {
            // Calculando el promedio de edades
            int sumaEdades = 0;
            int contadorEdades = 0;

            for (int i = 0; i < 3; i++)
            {
                if (IsNumeric(matriz[i, 2]))
                {
                    sumaEdades += int.Parse(matriz[i, 2]);
                    contadorEdades++;
                }
            }

            if (contadorEdades > 0)
            {
                double promedio = (double)sumaEdades / contadorEdades;
                MessageBox.Show("El promedio de las edades es: " + promedio.ToString("F2"));
            }
            else
            {
                MessageBox.Show("No hay edades para calcular el promedio");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicialización de componentes si es necesario
        }

        private void btLimpiar_Click_1(object sender, EventArgs e)
        {
            // Limpiando la matriz
            Array.Clear(matriz, 0, matriz.Length);
            fila1 = fila2 = fila3 = 0;
            // Limpiando la grilla
            dgdatos.Rows.Clear();
            dgdatos.Refresh();
            MessageBox.Show("Datos limpiados exitosamente");
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            // Limpiando grilla
            dgdatos.Columns.Clear();
            // Creando columnas
            dgdatos.ColumnCount = 3;
            dgdatos.Columns[0].Name = "Nombre";
            dgdatos.Columns[1].Name = "Apellido";
            dgdatos.Columns[2].Name = "Edad";
            dgdatos.Rows.Add();
            dgdatos.Rows.Add();
            dgdatos.Rows.Add();
            // Agregando datos a grilla
            // Mostrando nombres
            dgdatos.Rows[0].Cells[0].Value = matriz[0, 0];
            dgdatos.Rows[0].Cells[1].Value = matriz[0, 1];
            dgdatos.Rows[0].Cells[2].Value = matriz[0, 2];
            // Mostrando apellidos
            dgdatos.Rows[1].Cells[0].Value = matriz[1, 0];
            dgdatos.Rows[1].Cells[1].Value = matriz[1, 1];
            dgdatos.Rows[1].Cells[2].Value = matriz[1, 2];
            // Mostrando edades
            dgdatos.Rows[2].Cells[0].Value = matriz[2, 0];
            dgdatos.Rows[2].Cells[1].Value = matriz[2, 1];
            dgdatos.Rows[2].Cells[2].Value = matriz[2, 2];
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            // Posiciones de la columna de la matriz
            colum1 = 0;
            colum2 = 1;
            colum3 = 2;
            // Verificamos el combobox1
            if (cbtipoinfo.SelectedIndex == 0)
            {
                if (string.IsNullOrEmpty(txtInfo.Text))
                    txtInfo.BackColor = Color.Bisque;
                else
                {
                    if (fila1 < 3)
                    {
                        // Agregamos el dato en la posicion [fila1,column1] de la matriz
                        matriz[fila1, colum1] = txtInfo.Text;
                        // Pasamos a la siguiente fila de la matriz
                        fila1 += 1;
                        MessageBox.Show("Nombre ingresado exitosamente", "", MessageBoxButtons.OK);
                        txtInfo.Clear(); // Limpiamos el texboxt1
                    }
                    else
                        MessageBox.Show("No se pueden agregar más nombres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (cbtipoinfo.SelectedIndex == 1)
            {
                if (string.IsNullOrEmpty(txtInfo.Text))
                    txtInfo.BackColor = Color.Bisque;
                else
                {
                    if (fila2 < 3)
                    {
                        // Agregamos el dato en la posicion (fila2,colum2) de la matriz
                        matriz[fila2, colum2] = txtInfo.Text;
                        // Pasamos a la siguiente fila de la matriz
                        fila2 += 1;
                        MessageBox.Show("Apellido ingresado exitosamente");
                        txtInfo.Clear();
                    }
                    else
                        MessageBox.Show("No se pueden agregar más apellidos");
                }
            }

            if (IsNumeric(txtEdad.Text))
            {
                if (fila3 < 3)
                {
                    // Agregamos el dato en la posicion [fila3,colum3] de la matriz
                    matriz[fila3, colum3] = txtEdad.Text;
                    // Pasamos a la siguiente fila de la matriz
                    fila3 += 1;
                    MessageBox.Show("Edad ingresada exitosamente");
                    txtEdad.Clear(); // Limpiamos el textbox1
                    countergen += 1;
                }
                else
                    MessageBox.Show("No se pueden agregar más edades");
            }
            else
                txtEdad.BackColor = Color.Beige;
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            // Validación solo números
            txtEdad.KeyPress += (s, ev) =>
            {
                if (Char.IsDigit(ev.KeyChar) || Char.IsControl(ev.KeyChar) || Char.IsSeparator(ev.KeyChar))
                    ev.Handled = false;
                else
                {
                    ev.Handled = true;
                    MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            };
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
        {
            // Validación de solo letras
            txtInfo.KeyPress += (s, ev) =>
            {
                if (!char.IsLetter(ev.KeyChar) && ev.KeyChar != (char)Keys.Back)
                {
                    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ev.Handled = true;
                }
            };
        }

        public static bool IsNumeric(string valor)
        {
            // Determina si parametro valor puede convertirse a numero entero
            int result;
            return int.TryParse(valor, out result);
        }

       

        
        }
    }


