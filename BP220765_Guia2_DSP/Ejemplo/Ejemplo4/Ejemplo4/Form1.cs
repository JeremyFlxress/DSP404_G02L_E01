namespace Ejemplo4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (IsNumeric(txtNumero.Text) && (long.Parse(txtNumero.Text) > 0))

            {
                long numero = long.Parse(txtNumero.Text);
                /* Para poner al revés un número hay que ir diviendo el número
                * para sacar al digito mas significativo y colocarlo en el nuevo
                * numero osea en el digito menos significativo y asi sucesivamente */
                long r, div, reves = 0, multi = 1;
                txtNumero.Text = numero.ToString();
                if (numero >= 100000 & numero <= 999999)
                {
                    div = 100000;
                }
                else if (numero >= 10000 & numero <= 99999)
                {
                    div = 10000;
                }
                else if (numero >= 1000 & numero <= 9999)
                {
                    div = 1000;
                }
                else if (numero >= 100 & numero <= 999)
                {
                    div = 100;
                }
                else if (numero >= 10 & numero <= 99)
                {
                    div = 10;
                }
                else
                {
                    MessageBox.Show("Numero fuera de rango(1-999999)", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    txtNumero.Clear();
                    txtNumero.BackColor = Color.Red;
                    return;
                }
                do
                {
                    //capturamos el digito mas significativo
                    r = numero / div;
                    //restamos ese digito al numero
                    numero = numero - r * div;
                    //calculamos el siguiente divisor
                    div = div / 10;
                    //multiplicamosd el digito segun su peso y lo sumamos al nuevo numero
                    reves = reves + (r * multi);
                    //calculamos el siguiente multiplicador
                    multi = multi * 10;
                    //el proceso se repite hasta que el numero es igual a 0
                } while (numero != 0);
                txtReves.Text = reves.ToString();
            }
            else
            {
                MessageBox.Show("El dato que ingreso no es un número", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Clear();
                txtNumero.BackColor = Color.Red;
            }
        }

        private bool IsNumeric(string text)
        {
            long result;
            return long.TryParse(text, out result);
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.BackColor = Color.White;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtReves.Clear();
            txtNumero.BackColor = Color.White;
        }
    }
}
