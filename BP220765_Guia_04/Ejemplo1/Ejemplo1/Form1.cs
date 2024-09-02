namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PresentacionInicial(); // Mover esta llamada al constructor
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            // Invoca a la subrutina HacerCalculos
            decimal n = nupBase.Value;
            HacerCalculos(n);
            // Muestra resultados
            lstTabla1.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // El evento de carga del formulario no debe contener métodos adicionales.
        }

        private void PresentacionInicial()
        {
            // Prepara controles antes de mostrar el formulario al usuario
            lstTabla1.Visible = false;
            nupBase.Focus();
        }

        private void HacerCalculos(decimal N)
        {
            // Calcula tablas (de multiplicar y potencia) según el valor del argumento N
            int c;
            decimal res;

            // Limpiar listas antes de mostrar resultados
            lstTabla1.Items.Clear();
            c = 1;
            do
            {
                res = N * c;
                lstTabla1.Items.Add(N.ToString() + " X " + c.ToString() + " = " + res.ToString());
                c += 1;
            } while (c <= 10);

            // Genera la potencia de las tablas
            lstTabla2.Items.Clear();
            c = 1;
            do
            {
                res = Elevar(N, c);
                lstTabla2.Items.Add(N.ToString() + " a la " + c.ToString() + " = " + res.ToString());
                c += 1;
            } while (c <= 10);
        }

        private decimal Elevar(decimal B, int expo)
        {
            // Reemplaza al operador pow que calcula la potencia de argumentos (B pow(expo))
            int i = 1;
            decimal r = 1;
            do
            {
                r *= B;
                i += 1;
            } while (i <= expo);
            return r;
        }
    }
}


