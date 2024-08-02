namespace Ejemplo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Declaracion de variables
            long factorial = 1;
            int number;

            // Verificar que el TxtNumero contenga un dato numerico
            if (int.TryParse(txtNumero.Text, out number))
            {
                // Realizar un for desde el número ingresado hasta llegar a uno
                for (int i = number; i >= 1; i--)
                {
                    // Multiplica el factorial por todos los números menores
                    factorial *= i;
                }
                txtFactorial.Text = factorial.ToString();
            }
            else
            {
                txtNumero.BackColor = Color.Red;
                MessageBox.Show("Debe ingresar un número!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Clear();
                txtFactorial.Clear();
                txtNumero.Focus();
            }
        }

        private void lblNumero_Click(object sender, EventArgs e)
        {
            txtNumero.BackColor = Color.White;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            static Boolean IsNumeric(string valor)
            {
                int result;
                return int.TryParse(valor, out result);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}