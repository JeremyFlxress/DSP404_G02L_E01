namespace Ejemplo4
{
    public partial class Form1 : Form
    {
        const float Pago_turista = 50, Pago_Delegado = 70;
        float interes = 0.18f;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarControles();
        }

        // Función que calcula el costo de hospedaje basado en los días y el tipo de cliente.
        private float CalculoHospedaje(int dias)
        {
            float calculo = 0f;
            if (radioButton1.Checked) // Si el radioButton1 está seleccionado, se considera pago de turista.
            {
                calculo = dias * Pago_turista;
            }
            else // De lo contrario, se considera pago de delegado.
            {
                calculo = dias * Pago_Delegado;
            }
            return calculo;
        }

        // Función que calcula el costo de servicios adicionales seleccionados.
        private int CalculoServicio()
        {
            int acum = 0;
            foreach (Control contr in this.groupBox2.Controls)
            {
                if (contr is CheckBox checkbox && checkbox.Checked)
                {
                    acum += 20;
                }
            }
            return acum;
        }

        private void InicializarControles()
        {
            txtnombre.Focus();
            txtmontoh.Enabled = false;
            txtmontos.Enabled = false;
            txtmontot.Enabled = false;
            txtinteres.Enabled = false;
            nUDpagar.Enabled = false;

            radioButton1.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float montoh = CalculoHospedaje(Convert.ToInt32(txtdias.Text));
            txtmontoh.Text = Convert.ToString(montoh);

            int montos = CalculoServicio();
            txtmontos.Text = Convert.ToString(montos);

            float montot = montoh + montos;
            txtmontot.Text = Convert.ToString(montot);

            float interesCalculado = montot * interes;
            txtinteres.Text = interesCalculado.ToString();

            decimal total = Convert.ToDecimal(montot) + Convert.ToDecimal(interesCalculado);
            nUDpagar.Maximum = 2 * total;
            nUDpagar.Value = total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Limpia los campos de entrada y vuelve a los valores iniciales.
            txtnombre.Text = "";
            txtnombre.Focus();
            txtdias.Text = "";
            txtmontoh.Text = "";
            txtmontos.Text = "";
            txtmontot.Text = "";
            txtinteres.Text = "";
            nUDpagar.Value = 0;

            radioButton1.Checked = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación.
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            float montoh = CalculoHospedaje(Convert.ToInt32(txtdias.Text));
            txtmontoh.Text = Convert.ToString(montoh);

            int montos = CalculoServicio();
            txtmontos.Text = Convert.ToString(montos);

            float montot = montoh + montos;
            txtmontot.Text = Convert.ToString(montot);

            float interesCalculado = montot * interes;
            txtinteres.Text = interesCalculado.ToString();

            decimal total = Convert.ToDecimal(montot) + Convert.ToDecimal(interesCalculado);
            nUDpagar.Maximum = 2 * total;
            nUDpagar.Value = total;
        }
    }
}


