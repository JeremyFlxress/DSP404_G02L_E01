using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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

        int contaventa; //Contador de montos de ventas ingresadas

        public void inicializarControles()
        {
            //Mostrara a la pagina 1 del TabControl1
            tabControl1.TabPages[0].Text = "Ventas Efectuadas";
            tabControl1.TabPages[1].Text = "Estadisticas de venta";
            tabControl1.SelectedIndex = 0;

            //Configura a DatagridView
            dataGridView1.ReadOnly = true;

            //Desde colección columns, agrega 3 columnas
            dataGridView1.Columns.Add("Numeventa", "#");
            dataGridView1.Columns.Add("Montoventa", "Monto ($)");
            dataGridView1.Columns.Add("fechaventa", "Fecha Venta");
            dataGridView1.Columns.Add("Trims", "Trimestral(1-4)");

            //Limite de rango de fechas a escoger por un usuario
            dateTimePicker1.MaxDate = Convert.ToDateTime("31/12/2015");
            dateTimePicker1.MinDate = Convert.ToDateTime("01/01/2014");

            //Establece fechas a mostrar dentro del rango
            dateTimePicker1.Value = Convert.ToDateTime("01/01/2015");
            label3.Text = "Totales ventas promedio por trimestre";

            maskedTextBox1.Select();

        }

        public void registrarVenta(decimal MontoVe, DateTime Fecha)
        {
            int Trimestre;

            //Determina el trimestre de parametros fecha recibido
            switch (Convert.ToInt32(Fecha.Month))
            {
                case 1:
                case 2:
                case 3:
                    Trimestre = 1;
                    break;
                case 4:
                case 5:
                case 6:
                    Trimestre = 2;
                    break;
                case 7: 
                case 8:
                case 9:
                    Trimestre = 3;
                    break;
                default:
                    Trimestre = 4;
                    break;
            }

            dataGridView1.Rows.Add();
            dataGridView1.Rows[contaventa].Cells[0].Value = contaventa + 1;
            dataGridView1.Rows[contaventa].Cells[1].Value = MontoVe;
            dataGridView1.Rows[contaventa].Cells[2].Value = Fecha;
            dataGridView1.Rows[contaventa].Cells[3].Value = Trimestre;

            contaventa += 1;
        }

        public void evaluacionTrimestral()
        {
            /**
             * Analiza los datos en el grid, para asi determinar:
             * a) Total ($) de ventas por trimestres
             * Fecha de la mayor y menor venta efectuada
             */

            decimal[] totalVentaTrimestre = new decimal[5];
            int c;
            int tri;

            //Primero determinar total venta por trimestre
            for (c = 0; c <= (contaventa -1); c++)
            {
                tri = Convert.ToInt32(dataGridView1.Rows[c].Cells["Trims"].Value);
                /*
                 * Este numero de trimestre se aprovecha para acceder a posicion 
                 * dentro del arreglo TotVentaTrim()
                 * aqui acumulo Monto venta de la celda"montoventa" 
                 */ 

                decimal x = Convert.ToDecimal(dataGridView1.Rows[c].Cells["Montoventa"].Value);

                totalVentaTrimestre[tri] = totalVentaTrimestre[tri] + x;
            }

            for (c = 1; c < 5; c++)
            {
                listBox1.Items.Add("Trimestre " + Convert.ToString(c) + ": $" +
                    Convert.ToString(totalVentaTrimestre[c]));
            }
        }

        public void validarDatos()
        {
            //confirmar que usuario escribio datos correctos
            decimal montov;
            //Registra venta en la fecha indicada por usuario
            montov = Convert.ToDecimal(maskedTextBox1.Text);
            //invoca a subrutina, enviando parámetros por valor
            registrarVenta(montov, dateTimePicker1.Value);
            //reinicia controles para nueva venta
            maskedTextBox1.Clear();
            maskedTextBox1.Focus();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            validarDatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            evaluacionTrimestral();
            //Mostrara a la pagina 2 del tabControl1
            tabControl1.SelectedIndex = 1;
            //Bloquea ingreso a controles del contenedor GroupBox
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Monto de venta incorrecto");
                maskedTextBox1.Focus();
            }
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inicializarControles();
            contaventa = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
