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
        string[,] matriz = new string[3, 3];
        public int fila1, colum1, fila2, colum2, fila3, colum3, countergen, i;

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[10, 10]; 
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = 0;
                }
            }
            int filas = 0;
            int columnas = 0;
            dgdatos.Rows.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[10, 10]; 
            int sumaEdades = 0;
            int contadorEdades = 0;
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] > 0) 
                    {
                        sumaEdades += matriz[i, j];
                        contadorEdades++;
                    }
                }
            }
            double promedio = (contadorEdades > 0) ? (double)sumaEdades / contadorEdades : 0;
            MessageBox.Show($"El promedio de las edades es: {promedio}", "Promedio de Edades");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgdatos.Columns.Clear();
            dgdatos.ColumnCount = 3;
            dgdatos.Columns[0].Name = "Nombre";
            dgdatos.Columns[1].Name = "Apellido";
            dgdatos.Columns[2].Name = "Edad";
            dgdatos.Rows.Add();
            dgdatos.Rows.Add();
            dgdatos.Rows[0].Cells[0].Value = matriz[0, 0];
            dgdatos.Rows[0].Cells[1].Value = matriz[0, 1];
            dgdatos.Rows[0].Cells[2].Value = matriz[0, 2];
            dgdatos.Rows[1].Cells[0].Value = matriz[1, 0];
            dgdatos.Rows[1].Cells[1].Value = matriz[1, 1];
            dgdatos.Rows[1].Cells[2].Value = matriz[1, 2];
            dgdatos.Rows[2].Cells[0].Value = matriz[2, 0];
            dgdatos.Rows[2].Cells[1].Value = matriz[2, 1];
            dgdatos.Rows[2].Cells[2].Value = matriz[2, 2];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colum1 = 0;
            colum2 = 1;
            colum3 = 2;
            if (cbtipoinfo.SelectedIndex == 0)
            {
                if (txtInfo.Text == "")
                    txtInfo.BackColor = Color.Bisque;
                else
                {
                    if (fila1 < 3)
                    {
                        matriz[fila1, colum1] = txtInfo.Text;
                        fila1 += 1;
                        MessageBox.Show("Nombre ingresado exitosamente", "", MessageBoxButtons.OK);
                        txtInfo.Clear();
                    }
                    else
                        MessageBox.Show("No se pueden agregar mas nombres", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (cbtipoinfo.SelectedIndex == 1)
                    if (txtInfo.Text == "")
                        txtInfo.BackColor = Color.Bisque;
                    else
                    if (fila2 < 3)
                    {
                      
                        matriz[fila2, colum2] = txtInfo.Text;
                 
                        fila2 += 1;
                        MessageBox.Show("Apellido ingresado exitosamente");
                        txtInfo.Clear();
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

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in txtEdad.Text)
            {
                if (!Char.IsDigit(c) && !Char.IsControl(c) && !Char.IsSeparator(c))
                {
                    MessageBox.Show("Solo se permiten Números", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtEdad.Text = new string(txtEdad.Text.Where(char.IsDigit).ToArray());
                    txtEdad.SelectionStart = txtEdad.Text.Length;
                    break;
                }
            }
        }

        private void txtInfo_TextChanged(object sender, EventArgs e)
            {
                foreach (char c in txtInfo.Text)
                {
                    if (!char.IsLetter(c) && c != ' ' && c != (char)Keys.Back)
                    {
                        MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                        txtInfo.Text = new string(txtInfo.Text.Where(char.IsLetter).ToArray());
                        txtInfo.SelectionStart = txtInfo.Text.Length; 
                        break;
                    }
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
            btnLimpiar.Click += new EventHandler(button3_Click);
            btnPromedio.Click += new EventHandler(button4_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
