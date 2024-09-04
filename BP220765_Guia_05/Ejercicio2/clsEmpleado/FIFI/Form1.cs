using clsEmpleado;
using System.Windows.Forms;

namespace FIFI
{
    public partial class Form1 : Form
    {

        clsPlanilla planillaEPSON = new clsPlanilla();

        public Form1()
        {
            InitializeComponent();
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            DateTime fecha = DateTime.Now;
            dtpFechaNac.MinDate = fecha.AddYears(-70);
            dtpFechaNac.MaxDate = fecha.AddYears(-15);
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            btnNuevo.Enabled = false;
            btnAceptar.Enabled = false;
            btnGenerarPlanilla.Enabled = false;
            btnNuevo.Focus();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //define fecha min y max que podra seleccionar en dtpFechaNac
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
                MessageBox.Show(ex.Message);
            }
            try
            {
                // Se prepara a registrar un nuevo empleado
                clsEmpleado trabajador = new clsEmpleado();  //Crea un objeto de la clase ClsEmpleado
                trabajador.DefinirDatosPersonales(txtNombres.Text, txtApellidos.Text,
                dtpFechaNac.Value);
                //Empleado será aceptado hasta que objeto trabajador lo confirme
                if (trabajador.datospersonales_aceptados)
                {
                    /*Tranfiere datos laborales, para que confirme si son correctos
                    evalua si ha escrito mal el sueldo inicial*/
                    if (!(Int32.Parse(txtSueldoini.Text) >= 0))
                    {
                        MessageBox.Show("ERROR, Sueldo inicial no valido");
                        txtSueldoini.Focus();
                        return;
                    }
                    //evalua si valor tasa isss es incorrecto
                    if (nudRenta.Value <= 0.0m)
                    {
                        MessageBox.Show("ERROR, revise tasa renta");
                        nudRenta.Focus();
                        return;
                    }
                    //evalua si valor tasa isss es incorrecto
                    if (nudISSS.Value <= 0.0m)
                    {
                        MessageBox.Show("ERROR, revise tasa ISSS");
                        nudISSS.Focus();
                        return;
                    }
                    trabajador.DefinirDatosLaborales(dtpFechaContrato.Value,
                    Convert.ToDecimal(txtSueldoini.Text));
                    if (trabajador.datoslaborales_aceptados)
                    {
                        trabajador.AsignarDescuentos(Convert.ToDecimal(nudISSS.Text),
                        Convert.ToDecimal(nudRenta.Text));
                        planillaEPSON.RecibirEmpleado(trabajador);
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
            catch (Exception)
            {
                
            }
        }

        private void btnGenerarPlanilla_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombres.Clear();
            txtApellidos.Clear();
            txtSueldoini.Clear();
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

        private void btnAbrirPlanilla_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = true;
            btnGenerarPlanilla.Enabled = true;
            //Activa planilla actual, para que se agreguen los N empleados
            planillaEPSON.AbrirPlanilla(DateTime.Now, "Epson Internacional");
        }
    }
}
