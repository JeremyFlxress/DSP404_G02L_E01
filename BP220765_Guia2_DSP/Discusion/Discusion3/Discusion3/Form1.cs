namespace Discusion3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int numero) && numero >= -40 && numero <= 45)
            {
                countTotal++;

                if (numero > 0)
                {
                    countPositivos++;
                }
                else if (numero < 0)
                {
                    countNegativos++;
                    sumNegativos += numero;
                    if (numero > mayorNegativo)
                    {
                        mayorNegativo = numero;
                    }
                }
                else
                {
                    countCeros++;
                }


                txtMayorNegativo.Text = mayorNegativo == int.MinValue ? "N/A" : mayorNegativo.ToString();
                txtPositivos.Text = countPositivos.ToString();
                txtPromedioNegativos.Text = countNegativos == 0 ? "N/A" : (sumNegativos / (double)countNegativos).ToString("F2");
                txtPorcentajePositivos.Text = (countPositivos / (double)countTotal * 100).ToString("F2") + "%";
                txtPorcentajeNegativos.Text = (countNegativos / (double)countTotal * 100).ToString("F2") + "%";
                txtPorcentajeCeros.Text = (countCeros / (double)countTotal * 100).ToString("F2") + "%";


                txtNumero.Clear();
                txtNumero.Focus();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido entre -40 y 45.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Clear();
                txtNumero.BackColor = Color.Red;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtMayorNegativo.Clear();
            txtPositivos.Clear();
            txtPromedioNegativos.Clear();
            txtPorcentajePositivos.Clear();
            txtPorcentajeNegativos.Clear();
            txtPorcentajeCeros.Clear();

            countPositivos = 0;
            countNegativos = 0;
            countCeros = 0;
            sumNegativos = 0;
            countTotal = 0;
            mayorNegativo = int.MinValue;

            txtNumero.BackColor = Color.White;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private int countPositivos = 0;
        private int countNegativos = 0;
        private int countCeros = 0;
        private int sumNegativos = 0;
        private int countTotal = 0;
        private int mayorNegativo = int.MinValue;

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtNumero.Clear();
            txtMayorNegativo.Clear();
            txtPositivos.Clear();
            txtPromedioNegativos.Clear();
            txtPorcentajePositivos.Clear();
            txtPorcentajeNegativos.Clear();
            txtPorcentajeCeros.Clear();

            countPositivos = 0;
            countNegativos = 0;
            countCeros = 0;
            sumNegativos = 0;
            countTotal = 0;
            mayorNegativo = int.MinValue;

            txtNumero.BackColor = Color.White;
        }

        

        private void btnSalir_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


