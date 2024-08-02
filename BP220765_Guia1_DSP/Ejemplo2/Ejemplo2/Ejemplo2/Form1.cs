using System.Windows.Forms;

namespace Ejemplo2
{
    public partial class form1 : Form
    {
        // Declarar tasaI como una variable de clase
        private double tasaI = 0;

        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Método para verificar si un valor es numérico
        private bool IsNumeric(string valor)
        {
            double result;
            return double.TryParse(valor, out result);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tasaI = 0.12;
        }

        private void rdbInteres3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbInteres3.Checked == true)
            {
                txtTasaInterEX.Enabled = true;
                txtTasaInterEX.Focus();
            }
            else
            {
                txtTasaInterEX.Text = "0";
                txtTasaInterEX.Enabled = false;
            }
        }

        private void rdbInteres2_CheckedChanged(object sender, EventArgs e)
        {
            tasaI = 0.235;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnalisis_Click(object sender, EventArgs e)
        {
            // Declaración de variables a utilizar
            string NomEmpre;
            double MontoInic = 0, MontoFin = 0;
            int Tiempo;

            NomEmpre = txtEmpresa.Text;
            NomEmpre = NomEmpre.Trim(); // Quita el espacio en blanco al inicio/final

            if (NomEmpre.Length == 0)
            {
                // Si no hay caracteres en nombre empresa
                MessageBox.Show("Debe indicar Nombre de la empresa", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmpresa.Focus(); // Método que indica que control txtEmpresa recibirá cursor
                return; // Sale del procedimiento btnAnalisis
            }
            if (!IsNumeric(txtMonto.Text))
            {
                MessageBox.Show("Valor Monto incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonto.Focus(); // Método que indica que control txtMonto recibirá cursor
                return;
            }
            else
            {
                MontoInic = Convert.ToDouble(txtMonto.Text);
                if (!(MontoInic > 0))
                {
                    MessageBox.Show("Valor Monto no puede ser negativo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMonto.Focus(); // Método que indica que control txtMonto recibirá cursor
                    return;
                }
            }

            if (!IsNumeric(txtTiempo.Text) || Convert.ToInt32(txtTiempo.Text) <= 0)
            {
                MessageBox.Show("Valor Tiempo incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTiempo.Focus(); // Método que indica que control txtTiempo recibirá cursor
                return;
            }

            Tiempo = Convert.ToInt32(txtTiempo.Text);
            // Si seleccionó Tasa de interés 3, valida que sea correcta

            txtTasaInterEX.Text = txtTasaInterEX.Text.Trim();

            if (rdbInteres3.Checked == true)
            {
                if (txtTasaInterEX.Text.Length > 0)
                {
                    if (!IsNumeric(txtTasaInterEX.Text))
                    {
                        MessageBox.Show("Tasa de interés incorrecta", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTasaInterEX.Text = "0";
                        txtTasaInterEX.Focus();
                        return;
                    }
                    else
                    {
                        tasaI = Convert.ToDouble(txtTasaInterEX.Text) / 100;
                    }
                }
                else
                {
                    MessageBox.Show("Aún no ha indicado una tasa de interés", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTasaInterEX.Focus();
                    return;
                }
            }

            // Hace el cálculo esperado
            MontoFin = (1 + tasaI);
            MontoFin = MontoInic * (Math.Pow(MontoFin, Tiempo));
            tasaI *= 100;
            // Muestra la respuesta (Monto a pagar)
            lstResul.Items.Clear();
            lstResul.Items.Add("Empresa: " + txtEmpresa.Text);
            lstResul.Items.Add("Monto: $" + MontoInic + ", Tasa anual: " + tasaI);
            lstResul.Items.Add("Monto a pagar: $" + MontoFin);
        }
    }
}

