using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaración de matriz

        string[,] matriz = new string[3, 3];

        public int fila1, fila2, fila3, colum1, colum2, colum3, countergen, i;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            int sumatoria = 0;
            int totalElementos = 0;
            int convertir_edad;
            bool conversionExitosa;

            // Recorrer solo la tercera columna de la matriz para calcular la sumatoria de las edades
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                // Validar si la celda no está vacía y se puede convertir a entero
                if (!string.IsNullOrEmpty(matriz[i, 2]))
                {
                    conversionExitosa = int.TryParse(matriz[i, 2], out convertir_edad);
                    if (conversionExitosa)
                    {
                        sumatoria += convertir_edad;
                        totalElementos++;
                    }
                    else
                    {
                        MessageBox.Show($"El valor en la posición [{i}, 2] no es un número válido.", "Error de Conversión",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            // Calcular el promedio solo si hay elementos válidos
            if (totalElementos > 0)
            {
                int promedio = sumatoria / totalElementos;
                MessageBox.Show("El promedio de las edades es: " + promedio, "Promedio",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No hay elementos numéricos válidos en la columna de edades.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Inicializar las variables filas y columnas a cero
            fila1 = 0;
            fila2 = 0;
            fila3 = 0;
            colum1 = 0;
            colum2 = 0;
            colum3 = 0;

            // Limpiar la matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = string.Empty;
                }
            }

            // Limpiar la grilla de datos
            dgDatos.Rows.Clear();
            dgDatos.Columns.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Limpiando grilla
            dgDatos.Columns.Clear();
            //Creando columnas
            dgDatos.ColumnCount = 3;
            dgDatos.Columns[0].Name = "Nombre";
            dgDatos.Columns[1].Name = "Apellido";
            dgDatos.Columns[2].Name = "Edad";
            dgDatos.Rows.Add();
            dgDatos.Rows.Add();

            //Agregando datos a grilla
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

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validación solo numeros
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validación de solo letras
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public static Boolean IsNumeric(string valor)
        {
            //Determina si parametro valor puede convertirse a numero entero
            int result;
            return int.TryParse(valor, out result);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Posiciones de la columna de la matriz

            colum1 = 0;
            colum2 = 1;
            colum3 = 2;
            if (cboTipoInfo.SelectedIndex == 0)
            {
                if (txtInfo.Text == "")
                    txtInfo.BackColor = Color.Bisque;
                else
                {
                    //Verificamos el combobox1
                    if (fila1 < 3)
                    {
                        //Agregamos el dato en la posición [fila 1, columna1] de la matriz
                        matriz[fila1, colum1] = txtInfo.Text;
                        //Pasamos a la siguiente fila de la matriz
                        fila1 += 1;
                        MessageBox.Show("Nombre ingresado exitosamente", "", MessageBoxButtons.OK);
                        txtInfo.Clear(); //Limpiamos el textbox1
                    }
                    else
                    {
                        MessageBox.Show("No se pueden agregar más nombres", "Alerta",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                if (cboTipoInfo.SelectedIndex == 1)
                {
                    if (txtInfo.Text == "")
                        txtInfo.BackColor = Color.Bisque;
                    else
                    {
                        if (fila2 < 3)
                        {
                            //Agregamos el dato en la posición (fila2, columna2) de la matriz
                            matriz[fila2, colum2] = txtInfo.Text;
                            //Pasamos a la siguiente fila de la matriz
                            fila2 += 1;
                            MessageBox.Show("Apellido ingresado exitosamente");
                            txtInfo.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se pueden agregar más apellidos");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una opción");
                }
            }

            if (IsNumeric(txtEdad.Text) == true)
            {
                if (fila3 < 3)
                {
                    //Agregamos el dato en la posición [fila3, column3] de la matriz
                    matriz[fila3, colum3] = txtEdad.Text;
                    //Pasamos a la siguiente fila de la matriz
                    fila3 += 1;
                    MessageBox.Show("Edad ingresada exitosamente");
                    txtEdad.Clear(); //Limpiamos el textbox1
                    countergen += 1;
                }
                else
                {
                    MessageBox.Show("No se pueden agregar más edades");
                }
            }
            else
            {
                txtEdad.BackColor = Color.Beige;
            }

        }

    }

}

