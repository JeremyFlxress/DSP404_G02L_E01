using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia_2.Videos
{
    public partial class frmEntregas : Form
    {
        public frmEntregas()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Declarar variables
            int stock;
            int cantPersonas, cantEntrega;

            //Entrada de datos
            stock = Convert.ToInt32(txtStockInicial.Text);
            cantPersonas = 0;

            //Empezamos a repartir las vacunas
            while (stock >= 10)
            {
                cantEntrega = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ingrese cantidad entregada a persona " + (cantPersonas + 1), "Reparto de vacunas"));

                //Validar cantidad entregada sea menor o igual que el stock
                if (stock >= cantEntrega)
                {
                    cantPersonas++;
                    stock -= cantEntrega;
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock", "Reparto de vacunas",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("El stock es inferior a 10 unidades", "Reparto de vacunas",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Salida de la información

            txtStockFinal.Text = Convert.ToString(stock);

            txtCantPersonas.Text = Convert.ToString(cantPersonas);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtStockInicial.Clear();
            txtStockFinal.Clear();
            txtCantPersonas.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
