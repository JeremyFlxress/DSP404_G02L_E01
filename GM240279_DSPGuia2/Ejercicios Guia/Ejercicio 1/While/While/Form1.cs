using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtStockFinal.Clear();
            txtStockInicial.Clear();
            txtCantidadPersonas.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            int stockInicial;
            int cantPersonas, cantEntrega;

            stockInicial = Convert.ToInt32(txtStockInicial.Text);
            cantPersonas = 0;


            while (stockInicial >= 10)
            {
                cantEntrega = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad Entregada " + (cantPersonas + 1) + "Stock Actual: " + stockInicial, "Reparto de vacunas"));
                if (stockInicial >= cantEntrega)
                {
                    cantPersonas = cantPersonas + 1;
                    stockInicial = stockInicial - cantEntrega;
                }
                else
                {
                    MessageBox.Show("No hay Stock suficiente", "Reparto Vacunas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            MessageBox.Show("El Stock es inferior a 10 und", "Reparto Vacunas", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Salida de Información
            txtStockFinal.Text = Convert.ToString(stockInicial);
            txtCantidadPersonas.Text = Convert.ToString(cantPersonas);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
