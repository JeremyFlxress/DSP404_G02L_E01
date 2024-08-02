namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int conta = 0;
        private string mensa;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnContar_Click(object sender, EventArgs e)
        {
            int conta = 0; //Acumulador, Total veces que se presiona el botón

            void button1_Click(object sender, EventArgs e)

            {
                conta++; //conta+=1; //En forma de operador abreviado

                string mensa = "Presiono botón Contar, un total de " + Convert.ToString(conta) + " veces";
                label1.Text = mensa;


            }
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            conta = 0; // Restablece el contador a 0
            mensa = "Presioné el botón Contar, un total de " + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Cierra la aplicación
        }
    }
}

