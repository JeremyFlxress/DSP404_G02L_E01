using System.Reflection.Emit;

namespace Practica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string mensa;
        private static int conta;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Evento se ejecuta al iniciar ejecución de Form1
            mensa = "Aun no ha presionado botón contar";
            label1.Text = mensa;
        }
        private void btnContar_Click(object sender, EventArgs e)
        {
            // int conta = 0;
            // Acumulador, Total veces que presiona
            conta += 1;
            mensa = "Presiono botón contar, un total de " + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void btnReinicio_Click(object sender, EventArgs e)
        {
            //Restaura el conteo realizado a button1
            conta = 0;
            mensa = "Presiono botón contar, un total de " + Convert.ToString(conta) + " veces";
            label1.Text = mensa;
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close(); //Finaliza la aplicación
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
