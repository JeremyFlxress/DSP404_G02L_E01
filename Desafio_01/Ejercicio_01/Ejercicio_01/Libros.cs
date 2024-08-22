using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_01
{
    public partial class Libros : Form
    {
        public string categoriaSeleccionada;

        public Libros(string CategoriaSeleccionada)
        {
            InitializeComponent();
            categoriaSeleccionada = CategoriaSeleccionada;
        }

    private void Libros_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSinopsis.Clear();
            txtIProtagonistas.Clear();
            txtPaisOrigen.Clear();
            txtCreadoPor.Clear();
            txtTemporadas.Clear();
            txtEpisodios.Clear();
         

            lblTitulo1.Text = "Harry Potter";
            lblTituloEspañol.Text = "Autor: J. K. Rowling";
            txtSinopsis.Text = "La historia comienza con la celebración del mundo mágico. Durante muchos años, había sido aterrorizado por el malvado mago Lord Voldemort.Él mató a Lily y James Potter. Sin embargo, cuando intenta matar a su hijo de 1 año, Harry, la maldición asesina Avada Kedavra se vuelve sobre sí mismo. El cuerpo de Voldemort sobrevive. Por su parte, Harry le queda una cicatriz con forma de rayo en la frente que es el único remanente físico de la maldición de Voldemort. Harry es el único sobreviviente de la maldición asesina, y a raíz de la misteriosa derrota de Voldemort, el mundo mágico empieza a llamarlo como «el niño que sobrevivió».";
            txtIProtagonistas.Text = "Harry Potter\nRon Weasley\nHermione Granger\nGinny Weasley\nNeville Longbottom\nAlbus Dumbledore";
            txtPaisOrigen.Text = "Novela, Literatura fantástica, Literatura juvenil, Novela de desarrollo, Literatura infantil y juvenil";
            txtCreadoPor.Text = "Lord Voldemort, Mortífagos";
            txtTemporadas.Text = "3407 (ENG)\n3665 (ESP)";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSinopsis.Clear();
            txtIProtagonistas.Clear();
            txtPaisOrigen.Clear();
            txtCreadoPor.Clear();
            txtTemporadas.Clear();
            txtEpisodios.Clear();

            lblTitulo1.Text = "Goosebumps";
            lblTituloEspañol.Text = "Autor: Robert Lawrence Stine";
            txtSinopsis.Text = "La serie consta de un total de 60 libros para España, el último de los cuales (Sangre de monstruo IV) se publicó en 1999, mientras que en Hispanoamérica consta de 45 historias. El nombre se tradujo en España como Pesadillas y en Hispanoamérica como Escalofríos.";
            txtIProtagonistas.Text = "El protagonista principal de una historia de Pesadillas / Escalofríos es a menudo situado en una ubicación remota o de alguna manera aislada en algunas situaciones.";
            txtPaisOrigen.Text = "Ciencia ficción\nLiteratura infantil\nSuspenso";
            txtCreadoPor.Text = "--";
            txtTemporadas.Text = "--";
            txtEpisodios.Text = "Suspenso\nTerror\nJuvenil";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSinopsis.Clear();
            txtIProtagonistas.Clear();
            txtPaisOrigen.Clear();
            txtCreadoPor.Clear();
            txtTemporadas.Clear();
            txtEpisodios.Clear();

            lblTitulo1.Text = "Perry Mason";
            lblTituloEspañol.Text = "Autor: Erle Stanley Gardner";
            txtSinopsis.Text = "El personaje era un abogado que llegó a aparecer en 80 novelas e historias cortas, la mayoría de las cuales versaban sobre la defensa de un cliente que había sido acusado de asesinato. En general, Perry Mason era capaz de demostrar la inocencia de su cliente mediante la averiguación de la culpabilidad del verdadero asesino, otro personaje de la historia.";
            txtIProtagonistas.Text = "Perry Mason";
            txtPaisOrigen.Text = "Novela\npoliciaca";
            txtCreadoPor.Text = "--";
            txtTemporadas.Text = "--";
            txtEpisodios.Text = "--";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form1 log = new Form1();
            log.Show();
            this.Close();
        }

        private void txtEpisodios_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            Estadística Estadistica = new Estadística(categoriaSeleccionada);
            Estadistica.Show();

            this.Hide();
        }
    }
}
