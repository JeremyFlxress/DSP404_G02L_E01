using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }
        private void InicializarControles()
        {
            /**
             * Prepara controles antes de mostrar form a usuario
             * Define limites de cada control NumericUpDown
             * (rango valores que aceptara: de -20.0 hasta 35.0
             */

            nudN1.Minimum = -20;
            nudN1.Maximum = 35;
            nudN1.DecimalPlaces = 1;
            nudN1.Increment = 2;

            nudN2.Minimum = -20;
            nudN2.Maximum = 35;
            nudN2.DecimalPlaces = 1;
            nudN2.Increment = 2;

            //Define presentación de control cmbOperaciones
            cmbOperaciones.Items.Add("1. Suma");
            cmbOperaciones.Items.Add("2. Resta");
            cmbOperaciones.Items.Add("3. Multiplicación");
            cmbOperaciones.Items.Add("4. División");
            cmbOperaciones.Items.Add("5. Potencia");

            //Listado será solo selección (solo lectura) de valores del cmbobox
            cmbOperaciones.DropDownStyle = ComboBoxStyle.DropDownList;
            lblResult.Text = "(RESULTADO)";

        }

        private void SumarEstosNumeros()
        {
            //Calcula la suma de parámetros A y B recibidos
            double su;
            
            su = Convert.ToDouble(nudN1.Value) + Convert.ToDouble(nudN2.Value);
            /**
             * Muestra resultado de suma y como no hay error no se envia el ultimo parametro
             */
            MostrarResultado(su, 1);
        }

        private void MostrarResultado(double R, int Oper, Boolean hayError = false)
        {
            /*
             Muestre respuesta en label, resalta en
             A. fondo verde y letra blanca (si es error)
             B. fondo rojo y letra amarilla (si hay errores)
             copia texto del item seleccionado en cmbOperaciones
            */
            string descripcionOperacion = cmbOperaciones.Text;
            if (!hayError)
            {
                lblResult.BackColor = Color.Green;
                lblResult.ForeColor = Color.White;
                lblResult.Text = descripcionOperacion + " es " + Convert.ToString(R);
            }
            else
            {
                lblResult.BackColor = Color.Red;
                lblResult.ForeColor = Color.Yellow;
                lblResult.Text = "(ERROR, DIVISION POR CERO)";
            }
        }

        private double Potencia (double A, double B)
        {
            //Calcula potencia de A^B
            //Retorna potencia a llamada recursiva anterior de misma función potencia

            return Math.Pow(A, B);
        }

        private void Multiplicar(double x, double y, ref double M)
        {
            /*Recibe 2 factores X e Y de parámetros entrada, para luego
             * retornar en parámetro de salida(M) al resultado de multplicación
             */
            M = x * y;
        }

        private Boolean Dividir (double x, double y, ref double d)
        {
            /**
             * Recibe dos parametros de entrada, para intentar dividirlos y guardar resultados
             * en 0 confirma si hay division entre (0)
             */
            if (y == 0.0)
            {
                return false;
            }
            else
            {
                d = x / y;
                return true;
            }
        }

        private void RestarA(double a, double b)
        {
            //Calcula la suma de parámetros A y B recibidos
            double su;
            int opcion;

            su = a - b;
            opcion = cmbOperaciones.SelectedIndex + 1;
            //Muestra resultado de suma y como no hay error no se envia el último parámetro
            MostrarResultado(su, 1);
        }

        private void HacerOperacion (int numeroOperacion)
        {
            //Extraer los valores de los Numeric Up Down y prod
            double num1 = Convert.ToDouble(nudN1.Value);
            double num2 = Convert.ToDouble(nudN2.Value);
            double prod = 0;
            switch (numeroOperacion)
            {
                
                case 1:
                    SumarEstosNumeros();
                    break;

                case 2:
                    RestarA(num1, num2);
                    break;

                case 3:
                    num1 = Convert.ToDouble(nudN1.Value);
                    num2 = Convert.ToDouble(nudN2.Value);
                    Multiplicar(num1, num2, ref prod);
                    MostrarResultado(prod, 3, false);
                    break;
                case 4:
                    double division = 0;
                    if(Dividir(num1, num2, ref division))
                    {
                        MostrarResultado(division, 3, false);
                    }
                    else
                    {
                        MostrarResultado(division, 4, true);
                    }
                    break;
                case 5:
                    MostrarResultado(Potencia(num1, num2), 5);
                    break;
                default:
                    MessageBox.Show("Operacion solicitada no válida", "ERROR",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }


        private void cmbOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            /**
             * Hace operaciones matematicas especifica cuando usuario selecciona el item del combo
             */

            int numeroOpcion;

            numeroOpcion = cmbOperaciones.SelectedIndex + 1;

            HacerOperacion(numeroOpcion);
        }
    }
}
