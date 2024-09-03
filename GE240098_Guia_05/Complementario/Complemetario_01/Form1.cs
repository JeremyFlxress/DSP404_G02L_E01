using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complemetario_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        List<clsCuenta> cuentas = new List<clsCuenta>();

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            try
            {
                string dui = txtDUI.Text;
                double saldoInicial = double.Parse(txtSaldoInicial.Text);
                double interesAnual = double.Parse(txtInteresAnual.Text);

                clsCuenta nuevaCuenta = new clsCuenta(dui, saldoInicial, interesAnual);
                cuentas.Add(nuevaCuenta);
                lstCuentas.Items.Add(nuevaCuenta.NumeroCuenta);

                MessageBox.Show("Cuenta agregada exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cuenta: " + ex.Message);
            }
        }

        private void btnActualizarSaldo_Click(object sender, EventArgs e)
        {
            if (lstCuentas.SelectedIndex != -1)
            {
                clsCuenta cuentaSeleccionada = cuentas[lstCuentas.SelectedIndex];
                cuentaSeleccionada.ActualizarSaldo();
                MessageBox.Show("Saldo actualizado exitosamente.");
            }
            else
            {
                MessageBox.Show("Seleccione una cuenta para actualizar el saldo.");

            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (lstCuentas.SelectedIndex != -1)
            {
                try
                {
                    double cantidad = double.Parse(txtCantidad.Text);
                    clsCuenta cuentaSeleccionada = cuentas[lstCuentas.SelectedIndex];
                    cuentaSeleccionada.Ingresar(cantidad);
                    MessageBox.Show("Cantidad ingresada exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar cantidad: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una cuenta para ingresar dinero.");
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (lstCuentas.SelectedIndex != -1)
            {
                try
                {
                    double cantidad = double.Parse(txtCantidad.Text);
                    clsCuenta cuentaSeleccionada = cuentas[lstCuentas.SelectedIndex];
                    cuentaSeleccionada.Retirar(cantidad);
                    MessageBox.Show("Cantidad retirada exitosamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al retirar cantidad: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una cuenta para retirar dinero.");
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (lstCuentas.SelectedIndex != -1)
            {
                clsCuenta cuentaSeleccionada = cuentas[lstCuentas.SelectedIndex];
                MessageBox.Show(cuentaSeleccionada.MostrarDatos());
            }
            else
            {
                MessageBox.Show("Seleccione una cuenta para mostrar los datos.");
            }
        }
    }
}
