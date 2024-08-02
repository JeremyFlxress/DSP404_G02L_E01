using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejemplo3
{
    public partial class frmCesar : Form
    {
        public frmCesar()
        {
            InitializeComponent();
        }

        private void btnEncriptar_Click(object sender, EventArgs e)
        {
            // Verificamos que la llave contenga un número y que este sea positivo
            if (IsNumeric(txtLlave.Text) && (Convert.ToInt16(txtLlave.Text) > 0))
            {
                txtResultado.Clear();
                int ascii;
                int key = Convert.ToInt16(txtLlave.Text);

                // Para cada caracter en el objeto txtTexto
                foreach (char c in txtTexto.Text)
                {
                    // Verificamos si el usuario desea encriptar o desencriptar el texto
                    if (rdbEncriptar.Checked == true)
                    {
                        // Convertimos el caracter extraido a su equivalente numero ASCII y le sumamos la llave
                        ascii = c + key;
                    }
                    else
                    {
                        // Convertimos el caracter extraido a su equivalente numero ASCII y le restamos la llave
                        ascii = c - key;
                    }
                    txtResultado.Text += (char)ascii;
                }
                lblresultado.Text = "Texto encriptado:";
            }
            else
            {
                MessageBox.Show("El dato introducido en la llave es incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtLlave.Focus();
                txtLlave.Clear();
                txtLlave.BackColor = Color.Red;
                txtLlave.ForeColor = Color.Green;

                if (rdbEncriptar.Checked == true)
                {
                    btnEncriptar.Text = "Encriptar";
                }
            }
        }

        private void lblllave_Click(object sender, EventArgs e)
        {
            txtLlave.BackColor = Color.White;
        }

        private void frmCesar_Load(object sender, EventArgs e)
        {
            // Any additional setup can go here
        }

        public static System.Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
            txtLlave.Clear();
            txtResultado.Clear();
            txtLlave.BackColor = Color.White;
            txtLlave.ForeColor = Color.Black;
            lblresultado.Text = "";
            rdbEncriptar.Checked = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}





