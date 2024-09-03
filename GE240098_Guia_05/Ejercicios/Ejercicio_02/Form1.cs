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
    public partial class frmRegistroEmpleados : Form
    {
        //Instanciacion de la clase
        clsPlanilla PlanillaEPSON = new clsPlanilla();

        public frmRegistroEmpleados()
        {
            InitializeComponent();
        }

        private void frmRegistroEmpleados_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = DateTime.Now;
                dtpFechaNac.MinDate = fecha.AddYears(-70);
                dtpFechaNac.MaxDate = fecha.AddYears(15);

                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                btnNuevo.Enabled = false;
                btnAceptar.Enabled = false;
                btnGenerarPlanilla.Enabled = false;
                btnNuevo.Focus();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //Se prepara para registrar un nuevo empleado
                clsEmpleado trabajador = new clsEmpleado(); //Se crea un objeto
                trabajador.definirDatosPersonales(txtNombres.Text, txtApellidos.Text, 
                    dtpFechaNac.Value);

                //Empleado será aceptado hasta que el objeto trabajador lo confirme
                if (trabajador.datosPersonalesAceptados)
                {
                    /*
                     Transifiere datos laborales, para que confirme si son correctos 
                     evalua si ha escripo mal el sueldo inicial
                     */
                    if(!(Int32.Parse(txtSueldoIni.Text) >= 0))
                    {
                        MessageBox.Show("Sueldo inicial no valido", "ERROR", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        txtSueldoIni.Focus();
                        return;
                    }

                    //Evalua si valor de la tasa isss es incorrecto
                    if (nudRenta.Value <= 0.0m)
                    {
                        MessageBox.Show("Revise tasa de renta", "ERROR", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        nudRenta.Focus();
                        return;
                    }    
                    //Evalua si el valor de ISSS es incorrecto
                    if (nudISSS.Value <= 0.0m)
                    {
                        MessageBox.Show("Revise tasa ISSS", "ERROR", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        nudISSS.Focus();
                        return;
                    }

                    trabajador.DefinirDatosLaborales(dtpFechaContrato.Value,
                        Convert.ToDecimal(txtSueldoIni.Text));

                    if (trabajador.datosLaboralesAceptados)
                    {
                        trabajador.asignarDescuento(Convert.ToDecimal(nudISSS.Value),
                            Convert.ToDecimal(nudRenta.Value));
                        PlanillaEPSON.recibirEmpleado(trabajador);
                        groupBox1.Enabled = false;
                        groupBox2.Enabled = false;

                        btnNuevo.Enabled = true;
                        btnAceptar.Enabled = false;
                        btnNuevo.Focus();
                    }
                    else
                    {
                        txtNombres.Focus();
                    }
                }
                else
                {
                    txtNombres.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR");
            }
        }

        private void btnAbrirPlanilla_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnGenerarPlanilla.Enabled = true;

            //Activa planilla actual, para que se agreguen los N empleados
            PlanillaEPSON.abrirPlanilla(DateTime.Now, "EPSON INTERNATIONAL");
        }

        private void btnGenerarPlanilla_Click(object sender, EventArgs e)
        {
            PlanillaEPSON.generarListado(ref dataGridView1);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Deja botones en blanco para un nuevo empleado
            txtNombres.Clear();
            txtApellidos.Clear();
            txtSueldoIni.Clear();
            nudISSS.Value = 0;
            nudRenta.Value = 0;
            dtpFechaContrato.Value = DateTime.Now;
            dtpFechaNac.Value = DateTime.Now;

            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            btnNuevo.Enabled = false;
            btnAceptar.Enabled = true;
            txtNombres.Focus();
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aceptara solamente letras
            if(!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aceptara solamente letras
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSueldoIni_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aceptara solamente dígitos
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nudRenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aceptara solamente dígitos
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nudISSS_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Aceptara solamente dígitos
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
